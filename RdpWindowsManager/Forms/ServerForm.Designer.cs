namespace RdpWindowsManager.Forms
{
   partial class ServerForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
         this.label1 = new System.Windows.Forms.Label();
         this.txtName = new RdpWindowsManager.Controls.RdpTextBox();
         this.txtHost = new RdpWindowsManager.Controls.RdpTextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.txtPort = new RdpWindowsManager.Controls.RdpTextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.txtUsername = new RdpWindowsManager.Controls.RdpTextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.txtPassword = new RdpWindowsManager.Controls.RdpTextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.btPassword = new System.Windows.Forms.CheckBox();
         this.btSave = new System.Windows.Forms.Button();
         this.label6 = new System.Windows.Forms.Label();
         this.btColor = new System.Windows.Forms.Button();
         this.lbColor = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.txtDescription = new RdpWindowsManager.Controls.RdpTextBox();
         this.label9 = new System.Windows.Forms.Label();
         this.txtGroup = new System.Windows.Forms.ComboBox();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(5, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(72, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "Name server:";
         // 
         // txtName
         // 
         this.txtName.BackColor = System.Drawing.Color.White;
         this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.txtName.BorderMode = RdpWindowsManager.Controls.Enums.BorderMode.Default;
         this.txtName.BorderSize = 1;
         this.txtName.DefaultText = "";
         this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtName.HoverState.BorderSize = 1;
         this.txtName.Location = new System.Drawing.Point(8, 26);
         this.txtName.Margin = new System.Windows.Forms.Padding(4);
         this.txtName.Multiline = false;
         this.txtName.Name = "txtName";
         this.txtName.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
         this.txtName.PasswordChar = false;
         this.txtName.Placeholder = null;
         this.txtName.ReadOnly = false;
         this.txtName.Size = new System.Drawing.Size(217, 24);
         this.txtName.TabIndex = 3;
         // 
         // txtHost
         // 
         this.txtHost.BackColor = System.Drawing.Color.White;
         this.txtHost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.txtHost.BorderMode = RdpWindowsManager.Controls.Enums.BorderMode.Default;
         this.txtHost.BorderSize = 1;
         this.txtHost.DefaultText = "";
         this.txtHost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtHost.HoverState.BorderSize = 1;
         this.txtHost.Location = new System.Drawing.Point(8, 77);
         this.txtHost.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
         this.txtHost.Multiline = false;
         this.txtHost.Name = "txtHost";
         this.txtHost.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
         this.txtHost.PasswordChar = false;
         this.txtHost.Placeholder = null;
         this.txtHost.ReadOnly = false;
         this.txtHost.Size = new System.Drawing.Size(158, 24);
         this.txtHost.TabIndex = 5;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(5, 60);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(34, 13);
         this.label2.TabIndex = 4;
         this.label2.Text = "Host:";
         // 
         // txtPort
         // 
         this.txtPort.BackColor = System.Drawing.Color.White;
         this.txtPort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.txtPort.BorderMode = RdpWindowsManager.Controls.Enums.BorderMode.Default;
         this.txtPort.BorderSize = 1;
         this.txtPort.DefaultText = "3389";
         this.txtPort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtPort.HoverState.BorderSize = 1;
         this.txtPort.Location = new System.Drawing.Point(170, 77);
         this.txtPort.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
         this.txtPort.Multiline = false;
         this.txtPort.Name = "txtPort";
         this.txtPort.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
         this.txtPort.PasswordChar = false;
         this.txtPort.Placeholder = null;
         this.txtPort.ReadOnly = false;
         this.txtPort.Size = new System.Drawing.Size(55, 24);
         this.txtPort.TabIndex = 6;
         this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPort_KeyPress);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(167, 60);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(31, 13);
         this.label3.TabIndex = 7;
         this.label3.Text = "Port:";
         // 
         // txtUsername
         // 
         this.txtUsername.BackColor = System.Drawing.Color.White;
         this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.txtUsername.BorderMode = RdpWindowsManager.Controls.Enums.BorderMode.Default;
         this.txtUsername.BorderSize = 1;
         this.txtUsername.DefaultText = "";
         this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtUsername.HoverState.BorderSize = 1;
         this.txtUsername.Location = new System.Drawing.Point(8, 128);
         this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
         this.txtUsername.Multiline = false;
         this.txtUsername.Name = "txtUsername";
         this.txtUsername.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
         this.txtUsername.PasswordChar = false;
         this.txtUsername.Placeholder = null;
         this.txtUsername.ReadOnly = false;
         this.txtUsername.Size = new System.Drawing.Size(217, 24);
         this.txtUsername.TabIndex = 9;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(5, 111);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(61, 13);
         this.label4.TabIndex = 8;
         this.label4.Text = "Username:";
         // 
         // txtPassword
         // 
         this.txtPassword.BackColor = System.Drawing.Color.White;
         this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.txtPassword.BorderMode = RdpWindowsManager.Controls.Enums.BorderMode.Default;
         this.txtPassword.BorderSize = 1;
         this.txtPassword.DefaultText = "";
         this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtPassword.HoverState.BorderSize = 1;
         this.txtPassword.Location = new System.Drawing.Point(8, 179);
         this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
         this.txtPassword.Multiline = false;
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
         this.txtPassword.PasswordChar = true;
         this.txtPassword.Placeholder = null;
         this.txtPassword.ReadOnly = false;
         this.txtPassword.Size = new System.Drawing.Size(188, 24);
         this.txtPassword.TabIndex = 11;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(5, 162);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(59, 13);
         this.label5.TabIndex = 10;
         this.label5.Text = "Password:";
         // 
         // btPassword
         // 
         this.btPassword.Appearance = System.Windows.Forms.Appearance.Button;
         this.btPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.btPassword.Checked = true;
         this.btPassword.CheckState = System.Windows.Forms.CheckState.Checked;
         this.btPassword.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
         this.btPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btPassword.Image = global::RdpWindowsManager.Properties.Resources.icon_show_password;
         this.btPassword.Location = new System.Drawing.Point(200, 179);
         this.btPassword.Name = "btPassword";
         this.btPassword.Padding = new System.Windows.Forms.Padding(2);
         this.btPassword.Size = new System.Drawing.Size(25, 25);
         this.btPassword.TabIndex = 13;
         this.btPassword.UseVisualStyleBackColor = false;
         this.btPassword.CheckedChanged += new System.EventHandler(this.BtPassword_CheckedChanged);
         // 
         // btSave
         // 
         this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.btSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
         this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btSave.ForeColor = System.Drawing.Color.Black;
         this.btSave.Location = new System.Drawing.Point(8, 211);
         this.btSave.Name = "btSave";
         this.btSave.Size = new System.Drawing.Size(217, 23);
         this.btSave.TabIndex = 14;
         this.btSave.Text = "Save";
         this.btSave.UseVisualStyleBackColor = false;
         this.btSave.Click += new System.EventHandler(this.BtSave_Click);
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(247, 9);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(68, 13);
         this.label6.TabIndex = 15;
         this.label6.Text = "Name color:";
         // 
         // btColor
         // 
         this.btColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.btColor.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
         this.btColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btColor.ForeColor = System.Drawing.Color.Black;
         this.btColor.Location = new System.Drawing.Point(250, 26);
         this.btColor.Name = "btColor";
         this.btColor.Size = new System.Drawing.Size(217, 25);
         this.btColor.TabIndex = 16;
         this.btColor.Text = "Select color";
         this.btColor.UseVisualStyleBackColor = false;
         this.btColor.Click += new System.EventHandler(this.BtColor_Click);
         // 
         // lbColor
         // 
         this.lbColor.AutoSize = true;
         this.lbColor.Location = new System.Drawing.Point(430, 9);
         this.lbColor.Name = "lbColor";
         this.lbColor.Size = new System.Drawing.Size(37, 13);
         this.lbColor.TabIndex = 17;
         this.lbColor.Text = "Demo";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(247, 60);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(69, 13);
         this.label8.TabIndex = 18;
         this.label8.Text = "Description:";
         // 
         // txtDescription
         // 
         this.txtDescription.BackColor = System.Drawing.Color.White;
         this.txtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.txtDescription.BorderMode = RdpWindowsManager.Controls.Enums.BorderMode.Default;
         this.txtDescription.BorderSize = 1;
         this.txtDescription.DefaultText = "";
         this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtDescription.HoverState.BorderSize = 1;
         this.txtDescription.Location = new System.Drawing.Point(250, 77);
         this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
         this.txtDescription.Multiline = true;
         this.txtDescription.Name = "txtDescription";
         this.txtDescription.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
         this.txtDescription.PasswordChar = false;
         this.txtDescription.Placeholder = null;
         this.txtDescription.ReadOnly = false;
         this.txtDescription.Size = new System.Drawing.Size(217, 76);
         this.txtDescription.TabIndex = 19;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(247, 162);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(43, 13);
         this.label9.TabIndex = 20;
         this.label9.Text = "Group:";
         // 
         // txtGroup
         // 
         this.txtGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.txtGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.txtGroup.ForeColor = System.Drawing.Color.Black;
         this.txtGroup.FormattingEnabled = true;
         this.txtGroup.Location = new System.Drawing.Point(250, 178);
         this.txtGroup.Name = "txtGroup";
         this.txtGroup.Size = new System.Drawing.Size(217, 25);
         this.txtGroup.TabIndex = 21;
         // 
         // ServerForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(475, 241);
         this.Controls.Add(this.txtGroup);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.txtDescription);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.lbColor);
         this.Controls.Add(this.btColor);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.btSave);
         this.Controls.Add(this.btPassword);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.txtUsername);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.txtPort);
         this.Controls.Add(this.txtHost);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtName);
         this.Controls.Add(this.label1);
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "ServerForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "New Server";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private Controls.RdpTextBox txtName;
      private Controls.RdpTextBox txtHost;
      private System.Windows.Forms.Label label2;
      private Controls.RdpTextBox txtPort;
      private System.Windows.Forms.Label label3;
      private Controls.RdpTextBox txtUsername;
      private System.Windows.Forms.Label label4;
      private Controls.RdpTextBox txtPassword;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.CheckBox btPassword;
      private System.Windows.Forms.Button btSave;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Button btColor;
      private System.Windows.Forms.Label lbColor;
      private System.Windows.Forms.Label label8;
      private Controls.RdpTextBox txtDescription;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.ComboBox txtGroup;
   }
}
