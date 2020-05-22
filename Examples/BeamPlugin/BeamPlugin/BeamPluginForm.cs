using System;

using Tekla.Structures.Dialog;

namespace BeamPlugin
{
    public partial class BeamPluginForm : PluginFormBase
    {
        public BeamPluginForm()
        {
            InitializeComponent();

            okApplyModifyGetOnOffCancel1.OkClicked += OkApplyModifyGetOnOffCancel1_OkClicked;
            okApplyModifyGetOnOffCancel1.ApplyClicked += OkApplyModifyGetOnOffCancel1_ApplyClicked;
            okApplyModifyGetOnOffCancel1.ModifyClicked += OkApplyModifyGetOnOffCancel1_ModifyClicked;
            okApplyModifyGetOnOffCancel1.GetClicked += OkApplyModifyGetOnOffCancel1_GetClicked;
            okApplyModifyGetOnOffCancel1.OnOffClicked += OkApplyModifyGetOnOffCancel1_OnOffClicked;
            okApplyModifyGetOnOffCancel1.CancelClicked += OkApplyModifyGetOnOffCancel1_CancelClicked;
        }

        private void OkApplyModifyGetOnOffCancel1_CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkApplyModifyGetOnOffCancel1_OnOffClicked(object sender, EventArgs e)
        {
            this.ToggleSelection();
        }

        private void OkApplyModifyGetOnOffCancel1_GetClicked(object sender, EventArgs e)
        {
            this.Get();
        }

        private void OkApplyModifyGetOnOffCancel1_ModifyClicked(object sender, EventArgs e)
        {
            this.Modify();
        }

        private void OkApplyModifyGetOnOffCancel1_ApplyClicked(object sender, EventArgs e)
        {
            this.Apply();
        }

        private void OkApplyModifyGetOnOffCancel1_OkClicked(object sender, EventArgs e)
        {
            this.Apply();
            this.Close();
        }

        protected override string LoadValuesPath(string FileName)
        {
            SetAttributeValue(TBLengthFactor, 2d);
            SetAttributeValue(TBProfile, "HEA300");
            Apply();

            return base.LoadValuesPath(FileName);
        }


    }
}
