using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButonEklemeUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Buton oluşturma
            Button yeniButon = new Button();

            // Buton özellikleri
            yeniButon.Text = "Yeni Buton";
            yeniButon.Name = "btnYeni";
            yeniButon.Size = new System.Drawing.Size(100, 30);
            yeniButon.Location = new System.Drawing.Point(50, 50);

            // Buton click event'i
            yeniButon.Click += new EventHandler(YeniButon_Click);

            // Forma buton ekleme
            this.Controls.Add(yeniButon);
        }

        private void YeniButon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeni butona tıklandı!");
        }
    }
}