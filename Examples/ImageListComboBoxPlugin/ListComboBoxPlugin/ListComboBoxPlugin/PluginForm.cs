using Tekla.Structures.Dialog;

namespace ImageListComboBoxPlugin
{
    public partial class PluginForm : PluginFormBase
    {
        public PluginForm()
        {
            InitializeComponent();

            okApplyModifyGetOnOffCancel1.ApplyClicked += OkApplyModifyGetOnOffCancel1_ApplyClicked;
            okApplyModifyGetOnOffCancel1.CancelClicked += OkApplyModifyGetOnOffCancel1_CancelClicked;
            okApplyModifyGetOnOffCancel1.ModifyClicked += OkApplyModifyGetOnOffCancel1_ModifyClicked;
            okApplyModifyGetOnOffCancel1.GetClicked += OkApplyModifyGetOnOffCancel1_GetClicked;
            okApplyModifyGetOnOffCancel1.OkClicked += OkApplyModifyGetOnOffCancel1_OkClicked;
            okApplyModifyGetOnOffCancel1.OnOffClicked += OkApplyModifyGetOnOffCancel1_OnOffClicked;
        }

        private void OkApplyModifyGetOnOffCancel1_OnOffClicked(object sender, System.EventArgs e)
        {
            this.ToggleSelection();
        }

        private void OkApplyModifyGetOnOffCancel1_OkClicked(object sender, System.EventArgs e)
        {
            this.Apply();
            this.Close();
        }

        private void OkApplyModifyGetOnOffCancel1_GetClicked(object sender, System.EventArgs e)
        {
            this.Get();
        }

        private void OkApplyModifyGetOnOffCancel1_ModifyClicked(object sender, System.EventArgs e)
        {
            this.Modify();
        }

        private void OkApplyModifyGetOnOffCancel1_CancelClicked(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void OkApplyModifyGetOnOffCancel1_ApplyClicked(object sender, System.EventArgs e)
        {
            this.Apply();
        }

        protected override string LoadValuesPath(string FileName)
        {
            SetAttributeValue(ILCBColor, 2);
            SetAttributeValue(TBProfile, "HEA300");

            Apply();

            return base.LoadValuesPath(FileName);
        }


    }
}
