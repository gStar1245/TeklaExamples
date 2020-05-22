namespace BeamCustomPart2
{
    partial class BeamCustomPartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.saveLoad1 = new Tekla.Structures.Dialog.UIControls.SaveLoad();
            this.okApplyModifyGetOnOffCancel1 = new Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.profileCatalog1 = new Tekla.Structures.Dialog.UIControls.ProfileCatalog();
            this.textBoxLengthFactor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lengthFactorLabel = new System.Windows.Forms.Label();
            this.textBoxProfile = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.atDepthCcomboBox = new System.Windows.Forms.ComboBox();
            this.rotationComboBox = new System.Windows.Forms.ComboBox();
            this.onPlaneComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.atDepthTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rotationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.onPlaneTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveLoad1
            // 
            this.saveLoad1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveLoad1.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveLoad1.HelpFileType = Tekla.Structures.Dialog.UIControls.SaveLoad.HelpFileTypeEnum.General;
            this.saveLoad1.HelpKeyword = "";
            this.saveLoad1.HelpUrl = "";
            this.saveLoad1.Location = new System.Drawing.Point(0, 0);
            this.saveLoad1.Margin = new System.Windows.Forms.Padding(4);
            this.saveLoad1.Name = "saveLoad1";
            this.saveLoad1.SaveAsText = "";
            this.saveLoad1.Size = new System.Drawing.Size(800, 40);
            this.saveLoad1.TabIndex = 2;
            this.saveLoad1.UserDefinedHelpFilePath = null;
            // 
            // okApplyModifyGetOnOffCancel1
            // 
            this.okApplyModifyGetOnOffCancel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okApplyModifyGetOnOffCancel1.Location = new System.Drawing.Point(0, 423);
            this.okApplyModifyGetOnOffCancel1.Margin = new System.Windows.Forms.Padding(4);
            this.okApplyModifyGetOnOffCancel1.Name = "okApplyModifyGetOnOffCancel1";
            this.okApplyModifyGetOnOffCancel1.Size = new System.Drawing.Size(800, 27);
            this.okApplyModifyGetOnOffCancel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 40);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 383);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.profileCatalog1);
            this.tabPage1.Controls.Add(this.textBoxLengthFactor);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lengthFactorLabel);
            this.tabPage1.Controls.Add(this.textBoxProfile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(792, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parameters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // profileCatalog1
            // 
            this.profileCatalog1.BackColor = System.Drawing.Color.Transparent;
            this.profileCatalog1.Location = new System.Drawing.Point(373, 21);
            this.profileCatalog1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.profileCatalog1.Name = "profileCatalog1";
            this.profileCatalog1.SelectedProfile = "";
            this.profileCatalog1.Size = new System.Drawing.Size(77, 16);
            this.profileCatalog1.TabIndex = 5;
            // 
            // textBoxLengthFactor
            // 
            this.textBoxLengthFactor.Location = new System.Drawing.Point(220, 51);
            this.textBoxLengthFactor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxLengthFactor.Name = "textBoxLengthFactor";
            this.textBoxLengthFactor.Size = new System.Drawing.Size(116, 21);
            this.textBoxLengthFactor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Profile";
            // 
            // lengthFactorLabel
            // 
            this.lengthFactorLabel.AutoSize = true;
            this.lengthFactorLabel.Location = new System.Drawing.Point(7, 51);
            this.lengthFactorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lengthFactorLabel.Name = "lengthFactorLabel";
            this.lengthFactorLabel.Size = new System.Drawing.Size(78, 12);
            this.lengthFactorLabel.TabIndex = 3;
            this.lengthFactorLabel.Text = "Length factor";
            // 
            // textBoxProfile
            // 
            this.textBoxProfile.Location = new System.Drawing.Point(220, 21);
            this.textBoxProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxProfile.Name = "textBoxProfile";
            this.textBoxProfile.Size = new System.Drawing.Size(116, 21);
            this.textBoxProfile.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.atDepthCcomboBox);
            this.tabPage2.Controls.Add(this.rotationComboBox);
            this.tabPage2.Controls.Add(this.onPlaneComboBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.atDepthTextBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.rotationTextBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.onPlaneTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(792, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Positions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // atDepthCcomboBox
            // 
            this.atDepthCcomboBox.FormattingEnabled = true;
            this.atDepthCcomboBox.Items.AddRange(new object[] {
            "Middle",
            "Front",
            "Behind"});
            this.atDepthCcomboBox.Location = new System.Drawing.Point(195, 65);
            this.atDepthCcomboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atDepthCcomboBox.Name = "atDepthCcomboBox";
            this.atDepthCcomboBox.Size = new System.Drawing.Size(102, 20);
            this.atDepthCcomboBox.TabIndex = 12;
            // 
            // rotationComboBox
            // 
            this.rotationComboBox.FormattingEnabled = true;
            this.rotationComboBox.Items.AddRange(new object[] {
            "Front",
            "Top",
            "Back",
            "Below"});
            this.rotationComboBox.Location = new System.Drawing.Point(195, 41);
            this.rotationComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rotationComboBox.Name = "rotationComboBox";
            this.rotationComboBox.Size = new System.Drawing.Size(102, 20);
            this.rotationComboBox.TabIndex = 11;
            // 
            // onPlaneComboBox
            // 
            this.onPlaneComboBox.FormattingEnabled = true;
            this.onPlaneComboBox.Items.AddRange(new object[] {
            "Middle",
            "Right",
            "Left"});
            this.onPlaneComboBox.Location = new System.Drawing.Point(195, 17);
            this.onPlaneComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.onPlaneComboBox.Name = "onPlaneComboBox";
            this.onPlaneComboBox.Size = new System.Drawing.Size(102, 20);
            this.onPlaneComboBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "At depth";
            // 
            // atDepthTextBox
            // 
            this.atDepthTextBox.Location = new System.Drawing.Point(304, 65);
            this.atDepthTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.atDepthTextBox.Name = "atDepthTextBox";
            this.atDepthTextBox.Size = new System.Drawing.Size(194, 21);
            this.atDepthTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rotation";
            // 
            // rotationTextBox
            // 
            this.rotationTextBox.Location = new System.Drawing.Point(304, 41);
            this.rotationTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rotationTextBox.Name = "rotationTextBox";
            this.rotationTextBox.Size = new System.Drawing.Size(194, 21);
            this.rotationTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "On plane";
            // 
            // onPlaneTextBox
            // 
            this.onPlaneTextBox.Location = new System.Drawing.Point(304, 17);
            this.onPlaneTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.onPlaneTextBox.Name = "onPlaneTextBox";
            this.onPlaneTextBox.Size = new System.Drawing.Size(194, 21);
            this.onPlaneTextBox.TabIndex = 4;
            // 
            // BeamCustomPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.okApplyModifyGetOnOffCancel1);
            this.Controls.Add(this.saveLoad1);
            this.Name = "BeamCustomPartForm";
            this.Text = "BeamCustomPartForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Tekla.Structures.Dialog.UIControls.ProfileCatalog profileCatalog1;
        private System.Windows.Forms.TextBox textBoxLengthFactor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lengthFactorLabel;
        private System.Windows.Forms.TextBox textBoxProfile;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox atDepthCcomboBox;
        private System.Windows.Forms.ComboBox rotationComboBox;
        private System.Windows.Forms.ComboBox onPlaneComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox atDepthTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rotationTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox onPlaneTextBox;
    }
}