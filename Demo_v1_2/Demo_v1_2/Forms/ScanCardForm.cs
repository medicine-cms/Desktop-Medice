using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_v1_2
{
    public partial class ScanCard : Form
    {        
        public ScanCard()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = DBConnect.getConnection();
            cnn.Open();

            if (cnn.State!=ConnectionState.Open) {
                MessageBox.Show("Fail");
            }
            else
            {
                MessageBox.Show("Success");
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    MessageBox.Show("Kart Okuyucuya başarılı bir şekilde Bağlanıldı.");
                }
            }
            cnn.Close();
        }
        public void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            string startsWith = "The tag's number is:";
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            int tagNumber = 0;
            try
            {
                indata.Split(Environment.NewLine.ToCharArray())      // split on newline chars
                      .FirstOrDefault(s => s.Contains(startsWith)) // get first string matching pattern above 
                      .Split(':')                                    // split on ':'
                      .FirstOrDefault(x => int.TryParse(x, out tagNumber));  // return first successful try parse
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            txtRFID.Text = tagNumber.ToString();

            // Receive Data
            SqlConnection cnn = DBConnect.getConnection();
            cnn.Open();
            string sqlSelectQuery = "SELECT * FROM HASTA WHERE KART_ID= " + int.Parse(txtRFID.Text);
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            int yas;
            DateTime dogumtarihi;

            if (dr.Read())
            {
                txtKimlikNo.Text = (dr["Hasta_TC_Kimlik_No"].ToString());
                txtAd.Text = (dr["Hasta_Ad"].ToString());
                txtSoy.Text = (dr["Hasta_Soyad"].ToString());
                dogumtarihi = Convert.ToDateTime(dr["Hasta_Dogum_Tarihi"]);
                yas = DateTime.Now.Year - dogumtarihi.Year; // Calculate age
                txtDogum.Text = yas.ToString();
                txtAlerji.Text = (dr["Alerji"].ToString());
                txtKronik.Text = (dr["Kronik_Hastalik"].ToString());
                txtHID.Text = (dr["Hasta_ID"].ToString());
            }
            cnn.Close();
        }
        private void btnRcv_Click(object sender, EventArgs e)
        {
            Prescribe prescribe = new Prescribe();
            prescribe.Show();
        }
    }
}
