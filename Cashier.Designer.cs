namespace WindowsFormsApp1
{
    partial class Cashier
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
            this.htmlPanel1 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.cashierlogopanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cashierlogopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.AutoScroll = true;
            this.htmlPanel1.AutoScrollMinSize = new System.Drawing.Size(75, 18);
            this.htmlPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel1.Location = new System.Drawing.Point(0, 0);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.Size = new System.Drawing.Size(75, 23);
            this.htmlPanel1.TabIndex = 0;
            this.htmlPanel1.Text = "htmlPanel1";
            // 
            // cashierlogopanel
            // 
            this.cashierlogopanel.Controls.Add(this.panel1);
            this.cashierlogopanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.cashierlogopanel.Location = new System.Drawing.Point(0, 0);
            this.cashierlogopanel.Name = "cashierlogopanel";
            this.cashierlogopanel.Size = new System.Drawing.Size(200, 664);
            this.cashierlogopanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 148);
            this.panel1.TabIndex = 0;
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 664);
            this.Controls.Add(this.cashierlogopanel);
            this.Controls.Add(this.htmlPanel1);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.cashierlogopanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel1;
        private System.Windows.Forms.Panel cashierlogopanel;
        private System.Windows.Forms.Panel panel1;
    }
}