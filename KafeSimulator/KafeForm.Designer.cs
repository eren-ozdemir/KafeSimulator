namespace KafeSimulator
{
    partial class KafeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlKasa3 = new System.Windows.Forms.Panel();
            this.pnlKasa2 = new System.Windows.Forms.Panel();
            this.pnlKasa1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.flpMutfak = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCalisanBeklemeAlani = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSiralar = new System.Windows.Forms.Panel();
            this.flpSiparisBeklemeAlani = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSira3 = new System.Windows.Forms.Panel();
            this.flpSira = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSira2 = new System.Windows.Forms.Panel();
            this.pnlSira1 = new System.Windows.Forms.Panel();
            this.tmrKasa1 = new System.Windows.Forms.Timer(this.components);
            this.tmrKasa2 = new System.Windows.Forms.Timer(this.components);
            this.tmrKasa3 = new System.Windows.Forms.Timer(this.components);
            this.tmrMusteriEkle = new System.Windows.Forms.Timer(this.components);
            this.tmrCalisan1 = new System.Windows.Forms.Timer(this.components);
            this.tmrCalisan2 = new System.Windows.Forms.Timer(this.components);
            this.tmrSiparisKontrol = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.pnlSiralar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pnlKasa3);
            this.panel1.Controls.Add(this.pnlKasa2);
            this.panel1.Controls.Add(this.pnlKasa1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.flpMutfak);
            this.panel1.Controls.Add(this.flpCalisanBeklemeAlani);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 234);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(732, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mutfak";
            // 
            // pnlKasa3
            // 
            this.pnlKasa3.Location = new System.Drawing.Point(650, 165);
            this.pnlKasa3.Name = "pnlKasa3";
            this.pnlKasa3.Size = new System.Drawing.Size(130, 66);
            this.pnlKasa3.TabIndex = 5;
            // 
            // pnlKasa2
            // 
            this.pnlKasa2.Location = new System.Drawing.Point(473, 165);
            this.pnlKasa2.Name = "pnlKasa2";
            this.pnlKasa2.Size = new System.Drawing.Size(130, 66);
            this.pnlKasa2.TabIndex = 5;
            // 
            // pnlKasa1
            // 
            this.pnlKasa1.Location = new System.Drawing.Point(279, 165);
            this.pnlKasa1.Name = "pnlKasa1";
            this.pnlKasa1.Size = new System.Drawing.Size(130, 66);
            this.pnlKasa1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bekleme Alanı";
            // 
            // flpMutfak
            // 
            this.flpMutfak.BackColor = System.Drawing.Color.LightSalmon;
            this.flpMutfak.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpMutfak.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMutfak.Location = new System.Drawing.Point(810, 0);
            this.flpMutfak.Name = "flpMutfak";
            this.flpMutfak.Size = new System.Drawing.Size(388, 234);
            this.flpMutfak.TabIndex = 2;
            this.flpMutfak.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flpMutfak_ControlAdded);
            // 
            // flpCalisanBeklemeAlani
            // 
            this.flpCalisanBeklemeAlani.BackColor = System.Drawing.Color.Teal;
            this.flpCalisanBeklemeAlani.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpCalisanBeklemeAlani.Location = new System.Drawing.Point(0, 0);
            this.flpCalisanBeklemeAlani.Name = "flpCalisanBeklemeAlani";
            this.flpCalisanBeklemeAlani.Size = new System.Drawing.Size(209, 234);
            this.flpCalisanBeklemeAlani.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(698, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sipariş Bekleme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kasa 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kasa 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasa 1";
            // 
            // pnlSiralar
            // 
            this.pnlSiralar.Controls.Add(this.label5);
            this.pnlSiralar.Controls.Add(this.flpSiparisBeklemeAlani);
            this.pnlSiralar.Controls.Add(this.pnlSira3);
            this.pnlSiralar.Controls.Add(this.flpSira);
            this.pnlSiralar.Controls.Add(this.pnlSira2);
            this.pnlSiralar.Controls.Add(this.label3);
            this.pnlSiralar.Controls.Add(this.pnlSira1);
            this.pnlSiralar.Controls.Add(this.label1);
            this.pnlSiralar.Controls.Add(this.label2);
            this.pnlSiralar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSiralar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlSiralar.Location = new System.Drawing.Point(0, 234);
            this.pnlSiralar.Name = "pnlSiralar";
            this.pnlSiralar.Size = new System.Drawing.Size(1198, 420);
            this.pnlSiralar.TabIndex = 1;
            // 
            // flpSiparisBeklemeAlani
            // 
            this.flpSiparisBeklemeAlani.BackColor = System.Drawing.Color.Crimson;
            this.flpSiparisBeklemeAlani.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpSiparisBeklemeAlani.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSiparisBeklemeAlani.Location = new System.Drawing.Point(810, 0);
            this.flpSiparisBeklemeAlani.Name = "flpSiparisBeklemeAlani";
            this.flpSiparisBeklemeAlani.Size = new System.Drawing.Size(388, 324);
            this.flpSiparisBeklemeAlani.TabIndex = 7;
            // 
            // pnlSira3
            // 
            this.pnlSira3.Location = new System.Drawing.Point(637, 40);
            this.pnlSira3.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSira3.Name = "pnlSira3";
            this.pnlSira3.Size = new System.Drawing.Size(153, 93);
            this.pnlSira3.TabIndex = 5;
            this.pnlSira3.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlSira3_ControlAdded);
            // 
            // flpSira
            // 
            this.flpSira.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpSira.Location = new System.Drawing.Point(0, 324);
            this.flpSira.Name = "flpSira";
            this.flpSira.Size = new System.Drawing.Size(1198, 96);
            this.flpSira.TabIndex = 5;
            this.flpSira.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flpSira_ControlAdded);
            // 
            // pnlSira2
            // 
            this.pnlSira2.Location = new System.Drawing.Point(460, 40);
            this.pnlSira2.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSira2.Name = "pnlSira2";
            this.pnlSira2.Size = new System.Drawing.Size(153, 93);
            this.pnlSira2.TabIndex = 5;
            this.pnlSira2.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlSira2_ControlAdded);
            // 
            // pnlSira1
            // 
            this.pnlSira1.Location = new System.Drawing.Point(266, 40);
            this.pnlSira1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSira1.Name = "pnlSira1";
            this.pnlSira1.Size = new System.Drawing.Size(153, 93);
            this.pnlSira1.TabIndex = 5;
            this.pnlSira1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlSira1_ControlAdded);
            // 
            // tmrKasa1
            // 
            this.tmrKasa1.Interval = 2000;
            this.tmrKasa1.Tick += new System.EventHandler(this.tmrKasa1_Tick);
            // 
            // tmrKasa2
            // 
            this.tmrKasa2.Interval = 2000;
            this.tmrKasa2.Tick += new System.EventHandler(this.tmrKasa2_Tick);
            // 
            // tmrKasa3
            // 
            this.tmrKasa3.Interval = 2000;
            this.tmrKasa3.Tick += new System.EventHandler(this.tmrKasa3_Tick);
            // 
            // tmrMusteriEkle
            // 
            this.tmrMusteriEkle.Tick += new System.EventHandler(this.tmrMusteriEkle_Tick);
            // 
            // tmrCalisan1
            // 
            this.tmrCalisan1.Interval = 2000;
            this.tmrCalisan1.Tick += new System.EventHandler(this.tmrCalisan1_Tick);
            // 
            // tmrCalisan2
            // 
            this.tmrCalisan2.Interval = 2000;
            this.tmrCalisan2.Tick += new System.EventHandler(this.tmrCalisan2_Tick);
            // 
            // tmrSiparisKontrol
            // 
            this.tmrSiparisKontrol.Interval = 1000;
            this.tmrSiparisKontrol.Tick += new System.EventHandler(this.tmrSiparisKontrol_Tick);
            // 
            // KafeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 654);
            this.Controls.Add(this.pnlSiralar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KafeForm";
            this.Text = "Kafe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSiralar.ResumeLayout(false);
            this.pnlSiralar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpMutfak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flpCalisanBeklemeAlani;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSiralar;
        private System.Windows.Forms.Panel pnlKasa3;
        private System.Windows.Forms.Panel pnlKasa2;
        private System.Windows.Forms.Panel pnlKasa1;
        private System.Windows.Forms.FlowLayoutPanel flpSira;
        private System.Windows.Forms.Panel pnlSira3;
        private System.Windows.Forms.Panel pnlSira2;
        private System.Windows.Forms.Panel pnlSira1;
        private System.Windows.Forms.FlowLayoutPanel flpSiparisBeklemeAlani;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer tmrKasa1;
        private System.Windows.Forms.Timer tmrKasa2;
        private System.Windows.Forms.Timer tmrKasa3;
        private System.Windows.Forms.Timer tmrMusteriEkle;
        private System.Windows.Forms.Timer tmrCalisan1;
        private System.Windows.Forms.Timer tmrCalisan2;
        private System.Windows.Forms.Timer tmrSiparisKontrol;
    }
}

