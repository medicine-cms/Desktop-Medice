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

namespace Demo_v1_2
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            SqlConnection cnn = DBConnect.getConnection();
            SqlCommand cmd;
            SqlDataReader dr;
            cmd = new SqlCommand();
            cnn.Open();

            cmd.Connection = cnn;
            cmd.CommandText = "SELECT * FROM DOKTOR where Doktor_ID='" + txtUser.Text + "' AND Doktor_Password='" + txtPass.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                ScanCard frm1 = new ScanCard();
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            cnn.Close();
        }
        public TextBox tbText {
            get {
                return txtUser ;
            }
        }
    }
}
