namespace BentPlateBoxCreationExample
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateBoxWithCustomRadius = new System.Windows.Forms.Button();
            this.CustomRadiusValue = new System.Windows.Forms.NumericUpDown();
            this.CreateBends = new System.Windows.Forms.Button();
            this.CreateContourPlates = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateBoxUsingGeometryAndRadius = new System.Windows.Forms.Button();
            this.CreateBoxUsingGeometry = new System.Windows.Forms.Button();
            this.RadiusValueForAddLeg = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomRadiusValue)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusValueForAddLeg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CreateBoxWithCustomRadius);
            this.panel1.Controls.Add(this.CustomRadiusValue);
            this.panel1.Controls.Add(this.CreateBends);
            this.panel1.Controls.Add(this.CreateContourPlates);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 194);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(36, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Or set bend radius:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateBoxWithCustomRadius
            // 
            this.CreateBoxWithCustomRadius.Enabled = false;
            this.CreateBoxWithCustomRadius.Location = new System.Drawing.Point(3, 159);
            this.CreateBoxWithCustomRadius.Name = "CreateBoxWithCustomRadius";
            this.CreateBoxWithCustomRadius.Size = new System.Drawing.Size(296, 21);
            this.CreateBoxWithCustomRadius.TabIndex = 4;
            this.CreateBoxWithCustomRadius.Text = "Create bends between plates using radius";
            this.CreateBoxWithCustomRadius.UseVisualStyleBackColor = true;
            // 
            // CustomRadiusValue
            // 
            this.CustomRadiusValue.DecimalPlaces = 2;
            this.CustomRadiusValue.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.CustomRadiusValue.Location = new System.Drawing.Point(155, 135);
            this.CustomRadiusValue.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.CustomRadiusValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.CustomRadiusValue.Name = "CustomRadiusValue";
            this.CustomRadiusValue.Size = new System.Drawing.Size(105, 21);
            this.CustomRadiusValue.TabIndex = 3;
            this.CustomRadiusValue.ThousandsSeparator = true;
            this.CustomRadiusValue.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // CreateBends
            // 
            this.CreateBends.Enabled = false;
            this.CreateBends.Location = new System.Drawing.Point(40, 100);
            this.CreateBends.Name = "CreateBends";
            this.CreateBends.Size = new System.Drawing.Size(220, 21);
            this.CreateBends.TabIndex = 2;
            this.CreateBends.Text = "Create bends between plates";
            this.CreateBends.UseVisualStyleBackColor = true;
            // 
            // CreateContourPlates
            // 
            this.CreateContourPlates.Location = new System.Drawing.Point(40, 61);
            this.CreateContourPlates.Name = "CreateContourPlates";
            this.CreateContourPlates.Size = new System.Drawing.Size(220, 21);
            this.CreateContourPlates.TabIndex = 1;
            this.CreateContourPlates.Text = "Create contour plates for box";
            this.CreateContourPlates.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(23, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Box creation using \r\nmodelled plates example";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CreateBoxUsingGeometryAndRadius);
            this.panel2.Controls.Add(this.CreateBoxUsingGeometry);
            this.panel2.Controls.Add(this.RadiusValueForAddLeg);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(330, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 194);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(50, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Or set bend radius:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateBoxUsingGeometryAndRadius
            // 
            this.CreateBoxUsingGeometryAndRadius.Location = new System.Drawing.Point(54, 142);
            this.CreateBoxUsingGeometryAndRadius.Name = "CreateBoxUsingGeometryAndRadius";
            this.CreateBoxUsingGeometryAndRadius.Size = new System.Drawing.Size(220, 21);
            this.CreateBoxUsingGeometryAndRadius.TabIndex = 7;
            this.CreateBoxUsingGeometryAndRadius.Text = "Create box using radius value";
            this.CreateBoxUsingGeometryAndRadius.UseVisualStyleBackColor = true;
            // 
            // CreateBoxUsingGeometry
            // 
            this.CreateBoxUsingGeometry.Location = new System.Drawing.Point(54, 78);
            this.CreateBoxUsingGeometry.Name = "CreateBoxUsingGeometry";
            this.CreateBoxUsingGeometry.Size = new System.Drawing.Size(220, 21);
            this.CreateBoxUsingGeometry.TabIndex = 2;
            this.CreateBoxUsingGeometry.Text = "Create box structure";
            this.CreateBoxUsingGeometry.UseVisualStyleBackColor = true;
            // 
            // RadiusValueForAddLeg
            // 
            this.RadiusValueForAddLeg.DecimalPlaces = 2;
            this.RadiusValueForAddLeg.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.RadiusValueForAddLeg.Location = new System.Drawing.Point(169, 118);
            this.RadiusValueForAddLeg.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.RadiusValueForAddLeg.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.RadiusValueForAddLeg.Name = "RadiusValueForAddLeg";
            this.RadiusValueForAddLeg.Size = new System.Drawing.Size(105, 21);
            this.RadiusValueForAddLeg.TabIndex = 6;
            this.RadiusValueForAddLeg.ThousandsSeparator = true;
            this.RadiusValueForAddLeg.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Box creation using \r\nConnectiveGeometry example";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 220);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomRadiusValue)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusValueForAddLeg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateBoxWithCustomRadius;
        private System.Windows.Forms.NumericUpDown CustomRadiusValue;
        private System.Windows.Forms.Button CreateBends;
        private System.Windows.Forms.Button CreateContourPlates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateBoxUsingGeometryAndRadius;
        private System.Windows.Forms.Button CreateBoxUsingGeometry;
        private System.Windows.Forms.NumericUpDown RadiusValueForAddLeg;
        private System.Windows.Forms.Label label2;
    }
}

