namespace User_Managment_System.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pBox_Icon = new System.Windows.Forms.PictureBox();
            this.tBox_Username = new System.Windows.Forms.TextBox();
            this.tBox_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.cBox_Save_Username = new System.Windows.Forms.CheckBox();
            this.cBox_See_Password = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox_Icon
            // 
            this.pBox_Icon.Image = ((System.Drawing.Image)(resources.GetObject("pBox_Icon.Image")));
            this.pBox_Icon.Location = new System.Drawing.Point(12, 12);
            this.pBox_Icon.Name = "pBox_Icon";
            this.pBox_Icon.Size = new System.Drawing.Size(185, 172);
            this.pBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_Icon.TabIndex = 0;
            this.pBox_Icon.TabStop = false;
            // 
            // tBox_Username
            // 
            this.tBox_Username.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox_Username.Location = new System.Drawing.Point(232, 27);
            this.tBox_Username.Name = "tBox_Username";
            this.tBox_Username.PlaceholderText = "Username";
            this.tBox_Username.Size = new System.Drawing.Size(418, 35);
            this.tBox_Username.TabIndex = 1;
            // 
            // tBox_Password
            // 
            this.tBox_Password.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox_Password.Location = new System.Drawing.Point(232, 78);
            this.tBox_Password.Name = "tBox_Password";
            this.tBox_Password.PasswordChar = '*';
            this.tBox_Password.PlaceholderText = "Password";
            this.tBox_Password.Size = new System.Drawing.Size(418, 35);
            this.tBox_Password.TabIndex = 2;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(510, 144);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(140, 40);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // cBox_Save_Username
            // 
            this.cBox_Save_Username.AutoSize = true;
            this.cBox_Save_Username.Location = new System.Drawing.Point(232, 119);
            this.cBox_Save_Username.Name = "cBox_Save_Username";
            this.cBox_Save_Username.Size = new System.Drawing.Size(106, 19);
            this.cBox_Save_Username.TabIndex = 4;
            this.cBox_Save_Username.Text = "Save Username";
            this.cBox_Save_Username.UseVisualStyleBackColor = true;
            this.cBox_Save_Username.CheckedChanged += new System.EventHandler(this.cBox_Save_Username_CheckedChanged);
            // 
            // cBox_See_Password
            // 
            this.cBox_See_Password.AutoSize = true;
            this.cBox_See_Password.Location = new System.Drawing.Point(573, 119);
            this.cBox_See_Password.Name = "cBox_See_Password";
            this.cBox_See_Password.Size = new System.Drawing.Size(76, 19);
            this.cBox_See_Password.TabIndex = 5;
            this.cBox_See_Password.Text = "Password";
            this.cBox_See_Password.UseVisualStyleBackColor = true;
            this.cBox_See_Password.CheckedChanged += new System.EventHandler(this.cBox_See_Password_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 196);
            this.Controls.Add(this.cBox_See_Password);
            this.Controls.Add(this.cBox_Save_Username);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tBox_Password);
            this.Controls.Add(this.tBox_Username);
            this.Controls.Add(this.pBox_Icon);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pBox_Icon;
        private TextBox tBox_Username;
        private TextBox tBox_Password;
        private Button btn_Login;
        private CheckBox cBox_Save_Username;
        private CheckBox cBox_See_Password;
    }
}