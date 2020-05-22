namespace ImageListComboBoxExample
{
    using Tekla.Structures.Dialog;

    public partial class PluginForm : PluginFormBase
    {
        public PluginForm()
        {
            InitializeComponent();
        }

        protected override string LoadValuesPath(string FileName)
        {
            SetAttributeValue(ColorComboBox, 2);
            SetAttributeValue(textBoxProfile, "HEA300");
            string Result = base.LoadValuesPath(FileName);
            Apply();
            return Result;
        }

        private void okApplyModifyGetOnOffCancel1_ApplyClicked(object sender, System.EventArgs e)
        {
            Apply();
        }

        private void okApplyModifyGetOnOffCancel1_CancelClicked(object sender, System.EventArgs e)
        {
            Close();
        }

        private void okApplyModifyGetOnOffCancel1_GetClicked(object sender, System.EventArgs e)
        {
            Get();
        }

        private void okApplyModifyGetOnOffCancel1_ModifyClicked(object sender, System.EventArgs e)
        {
            Modify();
        }

        private void okApplyModifyGetOnOffCancel1_OkClicked(object sender, System.EventArgs e)
        {
            Apply();
            Close();
        }

        private void okApplyModifyGetOnOffCancel1_OnOffClicked(object sender, System.EventArgs e)
        {
            ToggleSelection();
        }
    }
}
