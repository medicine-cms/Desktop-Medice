namespace Demo_v1_2
{
    partial class Prescribe
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.txtDose = new System.Windows.Forms.TextBox();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.txtMaxDay = new System.Windows.Forms.TextBox();
            this.txtCurrentDate = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIlac = new System.Windows.Forms.TextBox();
            this.btnRecete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Kullanım Şekli";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Kullanım Dozu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Kullanım Aralığı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Azami Kullanım Süresi (Gün)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Verildiği Tarih";
            // 
            // txtUsage
            // 
            this.txtUsage.Location = new System.Drawing.Point(222, 266);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(146, 22);
            this.txtUsage.TabIndex = 22;
            // 
            // txtDose
            // 
            this.txtDose.Location = new System.Drawing.Point(222, 221);
            this.txtDose.Name = "txtDose";
            this.txtDose.Size = new System.Drawing.Size(146, 22);
            this.txtDose.TabIndex = 21;
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(222, 176);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(146, 22);
            this.txtRange.TabIndex = 20;
            // 
            // txtMaxDay
            // 
            this.txtMaxDay.Location = new System.Drawing.Point(222, 130);
            this.txtMaxDay.Name = "txtMaxDay";
            this.txtMaxDay.Size = new System.Drawing.Size(146, 22);
            this.txtMaxDay.TabIndex = 19;
            // 
            // txtCurrentDate
            // 
            this.txtCurrentDate.Location = new System.Drawing.Point(222, 83);
            this.txtCurrentDate.Name = "txtCurrentDate";
            this.txtCurrentDate.Size = new System.Drawing.Size(146, 22);
            this.txtCurrentDate.TabIndex = 18;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(279, 351);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(89, 34);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "Sonraki İlaç";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "İlaç Adı";
            // 
            // txtIlac
            // 
            this.txtIlac.Location = new System.Drawing.Point(222, 35);
            this.txtIlac.Name = "txtIlac";
            this.txtIlac.Size = new System.Drawing.Size(146, 22);
            this.txtIlac.TabIndex = 15;
            // 
            // btnRecete
            // 
            this.btnRecete.Location = new System.Drawing.Point(12, 346);
            this.btnRecete.Name = "btnRecete";
            this.btnRecete.Size = new System.Drawing.Size(126, 45);
            this.btnRecete.TabIndex = 29;
            this.btnRecete.Text = "Reçeteyi Gönder";
            this.btnRecete.UseVisualStyleBackColor = true;
            this.btnRecete.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 421);
            this.Controls.Add(this.btnRecete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsage);
            this.Controls.Add(this.txtDose);
            this.Controls.Add(this.txtRange);
            this.Controls.Add(this.txtMaxDay);
            this.Controls.Add(this.txtCurrentDate);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIlac);
            this.Name = "PrescribeForm";
            this.Text = "Reçete Yaz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.TextBox txtDose;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.TextBox txtMaxDay;
        private System.Windows.Forms.TextBox txtCurrentDate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIlac;
        private System.Windows.Forms.Button btnRecete;
    }
}