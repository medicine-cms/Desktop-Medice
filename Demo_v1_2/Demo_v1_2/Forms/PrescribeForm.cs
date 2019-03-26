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
    public partial class Prescribe : Form
    {
        public Prescribe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Diğer formlardan value çekemediğim için buraya geçici olarak atadım "hid" ve "did" 
            int did = 1;
            int hid = 2;
            SqlConnection cnn = DBConnect.getConnection();
            SqlCommand cmd;
            cnn.Open();
            string s = "insert into ILAC(Ilac_Adi, Verildigi_Tarih, Max_Kullanim_Suresi,Kullanim_Araligi," +
                "Kullanim_Dozu,Kullanim_Sekli,Doktor_ID,Hasta_ID) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
            cmd = new SqlCommand(s, cnn);
            cmd.Parameters.AddWithValue("@p1", txtIlac.Text);
            cmd.Parameters.AddWithValue("@p2", DateTime.Now);
            cmd.Parameters.AddWithValue("@p3", txtMaxDay.Text);
            cmd.Parameters.AddWithValue("@p4", txtRange.Text);
            cmd.Parameters.AddWithValue("@p5", txtDose.Text);
            cmd.Parameters.AddWithValue("@p6", txtUsage.Text);
            cmd.Parameters.AddWithValue("@p7", did);
            cmd.Parameters.AddWithValue("@p8", hid);
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show(i + " Row(s) Inserted ");
        }       
    }
}
