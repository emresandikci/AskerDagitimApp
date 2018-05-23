using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
namespace WFAskerDagitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Global Değişkenler

        Random rnd = new Random();

        string[] Askerler = new string[0];

        #region Sehir listesi
        string[] Sehirler ={"01 Adana","02 Adıyaman","03 Afyon","04 Ağrı","05 Amasya","06 Ankara","07 Antalya","08 Artvin","09 Aydın","10 Balıkesir","11 Bilecik","12 Bingöl","13 Bitlis","14 Bolu","15 Burdur","16 Bursa","17 Çanakkale","18 Çankırı","19 Çorum","20 Denizli","21 Diyarbakır","22 Edirne","23 Elazığ","24 Erzincan","25 Erzurum","26 Eskişehir","27 Gaziantep","28 Giresun",
"29 Gümüşhane","30 Hakkari","31 Hatay","32 Isparta","33 İçel (Mersin)","34 İstanbul","35 İzmir","36 Kars","37 Kastamonu","38 Kayseri","39 Kırklareli","40 Kırşehir","41 Kocaeli","42 Konya",
"43 Kütahya","44 Malatya","45 Manisa","46 K.maraş","47 Mardin","48 Muğla","49 Muş","50 Nevşehir","51 Niğde","52 Ordu","53 Rize","54 Sakarya","55 Samsun","56 Siirt","57 Sinop","58 Sivas","59 Tekirdağ","60 Tokat","61 Trabzon","62 Tunceli","63 Şanlıurfa","64 Uşak","65 Van","66 Yozgat","67 Zonguldak","68 Aksaray","69 Bayburt","70 Karaman","71 Kırıkkale","72 Batman","73 Şırnak","74 Bartın","75 Ardahan","76 Iğdır","77 Yalova","78 Karabük","79 Kilis","80 Osmaniye","81 Düzce"};
        #endregion

        SoundPlayer p = new SoundPlayer();

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            #region backgroundimage
            this.BackgroundImage = Image.FromFile("../../imagess/BG.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            #endregion

            #region Sehirler Yükleniyor
            int i = 0;

            while (i <= Sehirler.Length)
            {
                lstBolgeList.Items.Add(Sehirler[i].ToUpper());
                i++;
            }
            #endregion

            #region Default

            #endregion
        }

        #region Buttons
        private void btnAskerEkle_Click(object sender, EventArgs e)
        {
            YeniAskerEkle();
        }

        private void btnDagitimYap_Click_1(object sender, EventArgs e)
        {
            AskerDagitimiYap();
        } 
        #endregion

        #region Metodlar

        private void AskerDagitimiYap()
        {
            try
            {
                lstDagitim.Items.Clear();
                if (lstAskerList.Items.Count > 0)
                {
                    #region Dağıtma sesi
                    p.SoundLocation = "../../Sounds/card.wav";
                    p.Play();
                    #endregion

                    int i = 0;
                    foreach (string item in lstAskerList.Items)
                    {
                        Array.Resize(ref Askerler, Askerler.Length + 1);
                        Askerler[i] = item;
                        i++;
                    }
                    int k = 0;

                    while (k < Askerler.Length)
                    {
                        int Sehir = rnd.Next(0, lstBolgeList.Items.Count);
                        lstDagitim.Items.Add(Askerler[k].ToUpper() + "-" + Sehirler[Sehir].ToUpper());
                        k++;
                    }
                }

            }
            catch (Exception)
            {

            }
        }

        private void YeniAskerEkle()
        {
            if (!string.IsNullOrEmpty(txtAskerEkle.Text))
            {
                #region Ekleme sesi
                p.SoundLocation = "../../Sounds/add.wav";
                p.Play();
                #endregion

                lstAskerList.Items.Add(txtAskerEkle.Text);
                txtAskerEkle.Focus();
                txtAskerEkle.Clear();
            }
        }

        private void DefaultDegerler()
        {
            lstAskerList.Items.Clear();
            lstDagitim.Items.Clear();
        } 
        #endregion

        #region WindowsState
        private void Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSimgeDurumu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        } 
        #endregion

        #region Rakam Girisini Engelle
        private void txtAskerEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 58 & e.KeyChar >= 48) e.Handled = true;
            else if ((int)e.KeyChar == 8) e.Handled = false;
            else e.Handled = false;
        } 
        #endregion

        #region EMRE SANDIKÇI
        
        #endregion
    }
}
