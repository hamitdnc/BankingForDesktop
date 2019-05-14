using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartBankasi.UI
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

        int uruntiklaadet = 0;
        private void toolStripButtonUrunislemleri_Click(object sender, EventArgs e)
        {
            if (uruntiklaadet%2==0)
            {
                groupControlUrunler.Visible = true;
                uruntiklaadet++;
            }
            else
            {
                groupControlUrunler.Visible = false;
                uruntiklaadet++;
            }
        
        }
        int urundetaytikla = 0;
        private void toolStripButtonUrunDetayislemleri_Click(object sender, EventArgs e)
        {
            if (urundetaytikla%2==0)
            {
                groupControlUrunDetay.Visible = true;
                urundetaytikla++;
            }
            else
            {
                groupControlUrunDetay.Visible = false;
                urundetaytikla++;

            }
        }
    }
}
