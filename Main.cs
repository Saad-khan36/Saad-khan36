﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
            customizedesign();
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) 
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            titlelable.Text = childForm.Text;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront(); 
            childForm.Show();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void customizedesign()
        {
            panelsubpro.Visible = false;
            panelsubstock.Visible = false;
            panelsubrecord.Visible = false;
            panelsubsetting.Visible = false;
        }
        #region panelslide
        private void hidesubmenu()
        {
            if (panelsubpro.Visible == true)
                panelsubpro.Visible = false;
            if (panelsubstock.Visible == true)
                panelsubstock.Visible = false;
            if (panelsubrecord.Visible == true)
                panelsubrecord.Visible = false;
            if (panelsubsetting.Visible == true)
                panelsubsetting.Visible = false;
        }
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        #endregion panelslide
        

        private void Productbtn_Click(object sender, EventArgs e)
        {
        showsubmenu(panelsubpro);
        }
        

        private void dashboardbtn_Click(object sender, EventArgs e)
        {

        }

        private void productlistbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Product());
            hidesubmenu();
        }

        private void categorybtn_Click(object sender, EventArgs e)
        {
            openChildForm(new category());
            hidesubmenu();
        }

        private void brandbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Brand());
            hidesubmenu();
        }

        private void stockentry_Click(object sender, EventArgs e)
        {

        }

        private void adjustmentbtn_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }


        private void recordbtn_Click(object sender, EventArgs e)
        {

        }

        private void salrhistorybtn_Click(object sender, EventArgs e)
        {

        }

        private void POSrecordbtn_Click(object sender, EventArgs e)
        {

        }

        private void settingbtn_Click(object sender, EventArgs e)
        {

        }

        private void Userbtn_Click(object sender, EventArgs e)
        {

        }

        private void storebtn_Click(object sender, EventArgs e)
        {

        }
        

        private void instockbtn_Click(object sender, EventArgs e)
        {
            showsubmenu(panelsubstock);
        }

        private void stcokadjustmentbtn_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void stockentrybtn_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void supllierbtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Supplier());
        }

        private void recordbtn_Click_1(object sender, EventArgs e)
        {
            showsubmenu(panelsubrecord);
        }

        private void salerecordbtn_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void POSrecordbtn_Click_1(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void setting_Click(object sender, EventArgs e)
        {
            showsubmenu(panelsubsetting);
        }

        private void userbtn_Click_1(object sender, EventArgs e)

        {
            openChildForm(new User_Account());
            hidesubmenu();
        }

        private void storebtn_Click_1(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            hidesubmenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
