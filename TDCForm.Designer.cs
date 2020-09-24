namespace Maneubo
{
    partial class TDCForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label lblSpeed;
            System.Windows.Forms.Button btnCancelTDC;
            System.Windows.Forms.Label lblAoB;
            System.Windows.Forms.Label lblBearing;
            System.Windows.Forms.Label lblRange;
            System.Windows.Forms.Label lblTargetSpeed;
            System.Windows.Forms.Label lblCourse;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.AOBknobControl = new KnobControl.KnobControl();
            this.btnOKTDC = new System.Windows.Forms.Button();
            this.txtSpeedTDC = new System.Windows.Forms.TextBox();
            this.lblSolutionTDC = new System.Windows.Forms.Label();
            this.txtAoBTDC = new System.Windows.Forms.TextBox();
            this.txtBearingTDC = new System.Windows.Forms.TextBox();
            this.txtRangeTDC = new System.Windows.Forms.TextBox();
            this.txtTargetSpeedTDC = new System.Windows.Forms.TextBox();
            this.txtCourseTDC = new System.Windows.Forms.TextBox();
            lblSpeed = new System.Windows.Forms.Label();
            btnCancelTDC = new System.Windows.Forms.Button();
            lblAoB = new System.Windows.Forms.Label();
            lblBearing = new System.Windows.Forms.Label();
            lblRange = new System.Windows.Forms.Label();
            lblTargetSpeed = new System.Windows.Forms.Label();
            lblCourse = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AOBknobControl
            // 
            this.AOBknobControl.DrawDivInside = true;
            this.AOBknobControl.EndAngle = 450F;
            this.AOBknobControl.ImeMode = System.Windows.Forms.ImeMode.On;
            this.AOBknobControl.KnobBackColor = System.Drawing.Color.Black;
            this.AOBknobControl.KnobPointerStyle = KnobControl.KnobControl.KnobPointerStyles.line;
            this.AOBknobControl.LargeChange = 5;
            this.AOBknobControl.Location = new System.Drawing.Point(288, 65);
            this.AOBknobControl.Margin = new System.Windows.Forms.Padding(4);
            this.AOBknobControl.Maximum = 180;
            this.AOBknobControl.Minimum = -180;
            this.AOBknobControl.MouseWheelBarPartitions = 13;
            this.AOBknobControl.Name = "AOBknobControl";
            this.AOBknobControl.PointerColor = System.Drawing.Color.SlateBlue;
            this.AOBknobControl.ScaleColor = System.Drawing.Color.White;
            this.AOBknobControl.ScaleDivisions = 13;
            this.AOBknobControl.ScaleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.AOBknobControl.ScaleSubDivisions = 3;
            this.AOBknobControl.ShowLargeScale = true;
            this.AOBknobControl.ShowSmallScale = false;
            this.AOBknobControl.Size = new System.Drawing.Size(200, 200);
            this.AOBknobControl.SmallChange = 1;
            this.AOBknobControl.StartAngle = 90F;
            this.AOBknobControl.TabIndex = 1;
            this.AOBknobControl.Value = -90;
            this.AOBknobControl.ValueChanged += new KnobControl.ValueChangedEventHandler(this.AOBknobControl_ValueChanged);
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new System.Drawing.Point(285, 44);
            lblSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new System.Drawing.Size(105, 17);
            lblSpeed.TabIndex = 8;
            lblSpeed.Text = "Torpedo &speed";
            lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancelTDC
            // 
            btnCancelTDC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            btnCancelTDC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancelTDC.Location = new System.Drawing.Point(119, 295);
            btnCancelTDC.Margin = new System.Windows.Forms.Padding(4);
            btnCancelTDC.Name = "btnCancelTDC";
            btnCancelTDC.Size = new System.Drawing.Size(100, 28);
            btnCancelTDC.TabIndex = 20;
            btnCancelTDC.Text = "Cancel";
            btnCancelTDC.UseVisualStyleBackColor = true;
            // 
            // lblAoB
            // 
            lblAoB.AutoSize = true;
            lblAoB.Location = new System.Drawing.Point(11, 110);
            lblAoB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAoB.Name = "lblAoB";
            lblAoB.Size = new System.Drawing.Size(80, 17);
            lblAoB.TabIndex = 12;
            lblAoB.Text = "Target &AoB";
            lblAoB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBearing
            // 
            lblBearing.AutoSize = true;
            lblBearing.Location = new System.Drawing.Point(11, 14);
            lblBearing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBearing.Name = "lblBearing";
            lblBearing.Size = new System.Drawing.Size(131, 17);
            lblBearing.TabIndex = 0;
            lblBearing.Text = "Target true &bearing";
            lblBearing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRange
            // 
            lblRange.AutoSize = true;
            lblRange.Location = new System.Drawing.Point(11, 46);
            lblRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRange.Name = "lblRange";
            lblRange.Size = new System.Drawing.Size(107, 17);
            lblRange.TabIndex = 2;
            lblRange.Text = "Target &distance";
            lblRange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTargetSpeed
            // 
            lblTargetSpeed.AutoSize = true;
            lblTargetSpeed.Location = new System.Drawing.Point(11, 78);
            lblTargetSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTargetSpeed.Name = "lblTargetSpeed";
            lblTargetSpeed.Size = new System.Drawing.Size(93, 17);
            lblTargetSpeed.TabIndex = 4;
            lblTargetSpeed.Text = "Target s&peed";
            lblTargetSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new System.Drawing.Point(285, 14);
            lblCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new System.Drawing.Size(109, 17);
            lblCourse.TabIndex = 6;
            lblCourse.Text = "Ownship &course";
            lblCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 152);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(255, 17);
            label1.TabIndex = 12;
            label1.Text = "Note: For AOB, starboard is +, port is -.";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 169);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(254, 17);
            label2.TabIndex = 12;
            label2.Text = "i.e. port 110 = -110, starboard 80 = 80.";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOKTDC
            // 
            this.btnOKTDC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOKTDC.Location = new System.Drawing.Point(11, 295);
            this.btnOKTDC.Margin = new System.Windows.Forms.Padding(4);
            this.btnOKTDC.Name = "btnOKTDC";
            this.btnOKTDC.Size = new System.Drawing.Size(100, 28);
            this.btnOKTDC.TabIndex = 19;
            this.btnOKTDC.Text = "&OK";
            this.btnOKTDC.UseVisualStyleBackColor = true;
            this.btnOKTDC.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtSpeedTDC
            // 
            this.txtSpeedTDC.Location = new System.Drawing.Point(404, 39);
            this.txtSpeedTDC.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpeedTDC.Name = "txtSpeedTDC";
            this.txtSpeedTDC.Size = new System.Drawing.Size(91, 22);
            this.txtSpeedTDC.TabIndex = 9;
            this.txtSpeedTDC.Text = "90 kph";
            this.txtSpeedTDC.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtSpeedTDC.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // lblSolutionTDC
            // 
            this.lblSolutionTDC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSolutionTDC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolutionTDC.Location = new System.Drawing.Point(15, 247);
            this.lblSolutionTDC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSolutionTDC.Name = "lblSolutionTDC";
            this.lblSolutionTDC.Size = new System.Drawing.Size(322, 44);
            this.lblSolutionTDC.TabIndex = 16;
            this.lblSolutionTDC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAoBTDC
            // 
            this.txtAoBTDC.Location = new System.Drawing.Point(130, 105);
            this.txtAoBTDC.Margin = new System.Windows.Forms.Padding(4);
            this.txtAoBTDC.Name = "txtAoBTDC";
            this.txtAoBTDC.Size = new System.Drawing.Size(111, 22);
            this.txtAoBTDC.TabIndex = 13;
            this.txtAoBTDC.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtAoBTDC.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtBearingTDC
            // 
            this.txtBearingTDC.Location = new System.Drawing.Point(150, 11);
            this.txtBearingTDC.Margin = new System.Windows.Forms.Padding(4);
            this.txtBearingTDC.Name = "txtBearingTDC";
            this.txtBearingTDC.Size = new System.Drawing.Size(91, 22);
            this.txtBearingTDC.TabIndex = 1;
            this.txtBearingTDC.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtBearingTDC.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtRangeTDC
            // 
            this.txtRangeTDC.Location = new System.Drawing.Point(129, 41);
            this.txtRangeTDC.Margin = new System.Windows.Forms.Padding(4);
            this.txtRangeTDC.Name = "txtRangeTDC";
            this.txtRangeTDC.Size = new System.Drawing.Size(112, 22);
            this.txtRangeTDC.TabIndex = 3;
            this.txtRangeTDC.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtRangeTDC.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtTargetSpeedTDC
            // 
            this.txtTargetSpeedTDC.Location = new System.Drawing.Point(129, 73);
            this.txtTargetSpeedTDC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTargetSpeedTDC.Name = "txtTargetSpeedTDC";
            this.txtTargetSpeedTDC.Size = new System.Drawing.Size(112, 22);
            this.txtTargetSpeedTDC.TabIndex = 5;
            this.txtTargetSpeedTDC.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtTargetSpeedTDC.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtCourseTDC
            // 
            this.txtCourseTDC.Location = new System.Drawing.Point(404, 11);
            this.txtCourseTDC.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseTDC.Name = "txtCourseTDC";
            this.txtCourseTDC.Size = new System.Drawing.Size(91, 22);
            this.txtCourseTDC.TabIndex = 7;
            this.txtCourseTDC.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtCourseTDC.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // TDCForm
            // 
            this.AcceptButton = this.btnOKTDC;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = btnCancelTDC;
            this.ClientSize = new System.Drawing.Size(566, 348);
            this.Controls.Add(this.txtTargetSpeedTDC);
            this.Controls.Add(lblTargetSpeed);
            this.Controls.Add(this.txtCourseTDC);
            this.Controls.Add(lblCourse);
            this.Controls.Add(this.txtBearingTDC);
            this.Controls.Add(lblBearing);
            this.Controls.Add(this.txtRangeTDC);
            this.Controls.Add(lblRange);
            this.Controls.Add(this.txtAoBTDC);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(lblAoB);
            this.Controls.Add(this.lblSolutionTDC);
            this.Controls.Add(btnCancelTDC);
            this.Controls.Add(this.btnOKTDC);
            this.Controls.Add(this.txtSpeedTDC);
            this.Controls.Add(lblSpeed);
            this.Controls.Add(this.AOBknobControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TDCForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DCS Torpedo Data Computer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSpeedTDC;
        private System.Windows.Forms.Label lblSolutionTDC;
        private System.Windows.Forms.TextBox txtAoBTDC;
        private System.Windows.Forms.TextBox txtBearingTDC;
        private System.Windows.Forms.TextBox txtRangeTDC;
        private System.Windows.Forms.TextBox txtTargetSpeedTDC;
        private System.Windows.Forms.TextBox txtCourseTDC;
        private System.Windows.Forms.Button btnOKTDC;
        private KnobControl.KnobControl AOBknobControl;
    }
}