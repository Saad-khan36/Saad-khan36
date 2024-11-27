namespace WindowsFormsApp1
{
    partial class ProductModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductModule));
            this.closepic = new System.Windows.Forms.PictureBox();
            this.categorymodulepanel = new System.Windows.Forms.Panel();
            this.productModulelable = new System.Windows.Forms.Label();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.textBoxproductid = new System.Windows.Forms.TextBox();
            this.productID = new System.Windows.Forms.Label();
            this.Descriptionlable = new System.Windows.Forms.Label();
            this.productnamelable = new System.Windows.Forms.Label();
            this.brandlable = new System.Windows.Forms.Label();
            this.pricelable = new System.Windows.Forms.Label();
            this.categorylable = new System.Windows.Forms.Label();
            this.productnametxtbox = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.brandcombobox = new System.Windows.Forms.ComboBox();
            this.categorycombobox = new System.Windows.Forms.ComboBox();
            this.pricetextbox = new System.Windows.Forms.TextBox();
            this.AVailbitylable = new System.Windows.Forms.Label();
            this.availbiltybox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.closepic)).BeginInit();
            this.categorymodulepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availbiltybox)).BeginInit();
            this.SuspendLayout();
            // 
            // closepic
            // 
            this.closepic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closepic.BackgroundImage")));
            this.closepic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closepic.Location = new System.Drawing.Point(904, 3);
            this.closepic.Name = "closepic";
            this.closepic.Size = new System.Drawing.Size(50, 50);
            this.closepic.TabIndex = 1;
            this.closepic.TabStop = false;
            this.closepic.Click += new System.EventHandler(this.closepic_Click);
            // 
            // categorymodulepanel
            // 
            this.categorymodulepanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.categorymodulepanel.Controls.Add(this.closepic);
            this.categorymodulepanel.Controls.Add(this.productModulelable);
            this.categorymodulepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.categorymodulepanel.Location = new System.Drawing.Point(0, 0);
            this.categorymodulepanel.Name = "categorymodulepanel";
            this.categorymodulepanel.Size = new System.Drawing.Size(966, 75);
            this.categorymodulepanel.TabIndex = 12;
            // 
            // productModulelable
            // 
            this.productModulelable.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productModulelable.Location = new System.Drawing.Point(12, 9);
            this.productModulelable.Name = "productModulelable";
            this.productModulelable.Size = new System.Drawing.Size(195, 45);
            this.productModulelable.TabIndex = 0;
            this.productModulelable.Text = "Product Module";
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.SystemColors.Info;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Location = new System.Drawing.Point(761, 431);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(114, 33);
            this.cancelbtn.TabIndex = 17;
            this.cancelbtn.Text = " Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Location = new System.Drawing.Point(613, 431);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(114, 33);
            this.Updatebtn.TabIndex = 16;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Location = new System.Drawing.Point(458, 431);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(114, 33);
            this.Savebtn.TabIndex = 15;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // textBoxproductid
            // 
            this.textBoxproductid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxproductid.Location = new System.Drawing.Point(188, 108);
            this.textBoxproductid.Name = "textBoxproductid";
            this.textBoxproductid.Size = new System.Drawing.Size(156, 26);
            this.textBoxproductid.TabIndex = 14;
            // 
            // productID
            // 
            this.productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productID.Location = new System.Drawing.Point(43, 111);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(164, 23);
            this.productID.TabIndex = 13;
            this.productID.Text = "Product ID :";
            // 
            // Descriptionlable
            // 
            this.Descriptionlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descriptionlable.Location = new System.Drawing.Point(43, 178);
            this.Descriptionlable.Name = "Descriptionlable";
            this.Descriptionlable.Size = new System.Drawing.Size(164, 23);
            this.Descriptionlable.TabIndex = 18;
            this.Descriptionlable.Text = "Description : ";
            // 
            // productnamelable
            // 
            this.productnamelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productnamelable.Location = new System.Drawing.Point(396, 114);
            this.productnamelable.Name = "productnamelable";
            this.productnamelable.Size = new System.Drawing.Size(164, 23);
            this.productnamelable.TabIndex = 19;
            this.productnamelable.Text = "Product Name : ";
            // 
            // brandlable
            // 
            this.brandlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandlable.Location = new System.Drawing.Point(43, 226);
            this.brandlable.Name = "brandlable";
            this.brandlable.Size = new System.Drawing.Size(164, 23);
            this.brandlable.TabIndex = 20;
            this.brandlable.Text = "Brand :";
            // 
            // pricelable
            // 
            this.pricelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelable.Location = new System.Drawing.Point(43, 332);
            this.pricelable.Name = "pricelable";
            this.pricelable.Size = new System.Drawing.Size(164, 23);
            this.pricelable.TabIndex = 21;
            this.pricelable.Text = "Price : ";
            // 
            // categorylable
            // 
            this.categorylable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorylable.Location = new System.Drawing.Point(43, 278);
            this.categorylable.Name = "categorylable";
            this.categorylable.Size = new System.Drawing.Size(164, 23);
            this.categorylable.TabIndex = 21;
            this.categorylable.Text = "Category :";
            // 
            // productnametxtbox
            // 
            this.productnametxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productnametxtbox.Location = new System.Drawing.Point(566, 111);
            this.productnametxtbox.Name = "productnametxtbox";
            this.productnametxtbox.Size = new System.Drawing.Size(296, 26);
            this.productnametxtbox.TabIndex = 22;
            // 
            // description
            // 
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(188, 178);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(674, 26);
            this.description.TabIndex = 23;
            // 
            // brandcombobox
            // 
            this.brandcombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandcombobox.FormattingEnabled = true;
            this.brandcombobox.Location = new System.Drawing.Point(188, 226);
            this.brandcombobox.Name = "brandcombobox";
            this.brandcombobox.Size = new System.Drawing.Size(674, 28);
            this.brandcombobox.TabIndex = 27;
            // 
            // categorycombobox
            // 
            this.categorycombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorycombobox.FormattingEnabled = true;
            this.categorycombobox.Location = new System.Drawing.Point(188, 278);
            this.categorycombobox.Name = "categorycombobox";
            this.categorycombobox.Size = new System.Drawing.Size(674, 28);
            this.categorycombobox.TabIndex = 28;
            // 
            // pricetextbox
            // 
            this.pricetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetextbox.Location = new System.Drawing.Point(188, 329);
            this.pricetextbox.Name = "pricetextbox";
            this.pricetextbox.Size = new System.Drawing.Size(209, 26);
            this.pricetextbox.TabIndex = 26;
            // 
            // AVailbitylable
            // 
            this.AVailbitylable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AVailbitylable.Location = new System.Drawing.Point(546, 332);
            this.AVailbitylable.Name = "AVailbitylable";
            this.AVailbitylable.Size = new System.Drawing.Size(164, 23);
            this.AVailbitylable.TabIndex = 29;
            this.AVailbitylable.Text = "Availbility :";
            // 
            // availbiltybox
            // 
            this.availbiltybox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availbiltybox.Location = new System.Drawing.Point(716, 329);
            this.availbiltybox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.availbiltybox.Name = "availbiltybox";
            this.availbiltybox.Size = new System.Drawing.Size(146, 26);
            this.availbiltybox.TabIndex = 30;
            // 
            // ProductModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 483);
            this.Controls.Add(this.productnametxtbox);
            this.Controls.Add(this.availbiltybox);
            this.Controls.Add(this.AVailbitylable);
            this.Controls.Add(this.categorycombobox);
            this.Controls.Add(this.brandcombobox);
            this.Controls.Add(this.pricetextbox);
            this.Controls.Add(this.description);
            this.Controls.Add(this.categorylable);
            this.Controls.Add(this.pricelable);
            this.Controls.Add(this.brandlable);
            this.Controls.Add(this.productnamelable);
            this.Controls.Add(this.Descriptionlable);
            this.Controls.Add(this.categorymodulepanel);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.textBoxproductid);
            this.Controls.Add(this.productID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductModule";
            this.Text = "ProductModule";
            this.Load += new System.EventHandler(this.ProductModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closepic)).EndInit();
            this.categorymodulepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.availbiltybox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closepic;
        private System.Windows.Forms.Panel categorymodulepanel;
        private System.Windows.Forms.Label productModulelable;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.TextBox textBoxproductid;
        private System.Windows.Forms.Label productID;
        private System.Windows.Forms.Label Descriptionlable;
        private System.Windows.Forms.Label productnamelable;
        private System.Windows.Forms.Label brandlable;
        private System.Windows.Forms.Label pricelable;
        private System.Windows.Forms.Label categorylable;
        private System.Windows.Forms.TextBox productnametxtbox;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.ComboBox brandcombobox;
        private System.Windows.Forms.ComboBox categorycombobox;
        private System.Windows.Forms.TextBox pricetextbox;
        private System.Windows.Forms.Label AVailbitylable;
        private System.Windows.Forms.NumericUpDown availbiltybox;
    }
}