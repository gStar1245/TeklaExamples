using System.Windows.Forms;

using Tekla.Structures.Dialog;

namespace EllipsePlugin
{
    public partial class EllipsePluginForm : PluginFormBase
    {
        public EllipsePluginForm()
        {
            InitializeComponent();

            okApplyModifyGetOnOffCancel1.OkClicked += OkApplyModifyGetOnOffCancel1_OkClicked;
            okApplyModifyGetOnOffCancel1.ApplyClicked += OkApplyModifyGetOnOffCancel1_ApplyClicked;
            okApplyModifyGetOnOffCancel1.ModifyClicked += OkApplyModifyGetOnOffCancel1_ModifyClicked;
            okApplyModifyGetOnOffCancel1.GetClicked += OkApplyModifyGetOnOffCancel1_GetClicked;
            okApplyModifyGetOnOffCancel1.OnOffClicked += OkApplyModifyGetOnOffCancel1_OnOffClicked;
            okApplyModifyGetOnOffCancel1.CancelClicked += OkApplyModifyGetOnOffCancel1_CancelClicked;
        }

        private void OkApplyModifyGetOnOffCancel1_CancelClicked(object sender, System.EventArgs e)
        {
            Close();
        }

        private void OkApplyModifyGetOnOffCancel1_OnOffClicked(object sender, System.EventArgs e)
        {
            ToggleSelection();
        }

        private void OkApplyModifyGetOnOffCancel1_GetClicked(object sender, System.EventArgs e)
        {
            Get();
        }

        private void OkApplyModifyGetOnOffCancel1_ModifyClicked(object sender, System.EventArgs e)
        {
            Modify();
        }

        private void OkApplyModifyGetOnOffCancel1_ApplyClicked(object sender, System.EventArgs e)
        {
            Apply();
        }

        private void OkApplyModifyGetOnOffCancel1_OkClicked(object sender, System.EventArgs e)
        {
            Apply();
            Close();
        }
    }
}
