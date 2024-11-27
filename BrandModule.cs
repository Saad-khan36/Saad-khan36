using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BrandModule : Form
    {
        public BrandModule()
        {
            InitializeComponent();
        }

        private void brandmodulepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BrandModulelable_Click(object sender, EventArgs e)
        {

        }

        private void closepic_Click(object sender, EventArgs e)
        {
             this.Dispose();
        }

        private void BrandName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxbrandname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {


        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            textBoxbrandname.Clear();

        }
    }
}
