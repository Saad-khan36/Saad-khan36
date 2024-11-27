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
    public partial class ProductModule : Form
    {
        public ProductModule()
        {
            InitializeComponent();
        }
        public void clear()
        {
            textBoxproductid.Clear();
            productnametxtbox.Clear();
            description.Clear();
            pricetextbox.Clear();
            brandcombobox.SelectedIndex = 0;
            categorycombobox.SelectedIndex = 0;
            availbiltybox.Value = 0;

            textBoxproductid.Enabled = true;
            textBoxproductid.Focus();
            Savebtn.Enabled = true;
            Updatebtn.Enabled = false;
        }
        private void ProductModule_Load(object sender, EventArgs e)
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

        private void closepic_Click(object sender, EventArgs e)
        {
            this.Dispose();
 
        }
    }
}
