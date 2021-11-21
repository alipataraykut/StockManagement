using StockManagement.DataAccess.Abstract;
using StockManagement.DataAccess.Concrete.EntityFramework;
using StockManagement.Entities.Concrete;
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

namespace StockManagement.UIForms
{
    public partial class FrmLogin : Form
    {
        private IUserDal _userDal;
        public FrmLogin()
        {
            InitializeComponent();
            _userDal = new EfUserDal();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            tbxUserName.Text = "admin";
            tbxPassword.Text = "12345";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
                Application.Exit();
            else
                e.Cancel = true;
        }

        FrmProducts _frmProducts = new FrmProducts();
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //Ado.Net KODU
            //AuthanticateUser(tbxUserName.Text, tbxPassword.Text);

            //EntityFramework KODU
            if (_userDal.AuthanticationSuccess(new User { Username = tbxUserName.Text, _Password = tbxPassword.Text }) == true)
            {
                this.Hide();
                _frmProducts.Show();
            }
            else
                MessageBox.Show("Lütfen bilgilerinizi kontrol ediniz!");
        }

        //Ado.Net KODU
        private void AuthanticateUser(string userName, string password)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("Select * from Users where Username = @userName and _Password = @password", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@userName", userName);
            sqlCommand.Parameters.AddWithValue("@password", password);

            /*Potansiyel SQL Injection Saldırısı
            SqlCommand sqlCommand = new SqlCommand(
                "Select * from Users where Username = '" + tbxUserName.Text + "' and _Password = '" + tbxPassword.Text + "'", sqlConnection);
            sqlCommand.ExecuteNonQuery();*/

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.HasRows)
            {
                this.Hide();
                FrmProducts frmProducts = new FrmProducts();
                frmProducts.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da parolanız hatalı!");
                this.Show();
            }
            sqlDataReader.Close();
            sqlConnection.Close();
        }
    }
}
