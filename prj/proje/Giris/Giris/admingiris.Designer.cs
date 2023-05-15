
namespace Giris
{
    partial class admingiris
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnveri = new System.Windows.Forms.Button();
            this.MskTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.DtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btntmzl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 169);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(811, 157);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 131;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadı";
            this.columnHeader3.Width = 133;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon";
            this.columnHeader4.Width = 133;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Gün";
            this.columnHeader5.Width = 105;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ücret";
            this.columnHeader6.Width = 78;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tarih";
            this.columnHeader7.Width = 148;
            // 
            // btnveri
            // 
            this.btnveri.Location = new System.Drawing.Point(499, 12);
            this.btnveri.Name = "btnveri";
            this.btnveri.Size = new System.Drawing.Size(110, 36);
            this.btnveri.TabIndex = 1;
            this.btnveri.Text = "Verileri Göster";
            this.btnveri.UseVisualStyleBackColor = true;
            this.btnveri.Click += new System.EventHandler(this.button1_Click);
            // 
            // MskTxtTelefon
            // 
            this.MskTxtTelefon.Location = new System.Drawing.Point(57, 52);
            this.MskTxtTelefon.Mask = "(999) 000-0000";
            this.MskTxtTelefon.Name = "MskTxtTelefon";
            this.MskTxtTelefon.Size = new System.Drawing.Size(147, 20);
            this.MskTxtTelefon.TabIndex = 47;
            // 
            // DtpGirisTarihi
            // 
            this.DtpGirisTarihi.Location = new System.Drawing.Point(57, 93);
            this.DtpGirisTarihi.Name = "DtpGirisTarihi";
            this.DtpGirisTarihi.Size = new System.Drawing.Size(147, 20);
            this.DtpGirisTarihi.TabIndex = 46;
            // 
            // txtUcret
            // 
            this.txtUcret.Enabled = false;
            this.txtUcret.Location = new System.Drawing.Point(288, 97);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(147, 20);
            this.txtUcret.TabIndex = 45;
            this.txtUcret.Text = "200";
            // 
            // txtGun
            // 
            this.txtGun.Location = new System.Drawing.Point(288, 55);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(147, 20);
            this.txtGun.TabIndex = 44;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(288, 12);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(147, 20);
            this.txtSoyadi.TabIndex = 43;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(57, 12);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(147, 20);
            this.txtAdi.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Ücret : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Tarih : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Gün : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Telefon : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Soyadı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Adı : ";
            // 
            // btntmzl
            // 
            this.btntmzl.Location = new System.Drawing.Point(638, 12);
            this.btntmzl.Name = "btntmzl";
            this.btntmzl.Size = new System.Drawing.Size(110, 36);
            this.btntmzl.TabIndex = 48;
            this.btntmzl.Text = "Temizle";
            this.btntmzl.UseVisualStyleBackColor = true;
            this.btntmzl.Click += new System.EventHandler(this.btntmzl_Click);
            // 
            // admingiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 404);
            this.Controls.Add(this.btntmzl);
            this.Controls.Add(this.MskTxtTelefon);
            this.Controls.Add(this.DtpGirisTarihi);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.txtGun);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnveri);
            this.Controls.Add(this.listView1);
            this.Name = "admingiris";
            this.Text = "Admin Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnveri;
        private System.Windows.Forms.MaskedTextBox MskTxtTelefon;
        private System.Windows.Forms.DateTimePicker DtpGirisTarihi;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.TextBox txtGun;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntmzl;
    }
}