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
        private byte _gecenSaniye;
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
                _siparis = value;
            }
        }

        private Konum _konum;

        public Konum Konum
        {
            get { return _konum; }
            set
            {
                if (_konum != value)
                {
                    _konum = value;
                    Timer.Stop();
                    if (value == Konum.Mutfak)
                    {
                        Timer.Tick += SiparisHazirlamaTimer_Tick;
                        Timer.Tick -= SiparisAlmaTimer_Tick;
                    }
                    else if (value == Konum.Kasa)
                    {
                        Timer.Tick -= SiparisHazirlamaTimer_Tick;
                        Timer.Tick += SiparisAlmaTimer_Tick;

                    }
                }
                if (Panel != null)
                    Resetle();
            }
        }


        public void SiparisAl()
        {
            Panel.Size = _siparisliBoyut;
            ProgressBar.Value = 0;
            ProgressBar.Visible = true;
            Timer.Interval = 1000;
            Timer.Start();
        }

        private void SiparisAlmaTimer_Tick(object sender, EventArgs e)
        {
            _gecenSaniye++;

            double yuzde = (double)_gecenSaniye / 4 * 100;
            ProgressBar.Value = (int)yuzde;
            if (_gecenSaniye == 4)
            {
                SiparisAlindi?.Invoke(this, EventArgs.Empty);
                Resetle();
                _gecenSaniye = 0;
                Timer.Stop();
            }
        }

        private void Resetle()
        {
            Panel.Size = _siparissizBoyut;
            Label.Visible = false;
            ProgressBar.Value = 0;
            ProgressBar.Visible = false;
            _gecenSaniye = 0;
        }

        public void SiparisHazirla()
        {
            Panel.Size = _siparisliBoyut;
            ProgressBar.Value = 0;
            ProgressBar.Visible = true;
            Timer.Interval = 1000;
            Timer.Start();
        }

        private void SiparisHazirlamaTimer_Tick(object sender, EventArgs e)
        {
            _gecenSaniye++;
            if (Siparis != null)
            {
                double yuzde = (double)_gecenSaniye / Siparis.HazirlanmaSuresi * 100;
                ProgressBar.Value = (int)yuzde;

                if (_gecenSaniye == Siparis.HazirlanmaSuresi)
                {
                    SiparisHazirlandi?.Invoke(this, EventArgs.Empty);
                    Resetle();
                    Timer.Stop();
                }
            }

        }
    }
}
