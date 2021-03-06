namespace JuicySwapper.Main.GUI
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LoginFree = new System.Windows.Forms.PictureBox();
            this.PaidLogin = new System.Windows.Forms.PictureBox();
            this.NitroLogin = new System.Windows.Forms.PictureBox();
            this.ExitSwapper = new System.Windows.Forms.PictureBox();
            this.CurvaSidebar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LoginFree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaidLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NitroLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitSwapper)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.HintForeColor = System.Drawing.Color.Empty;
            this.Username.HintText = "";
            this.Username.isPassword = false;
            this.Username.LineFocusedColor = System.Drawing.Color.White;
            this.Username.LineIdleColor = System.Drawing.Color.White;
            this.Username.LineMouseHoverColor = System.Drawing.Color.White;
            this.Username.LineThickness = 2;
            this.Username.Location = new System.Drawing.Point(581, 194);
            this.Username.Margin = new System.Windows.Forms.Padding(4);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(232, 33);
            this.Username.TabIndex = 7;
            this.Username.TabStop = false;
            this.Username.Text = "Enter a username...";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Username.Enter += new System.EventHandler(this.username_Enter);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.HintForeColor = System.Drawing.Color.Empty;
            this.password.HintText = "";
            this.password.isPassword = false;
            this.password.LineFocusedColor = System.Drawing.Color.White;
            this.password.LineIdleColor = System.Drawing.Color.White;
            this.password.LineMouseHoverColor = System.Drawing.Color.White;
            this.password.LineThickness = 2;
            this.password.Location = new System.Drawing.Point(580, 235);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(232, 33);
            this.password.TabIndex = 8;
            this.password.TabStop = false;
            this.password.Text = "Enter a password...";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password.Enter += new System.EventHandler(this.password_Enter);
            // 
            // LoginFree
            // 
            this.LoginFree.BackColor = System.Drawing.Color.Transparent;
            this.LoginFree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginFree.Location = new System.Drawing.Point(571, 297);
            this.LoginFree.Name = "LoginFree";
            this.LoginFree.Size = new System.Drawing.Size(155, 22);
            this.LoginFree.TabIndex = 10;
            this.LoginFree.TabStop = false;
            this.LoginFree.Click += new System.EventHandler(this.LoginGest_Click);
            // 
            // PaidLogin
            // 
            this.PaidLogin.BackColor = System.Drawing.Color.Transparent;
            this.PaidLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaidLogin.Location = new System.Drawing.Point(738, 297);
            this.PaidLogin.Name = "PaidLogin";
            this.PaidLogin.Size = new System.Drawing.Size(155, 22);
            this.PaidLogin.TabIndex = 11;
            this.PaidLogin.TabStop = false;
            this.PaidLogin.Click += new System.EventHandler(this.PaidLogin_Click);
            // 
            // NitroLogin
            // 
            this.NitroLogin.BackColor = System.Drawing.Color.Transparent;
            this.NitroLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NitroLogin.Location = new System.Drawing.Point(650, 331);
            this.NitroLogin.Name = "NitroLogin";
            this.NitroLogin.Size = new System.Drawing.Size(155, 22);
            this.NitroLogin.TabIndex = 12;
            this.NitroLogin.TabStop = false;
            this.NitroLogin.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // ExitSwapper
            // 
            this.ExitSwapper.BackColor = System.Drawing.Color.Transparent;
            this.ExitSwapper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitSwapper.Location = new System.Drawing.Point(800, 493);
            this.ExitSwapper.Name = "ExitSwapper";
            this.ExitSwapper.Size = new System.Drawing.Size(155, 22);
            this.ExitSwapper.TabIndex = 13;
            this.ExitSwapper.TabStop = false;
            this.ExitSwapper.Click += new System.EventHandler(this.ExitSwapper_Click);
            // 
            // CurvaSidebar
            // 
            this.CurvaSidebar.ElipseRadius = 7;
            this.CurvaSidebar.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(966, 530);
            this.Controls.Add(this.ExitSwapper);
            this.Controls.Add(this.NitroLogin);
            this.Controls.Add(this.PaidLogin);
            this.Controls.Add(this.LoginFree);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.LoginFree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaidLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NitroLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitSwapper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox Username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private System.Windows.Forms.PictureBox LoginFree;
        private System.Windows.Forms.PictureBox PaidLogin;
        private System.Windows.Forms.PictureBox NitroLogin;
        private System.Windows.Forms.PictureBox ExitSwapper;
        private Bunifu.Framework.UI.BunifuElipse CurvaSidebar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Timer timer1;
    }
}