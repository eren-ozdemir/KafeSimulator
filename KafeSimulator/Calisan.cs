using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeSimulator
{
    public class Calisan
    {
        public event EventHandler SiparisHazirlandi;
        public event EventHandler SiparisAlindi;
        public byte Id { get; set; }
        public Timer Timer { get; set; } = new Timer();
        public DateTime TimerStartTime { get; set; }
        public Panel Panel { get; set; }
        public ProgressBar ProgressBar { get; set; }
        public Button Button { get; set; }
        public Label Label { get; set; }
        private Size _siparisliBoyut => new Size(150, 90);
        private Size _siparissizBoyut => new Size(150, 35);

        public Panel IlgilendigiSira { get; set; }

        private Siparis _siparis;

        public Siparis Siparis
        {
            get { return _siparis; }
            set
            {
                if (value == null)
                {
                    SiparisiTemizle();
                    _siparis = value;
                }
                else
                {
                    _siparis = value;
                    SiparisHazirla();
                }
            }
        }

        public Konum Konum { get; set; }

        public void SiparisAl()
        {
            Panel.Size = _siparisliBoyut;
            ProgressBar.Value = 0;
            ProgressBar.Visible = true;
            Timer.Interval = 1000;
            TimerStartTime = DateTime.Now;
            Timer.Tick += SiparisAlmaTimer_Tick;
            Timer.Start();
        }

        private void SiparisAlmaTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - TimerStartTime;
            double yuzde = (double)ts.Seconds / 4 * 100;
            if (yuzde <= 100)
            {
                ProgressBar.Value = (int)yuzde;
                if (yuzde == 100)
                {
                    SiparisAlindi?.Invoke(this, EventArgs.Empty);
                    SiparisiTemizle();
                    Timer.Tick -= SiparisAlmaTimer_Tick;
                    Timer.Stop();
                    ProgressBar.Visible = false;
                }
            }
        }

        private void SiparisiTemizle()
        {
            Panel.Size = _siparissizBoyut;
            Label.Visible = false;
            ProgressBar.Value = 0;
            ProgressBar.Visible = false;
        }

        public void SiparisHazirla()
        {
            Timer.Interval = 1000;
            Timer.Tick += SiparisHazirlamaTimer_Tick;
            TimerStartTime = DateTime.Now;
            Timer.Start();
        }

        private void SiparisHazirlamaTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - TimerStartTime;
            double yuzde = (double)ts.Seconds / _siparis.HazirlanmaSuresi * 100;
            if (yuzde <= 100)
            {
                ProgressBar.Value = (int)yuzde;
                if (yuzde == 100)
                {
                    SiparisHazirlandi?.Invoke(this, EventArgs.Empty);
                    SiparisiTemizle();
                    Timer.Tick -= SiparisHazirlamaTimer_Tick;
                    Timer.Stop();
                }
            }
        }
    }
}
