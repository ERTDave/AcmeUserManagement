namespace Acme.Forms.UI
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
            this.UserTabs = new System.Windows.Forms.TabControl();
            this.LogonTab = new System.Windows.Forms.TabPage();
            this.LogonButton = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsersTab = new System.Windows.Forms.TabPage();
            this.UsersGrid = new System.Windows.Forms.DataGridView();
            this.UserTabs.SuspendLayout();
            this.LogonTab.SuspendLayout();
            this.UsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UserTabs
            // 
            this.UserTabs.Controls.Add(this.LogonTab);
            this.UserTabs.Controls.Add(this.UsersTab);
            this.UserTabs.Location = new System.Drawing.Point(14, 13);
            this.UserTabs.Name = "UserTabs";
            this.UserTabs.SelectedIndex = 0;
            this.UserTabs.Size = new System.Drawing.Size(773, 400);
            this.UserTabs.TabIndex = 0;
            this.UserTabs.SelectedIndexChanged += new System.EventHandler(this.UserTabs_SelectedIndexChanged);
            // 
            // LogonTab
            // 
            this.LogonTab.Controls.Add(this.LogonButton);
            this.LogonTab.Controls.Add(this.Password);
            this.LogonTab.Controls.Add(this.Username);
            this.LogonTab.Controls.Add(this.PasswordLabel);
            this.LogonTab.Controls.Add(this.UsernameLabel);
            this.LogonTab.Location = new System.Drawing.Point(4, 22);
            this.LogonTab.Name = "LogonTab";
            this.LogonTab.Padding = new System.Windows.Forms.Padding(3);
            this.LogonTab.Size = new System.Drawing.Size(765, 374);
            this.LogonTab.TabIndex = 0;
            this.LogonTab.Text = "Logon";
            this.LogonTab.UseVisualStyleBackColor = true;
            // 
            // LogonButton
            // 
            this.LogonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogonButton.Location = new System.Drawing.Point(316, 219);
            this.LogonButton.Name = "LogonButton";
            this.LogonButton.Size = new System.Drawing.Size(117, 33);
            this.LogonButton.TabIndex = 4;
            this.LogonButton.Text = "Logon";
            this.LogonButton.UseVisualStyleBackColor = true;
            this.LogonButton.Click += new System.EventHandler(this.LogonButton_Click);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(316, 171);
            this.Password.MaxLength = 20;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(223, 22);
            this.Password.TabIndex = 3;
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(316, 127);
            this.Username.MaxLength = 20;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(223, 22);
            this.Username.TabIndex = 2;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(225, 171);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(68, 16);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(225, 130);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(71, 16);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            // 
            // UsersTab
            // 
            this.UsersTab.Controls.Add(this.UsersGrid);
            this.UsersTab.Location = new System.Drawing.Point(4, 22);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.UsersTab.Size = new System.Drawing.Size(765, 374);
            this.UsersTab.TabIndex = 1;
            this.UsersTab.Text = "User Management";
            this.UsersTab.UseVisualStyleBackColor = true;
            // 
            // UsersGrid
            // 
            this.UsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGrid.Location = new System.Drawing.Point(15, 15);
            this.UsersGrid.Name = "UsersGrid";
            this.UsersGrid.Size = new System.Drawing.Size(734, 339);
            this.UsersGrid.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.UserTabs);
            this.MaximumSize = new System.Drawing.Size(816, 460);
            this.MinimumSize = new System.Drawing.Size(816, 460);
            this.Name = "MainForm";
            this.Text = "Acme User Management copyright 1980";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.UserTabs.ResumeLayout(false);
            this.LogonTab.ResumeLayout(false);
            this.LogonTab.PerformLayout();
            this.UsersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl UserTabs;
        private System.Windows.Forms.TabPage LogonTab;
        private System.Windows.Forms.TabPage UsersTab;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button LogonButton;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.DataGridView UsersGrid;
    }
}

