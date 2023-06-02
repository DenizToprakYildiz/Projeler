using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RehberApp
{
    public partial class Form1 : Form
    {

        RehberDataContext db = new RehberDataContext();
        List<tblKisiler> kisiler;
        tblKisiler goruntulenenKisi;
        public Form1()
        {
            InitializeComponent();

            KayitlariGoster();
         
        }
        void KayitlariGoster()
        {
            kisiler = db.tblKisilers.ToList();

            lbKisiler.Items.Clear();

            foreach (var kisi in kisiler)
            lbKisiler.Items.Add(kisi.Ad + "" + kisi.Soyad);
        }
        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int yenidenGoster;

          if(goruntulenenKisi !=null)
            {
                goruntulenenKisi.Ad = txtAd.Text;
                goruntulenenKisi.Soyad = txtSoyad.Text;
                goruntulenenKisi.Cinsiyet = cbCinsiyet.SelectedIndex == 0;
                goruntulenenKisi.DogumTarihi = dtDogumTarihi.Value;
                goruntulenenKisi.Telefon = txtTel.Text;
                goruntulenenKisi.Adres = txtAdres.Text;

                yenidenGoster = lbKisiler.SelectedIndex;
            }
          else
            {
                tblKisiler yeniKisi = new tblKisiler();
                yeniKisi.Ad = txtAd.Text;
                yeniKisi.Soyad = txtAd.Text;
                yeniKisi.Cinsiyet = cbCinsiyet.SelectedIndex == 0;
                yeniKisi.DogumTarihi = dtDogumTarihi.Value;
                yeniKisi.Telefon = txtTel.Text;
                yeniKisi.Adres = txtAdres.Text;

                db.tblKisilers.InsertOnSubmit(yeniKisi);

                yenidenGoster = lbKisiler.Items.Count;
            }
          db.SubmitChanges();

            KayitlariGoster();
            lbKisiler.SelectedIndex = yenidenGoster;


        }

        private void lbKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
            if (lbKisiler.SelectedIndex>=0)
   
            {
                goruntulenenKisi = kisiler[lbKisiler.SelectedIndex];

                txtAd.Text = goruntulenenKisi.Ad;
                txtSoyad.Text = goruntulenenKisi.Soyad;

                if (goruntulenenKisi.Cinsiyet.GetValueOrDefault())
                    cbCinsiyet.SelectedIndex = 0;
                else cbCinsiyet.SelectedIndex = 1;

                dtDogumTarihi.Value = goruntulenenKisi.DogumTarihi.GetValueOrDefault();

                txtTel.Text = goruntulenenKisi.Telefon;
                txtAdres.Text = goruntulenenKisi.Adres;
            }

            else
            {
                goruntulenenKisi = null;
                txtAd.Text = "";
                txtSoyad.Text = "";
                cbCinsiyet.SelectedIndex = 0;
                dtDogumTarihi.Value = DateTime.Now;
                txtTel.Text = "";
                txtAdres.Text = "";

            }
                }
                catch
            {

            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
              lbKisiler.SelectedIndex = -1;
              txtAd.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(goruntulenenKisi!=null)
            {
                DialogResult cevap = MessageBox.Show(goruntulenenKisi.Ad + ""+ goruntulenenKisi.Soyad +
                    "Adlı kişiyi silmek istediğinize emin misiniz?", "Uyarı",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(cevap == DialogResult.Yes)
                {
                    db.tblKisilers.DeleteOnSubmit(goruntulenenKisi);
                    db.SubmitChanges();

                    KayitlariGoster();
                    lbKisiler.SelectedIndex = 0;


                }

            }
            else
            {
                MessageBox.Show("Silmek için önce bir kişi seçmelisiniz!", "Uyarı",
                    MessageBoxButtons.OK,   MessageBoxIcon.Error);
            }
        }

    }
}
