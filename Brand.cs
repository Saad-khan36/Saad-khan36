﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Brand : Form
    {
        public Brand()
        {
            InitializeComponent();
        }
                                                                                                                          
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void managerbrandlable_Click(object sender, EventArgs e)
        {
             
        }

        private void addbrandbtn_Click(object sender, EventArgs e)
        {
            BrandModule brandModule = new BrandModule();
            brandModule.ShowDialog();
        }
    }
}
