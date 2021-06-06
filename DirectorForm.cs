using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CASystem
{
    public partial class DirectorForm : Form
    {
        public DirectorForm()
        {
            InitializeComponent();
        }

        private void DirectorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cADBDataSet1.ProductType' table. You can move, or remove it, as needed.
            this.productTypeTableAdapter1.Fill(this.cADBDataSet1.ProductType);
            // TODO: This line of code loads data into the 'cADBDataSet.ProductType' table. You can move, or remove it, as needed.
            this.productTypeTableAdapter.Fill(this.cADBDataSet.ProductType);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM Product WHERE ProductTypeID = {comboBox1.SelectedValue}  and ProductAvailable = {(soldRadioButton.Checked ? 1 : 0)}", SqlCon.SqlConnection);

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

        private void calculateButton_Click(object sender, EventArgs e)
        {
            var dateFrom = dateTimeFromPicker.Value.Date.ToString("yyyy-MM-dd");
            var dateTill = dateTimeTillPicker.Value.Date.ToString("yyyy-MM-dd");

            var query = $"SELECT SUM(ProductSellPrice) AS Sold, SUM(ProductBuyPrice) AS Bought, SUM(ProductSellPrice) - SUM(ProductBuyPrice) AS Income FROM Product WHERE ProductSellDate >= '{dateFrom}' AND ProductSellDate <= '{dateTill}'";

            SqlCommand command = new SqlCommand(query, SqlCon.SqlConnection);
            SqlDataReader dataReader = command.ExecuteReader();

            dataReader.Read();
            incomeBox.Text = Convert.ToString(dataReader["Income"]) + '€';
            soldBox.Text = Convert.ToString(dataReader["Sold"]) + '€';
            boughtBox.Text = Convert.ToString(dataReader["Bought"]) + '€';
            dataReader.Close();
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
