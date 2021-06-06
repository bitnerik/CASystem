using System;
using System.Data;
using System.Data.SqlClient;
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
            listView1.Items.Clear();
            var brand = brandTextBox.Text;
            var model = modelTextBox.Text;
            var showOnlyAvailable = showOnlyAvailableCheckBox.Checked ? 1 : 0;

            string query = string.Empty;
            bool isGoodQuery = true;
            if (!string.IsNullOrEmpty(brand) && !string.IsNullOrEmpty(model))
            {
                query = $"SELECT * FROM Product WHERE (ProductBrand = '{brand}' AND ProductModel = '{model}') AND (ProductAvailable = {showOnlyAvailable} OR ProductAvailable = 1)";
            }
            else if (!string.IsNullOrEmpty(brand))
            {
                query = $"SELECT * FROM Product WHERE ProductBrand = '{brand}' AND (ProductAvailable = {showOnlyAvailable} OR ProductAvailable = 1)";
            }
            else if (!string.IsNullOrEmpty(model))
            {
                query = $"SELECT * FROM Product WHERE ProductModel = '{model}' AND (ProductAvailable = {showOnlyAvailable} OR ProductAvailable = 1)";
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
                ((ListBox)productListBox).ValueMember = "ProductID";

                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    ListViewItem item = new ListViewItem(new string[] {
                    Convert.ToString(dataReader["ProductBrand"]),
                    Convert.ToString(dataReader["ProductModel"]),
                    Convert.ToString(dataReader["ProductSellPrice"]),
                    Convert.ToString(dataReader["ProductAvailable"])});

                    listView1.Items.Add(item);
                }
                dataReader.Close();
            }
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            var dateNow = DateTime.Now.ToString();

            foreach (DataRowView item in productListBox.CheckedItems)
            {
                var itemId = item["ProductID"];
                SqlCommand command = new SqlCommand($"UPDATE Product SET ProductSellDate = '{dateNow}' WHERE ProductID = {itemId}", SqlCon.SqlConnection);
                command.ExecuteNonQuery();
            }

            MessageBox.Show($"{productListBox.CheckedItems.Count} products sold.\n{dateNow}");

            for (int i = 0; i < productListBox.Items.Count; i++)
            {
                productListBox.SetItemChecked(i, false);
            }

            checkProductButton_Click(sender, e);
        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
