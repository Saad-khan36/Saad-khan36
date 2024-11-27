namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panelLOGO = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Label();
            this.signuplable = new System.Windows.Forms.Label();
            this.namelable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Email = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.phoneNUmber = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.addressbox = new System.Windows.Forms.TextBox();
            this.numbrt = new System.Windows.Forms.TextBox();
            this.signupbtn = new System.Windows.Forms.Button();
            this.loginredirstbtn = new System.Windows.Forms.Button();
            this.panelLOGO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLOGO
            // 
            this.panelLOGO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelLOGO.Controls.Add(this.logo);
            this.panelLOGO.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLOGO.Location = new System.Drawing.Point(0, 0);
            this.panelLOGO.Name = "panelLOGO";
            this.panelLOGO.Size = new System.Drawing.Size(220, 638);
            this.panelLOGO.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.Location = new System.Drawing.Point(-3, 25);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(191, 58);
            this.logo.TabIndex = 1;
            this.logo.Text = "eShop";
            // 
            // signuplable
            // 
            this.signuplable.AutoSize = true;
            this.signuplable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.signuplable.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signuplable.Location = new System.Drawing.Point(909, 81);
            this.signuplable.Name = "signuplable";
            this.signuplable.Size = new System.Drawing.Size(120, 33);
            this.signuplable.TabIndex = 2;
            this.signuplable.Text = "Sign up";
            // 
            // namelable
            // 
            this.namelable.AutoSize = true;
            this.namelable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.namelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelable.Location = new System.Drawing.Point(812, 167);
            this.namelable.Name = "namelable";
            this.namelable.Size = new System.Drawing.Size(83, 20);
            this.namelable.TabIndex = 3;
            this.namelable.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(220, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1021, 638);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(812, 218);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(48, 20);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(812, 276);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(78, 20);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(812, 337);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(68, 20);
            this.Address.TabIndex = 6;
            this.Address.Text = "Address";
            // 
            // phoneNUmber
            // 
            this.phoneNUmber.AutoSize = true;
            this.phoneNUmber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.phoneNUmber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNUmber.Location = new System.Drawing.Point(812, 390);
            this.phoneNUmber.Name = "phoneNUmber";
            this.phoneNUmber.Size = new System.Drawing.Size(63, 20);
            this.phoneNUmber.TabIndex = 7;
            this.phoneNUmber.Text = "phone#";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(941, 161);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(160, 26);
            this.name.TabIndex = 8;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // emailbox
            // 
            this.emailbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailbox.Location = new System.Drawing.Point(941, 212);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(160, 26);
            this.emailbox.TabIndex = 9;
            // 
            // passwordbox
            // 
            this.passwordbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordbox.Location = new System.Drawing.Point(941, 273);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.PasswordChar = '*';
            this.passwordbox.Size = new System.Drawing.Size(160, 26);
            this.passwordbox.TabIndex = 10;
            // 
            // addressbox
            // 
            this.addressbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressbox.Location = new System.Drawing.Point(941, 331);
            this.addressbox.Name = "addressbox";
            this.addressbox.Size = new System.Drawing.Size(160, 26);
            this.addressbox.TabIndex = 11;
            // 
            // numbrt
            // 
            this.numbrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbrt.Location = new System.Drawing.Point(941, 387);
            this.numbrt.Name = "numbrt";
            this.numbrt.Size = new System.Drawing.Size(160, 26);
            this.numbrt.TabIndex = 12;
            // 
            // signupbtn
            // 
            this.signupbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.signupbtn.Location = new System.Drawing.Point(960, 443);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(100, 33);
            this.signupbtn.TabIndex = 13;
            this.signupbtn.Text = "Signup";
            this.signupbtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.signupbtn.UseVisualStyleBackColor = false;
            // 
            // loginredirstbtn
            // 
            this.loginredirstbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginredirstbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginredirstbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginredirstbtn.Location = new System.Drawing.Point(1017, 582);
            this.loginredirstbtn.Name = "loginredirstbtn";
            this.loginredirstbtn.Size = new System.Drawing.Size(202, 33);
            this.loginredirstbtn.TabIndex = 2;
            this.loginredirstbtn.Text = "Already have an account?";
            this.loginredirstbtn.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1241, 638);
            this.Controls.Add(this.loginredirstbtn);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.numbrt);
            this.Controls.Add(this.addressbox);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.phoneNUmber);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.namelable);
            this.Controls.Add(this.signuplable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelLOGO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.panelLOGO.ResumeLayout(false);
            this.panelLOGO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLOGO;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Label signuplable;
        private System.Windows.Forms.Label namelable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label phoneNUmber;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button loginredirstbtn;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.TextBox addressbox;
        private System.Windows.Forms.TextBox numbrt;
        private System.Windows.Forms.Button signupbtn;
    }
}