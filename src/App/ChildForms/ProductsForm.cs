using System;
using System.Windows.Forms;
using AppCore.Enums.ProductStatusEnum;
using System.Collections.Generic;
using MyProducts;

namespace MyManagementApp.ChildForms

{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();

            cbxProdStatus.DataSource = Enum.GetValues(typeof(ProductStatusEnum));


            btnProdSave.Click += btnProdSave_Click;

            ProductGridNew.DataSource = _productsList;
        }
        private void tbxProductID_Leave(object sender, EventArgs e)
        {
            if (tbxProductID.Text.Length > 0)
            {
                //string prodID = tbxProductID.Text;
            }


        }
        private void tbxProdDescription_Leave(object sender, EventArgs e)
        {
            if (tbxProdDescription.Text.Length > 0)
            {
                //string prodDescript = tbxProdDescription.Text;
            }
        }
        private void btnProdSave_Click(object sender, EventArgs e)
        {

            // validations
            if (tbxProductID.Text.Length > 0)
            {
                //string prodID = tbxProductID.Text;
            }



            // save or update
            SaveProduct(tbxProdDescription.Text, tbxProdBrand.Text, decimal.Parse(txtProdPrice.Text), 
                (ProductStatusEnum)Enum.Parse(typeof(ProductStatusEnum), 
                cbxProdStatus.SelectedItem.ToString()));
            ProductGridNew.SetDataBinding(_productsList, null, false);
 
        }



        // application layer - 
        private List<Product> _productsList = new List<Product>();
        private void SaveProduct(string productName, string brand, decimal price, ProductStatusEnum status)
        {

            var productID = _productsList.Count + 1;

            var product = new Product() { 
                ProductID = productID, 
                ProductName = productName, 
                Brand = brand, 
                Price = price,
                Status = status
            };
            _productsList.Add(product);

        }
    }
}

