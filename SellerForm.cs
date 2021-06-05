using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASystem
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }

        private void checkProductButton_Click(object sender, EventArgs e)
        {
            var brand = brandTextBox.Text;
            var model = modelTextBox.Text;

            string query = string.Empty;
            bool isGoodQuery = true;
            if (!string.IsNullOrEmpty(brand) && !string.IsNullOrEmpty(model))
            {
                query = $"SELECT * FROM Product WHERE ProductBrand = '{brand}' AND ProductModel = '{model}' AND ProductAvailable = 1";
            }
            else if (!string.IsNullOrEmpty(brand))
            {
                query = $"SELECT * FROM Product WHERE ProductBrand = '{brand}' AND ProductAvailable = 1";
            }
            else if (!string.IsNullOrEmpty(model))
            {
                query = $"SELECT * FROM Product WHERE ProductModel = '{model}' AND ProductAvailable = 1";
            }
            else
            {
                MessageBox.Show("Please input value");
                isGoodQuery = false;
            }

            if (isGoodQuery)
            {
                SqlCommand command = new SqlCommand(query, SqlCon.SqlConnection);
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);

                ((ListBox)productListBox).DataSource = dataTable;
                ((ListBox)productListBox).DisplayMember = "ProductBrand";
                ((ListBox)productListBox).ValueMember = "ProductID";
            }
        }
    }
}
