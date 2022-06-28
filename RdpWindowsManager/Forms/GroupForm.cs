using System;
using System.Windows.Forms;

using RdpWindowsManager.Controls;

namespace RdpWindowsManager.Forms
{
   public partial class GroupForm : Form
   {
      public GroupForm()
      {
         InitializeComponent();
      }

      public RdpTreeNode Node { get; private set; }

      public void SetGroup(RdpTreeNode node)
      {
         if (node != null)
         {
            txtName.Text = node.Text;
            txtDescription.DefaultText = node.ToolTipText;
            lbColor.ForeColor = node.ForeColor;

            btSave.Text = "Update";
         }
      }

      private void BtColor_Click(object sender, EventArgs e)
      {
         lbColor.ForeColor = Helpers.SelectColor();
      }

      private void BtSave_Click(object sender, EventArgs e)
      {
         if (!string.IsNullOrEmpty(txtName.Text))
         {
            Node = new RdpTreeNode()
            {
               Text = txtName.Text,
               ToolTipText = txtDescription.DefaultText,
               ForeColor = lbColor.ForeColor
            };

            DialogResult = DialogResult.OK;
         }
      }
   }
}
