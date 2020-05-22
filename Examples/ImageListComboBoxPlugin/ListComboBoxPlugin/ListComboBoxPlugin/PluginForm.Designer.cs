namespace ImageListComboBoxPlugin
{
    partial class PluginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginForm));
            this.saveLoad1 = new Tekla.Structures.Dialog.UIControls.SaveLoad();
            this.okApplyModifyGetOnOffCancel1 = new Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.TBProfile = new System.Windows.Forms.TextBox();
            this.ILCBColor = new Tekla.Structures.Dialog.UIControls.ImageListComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.saveLoad1.Size = new System.Drawing.Size(667, 40);
            this.saveLoad1.TabIndex = 0;
            this.saveLoad1.UserDefinedHelpFilePath = null;
            // 
            // okApplyModifyGetOnOffCancel1
            // 
            this.structuresExtender.SetAttributeName(this.okApplyModifyGetOnOffCancel1, null);
            this.structuresExtender.SetAttributeTypeName(this.okApplyModifyGetOnOffCancel1, null);
            this.structuresExtender.SetBindPropertyName(this.okApplyModifyGetOnOffCancel1, null);
            this.okApplyModifyGetOnOffCancel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okApplyModifyGetOnOffCancel1.Location = new System.Drawing.Point(0, 217);
            this.okApplyModifyGetOnOffCancel1.Name = "okApplyModifyGetOnOffCancel1";
            this.okApplyModifyGetOnOffCancel1.Size = new System.Drawing.Size(667, 27);
            this.okApplyModifyGetOnOffCancel1.TabIndex = 1;
            // 
            // label1
            // 
            this.structuresExtender.SetAttributeName(this.label1, null);
            this.structuresExtender.SetAttributeTypeName(this.label1, null);
            this.label1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label1, null);
            this.label1.Location = new System.Drawing.Point(92, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Profile";
            // 
            // label2
            // 
            this.structuresExtender.SetAttributeName(this.label2, null);
            this.structuresExtender.SetAttributeTypeName(this.label2, null);
            this.label2.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label2, null);
            this.label2.Location = new System.Drawing.Point(92, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Color";
            // 
            // checkBox1
            // 
            this.structuresExtender.SetAttributeName(this.checkBox1, null);
            this.structuresExtender.SetAttributeTypeName(this.checkBox1, null);
            this.checkBox1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.checkBox1, null);
            this.checkBox1.Location = new System.Drawing.Point(138, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.structuresExtender.SetAttributeName(this.checkBox2, null);
            this.structuresExtender.SetAttributeTypeName(this.checkBox2, null);
            this.checkBox2.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.checkBox2, null);
            this.checkBox2.Location = new System.Drawing.Point(138, 115);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // TBProfile
            // 
            this.structuresExtender.SetAttributeName(this.TBProfile, null);
            this.structuresExtender.SetAttributeTypeName(this.TBProfile, null);
            this.structuresExtender.SetBindPropertyName(this.TBProfile, null);
            this.TBProfile.Location = new System.Drawing.Point(183, 68);
            this.TBProfile.Name = "TBProfile";
            this.TBProfile.Size = new System.Drawing.Size(100, 21);
            this.TBProfile.TabIndex = 6;
            // 
            // ILCBColor
            // 
            this.structuresExtender.SetAttributeName(this.ILCBColor, null);
            this.structuresExtender.SetAttributeTypeName(this.ILCBColor, null);
            this.ILCBColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ILCBColor.BackColor = System.Drawing.Color.Transparent;
            this.ILCBColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.structuresExtender.SetBindPropertyName(this.ILCBColor, null);
            this.ILCBColor.DefaultValue = "";
            this.ILCBColor.HoverColor = System.Drawing.Color.DodgerBlue;
            this.ILCBColor.ImageList = this.imageList1;
            this.ILCBColor.Location = new System.Drawing.Point(183, 107);
            this.ILCBColor.MaximumSize = new System.Drawing.Size(5000, 5000);
            this.ILCBColor.MinimumSize = new System.Drawing.Size(36, 22);
            this.ILCBColor.Name = "ILCBColor";
            this.ILCBColor.SelectedIndex = 0;
            this.ILCBColor.SelectedItem = ((object)(resources.GetObject("ILCBColor.SelectedItem")));
            this.ILCBColor.Size = new System.Drawing.Size(36, 22);
            this.ILCBColor.TabIndex = 7;
            this.ILCBColor.ToolTipText = "";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "AquaMarine.png");
            this.imageList1.Images.SetKeyName(1, "Blue.png");
            this.imageList1.Images.SetKeyName(2, "Cyan.png");
            this.imageList1.Images.SetKeyName(3, "DarkBlue.png");
            this.imageList1.Images.SetKeyName(4, "DarkGray.png");
            this.imageList1.Images.SetKeyName(5, "DarkGreen.png");
            this.imageList1.Images.SetKeyName(6, "DarkRed.png");
            this.imageList1.Images.SetKeyName(7, "DarkYellow.png");
            this.imageList1.Images.SetKeyName(8, "Gray.png");
            this.imageList1.Images.SetKeyName(9, "Green.png");
            this.imageList1.Images.SetKeyName(10, "Magenta.png");
            this.imageList1.Images.SetKeyName(11, "Orange.png");
            this.imageList1.Images.SetKeyName(12, "Purple.png");
            this.imageList1.Images.SetKeyName(13, "Red.png");
            this.imageList1.Images.SetKeyName(14, "Yellow.png");
            // 
            // PluginForm
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(667, 244);
            this.Controls.Add(this.ILCBColor);
            this.Controls.Add(this.TBProfile);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okApplyModifyGetOnOffCancel1);
            this.Controls.Add(this.saveLoad1);
            this.Name = "PluginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tekla.Structures.Dialog.UIControls.SaveLoad saveLoad1;
        private Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel okApplyModifyGetOnOffCancel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox TBProfile;
        private Tekla.Structures.Dialog.UIControls.ImageListComboBox ILCBColor;
        private System.Windows.Forms.ImageList imageList1;
    }
}