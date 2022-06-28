namespace RdpWindowsManager.Forms
{
   partial class GroupForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupForm));
         this.txtName = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.lbColor = new System.Windows.Forms.Label();
         this.btColor = new System.Windows.Forms.Button();
         this.label3 = new System.Windows.Forms.Label();
         this.txtDescription = new RdpWindowsManager.Controls.RdpTextBox();
         this.btSave = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // txtName
         // 
         this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
         this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
         this.txtName.Location = new System.Drawing.Point(8, 25);
         this.txtName.Name = "txtName";
         this.txtName.Size = new System.Drawing.Size(262, 22);
         this.txtName.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(5, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(74, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Name group:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(5, 55);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(69, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "Color name:";
         // 
         // lbColor
         // 
         this.lbColor.AutoSize = true;
         this.lbColor.ForeColor = System.Drawing.Color.Black;
         this.lbColor.Location = new System.Drawing.Point(233, 55);
         this.lbColor.Name = "lbColor";
         this.lbColor.Size = new System.Drawing.Size(37, 13);
         this.lbColor.TabIndex = 3;
         this.lbColor.Text = "Demo";
         // 
         // btColor
         // 
         this.btColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.btColor.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
         this.btColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btColor.ForeColor = System.Drawing.Color.Black;
         this.btColor.Location = new System.Drawing.Point(8, 71);
         this.btColor.Name = "btColor";
         this.btColor.Size = new System.Drawing.Size(262, 23);
         this.btColor.TabIndex = 4;
         this.btColor.Text = "Select color";
         this.btColor.UseVisualStyleBackColor = false;
         this.btColor.Click += new System.EventHandler(this.BtColor_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(5, 102);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(69, 13);
         this.label3.TabIndex = 5;
         this.label3.Text = "Description:";
         // 
         // txtDescription
         // 
         this.txtDescription.BackColor = System.Drawing.Color.White;
         this.txtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.txtDescription.BorderMode = RdpWindowsManager.Controls.Enums.BorderMode.Default;
         this.txtDescription.BorderSize = 1;
         this.txtDescription.DefaultText = "";
         this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
         this.txtDescription.HoverState.BorderSize = 1;
         this.txtDescription.Location = new System.Drawing.Point(8, 118);
         this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
         this.txtDescription.Multiline = true;
         this.txtDescription.Name = "txtDescription";
         this.txtDescription.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
         this.txtDescription.PasswordChar = false;
         this.txtDescription.Placeholder = null;
         this.txtDescription.ReadOnly = false;
         this.txtDescription.Size = new System.Drawing.Size(262, 66);
         this.txtDescription.TabIndex = 6;
         // 
         // btSave
         // 
         this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.btSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
         this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btSave.ForeColor = System.Drawing.Color.Black;
         this.btSave.Location = new System.Drawing.Point(8, 190);
         this.btSave.Name = "btSave";
         this.btSave.Size = new System.Drawing.Size(262, 23);
         this.btSave.TabIndex = 7;
         this.btSave.Text = "Save";
         this.btSave.UseVisualStyleBackColor = false;
         this.btSave.Click += new System.EventHandler(this.BtSave_Click);
         // 
         // GroupForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(279, 220);
         this.Controls.Add(this.btSave);
         this.Controls.Add(this.txtDescription);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.btColor);
         this.Controls.Add(this.lbColor);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtName);
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "GroupForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "New Group";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtName;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label lbColor;
      private System.Windows.Forms.Button btColor;
      private System.Windows.Forms.Label label3;
      private Controls.RdpTextBox txtDescription;
      private System.Windows.Forms.Button btSave;
   }
}