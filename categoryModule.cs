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
    public partial class categoryModule : Form
    {
        public categoryModule()
        {
            InitializeComponent();
        }
        public void clear()
        {
            textBoxcategoryname.Clear();
            textBoxcategoryname.Focus();
            Savebtn.Enabled = true;
            Updatebtn.Enabled = false;
        }

        private void textBoxcategoryname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void closepic_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
