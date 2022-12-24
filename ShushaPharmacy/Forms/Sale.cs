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
            ApplicationDbContext.Products.ForEach(product =>
            {
                dgv_products.Rows.Add(product.Id, product.Name, product.Price, product.ProductType, product.ListCount, product.ExpirationDate);
            });

        }

        private void txbx_name_KeyUp(object sender, KeyEventArgs e)
        {

            dgv_products.Rows.Clear();

            string price = txbx_price.Text;
            string productName = txbx_name.Text.ToLower();
            string Id = txbx_id.Text;

            //Price validation
            if(price == "" || price == null) { price = "0"; }
            decimal productPrice;
            if (decimal.TryParse(price, out productPrice) == false)
            {
                MessageBox.Show("Please enter the correct price!");
                return;
            }

            //Id validation
            if (Id == "" || Id == null) { Id = "0"; }
            int productId;
            if (int.TryParse(Id, out productId) == false)
            {
                MessageBox.Show("Please enter the correct Id!");
                return;
            }


            Filter(productName, productPrice, productId);

        }

        private void txbx_price_KeyUp(object sender, KeyEventArgs e)
        {
            dgv_products.Rows.Clear();

            string price = txbx_price.Text;
            string productName = txbx_name.Text.ToLower();
            string Id = txbx_id.Text;

            //Price validation
            if (price == "" || price == null) { price = "0"; }
            decimal productPrice;
            if (decimal.TryParse(price, out productPrice) == false)
            {
                MessageBox.Show("Please enter the correct price!");
                return;
            }

            //Id validation
            if (Id == "" || Id == null) { Id = "0"; }
            int productId;
            if (int.TryParse(Id, out productId) == false)
            {
                MessageBox.Show("Please enter the correct Id!");
                return;
            }


            Filter(productName, productPrice,productId);

        }




        private void Filter(string productName,decimal productPrice,int productId)
        {
            ApplicationDbContext.Products
                                   .Where(p => p.Name.ToLower().StartsWith(productName) == true &&
                                               (productPrice != 0 ? p.Price == productPrice : true) &&
                                               (productId !=0 ? p.Id == productId:true))

                                   .ToList()
                                   .ForEach(product =>
                                   {
                                       dgv_products.Rows.Add(product.Id,
                                                                product.Name,
                                                                product.Price,
                                                                product.ProductType,
                                                                product.ListCount,
                                                                product.ExpirationDate);

                                   });
        }

        private void txbx_id_KeyUp(object sender, KeyEventArgs e)
        {

            dgv_products.Rows.Clear();

            string price = txbx_price.Text;
            string productName = txbx_name.Text.ToLower();
            string Id = txbx_id.Text;

            //Price validation
            if (price == "" || price == null) { price = "0"; }
            decimal productPrice;
            if (decimal.TryParse(price, out productPrice) == false)
            {
                MessageBox.Show("Please enter the correct price!");
                return;
            }

            //Id validation
            if (Id == "" || Id == null) { Id = "0"; }
            int productId;
            if (int.TryParse(Id, out productId) == false)
            {
                MessageBox.Show("Please enter the correct Id!");
                return;
            }


            Filter(productName, productPrice, productId);

        }
    }
}
