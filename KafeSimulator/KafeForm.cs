using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronXL;

namespace KafeSimulator
{
    public partial class KafeForm : Form
    {
        DateTime kasaStartTime1, kasaStartTime2, kasaStartTime3, calisanStartTime1, calisanStartTime2;
        //Dictionary<System.Windows.Forms.Timer, Panel> timerCalisanDict = new Dictionary<System.Windows.Forms.Timer, Panel>();
        Random rnd = new Random();
        int musteriSayaci = 1;
        int siparisSayaci = 1;
        Size siparisliBoyut = new Size(150, 90);
        Size siparissizBoyut = new Size(150, 35);
        
        BindingList<Siparis> bekleyenSiparisler = new BindingList<Siparis>();
        BindingList<Siparis> tumSiparisler = new BindingList<Siparis>();
        List<Siparis> icecekler = new List<Siparis>()
        {
            new Siparis(){Ad = "Caffè Latte", HazirlanmaSuresi = 9},
            new Siparis(){Ad = "Cappuccino", HazirlanmaSuresi = 5},
            new Siparis(){Ad = "Iced Cappuccino", HazirlanmaSuresi = 5},
            new Siparis(){Ad = "Espresso", HazirlanmaSuresi = 7},
            new Siparis(){Ad = "Espresso Macchiato", HazirlanmaSuresi = 9},
            new Siparis(){Ad = "Cold Brew", HazirlanmaSuresi = 8},
            new Siparis(){Ad = "Türk Kahvesi", HazirlanmaSuresi = 6},
            new Siparis(){Ad = "Cool Lime", HazirlanmaSuresi = 9},
            new Siparis(){Ad = "Chai Tea Latte", HazirlanmaSuresi = 5},
            new Siparis(){Ad = "Iced Black Tea", HazirlanmaSuresi = 9},
        };
        public KafeForm()
        {
            InitializeComponent();
            pnlKasa1.Controls.Add(CalisanOlustur(3));
            pnlKasa2.Controls.Add(CalisanOlustur(4));
            pnlKasa3.Controls.Add(CalisanOlustur(5));
            flpCalisanBeklemeAlani.Controls.Add(CalisanOlustur(1));
            flpCalisanBeklemeAlani.Controls.Add(CalisanOlustur(2));
            flpSira.Controls.Add(MusteriOlustur(musteriSayaci++));
            flpSira.Controls.Add(MusteriOlustur(musteriSayaci++));
            tmrMusteriEkle.Start();
            tmrSiparisKontrol.Start();
            CalisanlaraSiparisVer();
            dgwBekleyenSiparisler.DataSource = bekleyenSiparisler;
            dgwTumSiparisler.DataSource = tumSiparisler;
        }

        Panel CalisanOlustur(byte num)
        {
            Size size = siparissizBoyut;
            Panel flpCalisan = new Panel()
            {
                Name = "pnlCalisan" + num,
                Size = size,
                Tag = num,
            };
            ProgressBar pBarSiparis = new ProgressBar()
            {
                Name = "pBar" + num,
                Size = new Size(siparisliBoyut.Width, 10),
                Dock = DockStyle.Top,
                Visible = false
            };
            Label lblSiparis = new Label()
            {
                Name = "lblCalisan" + num,
                Size = new Size(siparisliBoyut.Width, 45),
                Location = new Point(0, 10),
                TextAlign = ContentAlignment.MiddleCenter,
                Visible = false
            };
            Button btnCalisan = new Button()
            {
                Size = new Size(90, 35),
                Dock = DockStyle.Bottom,
                Text = "Çalışan " + num,
                Tag = num,
                FlatStyle = FlatStyle.Flat,
            };

            flpCalisan.Controls.Add(pBarSiparis);
            flpCalisan.Controls.Add(btnCalisan);
            flpCalisan.Controls.Add(lblSiparis);
            return flpCalisan;
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
            ProgressBar pBar = pnl.Controls["pBar"+(byte)pnl.Tag] as ProgressBar;
            Label lbl = pnl.Controls["lblCalisan"+(byte)pnl.Tag] as Label;
            pBar.Value = 0;
            pBar.Visible = false;
            lbl.Visible = false;
            pnl.Parent = flpCalisanBeklemeAlani;
        }

        void SiparisiHavuzaEkle(Panel pnlSira)
        {
            Button btnMusteri = pnlSira.Controls[0] as Button;
            Siparis siparis = (btnMusteri.Tag as Musteri).Siparis;
            bekleyenSiparisler.Add(siparis);
            tumSiparisler.Add(siparis);
        }

        void MusteriyiBeklemeAlaninaAl(Button musteri)
        {
            musteri.Parent = flpSiparisBeklemeAlani;
        }

        void CalisanlaraSiparisVer()
        {
            if (bekleyenSiparisler.Count > 0 && flpCalisanBeklemeAlani.Controls.Count > 0)
            {
                Panel calisan = (Panel)flpCalisanBeklemeAlani.Controls[0];
                CalisanaSiparisEkle(calisan, bekleyenSiparisler[0]);
                bekleyenSiparisler.RemoveAt(0);
            }
        }

        void SiparisiTeslimEt(Siparis siparis)
        {
            foreach (Button btnMusteri in flpSiparisBeklemeAlani.Controls)
            {
                Musteri musteri = (Musteri)btnMusteri.Tag;
                if (musteri.Siparis == siparis)
                    flpSiparisBeklemeAlani.Controls.Remove(btnMusteri);
            }
        }

        private void flpMutfak_ControlAdded(object sender, ControlEventArgs e)
        {
            Panel calisan = (Panel)flpMutfak.Controls[flpMutfak.Controls.Count - 1];
            Label lbl = (Label)calisan.Controls.Find("lblCalisan" + (byte)calisan.Tag, true)[0];
            Siparis siparis = (Siparis)lbl.Tag;

            switch ((byte)calisan.Tag)
            {

                case 1:
                    calisanStartTime1 = DateTime.Now;
                    tmrCalisan1.Interval = 1000;
                    tmrCalisan1.Start();
                    break;
                case 2:
                    calisanStartTime2 = DateTime.Now;
                    tmrCalisan2.Interval = 1000;
                    tmrCalisan2.Start();
                    break;
                case 3:
                    calisanStartTime2 = DateTime.Now;
                    tmrCalisan2.Interval = 1000;
                    tmrCalisan2.Start();
                    break;
                default:
                    break;
            }
        }

        private void tmrCalisan1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - calisanStartTime1;
            Panel calisan = flpMutfak.Controls["pnlCalisan1"] as Panel;
            ProgressBar pBar = calisan.Controls["pBar1"] as ProgressBar;
            Label lbl = calisan.Controls["lblCalisan1"] as Label;
            Siparis siparis = (Siparis)lbl.Tag;
            double yuzde = (double)ts.Seconds / siparis.HazirlanmaSuresi * 100;
            if (yuzde <= 100)
            {
                pBar.Value = (int)yuzde;
                if (yuzde == 100)
                {
                    CalisandakiSiparisiSil(calisan);
                    SiparisiTeslimEt(siparis);
                    tmrCalisan1.Stop();
                }
            }
        }

        private void tmrCalisan2_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - calisanStartTime2;
            Panel calisan = flpMutfak.Controls["pnlCalisan2"] as Panel;
            ProgressBar pBar = calisan.Controls["pBar2"] as ProgressBar;
            Label lbl = calisan.Controls["lblCalisan2"] as Label;
            Siparis siparis = (Siparis)lbl.Tag;
            double yuzde = (double)ts.Seconds / siparis.HazirlanmaSuresi * 100;
            if (yuzde <= 100)
            {
                pBar.Value = (int)yuzde;
                if (yuzde == 100)
                {
                    CalisandakiSiparisiSil(calisan);
                    SiparisiTeslimEt(siparis);
                    tmrCalisan2.Stop();
                }
            }
        }

        private void tmrSiparisKontrol_Tick(object sender, EventArgs e)
        {
            CalisanlaraSiparisVer();
        }

        
        #region Müsteri sıra yönetimi
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
                Size = new Size(150, 90),
                FlatStyle = FlatStyle.Flat,
            };

            return btn;
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

        private void flpSira_ControlAdded(object sender, ControlEventArgs e)
        {
            SiradanMusteriAl();
        }
        private void tmrMusteriEkle_Tick(object sender, EventArgs e)
        {
            tmrMusteriEkle.Interval = rnd.Next(4,8) * 1000;
            flpSira.Controls.Add(MusteriOlustur(musteriSayaci++));
        }

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

        private void pnlSiralar_Paint(object sender, PaintEventArgs e)
        {

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
                SiparisiHavuzaEkle(pnlSira1);
                MusteriyiBeklemeAlaninaAl(pnlSira1.Controls[0] as Button);
                SiradanMusteriAl();
                tmrKasa1.Stop();
            }
        }

        private void tmrKasa2_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - kasaStartTime2;
            if (ts.Seconds >= tmrKasa2.Interval / 1000)
            {
                SiparisiHavuzaEkle(pnlSira2);
                MusteriyiBeklemeAlaninaAl(pnlSira2.Controls[0] as Button);
                SiradanMusteriAl();
                tmrKasa2.Stop();
            }
        }

        private void tmrKasa3_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - kasaStartTime3;
            if (ts.Seconds >= tmrKasa3.Interval / 1000)
            {
                SiparisiHavuzaEkle(pnlSira3);
                MusteriyiBeklemeAlaninaAl(pnlSira3.Controls[0] as Button);
                SiradanMusteriAl();
                tmrKasa3.Stop();
            }
        }
        #endregion

        private void KafeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var newXLFile = WorkBook.Create(ExcelFileFormat.XLSX);
            var newWorkSheet = newXLFile.CreateWorkSheet("data");

            for (int i = 1; i <= tumSiparisler.Count; i++)
            {
                newWorkSheet["A" + i].Value = tumSiparisler[i - 1].Ad;
                newWorkSheet["B" + i].Value = tumSiparisler[i - 1].HazirlanmaSuresi;
            }

            newXLFile.SaveAs("data.xlsx");
        }

    }
}
