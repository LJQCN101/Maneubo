using System;
using System.Windows.Forms;
using AdamMil.Mathematics.Geometry;
using AdamMil.Utilities;
using MB = Maneubo.ManeuveringBoard;
using AdamMil.Mathematics.Optimization;
using AdamMil.Mathematics;
using KnobControl;

namespace Maneubo
{
    partial class TDCForm : DataForm
    {
        public TDCForm()
        {
            InitializeComponent();
        }

        public TDCForm(UnitShape unit, UnitShape target, UnitSystem unitSystem, bool disableControls) : this()
        {

            if (unit == null) btnOKTDC.Enabled = false;

            this.unit = unit;
            this.target = target;
            this.unitSystem = unitSystem;
            UpdateSolution();
        }

        public double Course
        {
            get { return MB.SwapBearing(Solution.Angle); }
        }

        public Point2 InterceptPoint { get; private set; }
        public Vector2 Solution { get; private set; }

        public double Speed
        {
            get { return Solution.Length; }
        }

        public double Time
        {
            get { return (InterceptPoint - unit.Position).Length / Speed; }
        }

        bool UpdateSolution()
        {
            double? speed = null, time = null, aob = null, radius = null;

            if (!string.IsNullOrEmpty(txtSpeedTDC.Text.Trim()))
            {
                double value;
                if (!TryParseSpeed(txtSpeedTDC.Text, unitSystem, out value))
                {
                    ShowInvalidSpeed(txtSpeedTDC.Text);
                    goto invalidData;
                }
                speed = value;
            }

            Point2 targetPt;
            Vector2 targetVel;
            double targetCourse;
            double ownCourse;
            double targetAOB;


            {
                double bearing, range;
                if (string.IsNullOrEmpty(txtBearingTDC.Text))
                {
                    lblSolutionTDC.Text = "Enter a target true bearing.";
                    return false;
                }
                else if (!TryParseAngle(txtBearingTDC.Text, out bearing))
                {
                    ShowInvalidAngle(txtBearingTDC.Text);
                    goto invalidData;
                }

                if (string.IsNullOrEmpty(txtRangeTDC.Text))
                {
                    lblSolutionTDC.Text = "Enter a target range.";
                    return false;
                }
                else if (!TryParseLength(txtRangeTDC.Text, unitSystem, out range))
                {
                    ShowInvalidLength(txtRangeTDC.Text);
                    goto invalidData;
                }

                targetPt = new Vector2(0, range).Rotate(-bearing).ToPoint();

                double targetSpeed;
                if (string.IsNullOrEmpty(txtTargetSpeedTDC.Text))
                {
                    lblSolutionTDC.Text = "Enter a target speed.";
                    return false;
                }
                else if (!TryParseSpeed(txtTargetSpeedTDC.Text, unitSystem, out targetSpeed))
                {
                    ShowInvalidSpeed(txtTargetSpeedTDC.Text);
                    goto invalidData;
                }

                

                if (string.IsNullOrEmpty(txtAoBTDC.Text.Trim()))
                {
                    lblSolutionTDC.Text = "Enter target AOB.";
                    return false;
                }
                else if (!TryParseAngle(txtAoBTDC.Text.Trim(), out targetAOB))
                {
                    ShowInvalidAngle(txtAoBTDC.Text);
                    goto invalidData;
                }

                if (string.IsNullOrEmpty(txtCourseTDC.Text))
                {
                    lblSolutionTDC.Text = "Enter ownship course.";
                    return false;
                }
                else if (!TryParseAngle(txtCourseTDC.Text, out ownCourse))
                {
                    ShowInvalidAngle(txtCourseTDC.Text);
                    goto invalidData;
                }

                if (targetSpeed == 0)
                {
                    targetCourse = 0;
                }
                else
                {
                    targetCourse = ownCourse + (Math.PI - targetAOB);
                }

                targetVel = new Vector2(0, targetSpeed).Rotate(-targetCourse);
            }

            // if we've already satisfied the intercept criteria...
            Vector2 o = unit == null ? new Vector2(targetPt) : targetPt - unit.Position;
            if (o.LengthSqr <= (radius.HasValue && !aob.HasValue ? radius.Value * radius.Value : 0))
            {
                lblSolutionTDC.Text = "You are already at the target.";
                return false;
            }

            // if the target is not moving, any speed will work, so we'll just arbitrarily head there at 10 units of speed
            if (targetVel.LengthSqr == 0)
            {
                Solution = o.GetNormal(MB.ConvertFromUnit(10, MB.GetAppropriateSpeedUnit(unitSystem)));
                InterceptPoint = targetPt;
                lblSolutionTDC.Text = ManeuveringBoard.GetAngleString(MB.SwapBearing(o.Angle)) + " (target stationary)";
                return true;
            }

            // if we have a single target point (i.e. the target itself, or one point on the radius circle), the intercept formula basically
            // consists in solving a quadratic formula. if we're at P and the target is at T with velocity V, then we know that the interception
            // point is at T+V*t, where t is time. if we take the vector from P to the intersection point (T+V*t-P), then the distance is
            // |T+V*t-P|. dividing by the speed s gives us the time: t = |(T+V*t-P)|/s. so s*t = |T+V*t-P|. squaring both sides, replacing T-P
            // with the helper O (i.e. translating P to the origin), and expanding the vector, we get (s*t)^2 = (Ox+Vx*t)^2 + (Oy+Vy*t)^2
            if (!time.HasValue) // if the user didn't specify the time of intercept... (if they did, the problem's solved already)
            {
                if (!speed.HasValue)
                {
                    lblSolutionTDC.Text = "Enter torpedo speed.";
                    return false;
                }

                // if know the intercept speed, we take the above equation and factor out time. we end up with:
                // t^2(Vx^2 + Vy^2 - s^2) + t*(2Ox*Vx + 2Oy*Vy) + Ox^2 + Oy^2 = 0. if we take A=(Vx^2 + Vy^2 - s^2), B=2(Ox*Vx + Oy*Vy), and
                // C=Ox^2 + Oy^2, then we have the quadratic A*t^2 + B*t + C = 0 which we can solve with the quadratic formula.
                // t = (-B +/- sqrt(B^2 - 4AC)) / 2A (and we can remove a factor of 2). if the discriminant is negative, there is no solution.
                // otherwise, we take whichever solution gives the smallest non-negative time
                double A = targetVel.X * targetVel.X + targetVel.Y * targetVel.Y - speed.Value * speed.Value, B = o.X * targetVel.X + o.Y * targetVel.Y, C = o.X * o.X + o.Y * o.Y;

                // if A = 0, then the speeds are identical, and we get division by zero solving the quadratic. but if A = 0 then we just have
                // B*t + C = 0 or t = -C/B. we know B can't be zero because we checked the relevant cases above
                if (A == 0)
                {
                    double t = -C / (2 * B); // we have to multiply B by 2 because we removed a factor of two above
                    if (t >= 0) time = t;
                    else goto noSolution;
                }
                else
                {
                    double discriminant = B * B - A * C;
                    if (discriminant < 0) goto noSolution;
                    double root = Math.Sqrt(discriminant), time1 = (-B + root) / A, time2 = (-B - root) / A;
                    if (time1 >= 0 && time1 <= time2) time = time1;
                    else if (time2 >= 0) time = time2;
                    else goto noSolution;
                }
            }

            // now that we know the time of intercept, we can calculate the intercept point and get the velocity we'd need to get there.
            // the intercept point is T+V*t. the intercept vector is T+V*t-P = O+V*t. this vector has a length equal to the distance, but we
            // want a length equal to the speed, so divide by time to get speed (e.g. 10 km in 2 hour = 5km/hour). but (O+V*t)/t = O/t+V
            Solution = o / time.Value + targetVel;
            InterceptPoint = targetPt + targetVel * time.Value;
            haveSolution = true;

            lblSolutionTDC.Text = "Aim at " + ManeuveringBoard.GetAngleString(MB.SwapBearing(Solution.Angle)) + ", torpedo running time " + GetTimeString(time.Value);
            return true;

        noSolution:
            lblSolutionTDC.Text = "No intercept is possible.";
            return false;

        invalidData:
            lblSolutionTDC.Text = "Invalid data.";
            return false;
        }

        void btnOK_Click(object sender, System.EventArgs e)
        {
            if (!haveSolution && unit != null && !UpdateSolution())
            {
                MessageBox.Show(lblSolutionTDC.Text, "Can't provide solution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //DialogResult = DialogResult.OK;
        }

        void txt_Leave(object sender, System.EventArgs e)
        {
            if (!haveSolution) UpdateSolution();
        }

        void txt_TextChanged(object sender, EventArgs e)
        {
            haveSolution = false;
        }

        readonly UnitSystem unitSystem;
        readonly UnitShape unit, target;
        bool haveSolution;

        private void AOBknobControl_ValueChanged(object Sender)
        {
            txtAoBTDC.Text = AOBknobControl.Value.ToString();
        }

        static string GetTimeString(double seconds)
        {
            int secs = (int)Math.Ceiling(seconds);
            if (secs < 60) return secs.ToStringInvariant() + "s";
            int totalMinutes = (secs + 30) / 60, minutes = (secs % 3600 + 59) / 60;
            return secs < 3600 ? totalMinutes.ToStringInvariant() + "m" :
                   (secs / 3600).ToStringInvariant() + "h " + minutes.ToStringInvariant() + "m";
        }
    }
}
