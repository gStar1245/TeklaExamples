namespace DimensionCreator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.straightDimensionButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.curvedOrthogonalDimensionButton = new System.Windows.Forms.Button();
            this.numberOfPointsToPickLabel = new System.Windows.Forms.Label();
            this.numberOfPointsToPickNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.radiusDimensionButton = new System.Windows.Forms.Button();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.distanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.curvedRadialDimensionButton = new System.Windows.Forms.Button();
            this.repeatCheckBox = new System.Windows.Forms.CheckBox();
            this.angleDimensionButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPointsToPickNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.repeatCheckBox);
            this.groupBox1.Controls.Add(this.angleDimensionButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 203);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.straightDimensionButton);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.radiusDimensionButton);
            this.groupBox3.Controls.Add(this.distanceLabel);
            this.groupBox3.Controls.Add(this.distanceNumericUpDown);
            this.groupBox3.Controls.Add(this.curvedRadialDimensionButton);
            this.groupBox3.Location = new System.Drawing.Point(10, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 154);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // straightDimensionButton
            // 
            this.straightDimensionButton.Location = new System.Drawing.Point(225, 44);
            this.straightDimensionButton.Name = "straightDimensionButton";
            this.straightDimensionButton.Size = new System.Drawing.Size(219, 21);
            this.straightDimensionButton.TabIndex = 0;
            this.straightDimensionButton.Text = "Create straight dimension";
            this.straightDimensionButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.curvedOrthogonalDimensionButton);
            this.groupBox2.Controls.Add(this.numberOfPointsToPickLabel);
            this.groupBox2.Controls.Add(this.numberOfPointsToPickNumericUpDown);
            this.groupBox2.Location = new System.Drawing.Point(10, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 50);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // curvedOrthogonalDimensionButton
            // 
            this.curvedOrthogonalDimensionButton.Location = new System.Drawing.Point(215, 16);
            this.curvedOrthogonalDimensionButton.Name = "curvedOrthogonalDimensionButton";
            this.curvedOrthogonalDimensionButton.Size = new System.Drawing.Size(219, 21);
            this.curvedOrthogonalDimensionButton.TabIndex = 6;
            this.curvedOrthogonalDimensionButton.Text = "Create curved orthogonal dimension";
            this.curvedOrthogonalDimensionButton.UseVisualStyleBackColor = true;
            // 
            // numberOfPointsToPickLabel
            // 
            this.numberOfPointsToPickLabel.AutoSize = true;
            this.numberOfPointsToPickLabel.Location = new System.Drawing.Point(7, 20);
            this.numberOfPointsToPickLabel.Name = "numberOfPointsToPickLabel";
            this.numberOfPointsToPickLabel.Size = new System.Drawing.Size(147, 12);
            this.numberOfPointsToPickLabel.TabIndex = 8;
            this.numberOfPointsToPickLabel.Text = "Number of points to pick:";
            // 
            // numberOfPointsToPickNumericUpDown
            // 
            this.numberOfPointsToPickNumericUpDown.Location = new System.Drawing.Point(157, 18);
            this.numberOfPointsToPickNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfPointsToPickNumericUpDown.Name = "numberOfPointsToPickNumericUpDown";
            this.numberOfPointsToPickNumericUpDown.Size = new System.Drawing.Size(50, 21);
            this.numberOfPointsToPickNumericUpDown.TabIndex = 7;
            this.numberOfPointsToPickNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // radiusDimensionButton
            // 
            this.radiusDimensionButton.Location = new System.Drawing.Point(225, 18);
            this.radiusDimensionButton.Name = "radiusDimensionButton";
            this.radiusDimensionButton.Size = new System.Drawing.Size(219, 21);
            this.radiusDimensionButton.TabIndex = 0;
            this.radiusDimensionButton.Text = "Create radius dimension";
            this.radiusDimensionButton.UseVisualStyleBackColor = true;
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(17, 49);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(58, 12);
            this.distanceLabel.TabIndex = 6;
            this.distanceLabel.Text = "Distance:";
            // 
            // distanceNumericUpDown
            // 
            this.distanceNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.distanceNumericUpDown.Location = new System.Drawing.Point(85, 47);
            this.distanceNumericUpDown.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.distanceNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.distanceNumericUpDown.Name = "distanceNumericUpDown";
            this.distanceNumericUpDown.Size = new System.Drawing.Size(66, 21);
            this.distanceNumericUpDown.TabIndex = 2;
            this.distanceNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // curvedRadialDimensionButton
            // 
            this.curvedRadialDimensionButton.Location = new System.Drawing.Point(225, 71);
            this.curvedRadialDimensionButton.Name = "curvedRadialDimensionButton";
            this.curvedRadialDimensionButton.Size = new System.Drawing.Size(219, 21);
            this.curvedRadialDimensionButton.TabIndex = 0;
            this.curvedRadialDimensionButton.Text = "Create curved radial dimension";
            this.curvedRadialDimensionButton.UseVisualStyleBackColor = true;
            // 
            // repeatCheckBox
            // 
            this.repeatCheckBox.AutoSize = true;
            this.repeatCheckBox.Location = new System.Drawing.Point(31, 20);
            this.repeatCheckBox.Name = "repeatCheckBox";
            this.repeatCheckBox.Size = new System.Drawing.Size(136, 16);
            this.repeatCheckBox.TabIndex = 3;
            this.repeatCheckBox.Text = "Use previous points";
            this.repeatCheckBox.UseVisualStyleBackColor = true;
            // 
            // angleDimensionButton
            // 
            this.angleDimensionButton.Location = new System.Drawing.Point(236, 17);
            this.angleDimensionButton.Name = "angleDimensionButton";
            this.angleDimensionButton.Size = new System.Drawing.Size(219, 21);
            this.angleDimensionButton.TabIndex = 0;
            this.angleDimensionButton.Text = "Create angle dimension";
            this.angleDimensionButton.UseVisualStyleBackColor = true;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(380, 220);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(87, 21);
            this.quitButton.TabIndex = 10;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 252);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.quitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPointsToPickNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanceNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button straightDimensionButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button curvedOrthogonalDimensionButton;
        private System.Windows.Forms.Label numberOfPointsToPickLabel;
        private System.Windows.Forms.NumericUpDown numberOfPointsToPickNumericUpDown;
        private System.Windows.Forms.Button radiusDimensionButton;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.NumericUpDown distanceNumericUpDown;
        private System.Windows.Forms.Button curvedRadialDimensionButton;
        private System.Windows.Forms.CheckBox repeatCheckBox;
        private System.Windows.Forms.Button angleDimensionButton;
        private System.Windows.Forms.Button quitButton;
    }
}

