using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace YILANOYUNUERDALFİDAN
{
    public partial class Form1 : Form
    {
        private Label _yilankafasi;
        private int _yilanParcasiArasiMesafe = 2;
        private int _yilanParcasiSayisi;
        private int _yilanBoyutu = 20;
        private int _yemBoyutu = 20;
        private Label _yem;
        private Random _random;
        private HareketYonu _yon;

        public Form1()
        {
            InitializeComponent();
            _random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _yilanParcasiSayisi = 0;
            YemOlustur();
            YeminYeriniDegistir();
            YilaniYerlestir(); 
            _yon = HareketYonu.Saga;
            timerYilanHareket.Enabled = true;
        }
        private void YenidenBaslat()

        {
            puan.Text = "0";
            sure.Text = "0";
            Sifirla();

        }
        
        public void Sifirla()
        {
            panel.Controls.Clear();
            _yilanParcasiSayisi = 0;
            YemOlustur();
            YeminYeriniDegistir();
            YilaniYerlestir();
            _yon = HareketYonu.Saga;
            timerYilanHareket.Enabled = true;
            timersaat.Enabled = true;
        }
        private Label YilanParcasiOlustur(int locationX, int locationY)
        {
            _yilanParcasiSayisi++;
            Label lbl = new Label()
            {
                Name = "yilanParca" + _yilanParcasiSayisi,
                BackColor = Color.Red,
                Width = _yilanBoyutu,
                Height = _yilanBoyutu,
                Location = new Point(locationX, locationY)
            };
            this.panel.Controls.Add(lbl);
            return lbl;
            ; }
        private void YilaniYerlestir()
        {
            _yilankafasi = YilanParcasiOlustur(0, 0);
            _yilankafasi.Text = ":";
            _yilankafasi.TextAlign = ContentAlignment.MiddleCenter;
            _yilankafasi.ForeColor = Color.White;
            var locationX = (panel.Width / 2) - (_yilankafasi.Width / 2);
            var locationY = (panel.Height / 2) - (_yilankafasi.Height / 2);
            _yilankafasi.Location = new Point(locationX, locationY);


        }
        private void YemOlustur()
        {
            Label lbl = new Label()
            {
                Name = "yem",
                BackColor = Color.Yellow,
                Width = _yemBoyutu,
                Height = _yemBoyutu,
            };
            _yem = lbl;
            this.panel.Controls.Add(lbl);
        }
        private void YeminYeriniDegistir()
        {
            var locationX = 0;
            var locationY = 0;

            bool durum;
            do
            {
                durum = false;
                locationX = _random.Next(0, panel.Width - _yemBoyutu);
                locationY = _random.Next(0, panel.Height - _yemBoyutu);
                var rect1 = new Rectangle(new Point(locationX, locationY), _yem.Size);
                foreach (Control control in panel.Controls)
                {
                    if (control is Label && control.Name.Contains("yilanParca"))
                    {
                        var rect2 = new Rectangle(control.Location, control.Size);
                        if (rect1.IntersectsWith(rect2))
                        {
                            durum = true;
                            break;
                        }
                    }
                }
            } while (durum);
            _yem.Location = new Point(locationX, locationY);
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {


        }
        private enum HareketYonu
        {
            Yukari,
            Asagi,
            Sola,
            Saga
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var keyCode = e.KeyCode;
            if (_yon == HareketYonu.Sola && keyCode == Keys.D
    || _yon == HareketYonu.Saga && keyCode == Keys.A
    || _yon == HareketYonu.Yukari && keyCode == Keys.S
    || _yon == HareketYonu.Asagi && keyCode == Keys.W)
            {
                return;
            }
            switch (keyCode)
            {
                case Keys.W:
                    _yon = HareketYonu.Yukari;
                    break;
                case Keys.S:
                    _yon = HareketYonu.Asagi;
                    break;
                case Keys.A:
                    _yon = HareketYonu.Sola;
                    break;
                case Keys.D:
                    _yon = HareketYonu.Saga;
                    break;
                case Keys.P:
                    timersaat.Enabled = false;
                    timerYilanHareket.Enabled = false;
                    break;
                case Keys.O:
                    timersaat.Enabled = true;
                    timerYilanHareket.Enabled = true;
                    break;
                default:
                    break;


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            OyunBittimi();
            YilanKafasiniTakipEt();
            var locationX = _yilankafasi.Location.X;
            var locationY = _yilankafasi.Location.Y;
            switch (_yon)
            {
                case HareketYonu.Yukari:
                    _yilankafasi.Location = new Point(locationX, locationY - (_yilankafasi.Width + _yilanParcasiArasiMesafe));
                    break;
                case HareketYonu.Asagi:
                    _yilankafasi.Location = new Point(locationX, locationY + (_yilankafasi.Width + _yilanParcasiArasiMesafe));
                    break;
                case HareketYonu.Sola:
                    _yilankafasi.Location = new Point(locationX - (_yilankafasi.Width + _yilanParcasiArasiMesafe), locationY);
                    break;
                case HareketYonu.Saga:
                    _yilankafasi.Location = new Point(locationX + (_yilankafasi.Width + _yilanParcasiArasiMesafe), locationY);
                    break;


            }
            void OyunBittimi()
            {
                bool oyunBittimi = false;
                var rect1 = new Rectangle(_yilankafasi.Location, _yilankafasi.Size);
                 foreach(Control control in panel.Controls)
                {
                    if  (control is Label && control.Name.Contains("yilanParca") && control.Name != _yilankafasi.Name)
                    {
                        var rect2 = new Rectangle(control.Location, control.Size);
                        if (rect1.IntersectsWith(rect2))
                        {
                            oyunBittimi = true;
                            break;
                        }
                    }
                }
                 if (oyunBittimi)
                {
                    timerYilanHareket.Enabled = false;
                    timersaat.Enabled = false;
                    DialogResult sonuc = MessageBox.Show("Puanınız : "+ puan.Text , "Oyun Bitti!", MessageBoxButtons.OKCancel,  MessageBoxIcon.Information);
                    if(sonuc == DialogResult.OK)
                    {
                        YenidenBaslat();
                    }
                } 
                        }


            YilanYemiYedimi();
            void YilanYemiYedimi()
            {
                var rect1 = new Rectangle(_yilankafasi.Location, _yilankafasi.Size);
                var rect2 = new Rectangle(_yem.Location, _yem.Size);
                if (rect1.IntersectsWith(rect2))
                {
                    puan.Text = (Convert.ToInt32(puan.Text) + 10).ToString();
                    YeminYeriniDegistir();
                    YilanParcasiOlustur(-_yilanBoyutu, -_yilanBoyutu);

                }

            }

        }
        private void YilanKafasiniTakipEt()
        {
            if (_yilanParcasiSayisi <= 1) return;

            for (int i = _yilanParcasiSayisi; i > 1; i--)
            {
                var sonrakiParca = (Label)panel.Controls[i];
                var oncekiParca = (Label)panel.Controls[i-1];
                sonrakiParca.Location = oncekiParca.Location;
            }
        }

        private void timersaat_Tick(object sender, EventArgs e)
        {
            sure.Text = (Convert.ToInt32(sure.Text)+1).ToString();
        }
    }

    }
