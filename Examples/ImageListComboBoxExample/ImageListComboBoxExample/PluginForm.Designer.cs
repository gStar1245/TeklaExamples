namespace ImageListComboBoxExample
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
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.okApplyModifyGetOnOffCancel1 = new Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel();
            this.saveLoad1 = new Tekla.Structures.Dialog.UIControls.SaveLoad();
            this.ColorComboBox = new Tekla.Structures.Dialog.UIControls.ImageListComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProfile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBox2
            // 
            this.structuresExtender.SetAttributeName(this.checkBox2, null);
            this.structuresExtender.SetAttributeTypeName(this.checkBox2, null);
            this.checkBox2.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.checkBox2, null);
            this.checkBox2.Location = new System.Drawing.Point(157, 114);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.structuresExtender.SetAttributeName(this.checkBox1, null);
            this.structuresExtender.SetAttributeTypeName(this.checkBox1, null);
            this.checkBox1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.checkBox1, null);
            this.checkBox1.Location = new System.Drawing.Point(157, 59);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // okApplyModifyGetOnOffCancel1
            // 
            this.structuresExtender.SetAttributeName(this.okApplyModifyGetOnOffCancel1, null);
            this.structuresExtender.SetAttributeTypeName(this.okApplyModifyGetOnOffCancel1, null);
            this.structuresExtender.SetBindPropertyName(this.okApplyModifyGetOnOffCancel1, null);
            this.okApplyModifyGetOnOffCancel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okApplyModifyGetOnOffCancel1.Location = new System.Drawing.Point(0, 148);
            this.okApplyModifyGetOnOffCancel1.Name = "okApplyModifyGetOnOffCancel1";
            this.okApplyModifyGetOnOffCancel1.Size = new System.Drawing.Size(612, 27);
            this.okApplyModifyGetOnOffCancel1.TabIndex = 14;
            this.okApplyModifyGetOnOffCancel1.OkClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_OkClicked);
            this.okApplyModifyGetOnOffCancel1.ApplyClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_ApplyClicked);
            this.okApplyModifyGetOnOffCancel1.ModifyClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_ModifyClicked);
            this.okApplyModifyGetOnOffCancel1.GetClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_GetClicked);
            this.okApplyModifyGetOnOffCancel1.OnOffClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_OnOffClicked);
            this.okApplyModifyGetOnOffCancel1.CancelClicked += new System.EventHandler(this.okApplyModifyGetOnOffCancel1_CancelClicked);
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
            this.saveLoad1.Size = new System.Drawing.Size(612, 40);
            this.saveLoad1.TabIndex = 13;
            this.saveLoad1.UserDefinedHelpFilePath = null;
            // 
            // ColorComboBox
            // 
            this.structuresExtender.SetAttributeName(this.ColorComboBox, null);
            this.structuresExtender.SetAttributeTypeName(this.ColorComboBox, null);
            this.ColorComboBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ColorComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ColorComboBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.structuresExtender.SetBindPropertyName(this.ColorComboBox, null);
            this.ColorComboBox.DefaultValue = "";
            this.ColorComboBox.HoverColor = System.Drawing.Color.DodgerBlue;
            this.ColorComboBox.ImageList = this.imageList1;
            this.ColorComboBox.Location = new System.Drawing.Point(194, 108);
            this.ColorComboBox.MaximumSize = new System.Drawing.Size(5833, 4615);
            this.ColorComboBox.MinimumSize = new System.Drawing.Size(36, 22);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.SelectedIndex = 0;
            this.ColorComboBox.SelectedItem = ((object)(resources.GetObject("ColorComboBox.SelectedItem")));
            this.ColorComboBox.Size = new System.Drawing.Size(36, 22);
            this.ColorComboBox.TabIndex = 12;
            this.ColorComboBox.ToolTipText = "";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Red.png");
            this.imageList1.Images.SetKeyName(1, "Gray.png");
            this.imageList1.Images.SetKeyName(2, "Magenta.png");
            this.imageList1.Images.SetKeyName(3, "Green.png");
            this.imageList1.Images.SetKeyName(4, "Blue.png");
            this.imageList1.Images.SetKeyName(5, "Cyan.png");
            this.imageList1.Images.SetKeyName(6, "Yellow.png");
            this.imageList1.Images.SetKeyName(7, "AquaMarine.png");
            this.imageList1.Images.SetKeyName(8, "Blue.png");
            this.imageList1.Images.SetKeyName(9, "Cyan.png");
            this.imageList1.Images.SetKeyName(10, "DarkBlue.png");
            this.imageList1.Images.SetKeyName(11, "DarkGray.png");
            this.imageList1.Images.SetKeyName(12, "DarkGreen.png");
            this.imageList1.Images.SetKeyName(13, "DarkRed.png");
            this.imageList1.Images.SetKeyName(14, "DarkYellow.png");
            this.imageList1.Images.SetKeyName(15, "Gray.png");
            this.imageList1.Images.SetKeyName(16, "Green.png");
            this.imageList1.Images.SetKeyName(17, "Magenta.png");
            this.imageList1.Images.SetKeyName(18, "Orange.png");
            this.imageList1.Images.SetKeyName(19, "Purple.png");
            this.imageList1.Images.SetKeyName(20, "Red.png");
            this.imageList1.Images.SetKeyName(21, "Yellow.png");
            // 
            // label2
            // 
            this.structuresExtender.SetAttributeName(this.label2, null);
            this.structuresExtender.SetAttributeTypeName(this.label2, null);
            this.label2.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label2, null);
            this.label2.Location = new System.Drawing.Point(76, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Color";
            // 
            // label1
            // 
            this.structuresExtender.SetAttributeName(this.label1, null);
            this.structuresExtender.SetAttributeTypeName(this.label1, null);
            this.label1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label1, null);
            this.label1.Location = new System.Drawing.Point(76, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Profile";
            // 
            // textBoxProfile
            // 
            this.structuresExtender.SetAttributeName(this.textBoxProfile, null);
            this.structuresExtender.SetAttributeTypeName(this.textBoxProfile, null);
            this.structuresExtender.SetBindPropertyName(this.textBoxProfile, null);
            this.textBoxProfile.Location = new System.Drawing.Point(194, 57);
            this.textBoxProfile.Name = "textBoxProfile";
            this.textBoxProfile.Size = new System.Drawing.Size(116, 21);
            this.textBoxProfile.TabIndex = 9;
            // 
            // PluginForm
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(612, 175);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.okApplyModifyGetOnOffCancel1);
            this.Controls.Add(this.saveLoad1);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProfile);
            this.Name = "PluginForm";
            this.Text = "ImageListComboBoxPlugin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel okApplyModifyGetOnOffCancel1;
        private Tekla.Structures.Dialog.UIControls.SaveLoad saveLoad1;
        private Tekla.Structures.Dialog.UIControls.ImageListComboBox ColorComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProfile;
        private System.Windows.Forms.ImageList imageList1;
    }
}