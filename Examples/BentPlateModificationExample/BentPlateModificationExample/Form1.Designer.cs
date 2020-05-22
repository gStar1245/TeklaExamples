namespace BentPlateModificationExample
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.RadiusValue = new System.Windows.Forms.NumericUpDown();
            this.ModifyRadius = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateSimpleBentPlate2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ModifyCylindricalSide = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateSimpleBentPlate3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateSimpleBentPlate1 = new System.Windows.Forms.Button();
            this.ModifyPlateSide = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusValue)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 240);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(355, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bent plate modification example";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.RadiusValue);
            this.panel3.Controls.Add(this.ModifyRadius);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.CreateSimpleBentPlate2);
            this.panel3.Location = new System.Drawing.Point(359, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(317, 164);
            this.panel3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(51, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Set radius value :";
            // 
            // RadiusValue
            // 
            this.RadiusValue.DecimalPlaces = 2;
            this.RadiusValue.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.RadiusValue.Location = new System.Drawing.Point(176, 86);
            this.RadiusValue.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.RadiusValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.RadiusValue.Name = "RadiusValue";
            this.RadiusValue.Size = new System.Drawing.Size(86, 21);
            this.RadiusValue.TabIndex = 11;
            this.RadiusValue.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // ModifyRadius
            // 
            this.ModifyRadius.Enabled = false;
            this.ModifyRadius.Location = new System.Drawing.Point(65, 116);
            this.ModifyRadius.Name = "ModifyRadius";
            this.ModifyRadius.Size = new System.Drawing.Size(197, 21);
            this.ModifyRadius.TabIndex = 4;
            this.ModifyRadius.Text = "Modify bend radius";
            this.ModifyRadius.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(61, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Radius modification";
            // 
            // CreateSimpleBentPlate2
            // 
            this.CreateSimpleBentPlate2.Location = new System.Drawing.Point(65, 46);
            this.CreateSimpleBentPlate2.Name = "CreateSimpleBentPlate2";
            this.CreateSimpleBentPlate2.Size = new System.Drawing.Size(197, 21);
            this.CreateSimpleBentPlate2.TabIndex = 3;
            this.CreateSimpleBentPlate2.Text = "Create simple bent plate";
            this.CreateSimpleBentPlate2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.ModifyCylindricalSide);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.CreateSimpleBentPlate3);
            this.panel4.Location = new System.Drawing.Point(734, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 164);
            this.panel4.TabIndex = 0;
            // 
            // ModifyCylindricalSide
            // 
            this.ModifyCylindricalSide.Enabled = false;
            this.ModifyCylindricalSide.Location = new System.Drawing.Point(52, 98);
            this.ModifyCylindricalSide.Name = "ModifyCylindricalSide";
            this.ModifyCylindricalSide.Size = new System.Drawing.Size(210, 21);
            this.ModifyCylindricalSide.TabIndex = 6;
            this.ModifyCylindricalSide.Text = "Modify cylindrical side";
            this.ModifyCylindricalSide.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(15, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cylindrical side modification";
            // 
            // CreateSimpleBentPlate3
            // 
            this.CreateSimpleBentPlate3.Location = new System.Drawing.Point(52, 46);
            this.CreateSimpleBentPlate3.Name = "CreateSimpleBentPlate3";
            this.CreateSimpleBentPlate3.Size = new System.Drawing.Size(210, 21);
            this.CreateSimpleBentPlate3.TabIndex = 5;
            this.CreateSimpleBentPlate3.Text = "Create simple bent plate";
            this.CreateSimpleBentPlate3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CreateSimpleBentPlate1);
            this.panel2.Controls.Add(this.ModifyPlateSide);
            this.panel2.Location = new System.Drawing.Point(3, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 164);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(34, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Plate side modification";
            // 
            // CreateSimpleBentPlate1
            // 
            this.CreateSimpleBentPlate1.Location = new System.Drawing.Point(38, 46);
            this.CreateSimpleBentPlate1.Name = "CreateSimpleBentPlate1";
            this.CreateSimpleBentPlate1.Size = new System.Drawing.Size(224, 21);
            this.CreateSimpleBentPlate1.TabIndex = 1;
            this.CreateSimpleBentPlate1.Text = "Create simple bent plate";
            this.CreateSimpleBentPlate1.UseVisualStyleBackColor = true;
            // 
            // ModifyPlateSide
            // 
            this.ModifyPlateSide.Enabled = false;
            this.ModifyPlateSide.Location = new System.Drawing.Point(38, 98);
            this.ModifyPlateSide.Name = "ModifyPlateSide";
            this.ModifyPlateSide.Size = new System.Drawing.Size(224, 21);
            this.ModifyPlateSide.TabIndex = 2;
            this.ModifyPlateSide.Text = "Modify plate side";
            this.ModifyPlateSide.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 267);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusValue)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown RadiusValue;
        private System.Windows.Forms.Button ModifyRadius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CreateSimpleBentPlate2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ModifyCylindricalSide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateSimpleBentPlate3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateSimpleBentPlate1;
        private System.Windows.Forms.Button ModifyPlateSide;
    }
}

