using Tekla.Structures.Dialog;

namespace BeamCustomPart2
{
    public partial class BeamCustomPartForm : PluginFormBase
    {
        public BeamCustomPartForm()
        {
            InitializeComponent();

            okApplyModifyGetOnOffCancel1.OkClicked += OkApplyModifyGetOnOffCancel1_OkClicked;
            okApplyModifyGetOnOffCancel1.ApplyClicked += OkApplyModifyGetOnOffCancel1_ApplyClicked;
            okApplyModifyGetOnOffCancel1.ModifyClicked += OkApplyModifyGetOnOffCancel1_ModifyClicked;
            okApplyModifyGetOnOffCancel1.GetClicked += OkApplyModifyGetOnOffCancel1_GetClicked;
            okApplyModifyGetOnOffCancel1.OnOffClicked += OkApplyModifyGetOnOffCancel1_OnOffClicked;
            okApplyModifyGetOnOffCancel1.CancelClicked += OkApplyModifyGetOnOffCancel1_CancelClicked;

            profileCatalog1.SelectionDone += ProfileCatalog1_SelectionDone;
        }

        protected override string LoadValuesPath(string FileName)
        {
            SetAttributeValue(textBoxLengthFactor, 2d);
            SetAttributeValue(textBoxProfile, "HEA300");
            Apply();

            return base.LoadValuesPath(FileName);
        }

        private void OkApplyModifyGetOnOffCancel1_CancelClicked(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void OkApplyModifyGetOnOffCancel1_OnOffClicked(object sender, System.EventArgs e)
        {
            this.ToggleSelection();
        }

        private void OkApplyModifyGetOnOffCancel1_GetClicked(object sender, System.EventArgs e)
        {
            this.Get();
        }

        private void OkApplyModifyGetOnOffCancel1_ModifyClicked(object sender, System.EventArgs e)
        {
            this.Modify();
        }

        private void OkApplyModifyGetOnOffCancel1_ApplyClicked(object sender, System.EventArgs e)
        {
            this.Apply();
        }

        private void OkApplyModifyGetOnOffCancel1_OkClicked(object sender, System.EventArgs e)
        {
            this.Apply();
            this.Close();
        }

        private void ProfileCatalog1_SelectionDone(object sender, System.EventArgs e)
        {
            textBoxProfile.Text = profileCatalog1.SelectedProfile;
        }
    }
}
