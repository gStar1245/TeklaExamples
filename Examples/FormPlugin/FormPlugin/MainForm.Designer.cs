namespace FormPlugin
{
    partial class MainForm
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
            this.modifyButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // modifyButton
            // 
            this.structuresExtender.SetAttributeName(this.modifyButton, null);
            this.structuresExtender.SetAttributeTypeName(this.modifyButton, null);
            this.structuresExtender.SetBindPropertyName(this.modifyButton, null);
            this.modifyButton.Location = new System.Drawing.Point(105, 39);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(87, 21);
            this.modifyButton.TabIndex = 7;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // okButton
            // 
            this.structuresExtender.SetAttributeName(this.okButton, null);
            this.structuresExtender.SetAttributeTypeName(this.okButton, null);
            this.structuresExtender.SetBindPropertyName(this.okButton, null);
            this.okButton.Location = new System.Drawing.Point(12, 39);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(87, 21);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // heightLabel
            // 
            this.structuresExtender.SetAttributeName(this.heightLabel, null);
            this.structuresExtender.SetAttributeTypeName(this.heightLabel, null);
            this.heightLabel.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.heightLabel, null);
            this.heightLabel.Location = new System.Drawing.Point(14, 15);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(40, 12);
            this.heightLabel.TabIndex = 5;
            this.heightLabel.Text = "Height";
            // 
            // heightTextBox
            // 
            this.structuresExtender.SetAttributeName(this.heightTextBox, null);
            this.structuresExtender.SetAttributeTypeName(this.heightTextBox, null);
            this.structuresExtender.SetBindPropertyName(this.heightTextBox, null);
            this.heightTextBox.Location = new System.Drawing.Point(65, 12);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(116, 21);
            this.heightTextBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(212, 73);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.heightTextBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox heightTextBox;
    }
}