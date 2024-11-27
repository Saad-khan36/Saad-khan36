namespace WindowsFormsApp1
{
    partial class eShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eShop));
            this.packgroundpic = new System.Windows.Forms.PictureBox();
            this.panellogo = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.usernamelable = new System.Windows.Forms.Label();
            this.Passwordlable = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.packgroundpic)).BeginInit();
            this.panellogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // packgroundpic
            // 
            this.packgroundpic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("packgroundpic.BackgroundImage")));
            this.packgroundpic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packgroundpic.Location = new System.Drawing.Point(200, 0);
            this.packgroundpic.Name = "packgroundpic";
            this.packgroundpic.Size = new System.Drawing.Size(796, 579);
            this.packgroundpic.TabIndex = 1;
            this.packgroundpic.TabStop = false;
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panellogo.Controls.Add(this.button1);
            this.panellogo.Controls.Add(this.logo);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(200, 579);
            this.panellogo.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.Location = new System.Drawing.Point(3, 28);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(191, 58);
            this.logo.TabIndex = 0;
            this.logo.Text = "eShop";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(805, 140);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(91, 33);
            this.login.TabIndex = 2;
            this.login.Text = "Login";
            // 
            // usernamelable
            // 
            this.usernamelable.AutoSize = true;
            this.usernamelable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.usernamelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelable.Location = new System.Drawing.Point(807, 207);
            this.usernamelable.Name = "usernamelable";
            this.usernamelable.Size = new System.Drawing.Size(83, 20);
            this.usernamelable.TabIndex = 3;
            this.usernamelable.Text = "Username";
            // 
            // Passwordlable
            // 
            this.Passwordlable.AutoSize = true;
            this.Passwordlable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Passwordlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlable.Location = new System.Drawing.Point(807, 274);
            this.Passwordlable.Name = "Passwordlable";
            this.Passwordlable.Size = new System.Drawing.Size(78, 20);
            this.Passwordlable.TabIndex = 4;
            this.Passwordlable.Text = "Password";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(811, 230);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(133, 29);
            this.username.TabIndex = 5;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(811, 298);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(133, 29);
            this.password.TabIndex = 6;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(829, 344);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(92, 29);
            this.loginBtn.TabIndex = 7;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Click here to create account";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // eShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 579);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Passwordlable);
            this.Controls.Add(this.usernamelable);
            this.Controls.Add(this.login);
            this.Controls.Add(this.packgroundpic);
            this.Controls.Add(this.panellogo);
            this.Name = "eShop";
            this.Text = "eShop";
            ((System.ComponentModel.ISupportInitialize)(this.packgroundpic)).EndInit();
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox packgroundpic;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label usernamelable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Passwordlable;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button loginBtn;
    }
}

