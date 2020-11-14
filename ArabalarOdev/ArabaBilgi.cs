using ArabalarOdev.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ArabalarOdev.Classes;


namespace ArabalarOdev
{ 

    public partial class ArabaBilgi : Form
    {
        string[] kapısayısı = new string[3]
   {
        "iki kapılı",
        "dört kapılı",
        "beş kapılı"
   };
        string[] beygirgucu = new string[9]
        {
            "51-75 HP",
            "76-100 HP",
            "101-175 HP",
            "176-200 HP",
            "201-225 HP",
            "226-250 HP",
            "251-275 HP",
            "276,300 HP",
            "301-325 HP"
        };
        string [] makshız = new string[6]
        {
            "0-50 km/s",
            "50-100 km/s",
            "100-150 km/s",
            "150-200 km/s",
            "200-250 km/s",
            "300-350 km/s"
        };
        string[] cekis = new string[3]
        {
            "Önden Çekiş",
            "Arkadan Çekiş",
            "Dört Çeker"
        };
        string[] sıfırdanyuze = new string[5]
        {
            "5 sn",
            "10sn",
            "15sn",
            "20sn",
            "30 sn"
        };
        string[] agırlık = new string[4]
        {
            "100kg",
            "1500kg",
            "2000kg",
            "3000kg"

        };
        string[] motorhacmi = new string[6]
        {
            "1300 cm 3 ",
            "1600-1800 cm 3",
            " 2000-2500 cm 3",
            " 3000-3500 cm 3",
            "4000-4500 cm 3",
            " 5000-5500 cm 3",
        };
      // ArabaBilgi arabas;

        public ArabaBilgi()
        {
            InitializeComponent();
        }

        private void ArabaBilgi_Load(object sender, EventArgs e)
        {
            //int Id;
            //string Marka;
            //string Model;
            foreach ( var kapısayısı in kapısayısı)
            {
                cbKapıSayı.Items.Add(kapısayısı);
            }
            cbKapıSayı.Items.Insert(0,"--Seçiniz--");
            cbKapıSayı.SelectedIndex = 0;

            foreach (var beygirgucu in beygirgucu)
            {
                cbBeygir.Items.Add(beygirgucu);
            }
            cbBeygir.Items.Insert(0,"Seçiniz");
            cbBeygir.SelectedIndex = 0;
            foreach (var makshız in makshız)
            {
                cbMakHız.Items.Add(makshız);
            }
            cbMakHız.Items.Insert(0, "--Seçiniz--");
            cbMakHız.SelectedIndex = 0;
            foreach (var cekis in cekis)
            {
                cbCekis.Items.Add(cekis);
            }
            cbCekis.Items.Insert(0, "--Seçiniz--");
            cbCekis.SelectedIndex = 0;
            foreach (var sıfırdanyuze in sıfırdanyuze)
            {
                cbSıfırdanYüze.Items.Add(sıfırdanyuze);
            }
            cbSıfırdanYüze.Items.Insert(0,"--Seçiniz--");
            cbSıfırdanYüze.SelectedIndex = 0;
            foreach (var agırlık in agırlık)
            {
                cbagırlık.Items.Add(agırlık);
            }
            cbagırlık.Items.Insert(0, "--Seçiniz--");
            cbagırlık .SelectedIndex = 0;
            foreach (var motorhacmi in motorhacmi)
            {
                cbMotorHac.Items.Add(motorhacmi);
            }
           cbMotorHac.Items.Insert(0, "--Seçiniz--");
           cbMotorHac.SelectedIndex = 0;
           //Id = Convert.ToInt32(tbId.Text);
           // Marka = Convert.ToString(tbMarka.Text);
           // Model = Convert.ToString(tbModel.Text);
        }

        private void bKaydet_Click(object sender, EventArgs e)
              {
            if (tbId.Text== "")
            {
                MessageBox.Show("Boş Bırakmayınız");
            }
            else
            {
                MessageBox.Show("Kaydedildi");
            }        
        }
        private void bGoster_Click(object sender, EventArgs e)
        {
            string sonuc = "";
            if (tbId.Text.Trim() == "")
            {
                MessageBox.Show("Id Boş Geçilmez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbMarka.Text))
            {
                MessageBox.Show("Marka Boş Geçilmez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(tbModel.Text))
            {
                MessageBox.Show("Model Boş Geçilmez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sonuc = tbId.Text.Trim() + " " + tbMarka.Text.Trim() + " " + tbModel.Text.Trim() + " " + cbKapıSayı.Text.Trim() + " " + cbBeygir.Text.Trim() + " " + rbBınek.Text.Trim() + " " + rbTıcarı.Text.Trim() + " " + cbMakHız.Text.Trim() + " " + cbMotorHac.Text.Trim() + " " + cbSıfırdanYüze.Text.Trim() + " " + cbagırlık.Text.Trim() + " " + cbCekis.Text.Trim();
            lbsonuc.Items.Add(sonuc);
        }
    }
}
