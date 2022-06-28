using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using AxMSTSCLib;
using RdpWindowsManager.Controls;

namespace RdpWindowsManager.Forms
{
   public partial class MainForm : Form
   {
      private Size _sizeClient;

      public MainForm()
      {
         InitializeComponent();
      }

      private void MainForm_Load(object sender, EventArgs e)
      {
         _sizeClient = tabControl.TabPages[0].Size;

         if (File.Exists("servers.xml"))
         {
            treeView.Nodes.AddRange(Helpers.XmlDeserialize<RdpTreeNode[]>("servers.xml"));
            treeView.ExpandAll();
         }

         tabControl.TabPages.Remove(tabControl.TabPages[0]);
      }

      private void TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
      {
         if (e.Button == MouseButtons.Right)
         {
            treeView.SelectedNode = e.Node;
            treeViewMenu.Show(treeView, e.Location);
         }
      }

      private void RemoveViewMenu_Click(object sender, EventArgs e)
      {
         RdpTreeNode node = (RdpTreeNode)treeView.SelectedNode;
         DialogResult dialog = MessageBox.Show("Are you sure you want to delete: " + node.Text + "?");

         if (dialog == DialogResult.OK)
         {
            treeView.Nodes.Remove(treeView.SelectedNode);
            SaveServers();
         }
      }

      private void AddGroupMenu_Click(object sender, EventArgs e)
      {
         RdpTreeNode node = ShowGroupForm();

         if (node != null)
         {
            treeView.Nodes.Add(node);
            SaveServers();
         }
      }

      private void AddServerMenu_Click(object sender, EventArgs e)
      {
         (string, RdpTreeNode) node = ShowServesForm();

         if (node.Item2 != null)
         {
            RdpTreeNode parent = treeView.Nodes.Cast<RdpTreeNode>().FirstOrDefault(x => x.Text == node.Item1);

            if (parent != null)
            {
               parent.Nodes.Add(node.Item2);
               SaveServers();
            }
         }
      }

      private void EditViewMenu_Click(object sender, EventArgs e)
      {
         RdpTreeNode node1 = (RdpTreeNode)treeView.SelectedNode;

         if (node1.Parent == null)
         {
            RdpTreeNode node2 = ShowGroupForm(node1);

            if (node2 != null)
            {
               node1.Text = node2.Text;
               node1.ToolTipText = node2.ToolTipText;
               node1.ForeColor = node2.ForeColor;
            }
         }
         else
         {
            (string, RdpTreeNode) node3 = ShowServesForm(node1);

            if (node3.Item2 != null)
            {
               node1.Text = node3.Item2.Text;
               node1.ToolTipText = node3.Item2.ToolTipText;
               node1.ForeColor = node3.Item2.ForeColor;
               node1.Host = node3.Item2.Host;
               node1.Port = node3.Item2.Port;
               node1.Username = node3.Item2.Username;
               node1.Password = node3.Item2.Password;
            }
         }

         SaveServers();
      }

      private void ConnectMenu_Click(object sender, EventArgs e)
      {
         RdpTreeNode node = (RdpTreeNode)treeView.SelectedNode;

         if (node.Parent != null)
         {
            TabPage tabPage = new TabPage(node.Text);
            RdpClient client = new RdpClient
            {
               Size = _sizeClient,
               Dock = DockStyle.Fill
            };
            client.OnDisconnected += OnDisconnected;
            tabPage.Controls.Add(client);
            tabControl.TabPages.Add(tabPage);

            client.ConnectServer(node.Host, node.Username, node.Password, node.Port);
         }
      }

      private void TxtSearch_DefaultTextChanged(object sender, EventArgs e)
      {
         treeView.SelectedNode = SearchServer(txtSearch.DefaultText.ToLower(), treeView.Nodes.Cast<TreeNode>());
      }

      private RdpTreeNode ShowGroupForm(RdpTreeNode node = null)
      {
         using (GroupForm form = new GroupForm())
         {
            form.SetGroup(node);

            if (form.ShowDialog() == DialogResult.OK)
            {
               return form.Node;
            }
         }

         return null;
      }

      private (string, RdpTreeNode) ShowServesForm(RdpTreeNode node = null)
      {
         using (ServerForm form = new ServerForm())
         {
            form.SetGroup(treeView.GetNodesText(treeView.Nodes));
            form.SetServer(node);

            if (form.ShowDialog() == DialogResult.OK)
            {
               return (form.Group, form.Node);
            }
         }

         return (string.Empty, null);
      }

      private void OnDisconnected(object sender, IMsTscAxEvents_OnDisconnectedEvent e)
      {
         RdpClient client = sender as RdpClient;
         MessageBox.Show(client.GetErrorDescription((uint)e.discReason, (uint)client.ExtendedDisconnectReason));

         client.Parent.Dispose();
         client.Dispose();
      }

      private TreeNode SearchServer(string pattern, IEnumerable<TreeNode> nodes)
      {
         foreach (TreeNode item in nodes)
         {
            return item.Text.Contains(pattern, StringComparison.OrdinalIgnoreCase) ? item
               : SearchServer(pattern, item.Nodes.Cast<TreeNode>()) ?? null;
         }

         return null;
      }

      private void SaveServers()
      {
         if (treeView.Nodes.Count > 0)
         {
            RdpTreeNode[] tempNodes = new RdpTreeNode[treeView.Nodes.Count];

            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
               tempNodes[i] = (RdpTreeNode)treeView.Nodes[i];
            }

            Helpers.XmlSerialize(tempNodes, "servers.xml");
         }
      }
   }
}
