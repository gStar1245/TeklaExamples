namespace InsertMarkPlugin
{
    partial class InsertMarkPluginForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SaveLoadSaveAs = new Tekla.Structures.Dialog.UIControls.SaveLoad();
            this.OkApplyModifyGetOnOffCancel = new Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.structuresExtender.SetAttributeName(this.tableLayoutPanel1, null);
            this.structuresExtender.SetAttributeTypeName(this.tableLayoutPanel1, null);
            this.structuresExtender.SetBindPropertyName(this.tableLayoutPanel1, null);
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.49807F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.50193F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 26);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.structuresExtender.SetAttributeName(this.textBox1, null);
            this.structuresExtender.SetAttributeTypeName(this.textBox1, null);
            this.structuresExtender.SetBindPropertyName(this.textBox1, null);
            this.textBox1.Location = new System.Drawing.Point(120, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(481, 21);
            this.textBox1.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.structuresExtender.SetAttributeName(this.checkBox1, null);
            this.structuresExtender.SetAttributeTypeName(this.checkBox1, null);
            this.checkBox1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.checkBox1, null);
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 16);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Text";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SaveLoadSaveAs
            // 
            this.structuresExtender.SetAttributeName(this.SaveLoadSaveAs, null);
            this.structuresExtender.SetAttributeTypeName(this.SaveLoadSaveAs, null);
            this.SaveLoadSaveAs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.structuresExtender.SetBindPropertyName(this.SaveLoadSaveAs, null);
            this.SaveLoadSaveAs.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveLoadSaveAs.HelpFileType = Tekla.Structures.Dialog.UIControls.SaveLoad.HelpFileTypeEnum.General;
            this.SaveLoadSaveAs.HelpKeyword = "";
            this.SaveLoadSaveAs.HelpUrl = "";
            this.SaveLoadSaveAs.Location = new System.Drawing.Point(0, 0);
            this.SaveLoadSaveAs.Name = "SaveLoadSaveAs";
            this.SaveLoadSaveAs.SaveAsText = "";
            this.SaveLoadSaveAs.Size = new System.Drawing.Size(623, 40);
            this.SaveLoadSaveAs.TabIndex = 19;
            this.SaveLoadSaveAs.UserDefinedHelpFilePath = null;
            // 
            // OkApplyModifyGetOnOffCancel
            // 
            this.structuresExtender.SetAttributeName(this.OkApplyModifyGetOnOffCancel, null);
            this.structuresExtender.SetAttributeTypeName(this.OkApplyModifyGetOnOffCancel, null);
            this.structuresExtender.SetBindPropertyName(this.OkApplyModifyGetOnOffCancel, null);
            this.OkApplyModifyGetOnOffCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OkApplyModifyGetOnOffCancel.Location = new System.Drawing.Point(0, 73);
            this.OkApplyModifyGetOnOffCancel.Name = "OkApplyModifyGetOnOffCancel";
            this.OkApplyModifyGetOnOffCancel.Size = new System.Drawing.Size(623, 27);
            this.OkApplyModifyGetOnOffCancel.TabIndex = 18;
            // 
            // InsertMarkPluginForm
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(623, 100);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.SaveLoadSaveAs);
            this.Controls.Add(this.OkApplyModifyGetOnOffCancel);
            this.Name = "InsertMarkPluginForm";
            this.Text = "InsertMarkPluginForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private Tekla.Structures.Dialog.UIControls.SaveLoad SaveLoadSaveAs;
        private Tekla.Structures.Dialog.UIControls.OkApplyModifyGetOnOffCancel OkApplyModifyGetOnOffCancel;
    }
}