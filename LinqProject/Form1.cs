using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqProject
{
    public partial class Form1 : Form
    {
        private int[] sayilar = { -5, -9, -6, 3, 8, 43, 80 };
        List<string> isimler = new List<string>();
        public Form1()
        {
            isimler.Add("Elif");
            isimler.Add("Ece");
            isimler.Add("Ezel");
            isimler.Add("Ali");
            isimler.Add("Eyşan");
            isimler.Add("Ateş");
            isimler.Add("Su");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sayilar_hepsi_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = sayilar.ToList();
        }

        private void negatif_Click(object sender, EventArgs e)
        {
            //lambda expression
            //=> lambda
            //foreach ile dolaşabildiğimiz generic bir ifade interface***
            IEnumerable<int> n = sayilar.Where(x => x < 0);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void pozitif_Click(object sender, EventArgs e)
        {
            IEnumerable<int> pozitif = sayilar.Where(y => y > 0);
            listBox1.DataSource = null;
            listBox1.DataSource = pozitif.ToList();
        }

        private void cift_Click(object sender, EventArgs e)
        {
            IEnumerable<int> cift = sayilar.Where(z => z % 2 == 0);
            listBox1.DataSource = null;
            listBox1.DataSource = cift.ToList();
        }

        private void tek_Click(object sender, EventArgs e)
        {
            IEnumerable<int> tek = sayilar.Where(z => z % 2 == 1 || z % 2 == -1);
            listBox1.DataSource = null;
            listBox1.DataSource = tek.ToList();
        }

        private void enbuyuk_Click(object sender, EventArgs e)
        {
            int enBuyukSayi = sayilar.Max();
            MessageBox.Show(enBuyukSayi.ToString());
        }

        private void enkucuksayi_Click(object sender, EventArgs e)
        {
            int enKucukSayi = sayilar.Min();
            MessageBox.Show(enKucukSayi.ToString());
        }

        private void kacSayi_Click(object sender, EventArgs e)
        {
            int enKucukSayi = sayilar.Length;
            MessageBox.Show(enKucukSayi.ToString());
        }

        private void alfabetik_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource= isimler.OrderBy(z => z).ToList();

        }

        private void tersten_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.OrderByDescending(z => z).ToList();
        }

        private void isim_uzunluk_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Select(z => z.Length).ToList();
        }

        private void harfi_barindiran_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Where(z => z.Contains('a')||z.Contains('A')).ToList();
        }

        private void e_harfi_baslayan_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource=isimler.Where(x=>x.StartsWith("E")||x.StartsWith("e")).ToList();
        }

        private void i_harfi_biten_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Where(x => x.EndsWith("i") || x.EndsWith("İ")).ToList();
        }

        private void siparis_hepsi_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();

            var gorunen = orders.Select(x => new
            {
                SiparisNo = x.OrderID,
                Tarih=x.OrderDate,
                Musteri=x.Customer.ContactName
            });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gorunen.ToList();
        }

        private void tarih_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();

            var gorunen = orders.Select(x =>x.OrderDate).ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource= gorunen.ToList();
            //dataGridView1.DataSource=orders.Select(x =>x.OrderDate).ToList();
        }

        private void top_bes_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.Take(5).ToList();
        }

        private void son_bes_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders.OrderByDescending(x => x.OrderID).Take(5).Select(x => new
            {
                x.OrderID,
                x.Customer.ContactName,
                x.OrderDate
            }).ToList();
        }

        private void yang_wang_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            var filter =orders.Where(x=>x.Customer.ContactName=="Yang Wang").ToList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filter;
        }

        private void siparis_sayisi_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            int sayi=orders.Count();
            MessageBox.Show(sayi.ToString());
        }
    }
}
