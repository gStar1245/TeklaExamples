namespace BeamCustomPart
{
    partial class BeamCustomPartForm
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
            this.saveLoad1 = new Tekla.Structures.Dialog.UIControls.SaveLoad();
            this.okApplyModifyGetOnOffCancel1 = new Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel();
            this.profileCatalog = new Tekla.Structures.Dialog.UIControls.ProfileCatalog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBProfile = new System.Windows.Forms.TextBox();
            this.TBLengthFactor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.atDepthCcomboBox = new System.Windows.Forms.ComboBox();
            this.rotationComboBox = new System.Windows.Forms.ComboBox();
            this.onPlaneComboBox = new System.Windows.Forms.ComboBox();
            this.atDepthTextBox = new System.Windows.Forms.TextBox();
            this.rotationTextBox = new System.Windows.Forms.TextBox();
            this.onPlaneTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveLoad1
            // 
            this.structuresExtender.SetAttributeName(this.saveLoad1, null);
            this.structuresExtender.SetAttributeTypeName(this.saveLoad1, null);
            this.saveLoad1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.structuresExtender.SetBindPropertyName(this.saveLoad1, null);
            this.saveLoad1.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveLoad1.HelpFileType = Tekla.Structures.Dialog.UIControls.SaveLoad.HelpFileTypeEnum.General;
            this.saveLoad1.HelpKeyword = "";
            this.saveLoad1.HelpUrl = "";
            this.saveLoad1.Location = new System.Drawing.Point(0, 0);
            this.saveLoad1.Name = "saveLoad1";
            this.saveLoad1.SaveAsText = "";
            this.saveLoad1.Size = new System.Drawing.Size(687, 40);
            this.saveLoad1.TabIndex = 0;
            this.saveLoad1.UserDefinedHelpFilePath = null;
            // 
            // okApplyModifyGetOnOffCancel1
            // 
            this.structuresExtender.SetAttributeName(this.okApplyModifyGetOnOffCancel1, null);
            this.structuresExtender.SetAttributeTypeName(this.okApplyModifyGetOnOffCancel1, null);
            this.structuresExtender.SetBindPropertyName(this.okApplyModifyGetOnOffCancel1, null);
            this.okApplyModifyGetOnOffCancel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okApplyModifyGetOnOffCancel1.Location = new System.Drawing.Point(0, 207);
            this.okApplyModifyGetOnOffCancel1.Name = "okApplyModifyGetOnOffCancel1";
            this.okApplyModifyGetOnOffCancel1.Size = new System.Drawing.Size(687, 27);
            this.okApplyModifyGetOnOffCancel1.TabIndex = 1;
            // 
            // profileCatalog
            // 
            this.structuresExtender.SetAttributeName(this.profileCatalog, null);
            this.structuresExtender.SetAttributeTypeName(this.profileCatalog, null);
            this.profileCatalog.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.profileCatalog, null);
            this.profileCatalog.Location = new System.Drawing.Point(301, 13);
            this.profileCatalog.Name = "profileCatalog";
            this.profileCatalog.SelectedProfile = "";
            this.profileCatalog.Size = new System.Drawing.Size(103, 25);
            this.profileCatalog.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.structuresExtender.SetAttributeName(this.tabControl1, null);
            this.structuresExtender.SetAttributeTypeName(this.tabControl1, null);
            this.structuresExtender.SetBindPropertyName(this.tabControl1, null);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(687, 167);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.structuresExtender.SetAttributeName(this.tabPage1, null);
            this.structuresExtender.SetAttributeTypeName(this.tabPage1, null);
            this.structuresExtender.SetBindPropertyName(this.tabPage1, null);
            this.tabPage1.Controls.Add(this.TBLengthFactor);
            this.tabPage1.Controls.Add(this.TBProfile);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.profileCatalog);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(679, 141);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parameters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.structuresExtender.SetAttributeName(this.tabPage2, null);
            this.structuresExtender.SetAttributeTypeName(this.tabPage2, null);
            this.structuresExtender.SetBindPropertyName(this.tabPage2, null);
            this.tabPage2.Controls.Add(this.atDepthCcomboBox);
            this.tabPage2.Controls.Add(this.rotationComboBox);
            this.tabPage2.Controls.Add(this.onPlaneComboBox);
            this.tabPage2.Controls.Add(this.atDepthTextBox);
            this.tabPage2.Controls.Add(this.rotationTextBox);
            this.tabPage2.Controls.Add(this.onPlaneTextBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(679, 141);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Position";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.structuresExtender.SetAttributeName(this.label1, null);
            this.structuresExtender.SetAttributeTypeName(this.label1, null);
            this.label1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label1, null);
            this.label1.Location = new System.Drawing.Point(57, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Profile";
            // 
            // label2
            // 
            this.structuresExtender.SetAttributeName(this.label2, null);
            this.structuresExtender.SetAttributeTypeName(this.label2, null);
            this.label2.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label2, null);
            this.label2.Location = new System.Drawing.Point(57, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Length factor";
            // 
            // TBProfile
            // 
            this.structuresExtender.SetAttributeName(this.TBProfile, null);
            this.structuresExtender.SetAttributeTypeName(this.TBProfile, null);
            this.structuresExtender.SetBindPropertyName(this.TBProfile, null);
            this.TBProfile.Location = new System.Drawing.Point(163, 17);
            this.TBProfile.Name = "TBProfile";
            this.TBProfile.Size = new System.Drawing.Size(110, 21);
            this.TBProfile.TabIndex = 5;
            // 
            // TBLengthFactor
            // 
            this.structuresExtender.SetAttributeName(this.TBLengthFactor, null);
            this.structuresExtender.SetAttributeTypeName(this.TBLengthFactor, null);
            this.structuresExtender.SetBindPropertyName(this.TBLengthFactor, null);
            this.TBLengthFactor.Location = new System.Drawing.Point(163, 52);
            this.TBLengthFactor.Name = "TBLengthFactor";
            this.TBLengthFactor.Size = new System.Drawing.Size(110, 21);
            this.TBLengthFactor.TabIndex = 6;
            // 
            // label4
            // 
            this.structuresExtender.SetAttributeName(this.label4, null);
            this.structuresExtender.SetAttributeTypeName(this.label4, null);
            this.label4.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label4, null);
            this.label4.Location = new System.Drawing.Point(68, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "At depth";
            // 
            // label3
            // 
            this.structuresExtender.SetAttributeName(this.label3, null);
            this.structuresExtender.SetAttributeTypeName(this.label3, null);
            this.label3.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label3, null);
            this.label3.Location = new System.Drawing.Point(68, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rotation";
            // 
            // label5
            // 
            this.structuresExtender.SetAttributeName(this.label5, null);
            this.structuresExtender.SetAttributeTypeName(this.label5, null);
            this.label5.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label5, null);
            this.label5.Location = new System.Drawing.Point(68, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "On plane";
            // 
            // atDepthCcomboBox
            // 
            this.structuresExtender.SetAttributeName(this.atDepthCcomboBox, "AtDepth");
            this.structuresExtender.SetAttributeTypeName(this.atDepthCcomboBox, "Integer");
            this.structuresExtender.SetBindPropertyName(this.atDepthCcomboBox, "SelectedIndex");
            this.atDepthCcomboBox.FormattingEnabled = true;
            this.atDepthCcomboBox.Items.AddRange(new object[] {
            "Middle",
            "Front",
            "Behind"});
            this.atDepthCcomboBox.Location = new System.Drawing.Point(157, 67);
            this.atDepthCcomboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atDepthCcomboBox.Name = "atDepthCcomboBox";
            this.atDepthCcomboBox.Size = new System.Drawing.Size(102, 20);
            this.atDepthCcomboBox.TabIndex = 18;
            // 
            // rotationComboBox
            // 
            this.structuresExtender.SetAttributeName(this.rotationComboBox, "Rotation");
            this.structuresExtender.SetAttributeTypeName(this.rotationComboBox, "Integer");
            this.structuresExtender.SetBindPropertyName(this.rotationComboBox, "SelectedIndex");
            this.rotationComboBox.FormattingEnabled = true;
            this.rotationComboBox.Items.AddRange(new object[] {
            "Front",
            "Top",
            "Back",
            "Below"});
            this.rotationComboBox.Location = new System.Drawing.Point(157, 43);
            this.rotationComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rotationComboBox.Name = "rotationComboBox";
            this.rotationComboBox.Size = new System.Drawing.Size(102, 20);
            this.rotationComboBox.TabIndex = 17;
            // 
            // onPlaneComboBox
            // 
            this.structuresExtender.SetAttributeName(this.onPlaneComboBox, "OnPlane");
            this.structuresExtender.SetAttributeTypeName(this.onPlaneComboBox, "Integer");
            this.structuresExtender.SetBindPropertyName(this.onPlaneComboBox, "SelectedIndex");
            this.onPlaneComboBox.FormattingEnabled = true;
            this.onPlaneComboBox.Items.AddRange(new object[] {
            "Middle",
            "Right",
            "Left"});
            this.onPlaneComboBox.Location = new System.Drawing.Point(157, 19);
            this.onPlaneComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.onPlaneComboBox.Name = "onPlaneComboBox";
            this.onPlaneComboBox.Size = new System.Drawing.Size(102, 20);
            this.onPlaneComboBox.TabIndex = 16;
            // 
            // atDepthTextBox
            // 
            this.structuresExtender.SetAttributeName(this.atDepthTextBox, "AtDepthValue");
            this.structuresExtender.SetAttributeTypeName(this.atDepthTextBox, "Distance");
            this.structuresExtender.SetBindPropertyName(this.atDepthTextBox, null);
            this.atDepthTextBox.Location = new System.Drawing.Point(266, 67);
            this.atDepthTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atDepthTextBox.Name = "atDepthTextBox";
            this.atDepthTextBox.Size = new System.Drawing.Size(194, 21);
            this.atDepthTextBox.TabIndex = 15;
            // 
            // rotationTextBox
            // 
            this.structuresExtender.SetAttributeName(this.rotationTextBox, "RotationValue");
            this.structuresExtender.SetAttributeTypeName(this.rotationTextBox, "Double");
            this.structuresExtender.SetBindPropertyName(this.rotationTextBox, null);
            this.rotationTextBox.Location = new System.Drawing.Point(266, 43);
            this.rotationTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rotationTextBox.Name = "rotationTextBox";
            this.rotationTextBox.Size = new System.Drawing.Size(194, 21);
            this.rotationTextBox.TabIndex = 14;
            // 
            // onPlaneTextBox
            // 
            this.structuresExtender.SetAttributeName(this.onPlaneTextBox, "OnPlaneValue");
            this.structuresExtender.SetAttributeTypeName(this.onPlaneTextBox, "Distance");
            this.structuresExtender.SetBindPropertyName(this.onPlaneTextBox, null);
            this.onPlaneTextBox.Location = new System.Drawing.Point(266, 19);
            this.onPlaneTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.onPlaneTextBox.Name = "onPlaneTextBox";
            this.onPlaneTextBox.Size = new System.Drawing.Size(194, 21);
            this.onPlaneTextBox.TabIndex = 13;
            // 
            // BeamCutomPartForm
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(687, 234);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.okApplyModifyGetOnOffCancel1);
            this.Controls.Add(this.saveLoad1);
            this.Name = "BeamCutomPartForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Tekla.Structures.Dialog.UIControls.SaveLoad saveLoad1;
        private Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel okApplyModifyGetOnOffCancel1;
        private Tekla.Structures.Dialog.UIControls.ProfileCatalog profileCatalog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox TBLengthFactor;
        private System.Windows.Forms.TextBox TBProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox atDepthCcomboBox;
        private System.Windows.Forms.ComboBox rotationComboBox;
        private System.Windows.Forms.ComboBox onPlaneComboBox;
        private System.Windows.Forms.TextBox atDepthTextBox;
        private System.Windows.Forms.TextBox rotationTextBox;
        private System.Windows.Forms.TextBox onPlaneTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

