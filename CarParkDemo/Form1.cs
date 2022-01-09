using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GirisDal _girisDal = new GirisDal();

        private void Form1_Load(object sender, EventArgs e)
        {
            AracYukle();
        }

        private void AracYukle()
        {
            dgwGiris.DataSource = _girisDal.GetAll();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            _girisDal.Add(new Giris
            {
                plaka = tbxPlaka.Text,
                saat = Convert.ToDateTime(tbxSaat.Text),
                tarih = Convert.ToDateTime(tbxTarih.Text)
            });
            AracYukle();
            MessageBox.Show("Araç girişi yapıldı");
        }

        private void btncikis_Click(object sender, EventArgs e)
        {

            // string plaka = Convert.ToString(dgwGiris.CurrentRow.Cells[0].Value);
            //_girisDal.Delete(plaka);
            //AracYukle();
            //MessageBox.Show("Araç Çıkışı yapıldı");
        }
    }
}
