using System;

namespace InsertMarkPlugin
{
    public partial class InsertMarkPluginForm : Tekla.Structures.Dialog.PluginFormBase
    {
        public InsertMarkPluginForm()
        {
            InitializeComponent();

            OkApplyModifyGetOnOffCancel.OkClicked += OkApplyModifyGetOnOffCancel_OkClicked;
            OkApplyModifyGetOnOffCancel.ApplyClicked += OkApplyModifyGetOnOffCancel_ApplyClicked;
            OkApplyModifyGetOnOffCancel.ModifyClicked += OkApplyModifyGetOnOffCancel_ModifyClicked;
            OkApplyModifyGetOnOffCancel.GetClicked += OkApplyModifyGetOnOffCancel_GetClicked;
            OkApplyModifyGetOnOffCancel.OnOffClicked += OkApplyModifyGetOnOffCancel_OnOffClicked;
            OkApplyModifyGetOnOffCancel.CancelClicked += OkApplyModifyGetOnOffCancel_CancelClicked;
        }

        private void OkApplyModifyGetOnOffCancel_CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkApplyModifyGetOnOffCancel_OnOffClicked(object sender, EventArgs e)
        {
            this.ToggleSelection();
        }

        private void OkApplyModifyGetOnOffCancel_GetClicked(object sender, EventArgs e)
        {
            this.Get();
        }

        private void OkApplyModifyGetOnOffCancel_ModifyClicked(object sender, EventArgs e)
        {
            this.Modify();
        }

        private void OkApplyModifyGetOnOffCancel_ApplyClicked(object sender, EventArgs e)
        {
            this.Apply();
        }

        private void OkApplyModifyGetOnOffCancel_OkClicked(object sender, EventArgs e)
        {
            this.Apply();
            this.Close();
        }
    }
}
