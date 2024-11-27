namespace WindowsFormsApp1
{
    partial class BrandModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandModule));
            this.brandmodulepanel = new System.Windows.Forms.Panel();
            this.BrandModulelable = new System.Windows.Forms.Label();
            this.closepic = new System.Windows.Forms.PictureBox();
            this.BrandName = new System.Windows.Forms.Label();
            this.textBoxbrandname = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.brandmodulepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closepic)).BeginInit();
            this.SuspendLayout();
            // 
            // brandmodulepanel
            // 
            this.brandmodulepanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.brandmodulepanel.Controls.Add(this.closepic);
            this.brandmodulepanel.Controls.Add(this.BrandModulelable);
            this.brandmodulepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.brandmodulepanel.Location = new System.Drawing.Point(0, 0);
            this.brandmodulepanel.Name = "brandmodulepanel";
            this.brandmodulepanel.Size = new System.Drawing.Size(874, 75);
            this.brandmodulepanel.TabIndex = 0;
            this.brandmodulepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.brandmodulepanel_Paint);
            // 
            // BrandModulelable
            // 
            this.BrandModulelable.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandModulelable.Location = new System.Drawing.Point(12, 37);
            this.BrandModulelable.Name = "BrandModulelable";
            this.BrandModulelable.Size = new System.Drawing.Size(160, 23);
            this.BrandModulelable.TabIndex = 0;
            this.BrandModulelable.Text = "Brand Module";
            this.BrandModulelable.Click += new System.EventHandler(this.BrandModulelable_Click);
            // 
            // closepic
            // 
            this.closepic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closepic.BackgroundImage")));
            this.closepic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closepic.Location = new System.Drawing.Point(812, 12);
            this.closepic.Name = "closepic";
            this.closepic.Size = new System.Drawing.Size(50, 50);
            this.closepic.TabIndex = 1;
            this.closepic.TabStop = false;
            this.closepic.Click += new System.EventHandler(this.closepic_Click);
            // 
            // BrandName
            // 
            this.BrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandName.Location = new System.Drawing.Point(48, 171);
            this.BrandName.Name = "BrandName";
            this.BrandName.Size = new System.Drawing.Size(146, 23);
            this.BrandName.TabIndex = 1;
            this.BrandName.Text = "Brand Name :";
            this.BrandName.Click += new System.EventHandler(this.BrandName_Click);
            // 
            // textBoxbrandname
            // 
            this.textBoxbrandname.Location = new System.Drawing.Point(237, 174);
            this.textBoxbrandname.Name = "textBoxbrandname";
            this.textBoxbrandname.Size = new System.Drawing.Size(548, 22);
            this.textBoxbrandname.TabIndex = 2;
            this.textBoxbrandname.TextChanged += new System.EventHandler(this.textBoxbrandname_TextChanged);
            // 
            // Savebtn
            // 
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Location = new System.Drawing.Point(368, 225);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(114, 33);
            this.Savebtn.TabIndex = 3;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Location = new System.Drawing.Point(523, 225);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(114, 33);
            this.Updatebtn.TabIndex = 4;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.SystemColors.Info;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Location = new System.Drawing.Point(671, 225);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(114, 33);
            this.cancelbtn.TabIndex = 5;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // BrandModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 319);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.textBoxbrandname);
            this.Controls.Add(this.BrandName);
            this.Controls.Add(this.brandmodulepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BrandModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrandModule";
            this.brandmodulepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel brandmodulepanel;
        private System.Windows.Forms.PictureBox closepic;
        private System.Windows.Forms.Label BrandModulelable;
        private System.Windows.Forms.Label BrandName;
        private System.Windows.Forms.TextBox textBoxbrandname;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}