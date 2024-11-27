namespace WindowsFormsApp1
{
    partial class User_Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Account));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.brandlogo = new System.Windows.Forms.PictureBox();
            this.Usersetting = new System.Windows.Forms.Label();
            this.productlowerpanel = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.confrimpassword = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.confrimpasswordtxt = new System.Windows.Forms.TextBox();
            this.rolebox = new System.Windows.Forms.ComboBox();
            this.Rolelbl = new System.Windows.Forms.Label();
            this.Fullnamelbl = new System.Windows.Forms.Label();
            this.fullnametxt = new System.Windows.Forms.TextBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.unamelbl = new System.Windows.Forms.Label();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.cpasswordtxt = new System.Windows.Forms.TextBox();
            this.cpasswordlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confrompasswordtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newpasswordtxt = new System.Windows.Forms.TextBox();
            this.changecancelbtn = new System.Windows.Forms.Button();
            this.changesavebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVuser = new System.Windows.Forms.DataGridView();
            this.brandlowerpanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.brandlogo)).BeginInit();
            this.productlowerpanel.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVuser)).BeginInit();
            this.SuspendLayout();
            // 
            // brandlogo
            // 
            this.brandlogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brandlogo.BackgroundImage")));
            this.brandlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.brandlogo.Location = new System.Drawing.Point(2, 3);
            this.brandlogo.Margin = new System.Windows.Forms.Padding(2);
            this.brandlogo.Name = "brandlogo";
            this.brandlogo.Size = new System.Drawing.Size(52, 50);
            this.brandlogo.TabIndex = 1;
            this.brandlogo.TabStop = false;
            // 
            // Usersetting
            // 
            this.Usersetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usersetting.Location = new System.Drawing.Point(58, 12);
            this.Usersetting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Usersetting.Name = "Usersetting";
            this.Usersetting.Size = new System.Drawing.Size(161, 41);
            this.Usersetting.TabIndex = 0;
            this.Usersetting.Text = "User Setting";
            // 
            // productlowerpanel
            // 
            this.productlowerpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productlowerpanel.Controls.Add(this.brandlogo);
            this.productlowerpanel.Controls.Add(this.Usersetting);
            this.productlowerpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productlowerpanel.Location = new System.Drawing.Point(0, 528);
            this.productlowerpanel.Margin = new System.Windows.Forms.Padding(2);
            this.productlowerpanel.Name = "productlowerpanel";
            this.productlowerpanel.Size = new System.Drawing.Size(1114, 64);
            this.productlowerpanel.TabIndex = 5;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(30, 12);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1071, 491);
            this.metroTabControl1.TabIndex = 6;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.cancelbtn);
            this.metroTabPage1.Controls.Add(this.Savebtn);
            this.metroTabPage1.Controls.Add(this.fullnametxt);
            this.metroTabPage1.Controls.Add(this.Fullnamelbl);
            this.metroTabPage1.Controls.Add(this.Rolelbl);
            this.metroTabPage1.Controls.Add(this.rolebox);
            this.metroTabPage1.Controls.Add(this.confrimpasswordtxt);
            this.metroTabPage1.Controls.Add(this.passwordtxt);
            this.metroTabPage1.Controls.Add(this.confrimpassword);
            this.metroTabPage1.Controls.Add(this.passwordlbl);
            this.metroTabPage1.Controls.Add(this.usernamelbl);
            this.metroTabPage1.Controls.Add(this.usernametxt);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1063, 449);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Create Account";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.changecancelbtn);
            this.metroTabPage2.Controls.Add(this.changesavebtn);
            this.metroTabPage2.Controls.Add(this.newpasswordtxt);
            this.metroTabPage2.Controls.Add(this.confrompasswordtxt);
            this.metroTabPage2.Controls.Add(this.label4);
            this.metroTabPage2.Controls.Add(this.label3);
            this.metroTabPage2.Controls.Add(this.cpasswordtxt);
            this.metroTabPage2.Controls.Add(this.cpasswordlbl);
            this.metroTabPage2.Controls.Add(this.usernametext);
            this.metroTabPage2.Controls.Add(this.unamelbl);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1063, 449);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Change Password";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.DGVuser);
            this.metroTabPage3.Controls.Add(this.brandlowerpanel);
            this.metroTabPage3.Controls.Add(this.dataGridView1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1063, 449);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Activate /Unactivate Account";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // usernametxt
            // 
            this.usernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.Location = new System.Drawing.Point(378, 49);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(479, 26);
            this.usernametxt.TabIndex = 2;
            // 
            // usernamelbl
            // 
            this.usernamelbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(149, 52);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(100, 23);
            this.usernamelbl.TabIndex = 3;
            this.usernamelbl.Text = "User Name : ";
            // 
            // passwordlbl
            // 
            this.passwordlbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.Location = new System.Drawing.Point(149, 112);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(100, 23);
            this.passwordlbl.TabIndex = 4;
            this.passwordlbl.Text = "Password :";
            // 
            // confrimpassword
            // 
            this.confrimpassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.confrimpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confrimpassword.Location = new System.Drawing.Point(149, 180);
            this.confrimpassword.Name = "confrimpassword";
            this.confrimpassword.Size = new System.Drawing.Size(153, 23);
            this.confrimpassword.TabIndex = 5;
            this.confrimpassword.Text = "Confrim Password";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Location = new System.Drawing.Point(378, 109);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.Size = new System.Drawing.Size(479, 26);
            this.passwordtxt.TabIndex = 6;
            this.passwordtxt.TextChanged += new System.EventHandler(this.passwordtxt_TextChanged);
            // 
            // confrimpasswordtxt
            // 
            this.confrimpasswordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confrimpasswordtxt.Location = new System.Drawing.Point(378, 174);
            this.confrimpasswordtxt.Name = "confrimpasswordtxt";
            this.confrimpasswordtxt.PasswordChar = '*';
            this.confrimpasswordtxt.Size = new System.Drawing.Size(479, 26);
            this.confrimpasswordtxt.TabIndex = 7;
            // 
            // rolebox
            // 
            this.rolebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolebox.FormattingEnabled = true;
            this.rolebox.Items.AddRange(new object[] {
            "Administrator",
            "Cashier"});
            this.rolebox.Location = new System.Drawing.Point(378, 240);
            this.rolebox.Name = "rolebox";
            this.rolebox.Size = new System.Drawing.Size(479, 28);
            this.rolebox.TabIndex = 8;
            // 
            // Rolelbl
            // 
            this.Rolelbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Rolelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rolelbl.Location = new System.Drawing.Point(149, 245);
            this.Rolelbl.Name = "Rolelbl";
            this.Rolelbl.Size = new System.Drawing.Size(100, 23);
            this.Rolelbl.TabIndex = 9;
            this.Rolelbl.Text = "Role :";
            // 
            // Fullnamelbl
            // 
            this.Fullnamelbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Fullnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fullnamelbl.Location = new System.Drawing.Point(149, 311);
            this.Fullnamelbl.Name = "Fullnamelbl";
            this.Fullnamelbl.Size = new System.Drawing.Size(100, 23);
            this.Fullnamelbl.TabIndex = 10;
            this.Fullnamelbl.Text = "Full Name :";
            // 
            // fullnametxt
            // 
            this.fullnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnametxt.Location = new System.Drawing.Point(378, 308);
            this.fullnametxt.Name = "fullnametxt";
            this.fullnametxt.Size = new System.Drawing.Size(479, 26);
            this.fullnametxt.TabIndex = 11;
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.SystemColors.Info;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Location = new System.Drawing.Point(772, 393);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(86, 27);
            this.cancelbtn.TabIndex = 38;
            this.cancelbtn.Text = " Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            // 
            // Savebtn
            // 
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Location = new System.Drawing.Point(639, 393);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(86, 27);
            this.Savebtn.TabIndex = 37;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            // 
            // unamelbl
            // 
            this.unamelbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.unamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unamelbl.Location = new System.Drawing.Point(180, 91);
            this.unamelbl.Name = "unamelbl";
            this.unamelbl.Size = new System.Drawing.Size(100, 23);
            this.unamelbl.TabIndex = 2;
            this.unamelbl.Text = "User Name :";
            // 
            // usernametext
            // 
            this.usernametext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametext.Location = new System.Drawing.Point(377, 91);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(455, 26);
            this.usernametext.TabIndex = 3;
            // 
            // cpasswordtxt
            // 
            this.cpasswordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpasswordtxt.Location = new System.Drawing.Point(377, 142);
            this.cpasswordtxt.Name = "cpasswordtxt";
            this.cpasswordtxt.Size = new System.Drawing.Size(455, 26);
            this.cpasswordtxt.TabIndex = 5;
            // 
            // cpasswordlbl
            // 
            this.cpasswordlbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cpasswordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpasswordlbl.Location = new System.Drawing.Point(180, 142);
            this.cpasswordlbl.Name = "cpasswordlbl";
            this.cpasswordlbl.Size = new System.Drawing.Size(147, 23);
            this.cpasswordlbl.TabIndex = 4;
            this.cpasswordlbl.Text = "Current Password : ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "New Password :";
            // 
            // confrompasswordtxt
            // 
            this.confrompasswordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confrompasswordtxt.Location = new System.Drawing.Point(377, 270);
            this.confrompasswordtxt.Name = "confrompasswordtxt";
            this.confrompasswordtxt.Size = new System.Drawing.Size(455, 26);
            this.confrompasswordtxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confrim Password :";
            // 
            // newpasswordtxt
            // 
            this.newpasswordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpasswordtxt.Location = new System.Drawing.Point(377, 206);
            this.newpasswordtxt.Name = "newpasswordtxt";
            this.newpasswordtxt.Size = new System.Drawing.Size(455, 26);
            this.newpasswordtxt.TabIndex = 10;
            // 
            // changecancelbtn
            // 
            this.changecancelbtn.BackColor = System.Drawing.SystemColors.Info;
            this.changecancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changecancelbtn.Location = new System.Drawing.Point(746, 383);
            this.changecancelbtn.Margin = new System.Windows.Forms.Padding(2);
            this.changecancelbtn.Name = "changecancelbtn";
            this.changecancelbtn.Size = new System.Drawing.Size(86, 27);
            this.changecancelbtn.TabIndex = 38;
            this.changecancelbtn.Text = " Cancel";
            this.changecancelbtn.UseVisualStyleBackColor = false;
            this.changecancelbtn.Click += new System.EventHandler(this.changecancelbtn_Click);
            // 
            // changesavebtn
            // 
            this.changesavebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changesavebtn.Location = new System.Drawing.Point(616, 383);
            this.changesavebtn.Margin = new System.Windows.Forms.Padding(2);
            this.changesavebtn.Name = "changesavebtn";
            this.changesavebtn.Size = new System.Drawing.Size(86, 27);
            this.changesavebtn.TabIndex = 37;
            this.changesavebtn.Text = "Save";
            this.changesavebtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1063, 449);
            this.dataGridView1.TabIndex = 2;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.Width = 5;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Brand";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            this.Column2.Width = 45;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.Width = 48;
            // 
            // DGVuser
            // 
            this.DGVuser.AllowUserToAddRows = false;
            this.DGVuser.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVuser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVuser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVuser.ColumnHeadersHeight = 30;
            this.DGVuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVuser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Edit,
            this.Delete});
            this.DGVuser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVuser.EnableHeadersVisualStyles = false;
            this.DGVuser.GridColor = System.Drawing.SystemColors.Control;
            this.DGVuser.Location = new System.Drawing.Point(0, 0);
            this.DGVuser.Margin = new System.Windows.Forms.Padding(2);
            this.DGVuser.Name = "DGVuser";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVuser.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVuser.RowHeadersVisible = false;
            this.DGVuser.RowTemplate.Height = 24;
            this.DGVuser.Size = new System.Drawing.Size(1063, 449);
            this.DGVuser.TabIndex = 4;
            // 
            // brandlowerpanel
            // 
            this.brandlowerpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.brandlowerpanel.Location = new System.Drawing.Point(6, 69);
            this.brandlowerpanel.Margin = new System.Windows.Forms.Padding(2);
            this.brandlowerpanel.Name = "brandlowerpanel";
            this.brandlowerpanel.Size = new System.Drawing.Size(1063, 77);
            this.brandlowerpanel.TabIndex = 3;
            // 
            // User_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 592);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.productlowerpanel);
            this.Name = "User_Account";
            this.Text = "User_Account";
            ((System.ComponentModel.ISupportInitialize)(this.brandlogo)).EndInit();
            this.productlowerpanel.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVuser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox brandlogo;
        private System.Windows.Forms.Label Usersetting;
        private System.Windows.Forms.Panel productlowerpanel;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.ComboBox rolebox;
        private System.Windows.Forms.TextBox confrimpasswordtxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label confrimpassword;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label Fullnamelbl;
        private System.Windows.Forms.Label Rolelbl;
        private System.Windows.Forms.TextBox fullnametxt;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.TextBox confrompasswordtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cpasswordtxt;
        private System.Windows.Forms.Label cpasswordlbl;
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.Label unamelbl;
        private System.Windows.Forms.TextBox newpasswordtxt;
        private System.Windows.Forms.Button changecancelbtn;
        private System.Windows.Forms.Button changesavebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView DGVuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Panel brandlowerpanel;
    }
}