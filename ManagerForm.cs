using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CASystem
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cADBDataSet1.ProductType' table. You can move, or remove it, as needed.
            this.productTypeTableAdapter1.Fill(this.cADBDataSet1.ProductType);
            // TODO: This line of code loads data into the 'cADBDataSet.ProductType' table. You can move, or remove it, as needed.
            this.productTypeTableAdapter.Fill(this.cADBDataSet.ProductType);

            SqlCommand query = new SqlCommand($"SELECT * FROM ProductType", SqlCon.SqlConnection);
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = query;
            dataAdapter.Fill(dataTable);
            productTypeComboBox.DataSource = dataTable;
            productTypeComboBox.DisplayMember = "TypeName";
            productTypeComboBox.ValueMember = "ProductTypeID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Product] (ProductBrand, ProductBuyDate, ProductModel, ProductBuyPrice, ProductSellPrice, ProductTypeID) VALUES (@ProductBrand, @ProductBuyDate, @ProductModel, @ProductBuyPrice, @ProductSellPrice, @ProductTypeID)", SqlCon.SqlConnection);

            DateTime date = buyDateTimePicker.Value;

            command.Parameters.AddWithValue("ProductBrand", textBox1.Text);
            command.Parameters.AddWithValue("ProductBuyDate", $"{date.Year}/{date.Month}/{date.Day}");
            command.Parameters.AddWithValue("ProductModel", textBox3.Text);
            command.Parameters.AddWithValue("ProductBuyPrice", textBox4.Text);
            command.Parameters.AddWithValue("ProductSellPrice", textBox5.Text);
            command.Parameters.AddWithValue("ProductTypeID", productTypeComboBox.SelectedValue);
            var updateItemsCount = command.ExecuteNonQuery();

            if (updateItemsCount >= 1)
            {
                MessageBox.Show("Item successfully added");
            }
            else
            {
                MessageBox.Show("Failed to add item");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM Product WHERE ProductTypeID = {comboBox1.SelectedValue}  and ProductAvailable = {(boughtRadioButton.Checked ? 1 : 0)}", SqlCon.SqlConnection);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            var rowCount = dataSet.Tables[0].Rows.Count;
            textBox7.Text = rowCount.ToString();
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void boughtRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (boughtRadioButton.Checked)
            {
                soldRadioButton.Checked = false;
            }
        }

        private void soldRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (soldRadioButton.Checked)
            {
                boughtRadioButton.Checked = false;
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
