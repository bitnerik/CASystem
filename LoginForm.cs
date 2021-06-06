using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CASystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cADBDataSet2.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.cADBDataSet2.User);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            var userId = comboBox1.SelectedValue;
            var userPassword = PasswordTextBox.Text;

            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand($"SELECT * FROM [User] WHERE  UserID = {userId} AND Password = '{userPassword}'", SqlCon.SqlConnection);
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count < 1)
            {
                MessageBox.Show("Failed to login");
            }
            else
            {
                MessageBox.Show("Login successful");
                switch (userId)
                {
                    case (int)UserRoleEnum.Director:
                        this.Hide();
                        var directorForm = new DirectorForm();
                        directorForm.ShowDialog();
                        this.Close();
                        break;
                    case (int)UserRoleEnum.Seller:
                        this.Hide();
                        var sellerForm = new SellerForm();
                        sellerForm.ShowDialog();
                        this.Close();
                        break;
                    case (int)UserRoleEnum.Accoountant:
                        this.Hide();
                        var accoountantForm = new AccountantForm();
                        accoountantForm.ShowDialog();
                        this.Close();
                        break;
                    case (int)UserRoleEnum.Manager:
                        this.Hide();
                        var managerForm = new ManagerForm();
                        managerForm.ShowDialog();
                        this.Close();
                        break;
                    default:
                        break;
                }
            }
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.PerformClick();
            }
        }
    }
}
