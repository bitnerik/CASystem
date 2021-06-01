using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CASystem
{
    public partial class ManagerForm : Form
    {
        private SqlConnection sqlConnection;
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
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CADB"].ConnectionString);

            sqlConnection.Open();

            if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Connection established");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Product] (ProductBrand, ProductBuyDate, ProductModel, ProductBuyPrice, ProductSellPrice, ProductTypeID) VALUES (@ProductBrand, @ProductBuyDate, @ProductModel, @ProductBuyPrice, @ProductSellPrice, @ProductTypeID)", sqlConnection);

            DateTime date = DateTime.Parse(textBox2.Text);

            command.Parameters.AddWithValue("ProductBrand", textBox1.Text);
            command.Parameters.AddWithValue("ProductBuyDate", $"{date.Year}/{date.Month}/{date.Day}");
            command.Parameters.AddWithValue("ProductModel", textBox3.Text);
            command.Parameters.AddWithValue("ProductBuyPrice", textBox4.Text);
            command.Parameters.AddWithValue("ProductSellPrice", textBox5.Text);
            command.Parameters.AddWithValue("ProductTypeID", textBox6.Text);

            MessageBox.Show(command.ExecuteNonQuery().ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM Product WHERE ProductTypeID = {comboBox1.SelectedValue}  and ProductAvailable = 1", sqlConnection);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            var rowCount = dataSet.Tables[0].Rows.Count;
            textBox7.Text = rowCount.ToString();
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
