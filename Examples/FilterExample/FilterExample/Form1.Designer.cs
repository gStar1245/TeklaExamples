namespace FilterExample
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
            this.filteredSurfaces = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnFilterSurface = new System.Windows.Forms.Button();
            this.textBox_surfaceClass = new System.Windows.Forms.TextBox();
            this.textBox_surfaceType = new System.Windows.Forms.TextBox();
            this.textBox_surfaceName = new System.Windows.Forms.TextBox();
            this.checkBox_surfaceClass = new System.Windows.Forms.CheckBox();
            this.checkBox_surfaceType = new System.Windows.Forms.CheckBox();
            this.checkBox_surfaceName = new System.Windows.Forms.CheckBox();
            this.filteredPU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPourUnits = new System.Windows.Forms.Button();
            this.textBox_PUName = new System.Windows.Forms.TextBox();
            this.checkBox_PUName = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filteredPours = new System.Windows.Forms.TextBox();
            this.BtnPourObject = new System.Windows.Forms.Button();
            this.textBox_CM = new System.Windows.Forms.TextBox();
            this.textBox_pourType = new System.Windows.Forms.TextBox();
            this.textBox_pourNumber = new System.Windows.Forms.TextBox();
            this.checkBox_pourCM = new System.Windows.Forms.CheckBox();
            this.checkBox_pourType = new System.Windows.Forms.CheckBox();
            this.checkBox_pourNumber = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // filteredSurfaces
            // 
            this.filteredSurfaces.Location = new System.Drawing.Point(455, 254);
            this.filteredSurfaces.Name = "filteredSurfaces";
            this.filteredSurfaces.Size = new System.Drawing.Size(81, 21);
            this.filteredSurfaces.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 12);
            this.label3.TabIndex = 45;
            this.label3.Text = "Filtered Surface Objects:";
            // 
            // BtnFilterSurface
            // 
            this.BtnFilterSurface.Location = new System.Drawing.Point(297, 222);
            this.BtnFilterSurface.Name = "BtnFilterSurface";
            this.BtnFilterSurface.Size = new System.Drawing.Size(251, 21);
            this.BtnFilterSurface.TabIndex = 44;
            this.BtnFilterSurface.Text = "Filter surface objects with left properties";
            this.BtnFilterSurface.UseVisualStyleBackColor = true;
            // 
            // textBox_surfaceClass
            // 
            this.textBox_surfaceClass.Location = new System.Drawing.Point(132, 268);
            this.textBox_surfaceClass.Name = "textBox_surfaceClass";
            this.textBox_surfaceClass.Size = new System.Drawing.Size(116, 21);
            this.textBox_surfaceClass.TabIndex = 43;
            // 
            // textBox_surfaceType
            // 
            this.textBox_surfaceType.Location = new System.Drawing.Point(132, 247);
            this.textBox_surfaceType.Name = "textBox_surfaceType";
            this.textBox_surfaceType.Size = new System.Drawing.Size(116, 21);
            this.textBox_surfaceType.TabIndex = 42;
            // 
            // textBox_surfaceName
            // 
            this.textBox_surfaceName.Location = new System.Drawing.Point(132, 226);
            this.textBox_surfaceName.Name = "textBox_surfaceName";
            this.textBox_surfaceName.Size = new System.Drawing.Size(116, 21);
            this.textBox_surfaceName.TabIndex = 41;
            // 
            // checkBox_surfaceClass
            // 
            this.checkBox_surfaceClass.AutoSize = true;
            this.checkBox_surfaceClass.Location = new System.Drawing.Point(12, 271);
            this.checkBox_surfaceClass.Name = "checkBox_surfaceClass";
            this.checkBox_surfaceClass.Size = new System.Drawing.Size(112, 16);
            this.checkBox_surfaceClass.TabIndex = 40;
            this.checkBox_surfaceClass.Text = "Surface class =";
            this.checkBox_surfaceClass.UseVisualStyleBackColor = true;
            // 
            // checkBox_surfaceType
            // 
            this.checkBox_surfaceType.AutoSize = true;
            this.checkBox_surfaceType.Location = new System.Drawing.Point(12, 250);
            this.checkBox_surfaceType.Name = "checkBox_surfaceType";
            this.checkBox_surfaceType.Size = new System.Drawing.Size(105, 16);
            this.checkBox_surfaceType.TabIndex = 39;
            this.checkBox_surfaceType.Text = "Surface type =";
            this.checkBox_surfaceType.UseVisualStyleBackColor = true;
            // 
            // checkBox_surfaceName
            // 
            this.checkBox_surfaceName.AutoSize = true;
            this.checkBox_surfaceName.Location = new System.Drawing.Point(12, 228);
            this.checkBox_surfaceName.Name = "checkBox_surfaceName";
            this.checkBox_surfaceName.Size = new System.Drawing.Size(113, 16);
            this.checkBox_surfaceName.TabIndex = 38;
            this.checkBox_surfaceName.Text = "Surface name =";
            this.checkBox_surfaceName.UseVisualStyleBackColor = true;
            // 
            // filteredPU
            // 
            this.filteredPU.Location = new System.Drawing.Point(423, 143);
            this.filteredPU.Name = "filteredPU";
            this.filteredPU.Size = new System.Drawing.Size(67, 21);
            this.filteredPU.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 12);
            this.label2.TabIndex = 36;
            this.label2.Text = "Filtered Pour Units:";
            // 
            // BtnPourUnits
            // 
            this.BtnPourUnits.Location = new System.Drawing.Point(297, 107);
            this.BtnPourUnits.Name = "BtnPourUnits";
            this.BtnPourUnits.Size = new System.Drawing.Size(253, 24);
            this.BtnPourUnits.TabIndex = 35;
            this.BtnPourUnits.Text = "Filter pour units with left property";
            this.BtnPourUnits.UseVisualStyleBackColor = true;
            // 
            // textBox_PUName
            // 
            this.textBox_PUName.Location = new System.Drawing.Point(132, 114);
            this.textBox_PUName.Name = "textBox_PUName";
            this.textBox_PUName.Size = new System.Drawing.Size(116, 21);
            this.textBox_PUName.TabIndex = 34;
            // 
            // checkBox_PUName
            // 
            this.checkBox_PUName.AutoSize = true;
            this.checkBox_PUName.Location = new System.Drawing.Point(12, 114);
            this.checkBox_PUName.Name = "checkBox_PUName";
            this.checkBox_PUName.Size = new System.Drawing.Size(110, 16);
            this.checkBox_PUName.TabIndex = 33;
            this.checkBox_PUName.Text = "Pour unit name";
            this.checkBox_PUName.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 12);
            this.label1.TabIndex = 32;
            this.label1.Text = "Filtered Pour Objects:";
            // 
            // filteredPours
            // 
            this.filteredPours.Location = new System.Drawing.Point(438, 43);
            this.filteredPours.Name = "filteredPours";
            this.filteredPours.Size = new System.Drawing.Size(53, 21);
            this.filteredPours.TabIndex = 31;
            // 
            // BtnPourObject
            // 
            this.BtnPourObject.Location = new System.Drawing.Point(297, 12);
            this.BtnPourObject.Name = "BtnPourObject";
            this.BtnPourObject.Size = new System.Drawing.Size(251, 22);
            this.BtnPourObject.TabIndex = 30;
            this.BtnPourObject.Text = "Filter pour objects with left properties:";
            this.BtnPourObject.UseVisualStyleBackColor = true;
            // 
            // textBox_CM
            // 
            this.textBox_CM.Location = new System.Drawing.Point(146, 52);
            this.textBox_CM.Name = "textBox_CM";
            this.textBox_CM.Size = new System.Drawing.Size(116, 21);
            this.textBox_CM.TabIndex = 29;
            // 
            // textBox_pourType
            // 
            this.textBox_pourType.Location = new System.Drawing.Point(146, 31);
            this.textBox_pourType.Name = "textBox_pourType";
            this.textBox_pourType.Size = new System.Drawing.Size(116, 21);
            this.textBox_pourType.TabIndex = 28;
            // 
            // textBox_pourNumber
            // 
            this.textBox_pourNumber.Location = new System.Drawing.Point(146, 10);
            this.textBox_pourNumber.Name = "textBox_pourNumber";
            this.textBox_pourNumber.Size = new System.Drawing.Size(116, 21);
            this.textBox_pourNumber.TabIndex = 27;
            // 
            // checkBox_pourCM
            // 
            this.checkBox_pourCM.AutoSize = true;
            this.checkBox_pourCM.Checked = true;
            this.checkBox_pourCM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_pourCM.Location = new System.Drawing.Point(12, 55);
            this.checkBox_pourCM.Name = "checkBox_pourCM";
            this.checkBox_pourCM.Size = new System.Drawing.Size(131, 16);
            this.checkBox_pourCM.TabIndex = 26;
            this.checkBox_pourCM.Text = "Concrete mixture =";
            this.checkBox_pourCM.UseVisualStyleBackColor = true;
            // 
            // checkBox_pourType
            // 
            this.checkBox_pourType.AutoSize = true;
            this.checkBox_pourType.Checked = true;
            this.checkBox_pourType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_pourType.Location = new System.Drawing.Point(12, 34);
            this.checkBox_pourType.Name = "checkBox_pourType";
            this.checkBox_pourType.Size = new System.Drawing.Size(88, 16);
            this.checkBox_pourType.TabIndex = 25;
            this.checkBox_pourType.Text = "Pour type =";
            this.checkBox_pourType.UseVisualStyleBackColor = true;
            // 
            // checkBox_pourNumber
            // 
            this.checkBox_pourNumber.AutoSize = true;
            this.checkBox_pourNumber.Checked = true;
            this.checkBox_pourNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_pourNumber.Location = new System.Drawing.Point(12, 12);
            this.checkBox_pourNumber.Name = "checkBox_pourNumber";
            this.checkBox_pourNumber.Size = new System.Drawing.Size(107, 16);
            this.checkBox_pourNumber.TabIndex = 24;
            this.checkBox_pourNumber.Text = "Pour number =";
            this.checkBox_pourNumber.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 309);
            this.Controls.Add(this.filteredSurfaces);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnFilterSurface);
            this.Controls.Add(this.textBox_surfaceClass);
            this.Controls.Add(this.textBox_surfaceType);
            this.Controls.Add(this.textBox_surfaceName);
            this.Controls.Add(this.checkBox_surfaceClass);
            this.Controls.Add(this.checkBox_surfaceType);
            this.Controls.Add(this.checkBox_surfaceName);
            this.Controls.Add(this.filteredPU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnPourUnits);
            this.Controls.Add(this.textBox_PUName);
            this.Controls.Add(this.checkBox_PUName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filteredPours);
            this.Controls.Add(this.BtnPourObject);
            this.Controls.Add(this.textBox_CM);
            this.Controls.Add(this.textBox_pourType);
            this.Controls.Add(this.textBox_pourNumber);
            this.Controls.Add(this.checkBox_pourCM);
            this.Controls.Add(this.checkBox_pourType);
            this.Controls.Add(this.checkBox_pourNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filteredSurfaces;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnFilterSurface;
        private System.Windows.Forms.TextBox textBox_surfaceClass;
        private System.Windows.Forms.TextBox textBox_surfaceType;
        private System.Windows.Forms.TextBox textBox_surfaceName;
        private System.Windows.Forms.CheckBox checkBox_surfaceClass;
        private System.Windows.Forms.CheckBox checkBox_surfaceType;
        private System.Windows.Forms.CheckBox checkBox_surfaceName;
        private System.Windows.Forms.TextBox filteredPU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPourUnits;
        private System.Windows.Forms.TextBox textBox_PUName;
        private System.Windows.Forms.CheckBox checkBox_PUName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filteredPours;
        private System.Windows.Forms.Button BtnPourObject;
        private System.Windows.Forms.TextBox textBox_CM;
        private System.Windows.Forms.TextBox textBox_pourType;
        private System.Windows.Forms.TextBox textBox_pourNumber;
        private System.Windows.Forms.CheckBox checkBox_pourCM;
        private System.Windows.Forms.CheckBox checkBox_pourType;
        private System.Windows.Forms.CheckBox checkBox_pourNumber;
    }
}

