using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeSimulator
{
    public partial class KafeForm : Form
    {
        DateTime kasaStartTime1, kasaStartTime2, kasaStartTime3;
        Random rnd = new Random();
        int musteriSayaci = 1;
        Size siparisliBoyut = new Size(90, 90);
        Size siparissizBoyut = new Size(90, 35);

        List<Siparis> icecekler = new List<Siparis>()
        {
            new Siparis(){Ad = "Caffè Latte", HazirlanmaSuresi = 10},
            new Siparis(){Ad = "Cappuccino", HazirlanmaSuresi = 5},
            new Siparis(){Ad = "Iced Cappuccino", HazirlanmaSuresi = 5},
            new Siparis(){Ad = "Espresso", HazirlanmaSuresi = 7},
            new Siparis(){Ad = "Espresso Macchiato", HazirlanmaSuresi = 10},
            new Siparis(){Ad = "Cold Brew", HazirlanmaSuresi = 8},
            new Siparis(){Ad = "Türk Kahvesi", HazirlanmaSuresi = 6},
            new Siparis(){Ad = "Cool Lime", HazirlanmaSuresi = 10},
            new Siparis(){Ad = "Chai Tea Latte", HazirlanmaSuresi = 5},
            new Siparis(){Ad = "Iced Black Tea", HazirlanmaSuresi = 10},
        };
        public KafeForm()
        {
            InitializeComponent();
            pnlKasa1.Controls.Add(CalisanOlustur(1));
            pnlKasa2.Controls.Add(CalisanOlustur(2));
            pnlKasa3.Controls.Add(CalisanOlustur(3));
            flpCalisanBeklemeAlani.Controls.Add(CalisanOlustur(4));
            flpCalisanBeklemeAlani.Controls.Add(CalisanOlustur(5));
            flpSira.Controls.Add(MusteriOlustur(musteriSayaci++));
            flpSira.Controls.Add(MusteriOlustur(musteriSayaci++));
            flpSira.Controls.Add(MusteriOlustur(musteriSayaci++));
            flpSira.Controls.Add(MusteriOlustur(musteriSayaci++));
            tmrMusteriEkle.Start();
            Calistir();
        }

        void Calistir()
        {
        }

        Panel CalisanOlustur(byte num)
        {
            Size size = siparissizBoyut;
            Panel flpCalisan = new Panel()
            {
                Name = "pnlCalisan" + num,
                Size = size,
                Tag = num
            };
            ProgressBar pBarSiparis = new ProgressBar()
            {
                Name = "pBar" + num,
                Size = new Size(90, 10),
                Dock = DockStyle.Top,
                Visible = false
            };
            Label lblSiparis = new Label()
            {
                Name = "lblCalisan" + num,
                Size = new Size(90, 45),
                Location = new Point(0, 10),
                TextAlign = ContentAlignment.MiddleCenter,
                Visible = false
            };
            Button btnCalisan = new Button()
            {
                Size = new Size(90, 35),
                Dock = DockStyle.Bottom,
                Text = "Çalışan " + num,
                Tag = num
            };

            flpCalisan.Controls.Add(pBarSiparis);
            flpCalisan.Controls.Add(btnCalisan);
            flpCalisan.Controls.Add(lblSiparis);
            return flpCalisan;
        }

        Button MusteriOlustur(int num)
        {
            Musteri musteri = new Musteri()
            {
                Siparis = icecekler[rnd.Next(icecekler.Count)]
            };

            Button btn = new Button()
            {
                Text = "Müşteri " + num + "\n" + musteri.Siparis.Ad,
                Tag = musteri,
                Size = new Size(150, 90)
            };

            return btn;
        }

        void CalisanaSiparisEkle(Panel pnl, Siparis siparis)
        {
            pnl.Size = siparisliBoyut;
            ProgressBar pb = pnl.Controls["pBar" + (byte)pnl.Tag] as ProgressBar;
            Label lbl = pnl.Controls["lblCalisan" + (byte)pnl.Tag] as Label;
            pb.Visible = true;
            lbl.Visible = true;
            lbl.Text = siparis.ToString();
            lbl.Tag = siparis;
            pnl.Parent = flpMutfak;
        }

        void CalisandakiSiparisiSil(Panel pnl)
        {
            pnl.Size = siparissizBoyut;
            pnl.Parent = flpCalisanBeklemeAlani;

            foreach (Control item in pnl.Controls)
            {
                if (!(item is Button))
                    item.Visible = false;
            }
        }

        void SiparisAl(Panel pnlSira)
        {
            if (flpCalisanBeklemeAlani.Controls.Count > 0)
            {
                Panel calisan = (Panel)flpCalisanBeklemeAlani.Controls[0];
                Button btnMusteri = pnlSira.Controls[0] as Button;
                Siparis siparis = (btnMusteri.Tag as Musteri).Siparis;

                CalisanaSiparisEkle(calisan, siparis);
                btnMusteri.Parent = flpSiparisBeklemeAlani;
            }
        }

        private void flpMutfak_ControlAdded(object sender, ControlEventArgs e)
        {
            Panel calisan = (Panel)flpMutfak.Controls[flpMutfak.Controls.Count - 1];
            Label lbl = (Label)calisan.Controls.Find("lblCalisan" + (byte)calisan.Tag, true)[0];
            Siparis siparis = (Siparis)lbl.Tag;
        }

        void SiradanMusteriAl()
        {
            if (flpSira.Controls.Count > 0)
            {
                if (pnlSira1.Controls.Count == 0)
                    pnlSira1.Controls.Add(flpSira.Controls[0]);
                else if (pnlSira2.Controls.Count == 0)
                    pnlSira2.Controls.Add(flpSira.Controls[0]);
                else if (pnlSira3.Controls.Count == 0)
                    pnlSira3.Controls.Add(flpSira.Controls[0]);
            }
        }

        private void tmrMusteriEkle_Tick(object sender, EventArgs e)
        {
            tmrMusteriEkle.Interval = rnd.Next(5, 10) * 1000;
            flpSira.Controls.Add(MusteriOlustur(musteriSayaci++));
        }

        private void flpSira_ControlAdded(object sender, ControlEventArgs e)
        {
            SiradanMusteriAl();
        }

        #region Müsteri sıra yönetimi
        private void pnlSira1_ControlAdded(object sender, ControlEventArgs e)
        {
            kasaStartTime1 = DateTime.Now;
            tmrKasa1.Start();
        }

        private void pnlSira2_ControlAdded(object sender, ControlEventArgs e)
        {
            kasaStartTime2 = DateTime.Now;
            tmrKasa2.Start();
        }

        private void pnlSira3_ControlAdded(object sender, ControlEventArgs e)
        {
            kasaStartTime3 = DateTime.Now;
            tmrKasa3.Start();
        }

        private void tmrKasa1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - kasaStartTime1;
            if (ts.Seconds >= tmrKasa1.Interval / 1000)
            {
                if (flpCalisanBeklemeAlani.Controls.Count > 0)
                    SiparisAl(pnlSira1);
                tmrKasa1.Stop();
            }
        }

        private void tmrKasa2_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - kasaStartTime2;
            if (ts.Seconds >= tmrKasa2.Interval / 1000)
            {
                if (flpCalisanBeklemeAlani.Controls.Count > 0)
                    SiparisAl(pnlSira2);
                tmrKasa2.Stop();
            }
        }

        private void tmrKasa3_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - kasaStartTime3;
            if (ts.Seconds >= tmrKasa3.Interval / 1000)
            {
                if (flpCalisanBeklemeAlani.Controls.Count > 0)
                    SiparisAl(pnlSira3);
                tmrKasa3.Stop();
            }
        }
        #endregion

    }
}
