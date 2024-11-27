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
    public partial class suppliermodule : Form
    {
        public void clear()
        {
            supplieraddresstxt.Clear();
            textBoxsuppliername.Clear();
            emailtxtbox.Clear();
            phonenumbertxt.Clear();
            faxnumbertxt.Clear();
            contactpersontxt.Clear();

            Savebtn.Enabled = true;
            Updatebtn.Enabled = false;
            textBoxsuppliername.Focus();
        }
        public suppliermodule()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void suppliermodule_Load(object sender, EventArgs e)
        {

        }

        private void closepic_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
