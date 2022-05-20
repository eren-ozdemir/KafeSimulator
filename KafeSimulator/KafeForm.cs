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
        Random rnd = new Random();
        Size siparisliBoyut = new Size(90, 90);
        Size siparissizBoyut = new Size(90, 35);
        List<BackgroundWorker> backgroundWorkerList = new List<BackgroundWorker>() { new BackgroundWorker(), new BackgroundWorker(), new BackgroundWorker(), new BackgroundWorker(), new BackgroundWorker(), new BackgroundWorker() };
        List<BackgroundWorker> kasaBackgroundWorkerList = new List<BackgroundWorker>() { new BackgroundWorker(), new BackgroundWorker(), new BackgroundWorker(), new BackgroundWorker() };
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
        }

        #region Çalışan Mototları
        Panel CalisanOlustur(byte num, Siparis siparis = null)
        {
            bool siparisVarMi = siparis != null;
            Size size = siparisVarMi ? siparisliBoyut : siparissizBoyut;
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
            };
            Label lblSiparis = new Label()
            {
                Name = "lblCalisan" + num,
                Size = new Size(90, 45),
                Location = new Point(0, 10),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = siparis?.ToString()
            };
            Button btnCalisan = new Button()
            {
                Size = new Size(90, 35),
                Dock = DockStyle.Bottom,
                Text = "Çalışan " + num,
                Tag = num
            };
            pBarSiparis.Visible = siparisVarMi;
            lblSiparis.Visible = siparisVarMi;

            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            if (siparisVarMi)
                backgroundWorkerList[num].RunWorkerAsync(2000);
            else
                backgroundWorkerList[num] = worker;


            flpCalisan.Controls.Add(pBarSiparis);
            flpCalisan.Controls.Add(btnCalisan);
            flpCalisan.Controls.Add(lblSiparis);
            return flpCalisan;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int i = backgroundWorkerList.IndexOf(worker);
            if (pnlSira1.Controls.Count != 0)
                SiparisAl(pnlSira1);
            else if (pnlSira2.Controls.Count != 0)
                SiparisAl(pnlSira2);
            else if (pnlSira3.Controls.Count != 0)
                SiparisAl(pnlSira3);
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int i = backgroundWorkerList.FindIndex(w => w == worker);
            Panel calisan = flpMutfak.Controls["pnlCalisan" + i] as Panel;
            ProgressBar pBar = calisan.Controls["pBar" + i] as ProgressBar;
            Label lbl = calisan.Controls["lblCalisan" + i] as Label;
            pBar.Value = e.ProgressPercentage;
            if (pBar.Value == 100)
            {
                Siparis siparis = lbl.Tag as Siparis;
                foreach (Control item in flpSiparisBeklemeAlani.Controls)
                {
                    if ((item.Tag as Musteri).Siparis == siparis)
                        flpSiparisBeklemeAlani.Controls.Remove(item);
                }
                CalisandakiSiparisiSil(calisan);
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int arg = (int)e.Argument;
            e.Result = BackgroundProcessLogicMethod(worker, arg);
        }

        private object BackgroundProcessLogicMethod(BackgroundWorker worker, int arg)
        {
            int result = 0;
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(arg / 100);
                worker.ReportProgress(i);
            }

            return result;
        }

        void CalisanaSiparisEkle(Panel pnl, Siparis siparis)
        {
            pnl.Size = siparisliBoyut;
            ProgressBar pb = pnl.Controls["pBar" + (byte)pnl.Tag] as ProgressBar;
            Label lbl = pnl.Controls["lblCalisan" + (byte)pnl.Tag] as Label;
            pb.Visible = true;
            lbl.Text = siparis.ToString();
            lbl.Visible = true;
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
        #endregion

        Button MusteriOlustur(byte num)
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

        private void button5_Click(object sender, EventArgs e)
        {
            for (byte i = 0; i < 5; i++)
                flpSira.Controls.Add(MusteriOlustur(i));
        }

        void MusteriYerlestir()
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

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriYerlestir();
        }

        private void pnl_MusteriEklendi(object sender, ControlEventArgs e)
        {
            Panel pnl = sender as Panel;
            string numStr = pnl.Name.Remove(0, "pnlSira".Length);
            int num = Convert.ToInt32(numStr);
            BackgroundWorker backgroundWorker = kasaBackgroundWorkerList[num];
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerAsync(2000);
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;

            //SiparisAl((Panel)sender);
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int i = kasaBackgroundWorkerList.FindIndex(w => w == worker);
            Panel pnlSira = pnlSiralar.Controls["pnlSira" + i] as Panel;
            SiparisAl(pnlSira);
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int i = kasaBackgroundWorkerList.FindIndex(w => w == worker);
            Panel pnlSira = pnlSiralar.Controls["pnlSira" + i] as Panel;
            int arg = (int)e.Argument;
            e.Result = WorkerMethod(worker, arg);
        }

        private object WorkerMethod(BackgroundWorker worker, int arg)
        {
            int result = 0;
            Thread.Sleep(2000);
            return result;
        }

        private void flpMutfak_ControlAdded(object sender, ControlEventArgs e)
        {
            Panel calisan = (Panel)flpMutfak.Controls[flpMutfak.Controls.Count - 1];
            Label lbl = (Label)calisan.Controls.Find("lblCalisan" + (byte)calisan.Tag, true)[0];
            Siparis siparis = (Siparis)lbl.Tag;
            backgroundWorkerList[(byte)calisan.Tag].RunWorkerAsync(siparis.HazirlanmaSuresi * 1000);
        }

        private void flpCalisanBeklemeAlani_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
}
