namespace Demo_v1_2
{
    partial class ScanCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtRFID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnRcv = new System.Windows.Forms.Button();
            this.txtKimlikNo = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoy = new System.Windows.Forms.TextBox();
            this.txtDogum = new System.Windows.Forms.TextBox();
            this.txtAlerji = new System.Windows.Forms.TextBox();
            this.txtKronik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRFID
            // 
            this.txtRFID.Location = new System.Drawing.Point(115, 28);
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.Size = new System.Drawing.Size(146, 22);
            this.txtRFID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "RFID";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnRcv
            // 
            this.btnRcv.Location = new System.Drawing.Point(283, 351);
            this.btnRcv.Name = "btnRcv";
            this.btnRcv.Size = new System.Drawing.Size(89, 51);
            this.btnRcv.TabIndex = 2;
            this.btnRcv.Text = "Reçete Yaz";
            this.btnRcv.UseVisualStyleBackColor = true;
            this.btnRcv.Click += new System.EventHandler(this.btnRcv_Click);
            // 
            // txtKimlikNo
            // 
            this.txtKimlikNo.Location = new System.Drawing.Point(115, 76);
            this.txtKimlikNo.Name = "txtKimlikNo";
            this.txtKimlikNo.ReadOnly = true;
            this.txtKimlikNo.Size = new System.Drawing.Size(146, 22);
            this.txtKimlikNo.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(115, 123);
            this.txtAd.Name = "txtAd";
            this.txtAd.ReadOnly = true;
            this.txtAd.Size = new System.Drawing.Size(146, 22);
            this.txtAd.TabIndex = 4;
            // 
            // txtSoy
            // 
            this.txtSoy.Location = new System.Drawing.Point(115, 169);
            this.txtSoy.Name = "txtSoy";
            this.txtSoy.ReadOnly = true;
            this.txtSoy.Size = new System.Drawing.Size(146, 22);
            this.txtSoy.TabIndex = 5;
            // 
            // txtDogum
            // 
            this.txtDogum.Location = new System.Drawing.Point(115, 214);
            this.txtDogum.Name = "txtDogum";
            this.txtDogum.ReadOnly = true;
            this.txtDogum.Size = new System.Drawing.Size(146, 22);
            this.txtDogum.TabIndex = 6;
            // 
            // txtAlerji
            // 
            this.txtAlerji.Location = new System.Drawing.Point(115, 259);
            this.txtAlerji.Name = "txtAlerji";
            this.txtAlerji.ReadOnly = true;
            this.txtAlerji.Size = new System.Drawing.Size(146, 22);
            this.txtAlerji.TabIndex = 7;
            // 
            // txtKronik
            // 
            this.txtKronik.Location = new System.Drawing.Point(115, 296);
            this.txtKronik.Name = "txtKronik";
            this.txtKronik.ReadOnly = true;
            this.txtKronik.Size = new System.Drawing.Size(146, 22);
            this.txtKronik.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "TC Kimlik No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hastanın Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hastanın Soyadı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hastanın Yaşı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Alerji Durumu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kronik Hastalığı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Hasta ID";
            // 
            // txtHID
            // 
            this.txtHID.Location = new System.Drawing.Point(115, 335);
            this.txtHID.Name = "txtHID";
            this.txtHID.ReadOnly = true;
            this.txtHID.Size = new System.Drawing.Size(146, 22);
            this.txtHID.TabIndex = 15;
            // 
            // ScanCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 414);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKronik);
            this.Controls.Add(this.txtAlerji);
            this.Controls.Add(this.txtDogum);
            this.Controls.Add(this.txtSoy);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtKimlikNo);
            this.Controls.Add(this.btnRcv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRFID);
            this.Name = "ScanCard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRFID;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnRcv;
        private System.Windows.Forms.TextBox txtKimlikNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoy;
        private System.Windows.Forms.TextBox txtDogum;
        private System.Windows.Forms.TextBox txtAlerji;
        private System.Windows.Forms.TextBox txtKronik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHID;
    }
}

