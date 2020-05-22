namespace BRepExample
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
            this.BtnInsertCutCube = new System.Windows.Forms.Button();
            this.BtnModifyPyramid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shapeType = new System.Windows.Forms.Label();
            this.shapeTypeBox = new System.Windows.Forms.TextBox();
            this.BtnAddCurrentModel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.xPos = new System.Windows.Forms.TextBox();
            this.yPos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.validateResult = new System.Windows.Forms.TextBox();
            this.BtnValidateCube = new System.Windows.Forms.Button();
            this.shapeSize = new System.Windows.Forms.TextBox();
            this.BtnInsertCube = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.shapeSize);
            this.panel1.Controls.Add(this.BtnInsertCube);
            this.panel1.Controls.Add(this.BtnInsertCutCube);
            this.panel1.Controls.Add(this.BtnModifyPyramid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 143);
            this.panel1.TabIndex = 16;
            // 
            // BtnInsertCutCube
            // 
            this.BtnInsertCutCube.Location = new System.Drawing.Point(28, 69);
            this.BtnInsertCutCube.Name = "BtnInsertCutCube";
            this.BtnInsertCutCube.Size = new System.Drawing.Size(255, 21);
            this.BtnInsertCutCube.TabIndex = 16;
            this.BtnInsertCutCube.Text = "Insert CUT cube into catalog";
            this.BtnInsertCutCube.UseVisualStyleBackColor = true;
            // 
            // BtnModifyPyramid
            // 
            this.BtnModifyPyramid.Enabled = false;
            this.BtnModifyPyramid.Location = new System.Drawing.Point(28, 102);
            this.BtnModifyPyramid.Name = "BtnModifyPyramid";
            this.BtnModifyPyramid.Size = new System.Drawing.Size(255, 21);
            this.BtnModifyPyramid.TabIndex = 9;
            this.BtnModifyPyramid.Text = "Modify shape in catalog to pyramid";
            this.BtnModifyPyramid.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cube side length in mm";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.shapeType);
            this.panel2.Controls.Add(this.shapeTypeBox);
            this.panel2.Controls.Add(this.BtnAddCurrentModel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.xPos);
            this.panel2.Controls.Add(this.yPos);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 119);
            this.panel2.TabIndex = 17;
            // 
            // shapeType
            // 
            this.shapeType.AutoSize = true;
            this.shapeType.Location = new System.Drawing.Point(24, 20);
            this.shapeType.Name = "shapeType";
            this.shapeType.Size = new System.Drawing.Size(85, 12);
            this.shapeType.TabIndex = 12;
            this.shapeType.Text = "Current shape";
            // 
            // shapeTypeBox
            // 
            this.shapeTypeBox.Location = new System.Drawing.Point(140, 18);
            this.shapeTypeBox.Name = "shapeTypeBox";
            this.shapeTypeBox.Size = new System.Drawing.Size(143, 21);
            this.shapeTypeBox.TabIndex = 11;
            // 
            // BtnAddCurrentModel
            // 
            this.BtnAddCurrentModel.Enabled = false;
            this.BtnAddCurrentModel.Location = new System.Drawing.Point(28, 84);
            this.BtnAddCurrentModel.Name = "BtnAddCurrentModel";
            this.BtnAddCurrentModel.Size = new System.Drawing.Size(255, 20);
            this.BtnAddCurrentModel.TabIndex = 10;
            this.BtnAddCurrentModel.Text = "Add current shape to model";
            this.BtnAddCurrentModel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "X-position";
            // 
            // xPos
            // 
            this.xPos.Location = new System.Drawing.Point(93, 46);
            this.xPos.Name = "xPos";
            this.xPos.Size = new System.Drawing.Size(47, 21);
            this.xPos.TabIndex = 7;
            // 
            // yPos
            // 
            this.yPos.Location = new System.Drawing.Point(236, 49);
            this.yPos.Name = "yPos";
            this.yPos.Size = new System.Drawing.Size(47, 21);
            this.yPos.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y-position";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.validateResult);
            this.panel3.Controls.Add(this.BtnValidateCube);
            this.panel3.Location = new System.Drawing.Point(12, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 91);
            this.panel3.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Result";
            // 
            // validateResult
            // 
            this.validateResult.Location = new System.Drawing.Point(76, 54);
            this.validateResult.Name = "validateResult";
            this.validateResult.Size = new System.Drawing.Size(208, 21);
            this.validateResult.TabIndex = 2;
            // 
            // BtnValidateCube
            // 
            this.BtnValidateCube.Location = new System.Drawing.Point(29, 19);
            this.BtnValidateCube.Name = "BtnValidateCube";
            this.BtnValidateCube.Size = new System.Drawing.Size(255, 21);
            this.BtnValidateCube.TabIndex = 1;
            this.BtnValidateCube.Text = "Validate cube shape";
            this.BtnValidateCube.UseVisualStyleBackColor = true;
            // 
            // shapeSize
            // 
            this.shapeSize.Location = new System.Drawing.Point(218, 9);
            this.shapeSize.Name = "shapeSize";
            this.shapeSize.Size = new System.Drawing.Size(65, 21);
            this.shapeSize.TabIndex = 18;
            // 
            // BtnInsertCube
            // 
            this.BtnInsertCube.Location = new System.Drawing.Point(28, 36);
            this.BtnInsertCube.Name = "BtnInsertCube";
            this.BtnInsertCube.Size = new System.Drawing.Size(255, 21);
            this.BtnInsertCube.TabIndex = 17;
            this.BtnInsertCube.Text = "Insert cube into catalog";
            this.BtnInsertCube.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnInsertCutCube;
        private System.Windows.Forms.Button BtnModifyPyramid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label shapeType;
        private System.Windows.Forms.TextBox shapeTypeBox;
        private System.Windows.Forms.Button BtnAddCurrentModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xPos;
        private System.Windows.Forms.TextBox yPos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox validateResult;
        private System.Windows.Forms.Button BtnValidateCube;
        private System.Windows.Forms.TextBox shapeSize;
        private System.Windows.Forms.Button BtnInsertCube;
    }
}

