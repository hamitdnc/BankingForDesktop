namespace SmartBankasi.UI
{
    partial class FrmPersoneller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersoneller));
            this.gridControlPersoneller = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.buttonResimSeciniz = new System.Windows.Forms.Button();
            this.dateEditDogumTarihi = new DevExpress.XtraEditors.DateEdit();
            this.textEditTC = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxMedeniHali = new System.Windows.Forms.ComboBox();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.textEditSoyadi = new DevExpress.XtraEditors.TextEdit();
            this.textEditAdi = new DevExpress.XtraEditors.TextEdit();
            this.pictureBoxPersonelResim = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxiller = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonResimYok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPersoneller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDogumTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDogumTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonelResim)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlPersoneller
            // 
            this.gridControlPersoneller.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlPersoneller.Location = new System.Drawing.Point(0, 0);
            this.gridControlPersoneller.MainView = this.gridView1;
            this.gridControlPersoneller.Name = "gridControlPersoneller";
            this.gridControlPersoneller.Size = new System.Drawing.Size(717, 415);
            this.gridControlPersoneller.TabIndex = 0;
            this.gridControlPersoneller.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlPersoneller;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.buttonResimYok);
            this.groupControl1.Controls.Add(this.buttonResimSeciniz);
            this.groupControl1.Controls.Add(this.dateEditDogumTarihi);
            this.groupControl1.Controls.Add(this.textEditTC);
            this.groupControl1.Controls.Add(this.comboBoxMedeniHali);
            this.groupControl1.Controls.Add(this.comboBoxCinsiyet);
            this.groupControl1.Controls.Add(this.textEditSoyadi);
            this.groupControl1.Controls.Add(this.textEditAdi);
            this.groupControl1.Controls.Add(this.pictureBoxPersonelResim);
            this.groupControl1.Controls.Add(this.toolStrip1);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.comboBoxiller);
            this.groupControl1.Location = new System.Drawing.Point(719, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(295, 413);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "groupControl1";
            // 
            // buttonResimSeciniz
            // 
            this.buttonResimSeciniz.Location = new System.Drawing.Point(172, 197);
            this.buttonResimSeciniz.Name = "buttonResimSeciniz";
            this.buttonResimSeciniz.Size = new System.Drawing.Size(118, 23);
            this.buttonResimSeciniz.TabIndex = 11;
            this.buttonResimSeciniz.Text = "RESİM SEÇİNİZ";
            this.buttonResimSeciniz.UseVisualStyleBackColor = true;
            this.buttonResimSeciniz.Click += new System.EventHandler(this.buttonResimSeciniz_Click);
            // 
            // dateEditDogumTarihi
            // 
            this.dateEditDogumTarihi.EditValue = null;
            this.dateEditDogumTarihi.Location = new System.Drawing.Point(8, 379);
            this.dateEditDogumTarihi.Name = "dateEditDogumTarihi";
            this.dateEditDogumTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDogumTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDogumTarihi.Size = new System.Drawing.Size(148, 20);
            this.dateEditDogumTarihi.TabIndex = 10;
            // 
            // textEditTC
            // 
            this.textEditTC.Location = new System.Drawing.Point(5, 66);
            this.textEditTC.Name = "textEditTC";
            this.textEditTC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.textEditTC.Size = new System.Drawing.Size(148, 20);
            this.textEditTC.TabIndex = 9;
            // 
            // comboBoxMedeniHali
            // 
            this.comboBoxMedeniHali.FormattingEnabled = true;
            this.comboBoxMedeniHali.Location = new System.Drawing.Point(5, 274);
            this.comboBoxMedeniHali.Name = "comboBoxMedeniHali";
            this.comboBoxMedeniHali.Size = new System.Drawing.Size(148, 21);
            this.comboBoxMedeniHali.TabIndex = 8;
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(8, 222);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(148, 21);
            this.comboBoxCinsiyet.TabIndex = 8;
            // 
            // textEditSoyadi
            // 
            this.textEditSoyadi.Location = new System.Drawing.Point(8, 170);
            this.textEditSoyadi.Name = "textEditSoyadi";
            this.textEditSoyadi.Size = new System.Drawing.Size(148, 20);
            this.textEditSoyadi.TabIndex = 7;
            // 
            // textEditAdi
            // 
            this.textEditAdi.Location = new System.Drawing.Point(8, 118);
            this.textEditAdi.Name = "textEditAdi";
            this.textEditAdi.Size = new System.Drawing.Size(148, 20);
            this.textEditAdi.TabIndex = 7;
            // 
            // pictureBoxPersonelResim
            // 
            this.pictureBoxPersonelResim.Location = new System.Drawing.Point(172, 48);
            this.pictureBoxPersonelResim.Name = "pictureBoxPersonelResim";
            this.pictureBoxPersonelResim.Size = new System.Drawing.Size(118, 142);
            this.pictureBoxPersonelResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPersonelResim.TabIndex = 6;
            this.pictureBoxPersonelResim.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonKaydet,
            this.toolStripButtonGuncelle,
            this.toolStripButtonSil});
            this.toolStrip1.Location = new System.Drawing.Point(2, 20);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(291, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonKaydet
            // 
            this.toolStripButtonKaydet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonKaydet.Image")));
            this.toolStripButtonKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonKaydet.Name = "toolStripButtonKaydet";
            this.toolStripButtonKaydet.Size = new System.Drawing.Size(69, 22);
            this.toolStripButtonKaydet.Text = "KAYDET";
            this.toolStripButtonKaydet.Click += new System.EventHandler(this.toolStripButtonKaydet_Click);
            // 
            // toolStripButtonGuncelle
            // 
            this.toolStripButtonGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGuncelle.Image")));
            this.toolStripButtonGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuncelle.Name = "toolStripButtonGuncelle";
            this.toolStripButtonGuncelle.Size = new System.Drawing.Size(84, 22);
            this.toolStripButtonGuncelle.Text = "GÜNCELLE";
            this.toolStripButtonGuncelle.Click += new System.EventHandler(this.toolStripButtonGuncelle_Click);
            // 
            // toolStripButtonSil
            // 
            this.toolStripButtonSil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSil.Image")));
            this.toolStripButtonSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSil.Name = "toolStripButtonSil";
            this.toolStripButtonSil.Size = new System.Drawing.Size(42, 22);
            this.toolStripButtonSil.Text = "SİL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "DOĞUM TARİHİ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "DOĞUM YERİ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "MEDENİ HALİ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SOYADI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CİNSİYET:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ADI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC";
            // 
            // comboBoxiller
            // 
            this.comboBoxiller.FormattingEnabled = true;
            this.comboBoxiller.Location = new System.Drawing.Point(5, 326);
            this.comboBoxiller.Name = "comboBoxiller";
            this.comboBoxiller.Size = new System.Drawing.Size(148, 21);
            this.comboBoxiller.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonResimYok
            // 
            this.buttonResimYok.Location = new System.Drawing.Point(172, 227);
            this.buttonResimYok.Name = "buttonResimYok";
            this.buttonResimYok.Size = new System.Drawing.Size(118, 23);
            this.buttonResimYok.TabIndex = 12;
            this.buttonResimYok.Text = "button1";
            this.buttonResimYok.UseVisualStyleBackColor = true;
            this.buttonResimYok.Click += new System.EventHandler(this.buttonResimYok_Click);
            // 
            // FrmPersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 414);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControlPersoneller);
            this.Name = "FrmPersoneller";
            this.Text = "FrmPersoneller";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPersoneller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPersoneller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDogumTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDogumTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPersonelResim)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlPersoneller;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit dateEditDogumTarihi;
        private DevExpress.XtraEditors.TextEdit textEditTC;
        private System.Windows.Forms.ComboBox comboBoxMedeniHali;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private DevExpress.XtraEditors.TextEdit textEditSoyadi;
        private DevExpress.XtraEditors.TextEdit textEditAdi;
        private System.Windows.Forms.PictureBox pictureBoxPersonelResim;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxiller;
        private System.Windows.Forms.Button buttonResimSeciniz;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonResimYok;
    }
}