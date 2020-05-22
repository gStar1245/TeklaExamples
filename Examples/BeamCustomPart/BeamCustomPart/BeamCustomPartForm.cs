using System;

using Tekla.Structures.Dialog;

namespace BeamCustomPart
{
    public partial class BeamCustomPartForm : PluginFormBase
    {
        public BeamCustomPartForm()
        {
            InitializeComponent();

            #region Event : OkApplyModifyGetOnOffCancel
            okApplyModifyGetOnOffCancel1.OkClicked += OkApplyModifyGetOnOffCancel1_OkClicked;
            okApplyModifyGetOnOffCancel1.ApplyClicked += OkApplyModifyGetOnOffCancel1_ApplyClicked;
            okApplyModifyGetOnOffCancel1.ModifyClicked += OkApplyModifyGetOnOffCancel1_ModifyClicked;
            okApplyModifyGetOnOffCancel1.GetClicked += OkApplyModifyGetOnOffCancel1_GetClicked;
            okApplyModifyGetOnOffCancel1.OnOffClicked += OkApplyModifyGetOnOffCancel1_OnOffClicked;
            okApplyModifyGetOnOffCancel1.CancelClicked += OkApplyModifyGetOnOffCancel1_CancelClicked;
            #endregion

            #region Event : Catalog
            profileCatalog.SelectionDone += ProfileCatalog_SelectionDone;

            #endregion
        }

        protected override string LoadValuesPath(string FileName)
        {
            this.SetAttributeValue(this.TBLengthFactor, 2d);
            this.SetAttributeValue(this.TBProfile, "HEA300");

            this.Apply();

            return base.LoadValuesPath(FileName);
        }

        #region Event : OkApplyModifyGetOnOffCancel
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

        #endregion

        #region Event : Catalog
        private void ProfileCatalog_SelectionDone(object sender, EventArgs e)
        {
            TBProfile.Text = profileCatalog.SelectedProfile;
        }
        #endregion
    }
}
