using System;

using Tekla.Structures.Dialog;


namespace FormPlugin
{
    public partial class MainForm : PluginFormBase
    {
        public StructureData data;

        public MainForm()
        {
            InitializeComponent();

            okButton.Click += OkButton_Click;
            modifyButton.Click += ModifyButton_Click;
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            GetTextBoxValue();
            this.Modify();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            GetTextBoxValue();
            this.Apply();
            this.Close();
        }

        private void GetTextBoxValue()
        {
            data.height = Convert.ToDouble(heightTextBox.Text);

        }
    }
}
