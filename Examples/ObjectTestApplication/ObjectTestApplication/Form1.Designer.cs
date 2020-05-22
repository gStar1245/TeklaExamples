namespace ObjectTestApplication
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
            this.BtnClear = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.BtnRun = new System.Windows.Forms.Button();
            this.textLog = new System.Windows.Forms.TextBox();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(442, 116);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(144, 61);
            this.BtnClear.TabIndex = 15;
            this.BtnClear.Text = "Clear Model";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 140;
            this.checkedListBox1.Items.AddRange(new object[] {
            "All",
            "BeamTest",
            "PolyBeamTest",
            "ContourPlateTest",
            "BooleanTests",
            "RebarTests",
            "BoltTests",
            "WeldTest",
            "CastUnitTest",
            "AssemblyTest",
            "LoadTests",
            "PlaneTests",
            "SurfaceTreatmentTest",
            "EnumerationTest",
            "SolidTests",
            "ComponentTests"});
            this.checkedListBox1.Location = new System.Drawing.Point(19, 13);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(346, 148);
            this.checkedListBox1.TabIndex = 14;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(442, 21);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(144, 87);
            this.BtnRun.TabIndex = 13;
            this.BtnRun.Text = "Run Selected Tests";
            // 
            // textLog
            // 
            this.textLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textLog.Location = new System.Drawing.Point(0, 197);
            this.textLog.MaxLength = 2147483647;
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ReadOnly = true;
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textLog.Size = new System.Drawing.Size(673, 104);
            this.textLog.TabIndex = 17;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 301);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(673, 23);
            this.statusBar1.TabIndex = 16;
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "Objecttest started..";
            this.statusBarPanel1.Width = 556;
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusBarPanel2.Name = "statusBarPanel2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 324);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.BtnRun);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel2;
    }
}

