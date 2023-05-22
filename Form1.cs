using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Haber_uygulaması
{
    public partial class HABER : Form
    {
        public HABER()
        {
            InitializeComponent();
        }

        private void buttonGetir_Click(object sender, EventArgs e)
        {
            List<Haber> Kayitlar = XMLcevir();
            listboxBaslik.DataSource = Kayitlar;
        }

        private List<Haber> XMLcevir()
        {
            List<Haber> haberKayıtları = new List<Haber>();

            XDocument xmlKaynak = XDocument.Load(textBoxURL.Text);

            List<XElement> Rows = xmlKaynak.Descendants("item").ToList();
            foreach (XElement row in Rows)
            {
                Haber temp = new Haber();
                temp.baslik = row.Element("title").Value;
                temp.aciklama = row.Element("description").Value;
                temp.link=row.Element("link").Value;
                haberKayıtları.Add(temp);
            }
            return haberKayıtları;
        }

        private void listboxBaslik_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox seçilenKayıt = (ListBox)sender;
            Haber seçilendeger = (Haber)seçilenKayıt.SelectedItem;
            webBrowserURL.DocumentText = seçilendeger.aciklama;
        }
    }
}
