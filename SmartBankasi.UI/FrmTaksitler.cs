using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartBankasi.BLL.MusteriTurleriislemleri;
using SmartBankasi.BLL.OdemePlanlariislemleri;

namespace SmartBankasi.UI
{
    public partial class FrmTaksitler : Form
    {
        public FrmTaksitler()
        {
            InitializeComponent();
        }

        //*********************************************************
        MusteriTurleriManager mtm = new MusteriTurleriManager();
        //*********************************************************

         private  decimal FaizHesabi(decimal miktar,int taksitsayisi)
        {
            if (taksitsayisi>0 && taksitsayisi<=12)
            {
                miktar = miktar + miktar * 0.015m;
            }
            if (taksitsayisi>12 && taksitsayisi<=24)
            {
                miktar = miktar + miktar * 0.019m;
            }
            if (taksitsayisi>24&& taksitsayisi<=36)
            {
                miktar = miktar + miktar * 0.022m;
            }
            return miktar;
        }
        //*******************************************************
        TextBox[] taksit;
        //***************************************************************
        int sayisi;
        private void simpleButtonTaksitOlustur_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textEditTaksitSayisi.Text))
            {
                decimal krediMiktari = Convert.ToDecimal(textEditKrediMiktari.Text);
              
                sayisi = Convert.ToInt32(textEditTaksitSayisi.Text);
                decimal aylikOdeme = FaizHesabi(krediMiktari, sayisi) / sayisi;
                //int sayisi = 6;
                //taksit sayısı bilinmediğinden dolayı sanal bir textbox kontrolüne ihtiyacımız var
                taksit = new TextBox[sayisi];
                Label[] lDizi = new Label[sayisi];


                int sutun2TextBox = 0, sutun3TextBox = 0;
                int sutun3label = 0, sutun2label = 0;

                for (int i = 0; i < sayisi; i++)
                {
                    taksit[i] = new TextBox();

                    if (i <= 15)
                    {
                        //**********************
                        taksit[i].Name = "taksit" + i;//taksit eklerken name alanlarına ihtiyacımız olacak
                        panelControlTaksitler.Controls.Add(taksit[i]);//panelin üzerine textbox ı ekliyoruz
                        taksit[i].Text = aylikOdeme.ToString();
                        taksit[i].Top = i * 25;//yukardan mesafe
                        taksit[i].Left = 61;//panelin sol kenarına olan birim uzaklığı
                        taksit[i].Width = 150;//textbox ın genişliği
                    }
                    if (i > 15 && i <= 30)
                    {
                        //**********************
                        taksit[i].Name = "taksit" + i;
                        panelControlTaksitler.Controls.Add(taksit[i]);
                        //
                        taksit[i].Text = aylikOdeme.ToString();
                        taksit[i].Top = sutun2TextBox * 25;
                        taksit[i].Left = 300;
                        taksit[i].Width = 150;
                        sutun2TextBox++;
                    }
                    if (i > 30 && i <= 50)
                    {
                        //**********************
                        taksit[i].Name = "taksit" + i;
                        panelControlTaksitler.Controls.Add(taksit[i]);
                        taksit[i].Text = aylikOdeme.ToString();
                        taksit[i].Top = sutun3TextBox * 25;
                        taksit[i].Left = 583;
                        taksit[i].Width = 150;
                        sutun3TextBox++;
                    }
                }
                for (int i = 0; i < lDizi.Length; i++)
                {
                    lDizi[i] = new Label();
                    if (i <= 15)
                    {
                        lDizi[i].Text = (i + 1).ToString() + ".TAKSİT";
                        panelControlTaksitler.Controls.Add(lDizi[i]);
                        lDizi[i].Top = i * 25;
                        lDizi[i].Left = 1;
                        lDizi[i].Width = 60;
                    }
                    if (i > 15 && i <= 30)
                    {
                        lDizi[i].Text = (i + 1).ToString() + ".TAKSİT";
                        panelControlTaksitler.Controls.Add(lDizi[i]);
                        lDizi[i].Top = sutun2label * 25;
                        lDizi[i].Left = 235;
                        lDizi[i].Width = 75;
                        sutun2label++;
                    }
                    if (i > 30 && i <= 50)
                    {
                        lDizi[i].Text = (i + 1).ToString() + ".TAKSİT";
                        panelControlTaksitler.Controls.Add(lDizi[i]);
                        lDizi[i].Top = sutun3label * 25;
                        lDizi[i].Left = 483;
                        lDizi[i].Width = 75;
                        sutun3label++;
                    }
                } 
            }
            else
            {
                MessageBox.Show("Taksit sayısı giriniz");
            }
        }

        private void simpleButtonTcGetir_Click(object sender, EventArgs e)
        {
            if ((int)comboBoxMusteriTurleri.SelectedValue==1)
            {
                //kurumsal müşteri
                mtm.KurumsalMusteriGetir(maskedTextBoxTC.Text);
                //-----------------------------------
                textEditMusteriAdi.Text = mtm.isim;
                textEditMusteriSoyadi.Text = mtm.soyisim;
            }
            if ((int)comboBoxMusteriTurleri.SelectedValue == 2)
            {
                //Bireysel müşteri
            }
        }

        private void FrmTaksitler_Load(object sender, EventArgs e)
        {
            mtm.MusteriTurleri(comboBoxMusteriTurleri);
            //comboBoxMusteriTurleri.DataSource = mtm.MusteriTurleri();
        }
        //**********************************************************
         OdemePlanlariManager odman = new OdemePlanlariManager();
        //**********************************************************
        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            DateTime tarih = dateTimePicker1.Value;
            DateTime[] tarihEkle = new DateTime[sayisi];
            decimal[] taksitEkle = new decimal[sayisi];

            for (int i = 0; i < sayisi; i++)
            {
                taksitEkle[i] =Convert.ToDecimal(taksit[i].Text);
                int x = tarih.Month;
                if (x==12 && tarih.Year==dateTimePicker1.Value.Year)
                {
                    tarihEkle[i] = tarih.AddYears(1);
                }
                //if (x == 12 && tarih.Year== dateTimePicker1.Value.Year+1)
                //{
                //    tarihEkle[i] = tarih.AddYears(1);
                //}
                tarihEkle[i] = tarih.AddMonths(i);
                
            }
            string mesaj = odman.OdemePlaniKaydet(Convert.ToDecimal(taksit[0].Text), tarihEkle[0], Convert.ToDecimal(taksit[1].Text), tarihEkle[1], Convert.ToDecimal(taksit[2].Text), tarihEkle[2], Convert.ToDecimal(taksit[3].Text), tarihEkle[3], Convert.ToDecimal(taksit[4].Text), tarihEkle[4], Convert.ToDecimal(taksit[5].Text), tarihEkle[5], Convert.ToDecimal(taksit[6].Text), tarihEkle[6], Convert.ToDecimal(taksit[7].Text), tarihEkle[7], Convert.ToDecimal(taksit[8].Text), tarihEkle[8], Convert.ToDecimal(taksit[9].Text), tarihEkle[9], Convert.ToDecimal(taksit[10].Text), tarihEkle[10], Convert.ToDecimal(taksit[11].Text), tarihEkle[11], 1);

            MessageBox.Show(mesaj);
        }
    }
}
