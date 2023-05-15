using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giris
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Yönetici" && textBox1.Text == "admin123")
            {
                admingiris frma = new admingiris();
                frma.Show();
            }

          /*  else
            {
                MessageBox.Show("Hatalı giriş");
                comboBox1.Text = "";
                textBox1.Clear();
            }*/
         

            if (comboBox1.Text == "Misafir" && textBox1.Text == "")
            {
                Frmyenics frm = new Frmyenics();
                frm.Show();

               
            }
        }
    }
}
