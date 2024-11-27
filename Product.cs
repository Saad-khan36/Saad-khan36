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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void addproductbtn_Click(object sender, EventArgs e)
        {
            ProductModule productModule= new ProductModule();
            productModule.ShowDialog();
        }

        private void DGVproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productlowerpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void managerbrandlable_Click(object sender, EventArgs e)
        {

        }

        private void brandlogo_Click(object sender, EventArgs e)
        {

        }
    }
}
