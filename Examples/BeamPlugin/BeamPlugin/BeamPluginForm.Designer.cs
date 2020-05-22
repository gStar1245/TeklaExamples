namespace BeamPlugin
{
    partial class BeamPluginForm
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
            this.saveLoad1 = new Tekla.Structures.Dialog.UIControls.SaveLoad();
            this.okApplyModifyGetOnOffCancel1 = new Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel();
            this.label1 = new System.Windows.Forms.Label();
            this.TBProfile = new System.Windows.Forms.TextBox();
            this.LengthFactor = new System.Windows.Forms.Label();
            this.TBLengthFactor = new System.Windows.Forms.TextBox();
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
            this.saveLoad1.Size = new System.Drawing.Size(610, 40);
            this.saveLoad1.TabIndex = 2;
            this.saveLoad1.UserDefinedHelpFilePath = null;
            // 
            // okApplyModifyGetOnOffCancel1
            // 
            this.structuresExtender.SetAttributeName(this.okApplyModifyGetOnOffCancel1, null);
            this.structuresExtender.SetAttributeTypeName(this.okApplyModifyGetOnOffCancel1, null);
            this.structuresExtender.SetBindPropertyName(this.okApplyModifyGetOnOffCancel1, null);
            this.okApplyModifyGetOnOffCancel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okApplyModifyGetOnOffCancel1.Location = new System.Drawing.Point(0, 197);
            this.okApplyModifyGetOnOffCancel1.Name = "okApplyModifyGetOnOffCancel1";
            this.okApplyModifyGetOnOffCancel1.Size = new System.Drawing.Size(610, 27);
            this.okApplyModifyGetOnOffCancel1.TabIndex = 3;
            // 
            // label1
            // 
            this.structuresExtender.SetAttributeName(this.label1, null);
            this.structuresExtender.SetAttributeTypeName(this.label1, null);
            this.label1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label1, null);
            this.label1.Location = new System.Drawing.Point(86, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Profile";
            // 
            // TBProfile
            // 
            this.structuresExtender.SetAttributeName(this.TBProfile, "Profile");
            this.structuresExtender.SetAttributeTypeName(this.TBProfile, "String");
            this.structuresExtender.SetBindPropertyName(this.TBProfile, null);
            this.TBProfile.Location = new System.Drawing.Point(299, 89);
            this.TBProfile.Name = "TBProfile";
            this.TBProfile.Size = new System.Drawing.Size(116, 21);
            this.TBProfile.TabIndex = 4;
            // 
            // LengthFactor
            // 
            this.structuresExtender.SetAttributeName(this.LengthFactor, null);
            this.structuresExtender.SetAttributeTypeName(this.LengthFactor, null);
            this.LengthFactor.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.LengthFactor, null);
            this.LengthFactor.Location = new System.Drawing.Point(86, 136);
            this.LengthFactor.Name = "LengthFactor";
            this.LengthFactor.Size = new System.Drawing.Size(78, 12);
            this.LengthFactor.TabIndex = 7;
            this.LengthFactor.Text = "Length factor";
            // 
            // TBLengthFactor
            // 
            this.structuresExtender.SetAttributeName(this.TBLengthFactor, "LengthFactor");
            this.structuresExtender.SetAttributeTypeName(this.TBLengthFactor, "Double");
            this.structuresExtender.SetBindPropertyName(this.TBLengthFactor, null);
            this.TBLengthFactor.Location = new System.Drawing.Point(299, 133);
            this.TBLengthFactor.Name = "TBLengthFactor";
            this.TBLengthFactor.Size = new System.Drawing.Size(116, 21);
            this.TBLengthFactor.TabIndex = 5;
            // 
            // BeamPluginForm
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(610, 224);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBProfile);
            this.Controls.Add(this.LengthFactor);
            this.Controls.Add(this.TBLengthFactor);
            this.Controls.Add(this.okApplyModifyGetOnOffCancel1);
            this.Controls.Add(this.saveLoad1);
            this.Name = "BeamPluginForm";
            this.Text = "BeamPluginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tekla.Structures.Dialog.UIControls.SaveLoad saveLoad1;
        private Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel okApplyModifyGetOnOffCancel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBProfile;
        private System.Windows.Forms.Label LengthFactor;
        private System.Windows.Forms.TextBox TBLengthFactor;
    }
}