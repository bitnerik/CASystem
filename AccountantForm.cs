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
    public partial class AccountantForm : Form
    {
        public AccountantForm()
        {
            InitializeComponent();
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
    }
}
