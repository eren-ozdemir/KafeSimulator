using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeSimulator
{
    public partial class KafeForm : Form
    {
        List<BackgroundWorker> backgroundWorkerList = new List<BackgroundWorker>();
        public KafeForm()
        {
            InitializeComponent();
            flpCalisanBeklemeAlani.Controls.Add(CalisanOlustur(1));
        }

        Panel CalisanOlustur( byte num, string siparis = "")
        {
            bool siparisVarMi = siparis != "";
            Size size = siparisVarMi ? new Size(90, 90) : new Size(90, 35);
            Panel flpCalisan = new Panel()
            {
                Size = size,
                Name = "pnlCalisan" + num,
                Tag = num
            };
            ProgressBar pBarSiparis = new ProgressBar()
            {
                Size = new Size(90, 10),
                Dock = DockStyle.Top,
                Name = "pBar" + num
            };
            Label lblSiparis = new Label()
            {
                Size = new Size(90, 45),
                Location = new Point(0,10),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = siparis
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
            if (siparisVarMi)
                backgroundWorkerList[num-1].RunWorkerAsync(2000);
            else
                backgroundWorkerList.Add(worker);


            flpCalisan.Controls.Add(pBarSiparis);
            flpCalisan.Controls.Add(btnCalisan);
            flpCalisan.Controls.Add(lblSiparis);
            return flpCalisan;
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar pBar = flpMutfak.Controls["pnlCalisan1"].Controls["pBar1"] as ProgressBar;
            pBar.Value = e.ProgressPercentage;
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
            MessageBox.Show("Sipariş hazır.", "Sipariş Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
            return result;
        }

        void SiparisAl()
        {
            Panel calisan = (Panel)flpCalisanBeklemeAlani.Controls[0];
            Panel siparisli = CalisanOlustur((byte)calisan.Tag, "Kahve");
            flpCalisanBeklemeAlani.Controls.Remove(calisan);
            flpMutfak.Controls.Add(siparisli);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SiparisAl();
        }
    }
}
