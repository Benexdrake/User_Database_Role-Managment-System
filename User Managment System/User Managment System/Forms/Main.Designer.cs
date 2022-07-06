namespace User_Managment_System
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.panelRoles = new System.Windows.Forms.Panel();
            this.btn_All_Roles = new System.Windows.Forms.Button();
            this.btn_Search_Role = new System.Windows.Forms.Button();
            this.btn_New_Role = new System.Windows.Forms.Button();
            this.btn_Role = new System.Windows.Forms.Button();
            this.panelDatabase = new System.Windows.Forms.Panel();
            this.btn_All_Databases = new System.Windows.Forms.Button();
            this.btn_Search_Databases = new System.Windows.Forms.Button();
            this.btn_New_Database = new System.Windows.Forms.Button();
            this.btn_Database = new System.Windows.Forms.Button();
            this.panelUsers = new System.Windows.Forms.Panel();
            this.btn_BlackList = new System.Windows.Forms.Button();
            this.btn_All_Users = new System.Windows.Forms.Button();
            this.btn_RegReq_User = new System.Windows.Forms.Button();
            this.btn_New_User = new System.Windows.Forms.Button();
            this.btn_Users = new System.Windows.Forms.Button();
            this.panelAvatar = new System.Windows.Forms.Panel();
            this.pBox_Avatar = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.cBox_Compact = new System.Windows.Forms.CheckBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panelSideBar.SuspendLayout();
            this.panelRoles.SuspendLayout();
            this.panelDatabase.SuspendLayout();
            this.panelUsers.SuspendLayout();
            this.panelAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Avatar)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSideBar.Controls.Add(this.btn_Logout);
            this.panelSideBar.Controls.Add(this.panelRoles);
            this.panelSideBar.Controls.Add(this.panelDatabase);
            this.panelSideBar.Controls.Add(this.panelUsers);
            this.panelSideBar.Controls.Add(this.panelAvatar);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(225, 761);
            this.panelSideBar.TabIndex = 0;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.Location = new System.Drawing.Point(0, 701);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Logout.Size = new System.Drawing.Size(225, 60);
            this.btn_Logout.TabIndex = 6;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Logout.UseVisualStyleBackColor = false;
            // 
            // panelRoles
            // 
            this.panelRoles.Controls.Add(this.btn_All_Roles);
            this.panelRoles.Controls.Add(this.btn_Search_Role);
            this.panelRoles.Controls.Add(this.btn_New_Role);
            this.panelRoles.Controls.Add(this.btn_Role);
            this.panelRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRoles.Location = new System.Drawing.Point(0, 310);
            this.panelRoles.MinimumSize = new System.Drawing.Size(225, 60);
            this.panelRoles.Name = "panelRoles";
            this.panelRoles.Size = new System.Drawing.Size(225, 60);
            this.panelRoles.TabIndex = 5;
            // 
            // btn_All_Roles
            // 
            this.btn_All_Roles.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_All_Roles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_All_Roles.Image = ((System.Drawing.Image)(resources.GetObject("btn_All_Roles.Image")));
            this.btn_All_Roles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_All_Roles.Location = new System.Drawing.Point(0, 180);
            this.btn_All_Roles.Name = "btn_All_Roles";
            this.btn_All_Roles.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_All_Roles.Size = new System.Drawing.Size(225, 60);
            this.btn_All_Roles.TabIndex = 3;
            this.btn_All_Roles.Text = "   All Roles";
            this.btn_All_Roles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_All_Roles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_All_Roles.UseVisualStyleBackColor = false;
            // 
            // btn_Search_Role
            // 
            this.btn_Search_Role.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Search_Role.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Search_Role.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search_Role.Image")));
            this.btn_Search_Role.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search_Role.Location = new System.Drawing.Point(0, 120);
            this.btn_Search_Role.Name = "btn_Search_Role";
            this.btn_Search_Role.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Search_Role.Size = new System.Drawing.Size(225, 60);
            this.btn_Search_Role.TabIndex = 2;
            this.btn_Search_Role.Text = "   Search Role";
            this.btn_Search_Role.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search_Role.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Search_Role.UseVisualStyleBackColor = false;
            // 
            // btn_New_Role
            // 
            this.btn_New_Role.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_New_Role.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_New_Role.Image = ((System.Drawing.Image)(resources.GetObject("btn_New_Role.Image")));
            this.btn_New_Role.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_New_Role.Location = new System.Drawing.Point(0, 60);
            this.btn_New_Role.Name = "btn_New_Role";
            this.btn_New_Role.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_New_Role.Size = new System.Drawing.Size(225, 60);
            this.btn_New_Role.TabIndex = 1;
            this.btn_New_Role.Text = "   New Role";
            this.btn_New_Role.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_New_Role.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_New_Role.UseVisualStyleBackColor = false;
            // 
            // btn_Role
            // 
            this.btn_Role.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Role.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Role.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Role.Image = ((System.Drawing.Image)(resources.GetObject("btn_Role.Image")));
            this.btn_Role.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Role.Location = new System.Drawing.Point(0, 0);
            this.btn_Role.Name = "btn_Role";
            this.btn_Role.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Role.Size = new System.Drawing.Size(225, 60);
            this.btn_Role.TabIndex = 0;
            this.btn_Role.Text = "Roles";
            this.btn_Role.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Role.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Role.UseVisualStyleBackColor = false;
            this.btn_Role.Click += new System.EventHandler(this.btn_Role_Click);
            // 
            // panelDatabase
            // 
            this.panelDatabase.Controls.Add(this.btn_All_Databases);
            this.panelDatabase.Controls.Add(this.btn_Search_Databases);
            this.panelDatabase.Controls.Add(this.btn_New_Database);
            this.panelDatabase.Controls.Add(this.btn_Database);
            this.panelDatabase.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDatabase.Location = new System.Drawing.Point(0, 250);
            this.panelDatabase.MinimumSize = new System.Drawing.Size(225, 60);
            this.panelDatabase.Name = "panelDatabase";
            this.panelDatabase.Size = new System.Drawing.Size(225, 60);
            this.panelDatabase.TabIndex = 4;
            // 
            // btn_All_Databases
            // 
            this.btn_All_Databases.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_All_Databases.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_All_Databases.Image = ((System.Drawing.Image)(resources.GetObject("btn_All_Databases.Image")));
            this.btn_All_Databases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_All_Databases.Location = new System.Drawing.Point(0, 180);
            this.btn_All_Databases.Name = "btn_All_Databases";
            this.btn_All_Databases.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_All_Databases.Size = new System.Drawing.Size(225, 60);
            this.btn_All_Databases.TabIndex = 3;
            this.btn_All_Databases.Text = "   All Databases";
            this.btn_All_Databases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_All_Databases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_All_Databases.UseVisualStyleBackColor = false;
            // 
            // btn_Search_Databases
            // 
            this.btn_Search_Databases.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Search_Databases.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Search_Databases.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search_Databases.Image")));
            this.btn_Search_Databases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search_Databases.Location = new System.Drawing.Point(0, 120);
            this.btn_Search_Databases.Name = "btn_Search_Databases";
            this.btn_Search_Databases.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Search_Databases.Size = new System.Drawing.Size(225, 60);
            this.btn_Search_Databases.TabIndex = 2;
            this.btn_Search_Databases.Text = "   Search Database";
            this.btn_Search_Databases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search_Databases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Search_Databases.UseVisualStyleBackColor = false;
            // 
            // btn_New_Database
            // 
            this.btn_New_Database.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_New_Database.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_New_Database.Image = ((System.Drawing.Image)(resources.GetObject("btn_New_Database.Image")));
            this.btn_New_Database.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_New_Database.Location = new System.Drawing.Point(0, 60);
            this.btn_New_Database.Name = "btn_New_Database";
            this.btn_New_Database.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_New_Database.Size = new System.Drawing.Size(225, 60);
            this.btn_New_Database.TabIndex = 1;
            this.btn_New_Database.Text = "   New Database";
            this.btn_New_Database.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_New_Database.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_New_Database.UseVisualStyleBackColor = false;
            // 
            // btn_Database
            // 
            this.btn_Database.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Database.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Database.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Database.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Database.Image = ((System.Drawing.Image)(resources.GetObject("btn_Database.Image")));
            this.btn_Database.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Database.Location = new System.Drawing.Point(0, 0);
            this.btn_Database.Name = "btn_Database";
            this.btn_Database.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Database.Size = new System.Drawing.Size(225, 60);
            this.btn_Database.TabIndex = 0;
            this.btn_Database.Text = "Databases";
            this.btn_Database.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Database.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Database.UseVisualStyleBackColor = false;
            this.btn_Database.Click += new System.EventHandler(this.btn_Database_Click);
            // 
            // panelUsers
            // 
            this.panelUsers.Controls.Add(this.btn_BlackList);
            this.panelUsers.Controls.Add(this.btn_All_Users);
            this.panelUsers.Controls.Add(this.btn_RegReq_User);
            this.panelUsers.Controls.Add(this.btn_New_User);
            this.panelUsers.Controls.Add(this.btn_Users);
            this.panelUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsers.Location = new System.Drawing.Point(0, 190);
            this.panelUsers.MinimumSize = new System.Drawing.Size(225, 60);
            this.panelUsers.Name = "panelUsers";
            this.panelUsers.Size = new System.Drawing.Size(225, 60);
            this.panelUsers.TabIndex = 1;
            // 
            // btn_BlackList
            // 
            this.btn_BlackList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_BlackList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_BlackList.Image = ((System.Drawing.Image)(resources.GetObject("btn_BlackList.Image")));
            this.btn_BlackList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BlackList.Location = new System.Drawing.Point(0, 240);
            this.btn_BlackList.Name = "btn_BlackList";
            this.btn_BlackList.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_BlackList.Size = new System.Drawing.Size(225, 60);
            this.btn_BlackList.TabIndex = 4;
            this.btn_BlackList.Text = "   BlackList";
            this.btn_BlackList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BlackList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_BlackList.UseVisualStyleBackColor = false;
            this.btn_BlackList.Click += new System.EventHandler(this.btn_BlackList_Click);
            // 
            // btn_All_Users
            // 
            this.btn_All_Users.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_All_Users.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_All_Users.Image = ((System.Drawing.Image)(resources.GetObject("btn_All_Users.Image")));
            this.btn_All_Users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_All_Users.Location = new System.Drawing.Point(0, 180);
            this.btn_All_Users.Name = "btn_All_Users";
            this.btn_All_Users.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_All_Users.Size = new System.Drawing.Size(225, 60);
            this.btn_All_Users.TabIndex = 3;
            this.btn_All_Users.Text = "   All Users";
            this.btn_All_Users.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_All_Users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_All_Users.UseVisualStyleBackColor = false;
            this.btn_All_Users.Click += new System.EventHandler(this.btn_All_Users_Click);
            // 
            // btn_RegReq_User
            // 
            this.btn_RegReq_User.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_RegReq_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_RegReq_User.Image = ((System.Drawing.Image)(resources.GetObject("btn_RegReq_User.Image")));
            this.btn_RegReq_User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RegReq_User.Location = new System.Drawing.Point(0, 120);
            this.btn_RegReq_User.Name = "btn_RegReq_User";
            this.btn_RegReq_User.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_RegReq_User.Size = new System.Drawing.Size(225, 60);
            this.btn_RegReq_User.TabIndex = 2;
            this.btn_RegReq_User.Text = "   Registration Requests";
            this.btn_RegReq_User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RegReq_User.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RegReq_User.UseVisualStyleBackColor = false;
            this.btn_RegReq_User.Click += new System.EventHandler(this.btn_RegReq_User_Click);
            // 
            // btn_New_User
            // 
            this.btn_New_User.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_New_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_New_User.Image = ((System.Drawing.Image)(resources.GetObject("btn_New_User.Image")));
            this.btn_New_User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_New_User.Location = new System.Drawing.Point(0, 60);
            this.btn_New_User.Name = "btn_New_User";
            this.btn_New_User.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_New_User.Size = new System.Drawing.Size(225, 60);
            this.btn_New_User.TabIndex = 1;
            this.btn_New_User.Text = "   New User";
            this.btn_New_User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_New_User.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_New_User.UseVisualStyleBackColor = false;
            this.btn_New_User.Click += new System.EventHandler(this.btn_New_User_Click);
            // 
            // btn_Users
            // 
            this.btn_Users.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Users.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Users.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Users.Image = ((System.Drawing.Image)(resources.GetObject("btn_Users.Image")));
            this.btn_Users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Users.Location = new System.Drawing.Point(0, 0);
            this.btn_Users.Name = "btn_Users";
            this.btn_Users.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Users.Size = new System.Drawing.Size(225, 60);
            this.btn_Users.TabIndex = 0;
            this.btn_Users.Text = "Users";
            this.btn_Users.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Users.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Users.UseVisualStyleBackColor = false;
            this.btn_Users.Click += new System.EventHandler(this.btn_Users_Click);
            // 
            // panelAvatar
            // 
            this.panelAvatar.Controls.Add(this.pBox_Avatar);
            this.panelAvatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAvatar.Location = new System.Drawing.Point(0, 0);
            this.panelAvatar.Name = "panelAvatar";
            this.panelAvatar.Size = new System.Drawing.Size(225, 190);
            this.panelAvatar.TabIndex = 0;
            // 
            // pBox_Avatar
            // 
            this.pBox_Avatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox_Avatar.Image = ((System.Drawing.Image)(resources.GetObject("pBox_Avatar.Image")));
            this.pBox_Avatar.Location = new System.Drawing.Point(0, 0);
            this.pBox_Avatar.Name = "pBox_Avatar";
            this.pBox_Avatar.Size = new System.Drawing.Size(225, 190);
            this.pBox_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_Avatar.TabIndex = 0;
            this.pBox_Avatar.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHeader.Controls.Add(this.cBox_Compact);
            this.panelHeader.Controls.Add(this.btn_Refresh);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(225, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1209, 43);
            this.panelHeader.TabIndex = 1;
            // 
            // cBox_Compact
            // 
            this.cBox_Compact.AutoSize = true;
            this.cBox_Compact.Location = new System.Drawing.Point(6, 18);
            this.cBox_Compact.Name = "cBox_Compact";
            this.cBox_Compact.Size = new System.Drawing.Size(115, 19);
            this.cBox_Compact.TabIndex = 1;
            this.cBox_Compact.Text = "Compact Modus";
            this.cBox_Compact.UseVisualStyleBackColor = true;
            this.cBox_Compact.CheckedChanged += new System.EventHandler(this.cBox_Compact_CheckedChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.Image")));
            this.btn_Refresh.Location = new System.Drawing.Point(1168, 0);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(41, 43);
            this.btn_Refresh.TabIndex = 0;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // panelChild
            // 
            this.panelChild.AutoScroll = true;
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(225, 43);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(1209, 718);
            this.panelChild.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 761);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSideBar);
            this.MinimumSize = new System.Drawing.Size(1450, 800);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelSideBar.ResumeLayout(false);
            this.panelRoles.ResumeLayout(false);
            this.panelDatabase.ResumeLayout(false);
            this.panelUsers.ResumeLayout(false);
            this.panelAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Avatar)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSideBar;
        private Panel panelAvatar;
        private PictureBox pBox_Avatar;
        private Panel panelHeader;
        private Panel panelChild;
        private Panel panelUsers;
        private Button btn_All_Users;
        private Button btn_RegReq_User;
        private Button btn_New_User;
        private Button btn_Users;
        private Panel panelDatabase;
        private Button btn_All_Databases;
        private Button btn_Search_Databases;
        private Button btn_New_Database;
        private Button btn_Database;
        private Panel panelRoles;
        private Button btn_All_Roles;
        private Button btn_Search_Role;
        private Button btn_New_Role;
        private Button btn_Role;
        private Button btn_Logout;
        private Button btn_BlackList;
        private Button btn_Refresh;
        private CheckBox cBox_Compact;
    }
}