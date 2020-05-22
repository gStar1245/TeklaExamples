using System;
using System.Windows.Forms;

using TSPlugnins = Tekla.Structures.Plugins;
using Tekla.Structures.Plugins;
using Tekla.Structures.Dialog;
using Tekla.Structures.Datatype;

namespace FlangeBrace
{
    public partial class FlangeBraceForm : PluginFormBase
    {
        public FlangeBraceForm()
        {
            InitializeComponent();

            #region Event
            okApplyModifyGetOnOffCancel1.OkClicked += OkApplyModifyGetOnOffCancel1_OkClicked;
            okApplyModifyGetOnOffCancel1.ApplyClicked += OkApplyModifyGetOnOffCancel1_ApplyClicked;
            okApplyModifyGetOnOffCancel1.ModifyClicked += OkApplyModifyGetOnOffCancel1_ModifyClicked;
            okApplyModifyGetOnOffCancel1.GetClicked += OkApplyModifyGetOnOffCancel1_GetClicked;
            okApplyModifyGetOnOffCancel1.OnOffClicked += OkApplyModifyGetOnOffCancel1_OnOffClicked;
            okApplyModifyGetOnOffCancel1.CancelClicked += OkApplyModifyGetOnOffCancel1_CancelClicked;

            #endregion
        }

        private void ProfileCatalog1_SelectClicked(object sender, EventArgs e)
        {
            profileCatalog1.SelectedProfile = textBox1.Text;
        }

        private void ProfileCatalog1_SelectionDone(object sender, EventArgs e)
        {
            SetAttributeValue(textBox1, profileCatalog1.SelectedProfile);
        }

        private void materialCatalog1_SelectClicked(object sender, EventArgs e)
        {
            materialCatalog1.SelectedMaterial = textBox4.Text;
        }

        private void MaterialCatalog1_SelectionDone(object sender, EventArgs e)
        {
            SetAttributeValue(textBox4, materialCatalog1.SelectedMaterial);
        }

        private void MaterialCatalog2_SelectClicked(object sender, EventArgs e)
        {
            materialCatalog2.SelectedMaterial = textBox7.Text;
        }

        private void MaterialCatalog2_SelectionDone(object sender, EventArgs e)
        {
            SetAttributeValue(textBox7, materialCatalog2.SelectedMaterial);
        }

        private void MaterialCatalog3_SelectClicked(object sender, EventArgs e)
        {
            materialCatalog3.SelectedMaterial = textBox15.Text;
        }

        private void MaterialCatalog3_SelectionDone(object sender, EventArgs e)
        {
            SetAttributeValue(textBox15, materialCatalog3.SelectedMaterial);
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
    }
}
