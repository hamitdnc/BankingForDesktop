using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartBankasi.BLL.BireyselMusteriislemleri;

namespace SmartBankasi.UI
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        //************************************************************************
        BireyselMusterilerManager birmm = new BireyselMusterilerManager();
        //************************************************************************

        private void textBoxAdinaGoreAra_TextChanged(object sender, EventArgs e)
        {
            birmm.AdaGoreAra(gridControl1, textBoxAdinaGoreAra.Text);
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            birmm.BireyselMusteriListesi(gridControl1);
        }

        private void textBoxTCyeGoreAra_TextChanged(object sender, EventArgs e)
        {
            birmm.TCGoreAra(gridControl1, textBoxTCyeGoreAra.Text);


        }
    }
}
