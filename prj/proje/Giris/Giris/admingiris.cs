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
    public partial class admingiris : Form
    {
        public admingiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-55SM6T7\SQLEXPRESS;Initial Catalog=RenesHalisaha;Integrated Security=True");

        private void goster()
        {

            listView1.Items.Clear(); // verileri refresh
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from reneskayit", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = read["Musteriid"].ToString();
                ekle.SubItems.Add(read["Adi"].ToString());
                ekle.SubItems.Add(read["Soyadi"].ToString());
                ekle.SubItems.Add(read["Telefon"].ToString());
                ekle.SubItems.Add(read["Gun"].ToString());
                ekle.SubItems.Add(read["Ucret"].ToString());
                ekle.SubItems.Add(read["GirisTarihi"].ToString());

                listView1.Items.Add(ekle);
                

            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            goster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e) // admin listbox click verileri textboxa taşıma
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[3].Text;
           txtGun.Text = listView1.SelectedItems[0].SubItems[4].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[6].Text;





        }

        private void btntmzl_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            MskTxtTelefon.Clear();
            txtGun.Clear();
            DtpGirisTarihi.Text = "";
        }
    }
}


//Data Source=DESKTOP-55SM6T7\SQLEXPRESS;Initial Catalog=RenesHalisaha;Integrated Security=True