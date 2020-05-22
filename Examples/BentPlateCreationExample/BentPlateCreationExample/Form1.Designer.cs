namespace BentPlateCreationExample
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.CreateSampleBentPlateByFaces = new System.Windows.Forms.Button();
            this.CreateByFacesSamplePlates = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateMaxRadiusBendPlate = new System.Windows.Forms.Button();
            this.CreateSamplePlatesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radiusValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateBentPlateWithGivenRadius = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateSamplePlatesButton2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SimpleCreateByAddLeg = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.RadiusForAddLegWithSegments = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.CreateByAddLegUsingSegments = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.RadiusForAddLegCreation = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.CreateByAddLegWithRadius = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusValue)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusForAddLegWithSegments)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusForAddLegCreation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 392);
            this.panel3.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.CreateSampleBentPlateByFaces);
            this.panel8.Controls.Add(this.CreateByFacesSamplePlates);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Location = new System.Drawing.Point(7, 279);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(303, 103);
            this.panel8.TabIndex = 0;
            // 
            // CreateSampleBentPlateByFaces
            // 
            this.CreateSampleBentPlateByFaces.Enabled = false;
            this.CreateSampleBentPlateByFaces.Location = new System.Drawing.Point(3, 69);
            this.CreateSampleBentPlateByFaces.Name = "CreateSampleBentPlateByFaces";
            this.CreateSampleBentPlateByFaces.Size = new System.Drawing.Size(294, 21);
            this.CreateSampleBentPlateByFaces.TabIndex = 2;
            this.CreateSampleBentPlateByFaces.Text = "Create bend using faces between sample plates";
            this.CreateSampleBentPlateByFaces.UseVisualStyleBackColor = true;
            // 
            // CreateByFacesSamplePlates
            // 
            this.CreateByFacesSamplePlates.Location = new System.Drawing.Point(3, 42);
            this.CreateByFacesSamplePlates.Name = "CreateByFacesSamplePlates";
            this.CreateByFacesSamplePlates.Size = new System.Drawing.Size(294, 21);
            this.CreateByFacesSamplePlates.TabIndex = 1;
            this.CreateByFacesSamplePlates.Text = "Create sample plates";
            this.CreateByFacesSamplePlates.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(17, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Simple creation of bent plate by faces";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CreateMaxRadiusBendPlate);
            this.panel1.Controls.Add(this.CreateSamplePlatesButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 105);
            this.panel1.TabIndex = 0;
            // 
            // CreateMaxRadiusBendPlate
            // 
            this.CreateMaxRadiusBendPlate.Enabled = false;
            this.CreateMaxRadiusBendPlate.Location = new System.Drawing.Point(3, 69);
            this.CreateMaxRadiusBendPlate.Name = "CreateMaxRadiusBendPlate";
            this.CreateMaxRadiusBendPlate.Size = new System.Drawing.Size(294, 21);
            this.CreateMaxRadiusBendPlate.TabIndex = 2;
            this.CreateMaxRadiusBendPlate.Text = "Create bend between sample plates";
            this.CreateMaxRadiusBendPlate.UseVisualStyleBackColor = true;
            // 
            // CreateSamplePlatesButton
            // 
            this.CreateSamplePlatesButton.Location = new System.Drawing.Point(3, 42);
            this.CreateSamplePlatesButton.Name = "CreateSamplePlatesButton";
            this.CreateSamplePlatesButton.Size = new System.Drawing.Size(294, 21);
            this.CreateSamplePlatesButton.TabIndex = 1;
            this.CreateSamplePlatesButton.Text = "Create sample plates";
            this.CreateSamplePlatesButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(56, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple creation of bent plate";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Creation using modelled Contour Plates";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radiusValue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.CreateBentPlateWithGivenRadius);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CreateSamplePlatesButton2);
            this.panel2.Location = new System.Drawing.Point(7, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 143);
            this.panel2.TabIndex = 1;
            // 
            // radiusValue
            // 
            this.radiusValue.DecimalPlaces = 2;
            this.radiusValue.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.radiusValue.Location = new System.Drawing.Point(171, 70);
            this.radiusValue.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.radiusValue.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.radiusValue.Name = "radiusValue";
            this.radiusValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiusValue.Size = new System.Drawing.Size(91, 21);
            this.radiusValue.TabIndex = 8;
            this.radiusValue.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(36, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter radius between:\r\n 20 and 1500";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreateBentPlateWithGivenRadius
            // 
            this.CreateBentPlateWithGivenRadius.Enabled = false;
            this.CreateBentPlateWithGivenRadius.Location = new System.Drawing.Point(40, 94);
            this.CreateBentPlateWithGivenRadius.Name = "CreateBentPlateWithGivenRadius";
            this.CreateBentPlateWithGivenRadius.Size = new System.Drawing.Size(223, 31);
            this.CreateBentPlateWithGivenRadius.TabIndex = 5;
            this.CreateBentPlateWithGivenRadius.Text = "Create bend between sample plates with given radius";
            this.CreateBentPlateWithGivenRadius.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(76, 8);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Creation of bent plate \r\nwith given radius";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreateSamplePlatesButton2
            // 
            this.CreateSamplePlatesButton2.Location = new System.Drawing.Point(40, 41);
            this.CreateSamplePlatesButton2.Name = "CreateSamplePlatesButton2";
            this.CreateSamplePlatesButton2.Size = new System.Drawing.Size(223, 21);
            this.CreateSamplePlatesButton2.TabIndex = 4;
            this.CreateSamplePlatesButton2.Text = "Create sample plates";
            this.CreateSamplePlatesButton2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(342, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(339, 311);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.SimpleCreateByAddLeg);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(17, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(303, 65);
            this.panel5.TabIndex = 0;
            // 
            // SimpleCreateByAddLeg
            // 
            this.SimpleCreateByAddLeg.Location = new System.Drawing.Point(3, 33);
            this.SimpleCreateByAddLeg.Name = "SimpleCreateByAddLeg";
            this.SimpleCreateByAddLeg.Size = new System.Drawing.Size(294, 21);
            this.SimpleCreateByAddLeg.TabIndex = 2;
            this.SimpleCreateByAddLeg.Text = "Create bend using AddLeg";
            this.SimpleCreateByAddLeg.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(56, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Simple addLeg creation";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.RadiusForAddLegWithSegments);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.CreateByAddLegUsingSegments);
            this.panel9.Controls.Add(this.label12);
            this.panel9.Location = new System.Drawing.Point(17, 198);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(303, 100);
            this.panel9.TabIndex = 1;
            // 
            // RadiusForAddLegWithSegments
            // 
            this.RadiusForAddLegWithSegments.DecimalPlaces = 2;
            this.RadiusForAddLegWithSegments.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.RadiusForAddLegWithSegments.Location = new System.Drawing.Point(170, 36);
            this.RadiusForAddLegWithSegments.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.RadiusForAddLegWithSegments.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.RadiusForAddLegWithSegments.Name = "RadiusForAddLegWithSegments";
            this.RadiusForAddLegWithSegments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RadiusForAddLegWithSegments.Size = new System.Drawing.Size(91, 21);
            this.RadiusForAddLegWithSegments.TabIndex = 8;
            this.RadiusForAddLegWithSegments.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(35, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 26);
            this.label11.TabIndex = 6;
            this.label11.Text = "Enter radius between:\r\n 20 and 1500";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreateByAddLegUsingSegments
            // 
            this.CreateByAddLegUsingSegments.Location = new System.Drawing.Point(38, 60);
            this.CreateByAddLegUsingSegments.Name = "CreateByAddLegUsingSegments";
            this.CreateByAddLegUsingSegments.Size = new System.Drawing.Size(223, 31);
            this.CreateByAddLegUsingSegments.TabIndex = 5;
            this.CreateByAddLegUsingSegments.Text = "Create bend between sample plates with given radius";
            this.CreateByAddLegUsingSegments.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Location = new System.Drawing.Point(3, 8);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(243, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "AddLeg using line segments and radius";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Creation using ConnectiveGeometry class";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.RadiusForAddLegCreation);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.CreateByAddLegWithRadius);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(17, 90);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(303, 104);
            this.panel6.TabIndex = 1;
            // 
            // RadiusForAddLegCreation
            // 
            this.RadiusForAddLegCreation.DecimalPlaces = 2;
            this.RadiusForAddLegCreation.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.RadiusForAddLegCreation.Location = new System.Drawing.Point(170, 42);
            this.RadiusForAddLegCreation.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.RadiusForAddLegCreation.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.RadiusForAddLegCreation.Name = "RadiusForAddLegCreation";
            this.RadiusForAddLegCreation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RadiusForAddLegCreation.Size = new System.Drawing.Size(91, 21);
            this.RadiusForAddLegCreation.TabIndex = 8;
            this.RadiusForAddLegCreation.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Location = new System.Drawing.Point(35, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "Enter radius between:\r\n 20 and 1500";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreateByAddLegWithRadius
            // 
            this.CreateByAddLegWithRadius.Location = new System.Drawing.Point(38, 66);
            this.CreateByAddLegWithRadius.Name = "CreateByAddLegWithRadius";
            this.CreateByAddLegWithRadius.Size = new System.Drawing.Size(223, 31);
            this.CreateByAddLegWithRadius.TabIndex = 5;
            this.CreateByAddLegWithRadius.Text = "Create bend between sample plates with given radius";
            this.CreateByAddLegWithRadius.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(85, 5);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(110, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "AddLeg creation \r\nwith given radius";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 416);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusValue)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusForAddLegWithSegments)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusForAddLegCreation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button CreateSampleBentPlateByFaces;
        private System.Windows.Forms.Button CreateByFacesSamplePlates;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CreateMaxRadiusBendPlate;
        private System.Windows.Forms.Button CreateSamplePlatesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown radiusValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateBentPlateWithGivenRadius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateSamplePlatesButton2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button SimpleCreateByAddLeg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.NumericUpDown RadiusForAddLegWithSegments;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CreateByAddLegUsingSegments;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown RadiusForAddLegCreation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CreateByAddLegWithRadius;
        private System.Windows.Forms.Label label8;
    }
}

