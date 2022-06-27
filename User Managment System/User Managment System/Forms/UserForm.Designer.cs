namespace User_Managment_System.Forms
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.btn_Pic = new System.Windows.Forms.Button();
            this.pBox_Avatar = new System.Windows.Forms.PictureBox();
            this.lbl_Permission = new System.Windows.Forms.Label();
            this.tBox_Permission_Info = new System.Windows.Forms.TextBox();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.lbl_Database = new System.Windows.Forms.Label();
            this.lbl_DoB = new System.Windows.Forms.Label();
            this.tBox_Lastname = new System.Windows.Forms.TextBox();
            this.lbl_Lastname = new System.Windows.Forms.Label();
            this.tBox_Firstname = new System.Windows.Forms.TextBox();
            this.lbl_Firstname = new System.Windows.Forms.Label();
            this.tBox_Email = new System.Windows.Forms.TextBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.tBox_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Password = new System.Windows.Forms.Button();
            this.dTime_DoB = new System.Windows.Forms.DateTimePicker();
            this.lbl_FilePath = new System.Windows.Forms.Label();
            this.cBox_Database = new System.Windows.Forms.ComboBox();
            this.cBox_Role = new System.Windows.Forms.ComboBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tBox_Information = new System.Windows.Forms.TextBox();
            this.lbl_Profil_Info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Pic
            // 
            this.btn_Pic.Location = new System.Drawing.Point(12, 189);
            this.btn_Pic.Name = "btn_Pic";
            this.btn_Pic.Size = new System.Drawing.Size(176, 23);
            this.btn_Pic.TabIndex = 0;
            this.btn_Pic.Text = "Open Picture";
            this.btn_Pic.UseVisualStyleBackColor = true;
            this.btn_Pic.Click += new System.EventHandler(this.btn_Pic_Click);
            // 
            // pBox_Avatar
            // 
            this.pBox_Avatar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pBox_Avatar.ErrorImage")));
            this.pBox_Avatar.Location = new System.Drawing.Point(12, 12);
            this.pBox_Avatar.Name = "pBox_Avatar";
            this.pBox_Avatar.Size = new System.Drawing.Size(176, 171);
            this.pBox_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_Avatar.TabIndex = 1;
            this.pBox_Avatar.TabStop = false;
            this.pBox_Avatar.Click += new System.EventHandler(this.pBox_Avatar_Click);
            // 
            // lbl_Permission
            // 
            this.lbl_Permission.AutoSize = true;
            this.lbl_Permission.Location = new System.Drawing.Point(198, 319);
            this.lbl_Permission.Name = "lbl_Permission";
            this.lbl_Permission.Size = new System.Drawing.Size(96, 15);
            this.lbl_Permission.TabIndex = 32;
            this.lbl_Permission.Text = "Role Permissions";
            // 
            // tBox_Permission_Info
            // 
            this.tBox_Permission_Info.Location = new System.Drawing.Point(198, 337);
            this.tBox_Permission_Info.Name = "tBox_Permission_Info";
            this.tBox_Permission_Info.ReadOnly = true;
            this.tBox_Permission_Info.Size = new System.Drawing.Size(223, 23);
            this.tBox_Permission_Info.TabIndex = 31;
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.Location = new System.Drawing.Point(198, 275);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(33, 15);
            this.lbl_Role.TabIndex = 30;
            this.lbl_Role.Text = "Role:";
            // 
            // lbl_Database
            // 
            this.lbl_Database.AutoSize = true;
            this.lbl_Database.Location = new System.Drawing.Point(198, 231);
            this.lbl_Database.Name = "lbl_Database";
            this.lbl_Database.Size = new System.Drawing.Size(58, 15);
            this.lbl_Database.TabIndex = 29;
            this.lbl_Database.Text = "Database:";
            // 
            // lbl_DoB
            // 
            this.lbl_DoB.AutoSize = true;
            this.lbl_DoB.Location = new System.Drawing.Point(196, 99);
            this.lbl_DoB.Name = "lbl_DoB";
            this.lbl_DoB.Size = new System.Drawing.Size(32, 15);
            this.lbl_DoB.TabIndex = 28;
            this.lbl_DoB.Text = "DoB:";
            // 
            // tBox_Lastname
            // 
            this.tBox_Lastname.Location = new System.Drawing.Point(196, 205);
            this.tBox_Lastname.Name = "tBox_Lastname";
            this.tBox_Lastname.Size = new System.Drawing.Size(224, 23);
            this.tBox_Lastname.TabIndex = 27;
            // 
            // lbl_Lastname
            // 
            this.lbl_Lastname.AutoSize = true;
            this.lbl_Lastname.Location = new System.Drawing.Point(196, 187);
            this.lbl_Lastname.Name = "lbl_Lastname";
            this.lbl_Lastname.Size = new System.Drawing.Size(61, 15);
            this.lbl_Lastname.TabIndex = 26;
            this.lbl_Lastname.Text = "Lastname:";
            // 
            // tBox_Firstname
            // 
            this.tBox_Firstname.Location = new System.Drawing.Point(196, 161);
            this.tBox_Firstname.Name = "tBox_Firstname";
            this.tBox_Firstname.Size = new System.Drawing.Size(223, 23);
            this.tBox_Firstname.TabIndex = 25;
            // 
            // lbl_Firstname
            // 
            this.lbl_Firstname.AutoSize = true;
            this.lbl_Firstname.Location = new System.Drawing.Point(196, 142);
            this.lbl_Firstname.Name = "lbl_Firstname";
            this.lbl_Firstname.Size = new System.Drawing.Size(62, 15);
            this.lbl_Firstname.TabIndex = 24;
            this.lbl_Firstname.Text = "Firstname:";
            // 
            // tBox_Email
            // 
            this.tBox_Email.Location = new System.Drawing.Point(194, 28);
            this.tBox_Email.Name = "tBox_Email";
            this.tBox_Email.Size = new System.Drawing.Size(223, 23);
            this.tBox_Email.TabIndex = 23;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(194, 10);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(39, 15);
            this.lbl_Email.TabIndex = 22;
            this.lbl_Email.Text = "Email:";
            // 
            // tBox_Password
            // 
            this.tBox_Password.Location = new System.Drawing.Point(196, 73);
            this.tBox_Password.Name = "tBox_Password";
            this.tBox_Password.ReadOnly = true;
            this.tBox_Password.Size = new System.Drawing.Size(223, 23);
            this.tBox_Password.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Password:";
            // 
            // btn_Password
            // 
            this.btn_Password.Location = new System.Drawing.Point(307, 104);
            this.btn_Password.Name = "btn_Password";
            this.btn_Password.Size = new System.Drawing.Size(112, 51);
            this.btn_Password.TabIndex = 38;
            this.btn_Password.Text = "Generate Password";
            this.btn_Password.UseVisualStyleBackColor = true;
            this.btn_Password.Click += new System.EventHandler(this.btn_Password_Click);
            // 
            // dTime_DoB
            // 
            this.dTime_DoB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTime_DoB.Location = new System.Drawing.Point(196, 116);
            this.dTime_DoB.Name = "dTime_DoB";
            this.dTime_DoB.Size = new System.Drawing.Size(99, 23);
            this.dTime_DoB.TabIndex = 39;
            // 
            // lbl_FilePath
            // 
            this.lbl_FilePath.AutoSize = true;
            this.lbl_FilePath.Location = new System.Drawing.Point(12, 215);
            this.lbl_FilePath.Name = "lbl_FilePath";
            this.lbl_FilePath.Size = new System.Drawing.Size(54, 15);
            this.lbl_FilePath.TabIndex = 40;
            this.lbl_FilePath.Text = "File_Path";
            // 
            // cBox_Database
            // 
            this.cBox_Database.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Database.FormattingEnabled = true;
            this.cBox_Database.Location = new System.Drawing.Point(196, 249);
            this.cBox_Database.Name = "cBox_Database";
            this.cBox_Database.Size = new System.Drawing.Size(223, 23);
            this.cBox_Database.TabIndex = 41;
            this.cBox_Database.SelectedIndexChanged += new System.EventHandler(this.cBox_Database_SelectedIndexChanged);
            // 
            // cBox_Role
            // 
            this.cBox_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Role.FormattingEnabled = true;
            this.cBox_Role.Location = new System.Drawing.Point(197, 293);
            this.cBox_Role.Name = "cBox_Role";
            this.cBox_Role.Size = new System.Drawing.Size(223, 23);
            this.cBox_Role.TabIndex = 42;
            this.cBox_Role.SelectedIndexChanged += new System.EventHandler(this.cBox_Role_SelectedIndexChanged);
            // 
            // btn_Send
            // 
            this.btn_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send.Location = new System.Drawing.Point(710, 366);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(132, 40);
            this.btn_Send.TabIndex = 43;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tBox_Information
            // 
            this.tBox_Information.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBox_Information.Location = new System.Drawing.Point(441, 28);
            this.tBox_Information.Multiline = true;
            this.tBox_Information.Name = "tBox_Information";
            this.tBox_Information.Size = new System.Drawing.Size(401, 332);
            this.tBox_Information.TabIndex = 44;
            // 
            // lbl_Profil_Info
            // 
            this.lbl_Profil_Info.AutoSize = true;
            this.lbl_Profil_Info.Location = new System.Drawing.Point(441, 9);
            this.lbl_Profil_Info.Name = "lbl_Profil_Info";
            this.lbl_Profil_Info.Size = new System.Drawing.Size(104, 15);
            this.lbl_Profil_Info.TabIndex = 45;
            this.lbl_Profil_Info.Text = "Profil Information:";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 415);
            this.Controls.Add(this.lbl_Profil_Info);
            this.Controls.Add(this.tBox_Information);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.cBox_Role);
            this.Controls.Add(this.cBox_Database);
            this.Controls.Add(this.lbl_FilePath);
            this.Controls.Add(this.dTime_DoB);
            this.Controls.Add(this.btn_Password);
            this.Controls.Add(this.tBox_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Permission);
            this.Controls.Add(this.tBox_Permission_Info);
            this.Controls.Add(this.lbl_Role);
            this.Controls.Add(this.lbl_Database);
            this.Controls.Add(this.lbl_DoB);
            this.Controls.Add(this.tBox_Lastname);
            this.Controls.Add(this.lbl_Lastname);
            this.Controls.Add(this.tBox_Firstname);
            this.Controls.Add(this.lbl_Firstname);
            this.Controls.Add(this.tBox_Email);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.pBox_Avatar);
            this.Controls.Add(this.btn_Pic);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Pic;
        private PictureBox pBox_Avatar;
        private Label lbl_Permission;
        private TextBox tBox_Permission_Info;
        private Label lbl_Role;
        private Label lbl_Database;
        private Label lbl_DoB;
        private TextBox tBox_Lastname;
        private Label lbl_Lastname;
        private TextBox tBox_Firstname;
        private Label lbl_Firstname;
        private TextBox tBox_Email;
        private Label lbl_Email;
        private TextBox tBox_Password;
        private Label label1;
        private Button btn_Password;
        private DateTimePicker dTime_DoB;
        private Label lbl_FilePath;
        private ComboBox cBox_Database;
        private ComboBox cBox_Role;
        private Button btn_Send;
        private TextBox tBox_Information;
        private Label lbl_Profil_Info;
    }
}