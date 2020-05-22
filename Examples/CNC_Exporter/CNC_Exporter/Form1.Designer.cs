namespace CNC_Exporter
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
            this.BtnExportScript = new System.Windows.Forms.Button();
            this.BtnExportAPI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnExportScript
            // 
            this.BtnExportScript.Location = new System.Drawing.Point(79, 12);
            this.BtnExportScript.Name = "BtnExportScript";
            this.BtnExportScript.Size = new System.Drawing.Size(92, 28);
            this.BtnExportScript.TabIndex = 0;
            this.BtnExportScript.Text = "Export(Script)";
            this.BtnExportScript.UseVisualStyleBackColor = true;
            // 
            // BtnExportAPI
            // 
            this.BtnExportAPI.Location = new System.Drawing.Point(79, 52);
            this.BtnExportAPI.Name = "BtnExportAPI";
            this.BtnExportAPI.Size = new System.Drawing.Size(92, 28);
            this.BtnExportAPI.TabIndex = 1;
            this.BtnExportAPI.Text = "Export(API)";
            this.BtnExportAPI.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 92);
            this.Controls.Add(this.BtnExportAPI);
            this.Controls.Add(this.BtnExportScript);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExportScript;
        private System.Windows.Forms.Button BtnExportAPI;
    }
}

