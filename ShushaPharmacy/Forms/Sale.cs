using ShushaPharmacy.Data;
using ShushaPharmacy.Helper;
using ShushaPharmacy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShushaPharmacy.Forms
{
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }

        private void Sale_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.MainForm.Close();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            List<Product> products = ApplicationDbContext.Products;

            foreach (Product product in products)
            {
                dgv_products.Rows.Add(product.Id, product.Name, product.Price, product.ProductType, product.ListCount, product.ExpirationDate);
            }


        }
    }
}
