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
        Random rnd = new Random();
        int musteriSayaci = 1;
        Size siparisliBoyut = new Size(150, 90);
        Size siparissizBoyut = new Size(150, 35);

        BindingList<Siparis> bekleyenSiparisler = new BindingList<Siparis>();
        BindingList<Siparis> tumSiparisler = new BindingList<Siparis>();
        List<Siparis> icecekler = new List<Siparis>()
        {
            new Siparis(){Ad = "Caffè Latte", HazirlanmaSuresi = 3},
            new Siparis(){Ad = "Cappuccino", HazirlanmaSuresi = 5},
            new Siparis(){Ad = "Iced Cappuccino", HazirlanmaSuresi = 5},
            new Siparis(){Ad = "Espresso", HazirlanmaSuresi = 5},
            new Siparis(){Ad = "Espresso Macchiato", HazirlanmaSuresi = 5},
            new Siparis(){Ad = "Cold Brew", HazirlanmaSuresi = 5},
            new Siparis(){Ad = "Türk Kahvesi", HazirlanmaSuresi = 5},
            new Siparis(){Ad = "Cool Lime", HazirlanmaSuresi = 5},
            new Siparis(){Ad = "Chai Tea Latte", HazirlanmaSuresi = 5},
            new Siparis(){Ad = "Iced Black Tea", HazirlanmaSuresi = 5},
        };
        public KafeForm()
        {
            InitializeComponent();
            CalisanYonetim();
            flpSira.Controls.Add(MusteriOlustur(musteriSayaci++));
            tmrMusteriEkle.Start();
            tmrSiparisKontrol.Start();
            CalisanlaraSiparisVer();
            dgwBekleyenSiparisler.DataSource = bekleyenSiparisler;
            dgwTumSiparisler.DataSource = tumSiparisler;
            pnlSira1.Tag = flpKasa1;
            flpKasa1.Tag = pnlSira1;
            pnlSira2.Tag = flpKasa2;
            flpKasa2.Tag = pnlSira2;
            pnlSira3.Tag = flpKasa3;
            flpKasa3.Tag = pnlSira3;
        }

        void CalisanYonetim()
        {
            CalisanManager.CalisanSayisi = 5;
            byte mutfaktakiElemanSayisi = 2;

            CalisanManager.CalisanListesi.Add(new Calisan() { Id = 0 }); // id-index eşleşmesini sağlamak için listenin ilk elemanı boş çalışan 
            for (byte i = 1; i <= mutfaktakiElemanSayisi; i++)
            {
                flpCalisanBeklemeAlani.Controls.Add(CalisanOlustur(i, Konum.Mutfak).Panel);
            }

            for (byte i = (byte)(mutfaktakiElemanSayisi + 1); i <= CalisanManager.CalisanSayisi; i++)
            {
                CalisanManager.CalisanListesi.Add(new Calisan() { Konum = Konum.Kasa, Id = i });

                if (flpKasa1.Controls.Count == 0)
                    flpKasa1.Controls.Add(CalisanOlustur(i, Konum.Kasa).Panel);
                else if (flpKasa2.Controls.Count == 0)
                    flpKasa2.Controls.Add(CalisanOlustur(i, Konum.Kasa).Panel);
                else if (flpKasa3.Controls.Count == 0)
                    flpKasa3.Controls.Add(CalisanOlustur(i, Konum.Kasa).Panel);
            }
        }

        Calisan CalisanOlustur(byte num, Konum konum)
        {
            Size size = siparissizBoyut;
            Panel pnlCalisan = new Panel()
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
            btnCalisan.Click += CalisanKonumuDegistir;

            pnlCalisan.Controls.Add(pBarSiparis);
            pnlCalisan.Controls.Add(btnCalisan);
            pnlCalisan.Controls.Add(lblSiparis);

            Calisan calisan = new Calisan()
            {
                Konum = konum,
                Panel = pnlCalisan,
                Button = btnCalisan,
                Label = lblSiparis,
                ProgressBar = pBarSiparis,
            };
            calisan.SiparisHazirlandi += SiparisHazirlandiMetot;
            calisan.SiparisAlindi += SiparisAlindiMetot;
            calisan.Panel.Tag = calisan;
            return calisan;
        }

        private void SiparisAlindiMetot(object sender, EventArgs e)
        {
            Calisan calisan = (Calisan)sender;
            Button btnMusteri = calisan.IlgilendigiSira.Controls[0] as Button;
            SiparisiHavuzaEkle(calisan.IlgilendigiSira);
            MusteriyiBeklemeAlaninaAl(btnMusteri);
            SiradanMusteriAl();
        }

        private void CalisanKonumuDegistir(object sender, EventArgs e)
        {
            Panel pnlCalisan = (Panel)((Button)sender).Parent;
            Calisan calisan = (Calisan)pnlCalisan.Tag;
            if (calisan.Konum == Konum.Mutfak)
            {
                calisan.Panel.Location = new Point(0, 0);
                calisan.Konum = Konum.Kasa;
                CalisaniKasayaYerlestir(calisan);
            }
            else
            {
                calisan.Konum = Konum.Mutfak;
                pnlCalisan.Parent = flpCalisanBeklemeAlani;
            }
        }

        void CalisaniKasayaYerlestir(Calisan calisan)
        {

            if (flpKasa1.Controls.Count == 0)
            {
                calisan.IlgilendigiSira = pnlSira1;
                calisan.Panel.Parent = flpKasa1;
            }
            else if (flpKasa2.Controls.Count == 0)
            {
                calisan.IlgilendigiSira = pnlSira2;
                calisan.Panel.Parent = flpKasa2;
            }
            else if (flpKasa3.Controls.Count == 0)
            {
                calisan.IlgilendigiSira = pnlSira3;
                calisan.Panel.Parent = flpKasa3;
            }
        }

        void CalisanaSiparisEkle(Calisan calisan, Siparis siparis)
        {
            calisan.Siparis = siparis;
            calisan.Panel.Size = siparisliBoyut;
            calisan.ProgressBar.Visible = true;
            calisan.Label.Text = siparis.ToString();
            calisan.Label.Visible = true;
            calisan.Panel.Parent = flpMutfak;
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
            Panel pnlCalisan = (Panel)flpMutfak.Controls[flpMutfak.Controls.Count - 1];
            Calisan calisan = pnlCalisan.Tag as Calisan;
            calisan.SiparisHazirla();
        }

        void SiparisHazirlandiMetot(object sender, EventArgs e)
        {
            Calisan calisan = sender as Calisan;
            calisan.Panel.Parent = flpCalisanBeklemeAlani;
            SiparisiTeslimEt(calisan.Siparis);
        }

        private void tmrSiparisKontrol_Tick(object sender, EventArgs e)
        {
            CalisanlaraSiparisVer();
            SiparisAlKontrol();
        }

        private void SiparisAlKontrol()
        {
            if (flpKasa1.Controls.Count > 0 && pnlSira1.Controls.Count > 0)
            {
                Calisan calisan = (flpKasa1.Controls[0] as Panel).Tag as Calisan;
                if (calisan.ProgressBar.Value == 0)
                    calisan.SiparisAl();
            }

            if (flpKasa2.Controls.Count > 0 && pnlSira2.Controls.Count > 0)
            {
                Calisan calisan = (flpKasa2.Controls[0] as Panel).Tag as Calisan;
                if (calisan.ProgressBar.Value == 0)
                    calisan.SiparisAl();
            }

            if (flpKasa3.Controls.Count > 0 && pnlSira3.Controls.Count > 0)
            {
                Calisan calisan = (flpKasa3.Controls[0] as Panel).Tag as Calisan;
                if (calisan.ProgressBar.Value == 0)
                    calisan.SiparisAl();
            }
        }

        //Bekleme alanındaki çalışanı siparişe yönlendirme
        void CalisanlaraSiparisVer()
        {
            if (bekleyenSiparisler.Count > 0 && flpCalisanBeklemeAlani.Controls.Count > 0)
            {
                Panel pnlCalisan = (Panel)flpCalisanBeklemeAlani.Controls[0];
                Calisan calisan = (Calisan)pnlCalisan.Tag;
                CalisanaSiparisEkle(calisan, bekleyenSiparisler[0]);
                bekleyenSiparisler.RemoveAt(0);
            }
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

        //Kuyruktan sıraya müşteri alma
        void SiradanMusteriAl()
        {
            if (flpSira.Controls.Count > 0)
            {
                if (pnlSira1.Controls.Count == 0)
                    flpSira.Controls[0].Parent = pnlSira1;
                else if (pnlSira2.Controls.Count == 0)
                    flpSira.Controls[0].Parent = pnlSira2;
                else if (pnlSira3.Controls.Count == 0)
                    flpSira.Controls[0].Parent = pnlSira3;
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
            if (flpKasa1.Controls.Count != 0)
                ((flpKasa1.Controls[0] as Panel).Tag as Calisan).SiparisAl();
        }

        private void pnlSira2_ControlAdded(object sender, ControlEventArgs e)
        {
            if (flpKasa2.Controls.Count != 0)
                ((flpKasa2.Controls[0] as Panel).Tag as Calisan).SiparisAl();
        }

        private void pnlSira3_ControlAdded(object sender, ControlEventArgs e)
        {
            if (flpKasa3.Controls.Count != 0)
                ((flpKasa3.Controls[0] as Panel).Tag as Calisan).SiparisAl();
        }

        private void pnlKasa1_ControlAdded(object sender, ControlEventArgs e)
        {
            Calisan calisan = (flpKasa1.Controls[0] as Panel).Tag as Calisan;
            calisan.IlgilendigiSira = pnlSira1;
            if (pnlSira1.Controls.Count != 0)
            {
                calisan.SiparisAl();
            }
        }

        private void pnlKasa2_ControlAdded(object sender, ControlEventArgs e)
        {
            Calisan calisan = (flpKasa2.Controls[0] as Panel).Tag as Calisan;
            calisan.IlgilendigiSira = pnlSira2;
            if (pnlSira2.Controls.Count != 0)
            {
                calisan.SiparisAl();
            }
        }

        private void pnlKasa3_ControlAdded(object sender, ControlEventArgs e)
        {
            Calisan calisan = (flpKasa3.Controls[0] as Panel).Tag as Calisan;
            calisan.IlgilendigiSira = pnlSira3;
            if (pnlSira3.Controls.Count != 0)
            {
                calisan.SiparisAl();
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
