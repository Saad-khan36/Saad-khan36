namespace WindowsFormsApp1
{
    partial class category
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(category));
            this.DGVcategory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.managercategorylable = new System.Windows.Forms.Label();
            this.brandlowerpanel = new System.Windows.Forms.Panel();
            this.addbrandbtn = new System.Windows.Forms.Button();
            this.categorylogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcategory)).BeginInit();
            this.brandlowerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorylogo)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVcategory
            // 
            this.DGVcategory.AllowUserToAddRows = false;
            this.DGVcategory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVcategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVcategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVcategory.ColumnHeadersHeight = 30;
            this.DGVcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVcategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Edit,
            this.Delete});
            this.DGVcategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVcategory.EnableHeadersVisualStyles = false;
            this.DGVcategory.GridColor = System.Drawing.SystemColors.Control;
            this.DGVcategory.Location = new System.Drawing.Point(0, 0);
            this.DGVcategory.Name = "DGVcategory";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVcategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVcategory.RowHeadersVisible = false;
            this.DGVcategory.RowTemplate.Height = 24;
            this.DGVcategory.Size = new System.Drawing.Size(800, 371);
            this.DGVcategory.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.Width = 48;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            this.Column2.Width = 45;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Brand";
            this.Column3.Name = "Column3";
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // managercategorylable
            // 
            this.managercategorylable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managercategorylable.Location = new System.Drawing.Point(57, 34);
            this.managercategorylable.Name = "managercategorylable";
            this.managercategorylable.Size = new System.Drawing.Size(209, 34);
            this.managercategorylable.TabIndex = 0;
            this.managercategorylable.Text = "Manage Category";
            // 
            // brandlowerpanel
            // 
            this.brandlowerpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.brandlowerpanel.Controls.Add(this.addbrandbtn);
            this.brandlowerpanel.Controls.Add(this.categorylogo);
            this.brandlowerpanel.Controls.Add(this.managercategorylable);
            this.brandlowerpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.brandlowerpanel.Location = new System.Drawing.Point(0, 371);
            this.brandlowerpanel.Name = "brandlowerpanel";
            this.brandlowerpanel.Size = new System.Drawing.Size(800, 79);
            this.brandlowerpanel.TabIndex = 2;
            // 
            // addbrandbtn
            // 
            this.addbrandbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addbrandbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addbrandbtn.BackgroundImage")));
            this.addbrandbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addbrandbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbrandbtn.Location = new System.Drawing.Point(716, 15);
            this.addbrandbtn.Name = "addbrandbtn";
            this.addbrandbtn.Size = new System.Drawing.Size(72, 64);
            this.addbrandbtn.TabIndex = 3;
            this.addbrandbtn.UseVisualStyleBackColor = true;
            this.addbrandbtn.Click += new System.EventHandler(this.addbrandbtn_Click);
            // 
            // categorylogo
            // 
            this.categorylogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("categorylogo.BackgroundImage")));
            this.categorylogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.categorylogo.Location = new System.Drawing.Point(3, 26);
            this.categorylogo.Name = "categorylogo";
            this.categorylogo.Size = new System.Drawing.Size(50, 42);
            this.categorylogo.TabIndex = 1;
            this.categorylogo.TabStop = false;
            // 
            // category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVcategory);
            this.Controls.Add(this.brandlowerpanel);
            this.Name = "category";
            this.Text = "category";
            ((System.ComponentModel.ISupportInitialize)(this.DGVcategory)).EndInit();
            this.brandlowerpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categorylogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Label managercategorylable;
        private System.Windows.Forms.Panel brandlowerpanel;
        private System.Windows.Forms.Button addbrandbtn;
        private System.Windows.Forms.PictureBox categorylogo;
    }
}