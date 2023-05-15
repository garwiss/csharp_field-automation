using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Giris
{
    public partial class Frmyenics : Form
    {
        public Frmyenics()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-55SM6T7\\SQLEXPRESS;Initial Catalog=RenesHalisaha;Integrated Security=True");


        private void btnpzt_Click(object sender, EventArgs e)
        {
            txtGun.Text = "Pazartesi";
            btnpzt.BackColor = Color.Firebrick;
        }

        private void btnsli_Click(object sender, EventArgs e)
        {
            txtGun.Text = "Salı";
            btnsli.BackColor = Color.Firebrick;
        }

        private void btnçrş_Click(object sender, EventArgs e)
        {
            txtGun.Text = "Çarşamba";
            btnçrş.BackColor = Color.Firebrick;

        }

        private void btnprş_Click(object sender, EventArgs e)
        {
            txtGun.Text = "Perşemebe";
            btnprş.BackColor = Color.Firebrick;

        }

        private void btncuma_Click(object sender, EventArgs e)
        {
            txtGun.Text = "Cuma";
            btncuma.BackColor = Color.Firebrick;

        }

        private void btncmrts_Click(object sender, EventArgs e)
        {
            txtGun.Text = "Cumartesi";
            btncmrts.BackColor = Color.Firebrick;

        }

        private void btnpzr_Click(object sender, EventArgs e)
        {
            txtGun.Text = "Pazar";
            btnpzr.BackColor = Color.Firebrick;

        }

        private void btnrzrv_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rezerve günleri gösterir");

        }

        private void btnbos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boş günleri gösterir");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into reneskayit (Adi,Soyadi,Telefon,Gun,Ucret,GirisTarihi) values('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + MskTxtTelefon.Text + "','" + txtGun.Text + "','" + txtUcret.Text + "','" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt yapıldı");
            
        }
    }
}
