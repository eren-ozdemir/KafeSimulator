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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KafeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpKasa3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpKasa2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpKasa1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgwTumSiparisler = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgwBekleyenSiparisler = new System.Windows.Forms.DataGridView();
            this.flpMutfak = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCalisanBeklemeAlani = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlSiralar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.flpSiparisBeklemeAlani = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSira3 = new System.Windows.Forms.Panel();
            this.flpSira = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSira2 = new System.Windows.Forms.Panel();
            this.pnlSira1 = new System.Windows.Forms.Panel();
            this.tmrMusteriEkle = new System.Windows.Forms.Timer(this.components);
            this.tmrSiparisKontrol = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTumSiparisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBekleyenSiparisler)).BeginInit();
            this.pnlSiralar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(98)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.flpKasa3);
            this.panel1.Controls.Add(this.flpKasa2);
            this.panel1.Controls.Add(this.flpKasa1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgwTumSiparisler);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dgwBekleyenSiparisler);
            this.panel1.Controls.Add(this.flpMutfak);
            this.panel1.Controls.Add(this.flpCalisanBeklemeAlani);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(157)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 349);
            this.panel1.TabIndex = 0;
            // 
            // flpKasa3
            // 
            this.flpKasa3.Location = new System.Drawing.Point(795, 233);
            this.flpKasa3.Name = "flpKasa3";
            this.flpKasa3.Size = new System.Drawing.Size(153, 110);
            this.flpKasa3.TabIndex = 9;
            this.flpKasa3.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlKasa3_ControlAdded);
            // 
            // flpKasa2
            // 
            this.flpKasa2.Location = new System.Drawing.Point(618, 233);
            this.flpKasa2.Name = "flpKasa2";
            this.flpKasa2.Size = new System.Drawing.Size(153, 110);
            this.flpKasa2.TabIndex = 9;
            this.flpKasa2.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlKasa2_ControlAdded);
            // 
            // flpKasa1
            // 
            this.flpKasa1.Location = new System.Drawing.Point(424, 233);
            this.flpKasa1.Name = "flpKasa1";
            this.flpKasa1.Size = new System.Drawing.Size(153, 110);
            this.flpKasa1.TabIndex = 9;
            this.flpKasa1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlKasa1_ControlAdded);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(157)))));
            this.label4.Location = new System.Drawing.Point(160, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bekleme Alanı";
            // 
            // dgwTumSiparisler
            // 
            this.dgwTumSiparisler.AllowUserToAddRows = false;
            this.dgwTumSiparisler.AllowUserToDeleteRows = false;
            this.dgwTumSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTumSiparisler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(37)))), ((int)(((byte)(25)))));
            this.dgwTumSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(56)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(56)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwTumSiparisler.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgwTumSiparisler.Location = new System.Drawing.Point(687, 32);
            this.dgwTumSiparisler.Name = "dgwTumSiparisler";
            this.dgwTumSiparisler.ReadOnly = true;
            this.dgwTumSiparisler.RowHeadersVisible = false;
            this.dgwTumSiparisler.Size = new System.Drawing.Size(276, 144);
            this.dgwTumSiparisler.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(157)))));
            this.label9.Location = new System.Drawing.Point(758, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sipariş Geçmişi";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(157)))));
            this.label8.Location = new System.Drawing.Point(472, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bekleyen Siparişler";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(157)))));
            this.label6.Location = new System.Drawing.Point(1129, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mutfak";
            // 
            // dgwBekleyenSiparisler
            // 
            this.dgwBekleyenSiparisler.AllowUserToAddRows = false;
            this.dgwBekleyenSiparisler.AllowUserToDeleteRows = false;
            this.dgwBekleyenSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBekleyenSiparisler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(37)))), ((int)(((byte)(25)))));
            this.dgwBekleyenSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(56)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(56)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwBekleyenSiparisler.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgwBekleyenSiparisler.Location = new System.Drawing.Point(408, 32);
            this.dgwBekleyenSiparisler.Name = "dgwBekleyenSiparisler";
            this.dgwBekleyenSiparisler.ReadOnly = true;
            this.dgwBekleyenSiparisler.RowHeadersVisible = false;
            this.dgwBekleyenSiparisler.Size = new System.Drawing.Size(273, 144);
            this.dgwBekleyenSiparisler.TabIndex = 8;
            // 
            // flpMutfak
            // 
            this.flpMutfak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(56)))), ((int)(((byte)(19)))));
            this.flpMutfak.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpMutfak.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMutfak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(157)))));
            this.flpMutfak.Location = new System.Drawing.Point(1199, 0);
            this.flpMutfak.Name = "flpMutfak";
            this.flpMutfak.Size = new System.Drawing.Size(154, 349);
            this.flpMutfak.TabIndex = 2;
            this.flpMutfak.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flpMutfak_ControlAdded);
            // 
            // flpCalisanBeklemeAlani
            // 
            this.flpCalisanBeklemeAlani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(56)))), ((int)(((byte)(19)))));
            this.flpCalisanBeklemeAlani.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpCalisanBeklemeAlani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(157)))));
            this.flpCalisanBeklemeAlani.Location = new System.Drawing.Point(0, 0);
            this.flpCalisanBeklemeAlani.Name = "flpCalisanBeklemeAlani";
            this.flpCalisanBeklemeAlani.Size = new System.Drawing.Size(154, 349);
            this.flpCalisanBeklemeAlani.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(157)))));
            this.label3.Location = new System.Drawing.Point(842, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kasa 3";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(157)))));
            this.label1.Location = new System.Drawing.Point(472, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasa 1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(157)))));
            this.label2.Location = new System.Drawing.Point(665, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kasa 2";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(157)))));
            this.label5.Location = new System.Drawing.Point(1056, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sipariş Bekleme";
            // 
            // pnlSiralar
            // 
            this.pnlSiralar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(37)))), ((int)(((byte)(25)))));
            this.pnlSiralar.Controls.Add(this.pictureBox1);
            this.pnlSiralar.Controls.Add(this.label7);
            this.pnlSiralar.Controls.Add(this.label5);
            this.pnlSiralar.Controls.Add(this.flpSiparisBeklemeAlani);
            this.pnlSiralar.Controls.Add(this.pnlSira3);
            this.pnlSiralar.Controls.Add(this.flpSira);
            this.pnlSiralar.Controls.Add(this.pnlSira2);
            this.pnlSiralar.Controls.Add(this.pnlSira1);
            this.pnlSiralar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSiralar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlSiralar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(157)))));
            this.pnlSiralar.Location = new System.Drawing.Point(0, 349);
            this.pnlSiralar.Name = "pnlSiralar";
            this.pnlSiralar.Size = new System.Drawing.Size(1353, 374);
            this.pnlSiralar.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(532, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(157)))));
            this.label7.Location = new System.Drawing.Point(159, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kuyruk";
            // 
            // flpSiparisBeklemeAlani
            // 
            this.flpSiparisBeklemeAlani.AutoScroll = true;
            this.flpSiparisBeklemeAlani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(98)))), ((int)(((byte)(57)))));
            this.flpSiparisBeklemeAlani.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpSiparisBeklemeAlani.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSiparisBeklemeAlani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flpSiparisBeklemeAlani.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(157)))));
            this.flpSiparisBeklemeAlani.Location = new System.Drawing.Point(1199, 0);
            this.flpSiparisBeklemeAlani.Name = "flpSiparisBeklemeAlani";
            this.flpSiparisBeklemeAlani.Size = new System.Drawing.Size(154, 374);
            this.flpSiparisBeklemeAlani.TabIndex = 7;
            // 
            // pnlSira3
            // 
            this.pnlSira3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlSira3.Location = new System.Drawing.Point(795, 15);
            this.pnlSira3.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSira3.Name = "pnlSira3";
            this.pnlSira3.Size = new System.Drawing.Size(153, 93);
            this.pnlSira3.TabIndex = 5;
            this.pnlSira3.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlSira3_ControlAdded);
            // 
            // flpSira
            // 
            this.flpSira.AutoScroll = true;
            this.flpSira.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(98)))), ((int)(((byte)(57)))));
            this.flpSira.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpSira.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flpSira.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(157)))));
            this.flpSira.Location = new System.Drawing.Point(0, 0);
            this.flpSira.Name = "flpSira";
            this.flpSira.Size = new System.Drawing.Size(153, 374);
            this.flpSira.TabIndex = 5;
            this.flpSira.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flpSira_ControlAdded);
            // 
            // pnlSira2
            // 
            this.pnlSira2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlSira2.Location = new System.Drawing.Point(618, 15);
            this.pnlSira2.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSira2.Name = "pnlSira2";
            this.pnlSira2.Size = new System.Drawing.Size(153, 93);
            this.pnlSira2.TabIndex = 5;
            this.pnlSira2.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlSira2_ControlAdded);
            // 
            // pnlSira1
            // 
            this.pnlSira1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlSira1.Location = new System.Drawing.Point(424, 15);
            this.pnlSira1.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSira1.Name = "pnlSira1";
            this.pnlSira1.Size = new System.Drawing.Size(153, 93);
            this.pnlSira1.TabIndex = 5;
            this.pnlSira1.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlSira1_ControlAdded);
            // 
            // tmrMusteriEkle
            // 
            this.tmrMusteriEkle.Tick += new System.EventHandler(this.tmrMusteriEkle_Tick);
            // 
            // tmrSiparisKontrol
            // 
            this.tmrSiparisKontrol.Interval = 3000;
            this.tmrSiparisKontrol.Tick += new System.EventHandler(this.tmrSiparisKontrol_Tick);
            // 
            // KafeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 723);
            this.Controls.Add(this.pnlSiralar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KafeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kafe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTumSiparisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBekleyenSiparisler)).EndInit();
            this.pnlSiralar.ResumeLayout(false);
            this.pnlSiralar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flpSira;
        private System.Windows.Forms.Panel pnlSira3;
        private System.Windows.Forms.Panel pnlSira2;
        private System.Windows.Forms.Panel pnlSira1;
        private System.Windows.Forms.FlowLayoutPanel flpSiparisBeklemeAlani;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer tmrMusteriEkle;
        private System.Windows.Forms.Timer tmrSiparisKontrol;
        private System.Windows.Forms.DataGridView dgwBekleyenSiparisler;
        private System.Windows.Forms.DataGridView dgwTumSiparisler;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flpKasa3;
        private System.Windows.Forms.FlowLayoutPanel flpKasa2;
        private System.Windows.Forms.FlowLayoutPanel flpKasa1;
    }
}

