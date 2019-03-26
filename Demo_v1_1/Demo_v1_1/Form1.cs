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

namespace Demo_v1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MedicineCMS;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
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
                }

                MessageBox.Show("Kart Okuyucuya başarılı bir şekilde Bağlanıldı.");
            }
            

        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                //textRFID.Text = serialPort1.ReadLine();
                MessageBox.Show(serialPort1.ReadLine());
            }
            catch (Exception) {
                MessageBox.Show("veri gelmedi");
                    }
        }
    }
}
