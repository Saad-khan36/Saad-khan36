namespace WindowsFormsApp1
{
    partial class categoryModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(categoryModule));
            this.categorymodulepanel = new System.Windows.Forms.Panel();
            this.closepic = new System.Windows.Forms.PictureBox();
            this.categoryModulelable = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.textBoxcategoryname = new System.Windows.Forms.TextBox();
            this.categoryName = new System.Windows.Forms.Label();
            this.categorymodulepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closepic)).BeginInit();
            this.SuspendLayout();
            // 
            // categorymodulepanel
            // 
            this.categorymodulepanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.categorymodulepanel.Controls.Add(this.closepic);
            this.categorymodulepanel.Controls.Add(this.categoryModulelable);
            this.categorymodulepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.categorymodulepanel.Location = new System.Drawing.Point(0, 0);
            this.categorymodulepanel.Name = "categorymodulepanel";
            this.categorymodulepanel.Size = new System.Drawing.Size(858, 75);
            this.categorymodulepanel.TabIndex = 6;
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
            // categoryModulelable
            // 
            this.categoryModulelable.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryModulelable.Location = new System.Drawing.Point(12, 37);
            this.categoryModulelable.Name = "categoryModulelable";
            this.categoryModulelable.Size = new System.Drawing.Size(195, 23);
            this.categoryModulelable.TabIndex = 0;
            this.categoryModulelable.Text = "Category Module";
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.SystemColors.Info;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Location = new System.Drawing.Point(671, 236);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(114, 33);
            this.cancelbtn.TabIndex = 11;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Location = new System.Drawing.Point(523, 236);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(114, 33);
            this.Updatebtn.TabIndex = 10;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            // 
            // Savebtn
            // 
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Location = new System.Drawing.Point(368, 236);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(114, 33);
            this.Savebtn.TabIndex = 9;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // textBoxcategoryname
            // 
            this.textBoxcategoryname.Location = new System.Drawing.Point(237, 185);
            this.textBoxcategoryname.Name = "textBoxcategoryname";
            this.textBoxcategoryname.Size = new System.Drawing.Size(548, 22);
            this.textBoxcategoryname.TabIndex = 8;
            this.textBoxcategoryname.TextChanged += new System.EventHandler(this.textBoxcategoryname_TextChanged);
            // 
            // categoryName
            // 
            this.categoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryName.Location = new System.Drawing.Point(48, 182);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(146, 23);
            this.categoryName.TabIndex = 7;
            this.categoryName.Text = "Category Name :";
            // 
            // categoryModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 280);
            this.Controls.Add(this.categorymodulepanel);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.textBoxcategoryname);
            this.Controls.Add(this.categoryName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "categoryModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "categoryModule";
            this.categorymodulepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel categorymodulepanel;
        private System.Windows.Forms.PictureBox closepic;
        private System.Windows.Forms.Label categoryModulelable;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.TextBox textBoxcategoryname;
        private System.Windows.Forms.Label categoryName;
    }
}