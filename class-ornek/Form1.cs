using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace class_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap kitap= new Kitap();
            kitap.isim = "Gökyüzü";
            kitap.yazar = "Ahmet Cansever";
            kitap.sayfaSayisi = 300;
            kitap.tür = "Edebiyat";
            kitap.yili = 2022;
            label1.Text = kitap.isim +" "+ kitap.yazar + " "+ kitap.tür;

        }
    }
}
