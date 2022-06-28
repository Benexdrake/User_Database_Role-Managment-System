namespace User_Managment_System.Forms
{
    partial class UserControlPanels
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlPanels));
            this.pBox_Avatar = new System.Windows.Forms.PictureBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.tBox_Email = new System.Windows.Forms.TextBox();
            this.tBox_Firstname = new System.Windows.Forms.TextBox();
            this.lbl_Firstname = new System.Windows.Forms.Label();
            this.tBox_Lastname = new System.Windows.Forms.TextBox();
            this.lbl_Lastname = new System.Windows.Forms.Label();
            this.lbl_DoB = new System.Windows.Forms.Label();
            this.lbl_Database = new System.Windows.Forms.Label();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.tBox_Permission_Info = new System.Windows.Forms.TextBox();
            this.lbl_Permission = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Open = new System.Windows.Forms.Button();
            this.tBox_DB = new System.Windows.Forms.TextBox();
            this.tBox_Role = new System.Windows.Forms.TextBox();
            this.tBox_DoB = new System.Windows.Forms.TextBox();
            this.btn_Bann = new System.Windows.Forms.Button();
            this.btn_Accept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox_Avatar
            // 
            this.pBox_Avatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBox_Avatar.Image = ((System.Drawing.Image)(resources.GetObject("pBox_Avatar.Image")));
            this.pBox_Avatar.Location = new System.Drawing.Point(0, 0);
            this.pBox_Avatar.Name = "pBox_Avatar";
            this.pBox_Avatar.Size = new System.Drawing.Size(46, 54);
            this.pBox_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_Avatar.TabIndex = 0;
            this.pBox_Avatar.TabStop = false;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(52, 10);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(39, 15);
            this.lbl_Email.TabIndex = 1;
            this.lbl_Email.Text = "Email:";
            // 
            // tBox_Email
            // 
            this.tBox_Email.Location = new System.Drawing.Point(52, 27);
            this.tBox_Email.Name = "tBox_Email";
            this.tBox_Email.ReadOnly = true;
            this.tBox_Email.Size = new System.Drawing.Size(156, 23);
            this.tBox_Email.TabIndex = 2;
            // 
            // tBox_Firstname
            // 
            this.tBox_Firstname.Location = new System.Drawing.Point(214, 27);
            this.tBox_Firstname.Name = "tBox_Firstname";
            this.tBox_Firstname.ReadOnly = true;
            this.tBox_Firstname.Size = new System.Drawing.Size(133, 23);
            this.tBox_Firstname.TabIndex = 4;
            // 
            // lbl_Firstname
            // 
            this.lbl_Firstname.AutoSize = true;
            this.lbl_Firstname.Location = new System.Drawing.Point(214, 8);
            this.lbl_Firstname.Name = "lbl_Firstname";
            this.lbl_Firstname.Size = new System.Drawing.Size(62, 15);
            this.lbl_Firstname.TabIndex = 3;
            this.lbl_Firstname.Text = "Firstname:";
            // 
            // tBox_Lastname
            // 
            this.tBox_Lastname.Location = new System.Drawing.Point(353, 27);
            this.tBox_Lastname.Name = "tBox_Lastname";
            this.tBox_Lastname.ReadOnly = true;
            this.tBox_Lastname.Size = new System.Drawing.Size(133, 23);
            this.tBox_Lastname.TabIndex = 6;
            // 
            // lbl_Lastname
            // 
            this.lbl_Lastname.AutoSize = true;
            this.lbl_Lastname.Location = new System.Drawing.Point(353, 7);
            this.lbl_Lastname.Name = "lbl_Lastname";
            this.lbl_Lastname.Size = new System.Drawing.Size(61, 15);
            this.lbl_Lastname.TabIndex = 5;
            this.lbl_Lastname.Text = "Lastname:";
            // 
            // lbl_DoB
            // 
            this.lbl_DoB.AutoSize = true;
            this.lbl_DoB.Location = new System.Drawing.Point(492, 7);
            this.lbl_DoB.Name = "lbl_DoB";
            this.lbl_DoB.Size = new System.Drawing.Size(32, 15);
            this.lbl_DoB.TabIndex = 8;
            this.lbl_DoB.Text = "DoB:";
            // 
            // lbl_Database
            // 
            this.lbl_Database.AutoSize = true;
            this.lbl_Database.Location = new System.Drawing.Point(572, 9);
            this.lbl_Database.Name = "lbl_Database";
            this.lbl_Database.Size = new System.Drawing.Size(58, 15);
            this.lbl_Database.TabIndex = 11;
            this.lbl_Database.Text = "Database:";
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.Location = new System.Drawing.Point(698, 7);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(33, 15);
            this.lbl_Role.TabIndex = 12;
            this.lbl_Role.Text = "Role:";
            // 
            // tBox_Permission_Info
            // 
            this.tBox_Permission_Info.Location = new System.Drawing.Point(823, 25);
            this.tBox_Permission_Info.Name = "tBox_Permission_Info";
            this.tBox_Permission_Info.ReadOnly = true;
            this.tBox_Permission_Info.Size = new System.Drawing.Size(156, 23);
            this.tBox_Permission_Info.TabIndex = 13;
            // 
            // lbl_Permission
            // 
            this.lbl_Permission.AutoSize = true;
            this.lbl_Permission.Location = new System.Drawing.Point(823, 7);
            this.lbl_Permission.Name = "lbl_Permission";
            this.lbl_Permission.Size = new System.Drawing.Size(96, 15);
            this.lbl_Permission.TabIndex = 14;
            this.lbl_Permission.Text = "Role Permissions";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 5);
            this.panel1.TabIndex = 17;
            // 
            // btn_Open
            // 
            this.btn_Open.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Open.Location = new System.Drawing.Point(1139, 0);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(61, 54);
            this.btn_Open.TabIndex = 18;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // tBox_DB
            // 
            this.tBox_DB.Location = new System.Drawing.Point(572, 26);
            this.tBox_DB.Name = "tBox_DB";
            this.tBox_DB.ReadOnly = true;
            this.tBox_DB.Size = new System.Drawing.Size(122, 23);
            this.tBox_DB.TabIndex = 19;
            // 
            // tBox_Role
            // 
            this.tBox_Role.Location = new System.Drawing.Point(698, 25);
            this.tBox_Role.Name = "tBox_Role";
            this.tBox_Role.ReadOnly = true;
            this.tBox_Role.Size = new System.Drawing.Size(122, 23);
            this.tBox_Role.TabIndex = 20;
            // 
            // tBox_DoB
            // 
            this.tBox_DoB.Location = new System.Drawing.Point(492, 27);
            this.tBox_DoB.Name = "tBox_DoB";
            this.tBox_DoB.ReadOnly = true;
            this.tBox_DoB.Size = new System.Drawing.Size(77, 23);
            this.tBox_DoB.TabIndex = 21;
            // 
            // btn_Bann
            // 
            this.btn_Bann.BackColor = System.Drawing.Color.Red;
            this.btn_Bann.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Bann.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Bann.Location = new System.Drawing.Point(1078, 0);
            this.btn_Bann.Name = "btn_Bann";
            this.btn_Bann.Size = new System.Drawing.Size(61, 54);
            this.btn_Bann.TabIndex = 22;
            this.btn_Bann.Text = "Bann";
            this.btn_Bann.UseVisualStyleBackColor = false;
            this.btn_Bann.Click += new System.EventHandler(this.btn_Choice_Click);
            // 
            // btn_Accept
            // 
            this.btn_Accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Accept.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Accept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Accept.Location = new System.Drawing.Point(1017, 0);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(61, 54);
            this.btn_Accept.TabIndex = 23;
            this.btn_Accept.Text = "Accept";
            this.btn_Accept.UseVisualStyleBackColor = false;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // UserControlPanels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.btn_Bann);
            this.Controls.Add(this.tBox_DoB);
            this.Controls.Add(this.tBox_Role);
            this.Controls.Add(this.tBox_DB);
            this.Controls.Add(this.btn_Open);
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
            this.Controls.Add(this.panel1);
            this.Name = "UserControlPanels";
            this.Size = new System.Drawing.Size(1200, 59);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pBox_Avatar;
        private Label lbl_Email;
        private TextBox tBox_Email;
        private TextBox tBox_Firstname;
        private Label lbl_Firstname;
        private TextBox tBox_Lastname;
        private Label lbl_Lastname;
        private Label lbl_DoB;
        private Label lbl_Database;
        private Label lbl_Role;
        private TextBox tBox_Permission_Info;
        private Label lbl_Permission;
        private Panel panel1;
        private Button btn_Open;
        private TextBox tBox_DB;
        private TextBox tBox_Role;
        private TextBox tBox_DoB;
        private Button btn_Bann;
        private Button btn_Accept;
    }
}
