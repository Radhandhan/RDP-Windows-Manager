namespace RdpWindowsManager.Forms
{
   partial class MainForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.connectMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.addServerMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.addGroupMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.addServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.separator1 = new System.Windows.Forms.Panel();
         this.panel1 = new System.Windows.Forms.Panel();
         this.treeView = new RdpWindowsManager.Controls.RdpTreeView();
         this.imageList = new System.Windows.Forms.ImageList(this.components);
         this.separator3 = new System.Windows.Forms.Panel();
         this.txtSearch = new RdpWindowsManager.Controls.RdpTextBox();
         this.separator2 = new System.Windows.Forms.Panel();
         this.tabControl = new RdpWindowsManager.Controls.RdpTabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.treeViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.editViewMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.removeViewMenu = new System.Windows.Forms.ToolStripMenuItem();
         this.menuStrip1.SuspendLayout();
         this.panel1.SuspendLayout();
         this.tabControl.SuspendLayout();
         this.treeViewMenu.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectMenu,
            this.addServerMenu,
            this.addGroupMenu});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
         this.menuStrip1.Size = new System.Drawing.Size(926, 25);
         this.menuStrip1.TabIndex = 0;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // connectMenu
         // 
         this.connectMenu.Image = ((System.Drawing.Image)(resources.GetObject("connectMenu.Image")));
         this.connectMenu.Name = "connectMenu";
         this.connectMenu.Padding = new System.Windows.Forms.Padding(4, 1, 4, 0);
         this.connectMenu.Size = new System.Drawing.Size(83, 21);
         this.connectMenu.Text = " Connect";
         this.connectMenu.Click += new System.EventHandler(this.ConnectMenu_Click);
         // 
         // addServerMenu
         // 
         this.addServerMenu.Image = ((System.Drawing.Image)(resources.GetObject("addServerMenu.Image")));
         this.addServerMenu.Name = "addServerMenu";
         this.addServerMenu.Padding = new System.Windows.Forms.Padding(4, 1, 4, 0);
         this.addServerMenu.Size = new System.Drawing.Size(95, 21);
         this.addServerMenu.Text = " Add Server";
         this.addServerMenu.Click += new System.EventHandler(this.AddServerMenu_Click);
         // 
         // addGroupMenu
         // 
         this.addGroupMenu.Image = global::RdpWindowsManager.Properties.Resources.icon_folder_add;
         this.addGroupMenu.Name = "addGroupMenu";
         this.addGroupMenu.Padding = new System.Windows.Forms.Padding(4, 1, 4, 0);
         this.addGroupMenu.Size = new System.Drawing.Size(96, 21);
         this.addGroupMenu.Text = " Add Group";
         this.addGroupMenu.Click += new System.EventHandler(this.AddGroupMenu_Click);
         // 
         // connectToolStripMenuItem
         // 
         this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
         this.connectToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
         // 
         // addServerToolStripMenuItem
         // 
         this.addServerToolStripMenuItem.Name = "addServerToolStripMenuItem";
         this.addServerToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
         // 
         // settingToolStripMenuItem
         // 
         this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
         this.settingToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
         // 
         // separator1
         // 
         this.separator1.BackColor = System.Drawing.Color.Silver;
         this.separator1.Dock = System.Windows.Forms.DockStyle.Top;
         this.separator1.Location = new System.Drawing.Point(0, 25);
         this.separator1.Name = "separator1";
         this.separator1.Size = new System.Drawing.Size(926, 1);
         this.separator1.TabIndex = 1;
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.treeView);
         this.panel1.Controls.Add(this.separator3);
         this.panel1.Controls.Add(this.txtSearch);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
         this.panel1.Location = new System.Drawing.Point(0, 26);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(212, 514);
         this.panel1.TabIndex = 2;
         // 
         // treeView
         // 
         this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.treeView.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
         this.treeView.ForeColor = System.Drawing.Color.Black;
         this.treeView.ImageIndex = 0;
         this.treeView.ImageList = this.imageList;
         this.treeView.Location = new System.Drawing.Point(1, 31);
         this.treeView.Name = "treeView";
         this.treeView.PathSeparator = "0";
         this.treeView.SelectedImageIndex = 0;
         this.treeView.SelectFullRow = false;
         this.treeView.SelectNodeBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
         this.treeView.SelectNodeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.treeView.ShowLines = false;
         this.treeView.ShowPlusMinus = false;
         this.treeView.Size = new System.Drawing.Size(212, 483);
         this.treeView.TabIndex = 7;
         this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseClick);
         // 
         // imageList
         // 
         this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
         this.imageList.TransparentColor = System.Drawing.Color.Transparent;
         this.imageList.Images.SetKeyName(0, "icon-folder.png");
         this.imageList.Images.SetKeyName(1, "icon-server.png");
         // 
         // separator3
         // 
         this.separator3.BackColor = System.Drawing.Color.Silver;
         this.separator3.Dock = System.Windows.Forms.DockStyle.Top;
         this.separator3.Location = new System.Drawing.Point(0, 24);
         this.separator3.Name = "separator3";
         this.separator3.Size = new System.Drawing.Size(212, 1);
         this.separator3.TabIndex = 6;
         // 
         // txtSearch
         // 
         this.txtSearch.BackColor = System.Drawing.Color.White;
         this.txtSearch.BorderColor = System.Drawing.Color.Silver;
         this.txtSearch.BorderMode = RdpWindowsManager.Controls.Enums.BorderMode.Default;
         this.txtSearch.BorderSize = 1;
         this.txtSearch.DefaultText = "";
         this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
         this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
         this.txtSearch.HoverState.BorderSize = 1;
         this.txtSearch.Location = new System.Drawing.Point(0, 0);
         this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
         this.txtSearch.Multiline = false;
         this.txtSearch.Name = "txtSearch";
         this.txtSearch.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
         this.txtSearch.PasswordChar = false;
         this.txtSearch.Placeholder = "Search...";
         this.txtSearch.ReadOnly = false;
         this.txtSearch.Size = new System.Drawing.Size(212, 24);
         this.txtSearch.TabIndex = 4;
         this.txtSearch.DefaultTextChanged += new System.EventHandler(this.TxtSearch_DefaultTextChanged);
         // 
         // separator2
         // 
         this.separator2.BackColor = System.Drawing.Color.Silver;
         this.separator2.Dock = System.Windows.Forms.DockStyle.Left;
         this.separator2.Location = new System.Drawing.Point(212, 26);
         this.separator2.Name = "separator2";
         this.separator2.Size = new System.Drawing.Size(1, 514);
         this.separator2.TabIndex = 3;
         // 
         // tabControl
         // 
         this.tabControl.BorderPageColor = System.Drawing.Color.White;
         this.tabControl.Controls.Add(this.tabPage1);
         this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabControl.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
         this.tabControl.ItemSize = new System.Drawing.Size(240, 16);
         this.tabControl.Location = new System.Drawing.Point(213, 26);
         this.tabControl.Name = "tabControl";
         this.tabControl.SelectedIndex = 0;
         this.tabControl.SelectTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
         this.tabControl.SelectTextTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.tabControl.Size = new System.Drawing.Size(713, 514);
         this.tabControl.TabColor = System.Drawing.Color.Gray;
         this.tabControl.TabIndex = 4;
         this.tabControl.TextTabColor = System.Drawing.Color.White;
         // 
         // tabPage1
         // 
         this.tabPage1.Location = new System.Drawing.Point(4, 20);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(705, 490);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "tabPage1";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // treeViewMenu
         // 
         this.treeViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editViewMenu,
            this.removeViewMenu});
         this.treeViewMenu.Name = "viewMenu";
         this.treeViewMenu.Size = new System.Drawing.Size(118, 48);
         // 
         // editViewMenu
         // 
         this.editViewMenu.Image = global::RdpWindowsManager.Properties.Resources.icon_folder_edit;
         this.editViewMenu.Name = "editViewMenu";
         this.editViewMenu.Size = new System.Drawing.Size(117, 22);
         this.editViewMenu.Text = "Edit";
         this.editViewMenu.Click += new System.EventHandler(this.EditViewMenu_Click);
         // 
         // removeViewMenu
         // 
         this.removeViewMenu.Image = global::RdpWindowsManager.Properties.Resources.icon_folder_remove;
         this.removeViewMenu.Name = "removeViewMenu";
         this.removeViewMenu.Size = new System.Drawing.Size(117, 22);
         this.removeViewMenu.Text = "Remove";
         this.removeViewMenu.Click += new System.EventHandler(this.RemoveViewMenu_Click);
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(926, 540);
         this.Controls.Add(this.tabControl);
         this.Controls.Add(this.separator2);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.separator1);
         this.Controls.Add(this.menuStrip1);
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.ForeColor = System.Drawing.Color.Black;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MainMenuStrip = this.menuStrip1;
         this.Name = "MainForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "RDP Windows Manager";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.Load += new System.EventHandler(this.MainForm_Load);
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.panel1.ResumeLayout(false);
         this.tabControl.ResumeLayout(false);
         this.treeViewMenu.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem addServerToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
      private System.Windows.Forms.Panel separator1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel separator2;
      private System.Windows.Forms.ToolStripMenuItem connectMenu;
      private System.Windows.Forms.ToolStripMenuItem addServerMenu;
      private System.Windows.Forms.Panel separator3;
      private Controls.RdpTextBox txtSearch;
      private System.Windows.Forms.ToolStripMenuItem addGroupMenu;
      private Controls.RdpTabControl tabControl;
      private System.Windows.Forms.TabPage tabPage1;
      private Controls.RdpTreeView treeView;
      private System.Windows.Forms.ImageList imageList;
      private System.Windows.Forms.ContextMenuStrip treeViewMenu;
      private System.Windows.Forms.ToolStripMenuItem editViewMenu;
      private System.Windows.Forms.ToolStripMenuItem removeViewMenu;
   }
}