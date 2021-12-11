using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public static class VisibilityManager
    {
        public static void ChangeControlsVisibility(bool i_IsLogoutState, Control[] i_PermissionControls)
        {
            foreach (Control control in i_PermissionControls)
            {
                control.Visible = i_IsLogoutState;
            }
        }

        public static void ChangeTabVisibility(Control[] i_Controls, Label i_LabelNoItems, bool i_IsFetchSucceeded)
        {
            i_LabelNoItems.Visible = !i_IsFetchSucceeded;
            foreach (Control control in i_Controls)
            {
                control.Visible = i_IsFetchSucceeded;
            }
        }

        public static void ChangeTabVisibility(Panel i_Panel, Label i_LabelNoItems, bool i_IsFetchSucceeded)
        {
            i_LabelNoItems.Visible = !i_IsFetchSucceeded;
            i_Panel.Visible = i_IsFetchSucceeded;
        }

        public static void ChangeListBoxVisibilityAccordingToEmptiness(ListBox i_ListBox)
        {
            if (i_ListBox.Items.Count == 0)
            {
                i_ListBox.Enabled = false;
                i_ListBox.BackColor = Color.DarkGray;
            }
            else
            {
                i_ListBox.Enabled = true;
                i_ListBox.ResetBackColor();
            }
        }
    }
}