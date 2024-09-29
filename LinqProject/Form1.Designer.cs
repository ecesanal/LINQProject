namespace LinqProject
{
    partial class Form1
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
            this.sayilar_hepsi = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.negatif = new System.Windows.Forms.Button();
            this.pozitif = new System.Windows.Forms.Button();
            this.cift = new System.Windows.Forms.Button();
            this.tek = new System.Windows.Forms.Button();
            this.enbuyuk = new System.Windows.Forms.Button();
            this.enkucuksayi = new System.Windows.Forms.Button();
            this.kacSayi = new System.Windows.Forms.Button();
            this.alfabetik = new System.Windows.Forms.Button();
            this.tersten = new System.Windows.Forms.Button();
            this.isim_uzunluk = new System.Windows.Forms.Button();
            this.harfi_barindiran = new System.Windows.Forms.Button();
            this.e_harfi_baslayan = new System.Windows.Forms.Button();
            this.i_harfi_biten = new System.Windows.Forms.Button();
            this.siparis_hepsi = new System.Windows.Forms.Button();
            this.tarih = new System.Windows.Forms.Button();
            this.top_bes = new System.Windows.Forms.Button();
            this.son_bes = new System.Windows.Forms.Button();
            this.yang_wang = new System.Windows.Forms.Button();
            this.siparis_sayisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sayilar_hepsi
            // 
            this.sayilar_hepsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayilar_hepsi.Location = new System.Drawing.Point(12, 12);
            this.sayilar_hepsi.Name = "sayilar_hepsi";
            this.sayilar_hepsi.Size = new System.Drawing.Size(138, 64);
            this.sayilar_hepsi.TabIndex = 0;
            this.sayilar_hepsi.Text = "Bütün Sayılar";
            this.sayilar_hepsi.UseVisualStyleBackColor = true;
            this.sayilar_hepsi.Click += new System.EventHandler(this.sayilar_hepsi_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 423);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(204, 204);
            this.listBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(248, 423);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(913, 212);
            this.dataGridView1.TabIndex = 2;
            // 
            // negatif
            // 
            this.negatif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.negatif.Location = new System.Drawing.Point(156, 12);
            this.negatif.Name = "negatif";
            this.negatif.Size = new System.Drawing.Size(144, 64);
            this.negatif.TabIndex = 3;
            this.negatif.Text = "Negatif Sayılar";
            this.negatif.UseVisualStyleBackColor = true;
            this.negatif.Click += new System.EventHandler(this.negatif_Click);
            // 
            // pozitif
            // 
            this.pozitif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pozitif.Location = new System.Drawing.Point(306, 12);
            this.pozitif.Name = "pozitif";
            this.pozitif.Size = new System.Drawing.Size(140, 64);
            this.pozitif.TabIndex = 4;
            this.pozitif.Text = "Pozitif Sayılar";
            this.pozitif.UseVisualStyleBackColor = true;
            this.pozitif.Click += new System.EventHandler(this.pozitif_Click);
            // 
            // cift
            // 
            this.cift.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cift.Location = new System.Drawing.Point(452, 12);
            this.cift.Name = "cift";
            this.cift.Size = new System.Drawing.Size(116, 64);
            this.cift.TabIndex = 5;
            this.cift.Text = "Çift Sayılar";
            this.cift.UseVisualStyleBackColor = true;
            this.cift.Click += new System.EventHandler(this.cift_Click);
            // 
            // tek
            // 
            this.tek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tek.Location = new System.Drawing.Point(574, 12);
            this.tek.Name = "tek";
            this.tek.Size = new System.Drawing.Size(117, 64);
            this.tek.TabIndex = 6;
            this.tek.Text = "Tek Sayılar";
            this.tek.UseVisualStyleBackColor = true;
            this.tek.Click += new System.EventHandler(this.tek_Click);
            // 
            // enbuyuk
            // 
            this.enbuyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.enbuyuk.Location = new System.Drawing.Point(697, 12);
            this.enbuyuk.Name = "enbuyuk";
            this.enbuyuk.Size = new System.Drawing.Size(124, 64);
            this.enbuyuk.TabIndex = 7;
            this.enbuyuk.Text = "En Büyük Sayı";
            this.enbuyuk.UseVisualStyleBackColor = true;
            this.enbuyuk.Click += new System.EventHandler(this.enbuyuk_Click);
            // 
            // enkucuksayi
            // 
            this.enkucuksayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.enkucuksayi.Location = new System.Drawing.Point(827, 12);
            this.enkucuksayi.Name = "enkucuksayi";
            this.enkucuksayi.Size = new System.Drawing.Size(124, 64);
            this.enkucuksayi.TabIndex = 8;
            this.enkucuksayi.Text = "En Küçük Sayı";
            this.enkucuksayi.UseVisualStyleBackColor = true;
            this.enkucuksayi.Click += new System.EventHandler(this.enkucuksayi_Click);
            // 
            // kacSayi
            // 
            this.kacSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kacSayi.Location = new System.Drawing.Point(957, 12);
            this.kacSayi.Name = "kacSayi";
            this.kacSayi.Size = new System.Drawing.Size(124, 64);
            this.kacSayi.TabIndex = 9;
            this.kacSayi.Text = "Kaç Tane Sayı";
            this.kacSayi.UseVisualStyleBackColor = true;
            this.kacSayi.Click += new System.EventHandler(this.kacSayi_Click);
            // 
            // alfabetik
            // 
            this.alfabetik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alfabetik.Location = new System.Drawing.Point(156, 82);
            this.alfabetik.Name = "alfabetik";
            this.alfabetik.Size = new System.Drawing.Size(144, 64);
            this.alfabetik.TabIndex = 10;
            this.alfabetik.Text = "Alfabetik";
            this.alfabetik.UseVisualStyleBackColor = true;
            this.alfabetik.Click += new System.EventHandler(this.alfabetik_Click);
            // 
            // tersten
            // 
            this.tersten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tersten.Location = new System.Drawing.Point(306, 82);
            this.tersten.Name = "tersten";
            this.tersten.Size = new System.Drawing.Size(144, 64);
            this.tersten.TabIndex = 11;
            this.tersten.Text = "Ters Alfabetik";
            this.tersten.UseVisualStyleBackColor = true;
            this.tersten.Click += new System.EventHandler(this.tersten_Click);
            // 
            // isim_uzunluk
            // 
            this.isim_uzunluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isim_uzunluk.Location = new System.Drawing.Point(456, 82);
            this.isim_uzunluk.Name = "isim_uzunluk";
            this.isim_uzunluk.Size = new System.Drawing.Size(144, 64);
            this.isim_uzunluk.TabIndex = 12;
            this.isim_uzunluk.Text = "İsim uzunluğu";
            this.isim_uzunluk.UseVisualStyleBackColor = true;
            this.isim_uzunluk.Click += new System.EventHandler(this.isim_uzunluk_Click);
            // 
            // harfi_barindiran
            // 
            this.harfi_barindiran.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harfi_barindiran.Location = new System.Drawing.Point(606, 82);
            this.harfi_barindiran.Name = "harfi_barindiran";
            this.harfi_barindiran.Size = new System.Drawing.Size(144, 64);
            this.harfi_barindiran.TabIndex = 13;
            this.harfi_barindiran.Text = "A Harfi Barındıran";
            this.harfi_barindiran.UseVisualStyleBackColor = true;
            this.harfi_barindiran.Click += new System.EventHandler(this.harfi_barindiran_Click);
            // 
            // e_harfi_baslayan
            // 
            this.e_harfi_baslayan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.e_harfi_baslayan.Location = new System.Drawing.Point(756, 82);
            this.e_harfi_baslayan.Name = "e_harfi_baslayan";
            this.e_harfi_baslayan.Size = new System.Drawing.Size(144, 64);
            this.e_harfi_baslayan.TabIndex = 14;
            this.e_harfi_baslayan.Text = "E Harfi ile Başlayan";
            this.e_harfi_baslayan.UseVisualStyleBackColor = true;
            this.e_harfi_baslayan.Click += new System.EventHandler(this.e_harfi_baslayan_Click);
            // 
            // i_harfi_biten
            // 
            this.i_harfi_biten.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.i_harfi_biten.Location = new System.Drawing.Point(906, 82);
            this.i_harfi_biten.Name = "i_harfi_biten";
            this.i_harfi_biten.Size = new System.Drawing.Size(144, 64);
            this.i_harfi_biten.TabIndex = 15;
            this.i_harfi_biten.Text = "İ Harfi ile Biten";
            this.i_harfi_biten.UseVisualStyleBackColor = true;
            this.i_harfi_biten.Click += new System.EventHandler(this.i_harfi_biten_Click);
            // 
            // siparis_hepsi
            // 
            this.siparis_hepsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparis_hepsi.Location = new System.Drawing.Point(6, 162);
            this.siparis_hepsi.Name = "siparis_hepsi";
            this.siparis_hepsi.Size = new System.Drawing.Size(144, 64);
            this.siparis_hepsi.TabIndex = 16;
            this.siparis_hepsi.Text = "Tüm Siparişler";
            this.siparis_hepsi.UseVisualStyleBackColor = true;
            this.siparis_hepsi.Click += new System.EventHandler(this.siparis_hepsi_Click);
            // 
            // tarih
            // 
            this.tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih.Location = new System.Drawing.Point(156, 162);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(144, 64);
            this.tarih.TabIndex = 17;
            this.tarih.Text = "Alma Tarihi";
            this.tarih.UseVisualStyleBackColor = true;
            this.tarih.Click += new System.EventHandler(this.tarih_Click);
            // 
            // top_bes
            // 
            this.top_bes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.top_bes.Location = new System.Drawing.Point(306, 162);
            this.top_bes.Name = "top_bes";
            this.top_bes.Size = new System.Drawing.Size(144, 64);
            this.top_bes.TabIndex = 18;
            this.top_bes.Text = "Top 5";
            this.top_bes.UseVisualStyleBackColor = true;
            this.top_bes.Click += new System.EventHandler(this.top_bes_Click);
            // 
            // son_bes
            // 
            this.son_bes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.son_bes.Location = new System.Drawing.Point(456, 162);
            this.son_bes.Name = "son_bes";
            this.son_bes.Size = new System.Drawing.Size(144, 64);
            this.son_bes.TabIndex = 19;
            this.son_bes.Text = "Son 5";
            this.son_bes.UseVisualStyleBackColor = true;
            this.son_bes.Click += new System.EventHandler(this.son_bes_Click);
            // 
            // yang_wang
            // 
            this.yang_wang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yang_wang.Location = new System.Drawing.Point(606, 162);
            this.yang_wang.Name = "yang_wang";
            this.yang_wang.Size = new System.Drawing.Size(144, 64);
            this.yang_wang.TabIndex = 20;
            this.yang_wang.Text = "YangWang";
            this.yang_wang.UseVisualStyleBackColor = true;
            this.yang_wang.Click += new System.EventHandler(this.yang_wang_Click);
            // 
            // siparis_sayisi
            // 
            this.siparis_sayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparis_sayisi.Location = new System.Drawing.Point(756, 162);
            this.siparis_sayisi.Name = "siparis_sayisi";
            this.siparis_sayisi.Size = new System.Drawing.Size(144, 64);
            this.siparis_sayisi.TabIndex = 21;
            this.siparis_sayisi.Text = "Sipariş Sayısı";
            this.siparis_sayisi.UseVisualStyleBackColor = true;
            this.siparis_sayisi.Click += new System.EventHandler(this.siparis_sayisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 647);
            this.Controls.Add(this.siparis_sayisi);
            this.Controls.Add(this.yang_wang);
            this.Controls.Add(this.son_bes);
            this.Controls.Add(this.top_bes);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.siparis_hepsi);
            this.Controls.Add(this.i_harfi_biten);
            this.Controls.Add(this.e_harfi_baslayan);
            this.Controls.Add(this.harfi_barindiran);
            this.Controls.Add(this.isim_uzunluk);
            this.Controls.Add(this.tersten);
            this.Controls.Add(this.alfabetik);
            this.Controls.Add(this.kacSayi);
            this.Controls.Add(this.enkucuksayi);
            this.Controls.Add(this.enbuyuk);
            this.Controls.Add(this.tek);
            this.Controls.Add(this.cift);
            this.Controls.Add(this.pozitif);
            this.Controls.Add(this.negatif);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.sayilar_hepsi);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sayilar_hepsi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button negatif;
        private System.Windows.Forms.Button pozitif;
        private System.Windows.Forms.Button cift;
        private System.Windows.Forms.Button tek;
        private System.Windows.Forms.Button enbuyuk;
        private System.Windows.Forms.Button enkucuksayi;
        private System.Windows.Forms.Button kacSayi;
        private System.Windows.Forms.Button alfabetik;
        private System.Windows.Forms.Button tersten;
        private System.Windows.Forms.Button isim_uzunluk;
        private System.Windows.Forms.Button harfi_barindiran;
        private System.Windows.Forms.Button e_harfi_baslayan;
        private System.Windows.Forms.Button i_harfi_biten;
        private System.Windows.Forms.Button siparis_hepsi;
        private System.Windows.Forms.Button tarih;
        private System.Windows.Forms.Button top_bes;
        private System.Windows.Forms.Button son_bes;
        private System.Windows.Forms.Button yang_wang;
        private System.Windows.Forms.Button siparis_sayisi;
    }
}

