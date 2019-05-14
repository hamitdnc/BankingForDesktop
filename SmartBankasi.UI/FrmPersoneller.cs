using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartBankasi.BLL.Personelislemleri;
using SmartBankasi.BLL.ililceSecimi;

namespace SmartBankasi.UI
{
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }
        //******************************************
        TextBox resimYolu = new TextBox();
        //*******************************************
        PersonelManager pers = new PersonelManager();
        ililceGetir gelsinTurkiye = new ililceGetir();
        string MesajPersonel;
        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            //gridControlPersoneller.DataSource = prs.PersonelListesi();
            pers.PersonelListesi(gridControlPersoneller);
            gelsinTurkiye.illerListesi(comboBoxiller);
        }

        private void comboBoxilceler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxiller_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gelsinTurkiye.ilcelerListesi(comboBoxiller, comboBoxilceler);
        }

        private void buttonResimSeciniz_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBoxPersonelResim.ImageLocation = openFileDialog1.FileName;
            //MessageBox.Show(openFileDialog1.FileName);           
            resimYolu.Text = openFileDialog1.FileName;
        }

        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            MesajPersonel = pers.PersonelKaydet(textEditTC.Text, textEditAdi.Text, textEditSoyadi.Text,MedeniHali(), comboBoxCinsiyet.Text, Convert.ToDateTime(dateEditDogumTarihi.EditValue), comboBoxiller.Text, resimYolu.Text);
            MessageBox.Show(MesajPersonel);
        }

        bool MedeniHali()
        {
            if (comboBoxMedeniHali.Text=="Erkek")
            {
                return true;
            }
            return false;
        }
        int pers_Id;
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            pers_Id =Convert.ToInt32( gridView1.GetFocusedRowCellValue("PersonellerID").ToString());
            textEditTC.Text= gridView1.GetFocusedRowCellValue("TC").ToString();
            textEditAdi.Text= gridView1.GetFocusedRowCellValue("Adi").ToString();
            textEditSoyadi.Text= gridView1.GetFocusedRowCellValue("Soyadi").ToString();
            comboBoxCinsiyet.Text= gridView1.GetFocusedRowCellValue("Cinsiyet").ToString();
            comboBoxMedeniHali.Text= gridView1.GetFocusedRowCellValue("MedeniHali").ToString();
           comboBoxiller.Text= gridView1.GetFocusedRowCellValue("DogumYeri").ToString();
            dateEditDogumTarihi.Text= gridView1.GetFocusedRowCellValue("DogumTarihi").ToString();
            //***********************************************************************************
            resimYolu.Text= gridView1.GetFocusedRowCellValue("Resim").ToString();

            if (string.IsNullOrWhiteSpace(resimYolu.Text))
            {
                pictureBoxPersonelResim.Image = Image.FromFile("C:\\Users\\resul.turfent\\Desktop\\Test Fotolar\\ResimYok.jpg");
            }
            else
            {
                pictureBoxPersonelResim.ImageLocation = gridView1.GetFocusedRowCellValue("Resim").ToString();
            }

        }

        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            MesajPersonel = pers.PersonelGuncelle(pers_Id,textEditTC.Text, textEditAdi.Text, textEditSoyadi.Text, MedeniHali(), comboBoxCinsiyet.Text, Convert.ToDateTime(dateEditDogumTarihi.EditValue), comboBoxiller.Text, resimYolu.Text);
            MessageBox.Show(MesajPersonel);
        }

        private void buttonResimYok_Click(object sender, EventArgs e)
        {
           resimYolu.Text="";
        }
    }
}
