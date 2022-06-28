using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

using RdpWindowsManager.Controls;

namespace RdpWindowsManager.Forms
{
   public partial class ServerForm : Form
   {
      public ServerForm()
      {
         InitializeComponent();
      }

      public string Group { get; private set; }

      public RdpTreeNode Node { get; private set; }

      public void SetServer(RdpTreeNode node)
      {
         if (node != null)
         {
            txtName.DefaultText = node.Text;
            txtHost.DefaultText = node.Host;
            txtPort.DefaultText = node.Port.ToString();
            txtUsername.DefaultText = node.Username;
            txtPassword.DefaultText = node.Password;
            txtDescription.DefaultText = node.ToolTipText;
            lbColor.ForeColor = node.ForeColor;

            txtGroup.SelectedIndex = txtGroup.Items.IndexOf(node.Parent.Text);
         }
      }

      public void SetGroup(IEnumerable<string> groups)
      {
         txtGroup.Items.AddRange(groups.ToArray());
      }

      private void BtColor_Click(object sender, EventArgs e)
      {
         lbColor.ForeColor = Helpers.SelectColor();
      }

      private void BtPassword_CheckedChanged(object sender, EventArgs e)
      {
         txtPassword.PasswordChar = btPassword.Checked;
      }

      private void TxtPort_KeyPress(object sender, KeyPressEventArgs e)
      {
         char number = e.KeyChar;

         if (!char.IsDigit(number) && number != 8)
         {
            e.Handled = true;
         }
      }

      private void BtSave_Click(object sender, EventArgs e)
      {
         if (ValidateText() || txtGroup.SelectedIndex == -1)
         {
            _ = MessageBox.Show("Fill in all fields correctly");
            return;
         }

         Node = new RdpTreeNode()
         {
            Text = txtName.DefaultText,
            Host = txtHost.DefaultText,
            Port = int.Parse(txtPort.DefaultText),
            Username = txtUsername.DefaultText,
            Password = txtPassword.DefaultText,
            ToolTipText = txtDescription.DefaultText,
            ForeColor = lbColor.ForeColor,
            ImageIndex = 1,
            SelectedImageIndex = 1
         };

         Group = txtGroup.SelectedItem.ToString();

         DialogResult = DialogResult.OK;
      }

      private bool ValidateText()
      {
         foreach (RdpTextBox item in Controls.OfType<RdpTextBox>())
         {
            if (string.IsNullOrEmpty(item.DefaultText))
            {
               return true;
            }
         }

         return false;
      }
   }
}
