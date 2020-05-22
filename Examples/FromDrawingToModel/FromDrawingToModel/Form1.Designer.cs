namespace FromDrawingToModel
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
            this.Quit = new System.Windows.Forms.Button();
            this.PickObjectInDrawing = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modelObjectTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(499, 252);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(154, 30);
            this.Quit.TabIndex = 6;
            this.Quit.Text = "Close";
            this.Quit.UseVisualStyleBackColor = true;
            // 
            // PickObjectInDrawing
            // 
            this.PickObjectInDrawing.Location = new System.Drawing.Point(499, 29);
            this.PickObjectInDrawing.Name = "PickObjectInDrawing";
            this.PickObjectInDrawing.Size = new System.Drawing.Size(154, 30);
            this.PickObjectInDrawing.TabIndex = 5;
            this.PickObjectInDrawing.Text = "Pick object in drawing";
            this.PickObjectInDrawing.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.modelObjectTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 279);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model object info";
            // 
            // modelObjectTextBox
            // 
            this.modelObjectTextBox.Location = new System.Drawing.Point(6, 17);
            this.modelObjectTextBox.Multiline = true;
            this.modelObjectTextBox.Name = "modelObjectTextBox";
            this.modelObjectTextBox.Size = new System.Drawing.Size(441, 253);
            this.modelObjectTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 301);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.PickObjectInDrawing);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button PickObjectInDrawing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox modelObjectTextBox;
    }
}

