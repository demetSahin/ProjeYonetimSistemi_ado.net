namespace pys
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageProjeler = new System.Windows.Forms.TabPage();
            this.dgvProjeler = new System.Windows.Forms.DataGridView();
            this.gbProjeler = new System.Windows.Forms.GroupBox();
            this.btnLinq3Projeler = new System.Windows.Forms.Button();
            this.btnLinq2Projeler = new System.Windows.Forms.Button();
            this.btnLinq1Projeler = new System.Windows.Forms.Button();
            this.btnProjeGuncelle = new System.Windows.Forms.Button();
            this.btnProjeSil = new System.Windows.Forms.Button();
            this.btnProjeEkle = new System.Windows.Forms.Button();
            this.tabPageKisiler = new System.Windows.Forms.TabPage();
            this.gbKisiler = new System.Windows.Forms.GroupBox();
            this.btnLinq3Kisiler = new System.Windows.Forms.Button();
            this.btnLinq2Kisiler = new System.Windows.Forms.Button();
            this.btnLinq1Kisiler = new System.Windows.Forms.Button();
            this.btnKisiGuncelle = new System.Windows.Forms.Button();
            this.btnKisiSil = new System.Windows.Forms.Button();
            this.btnKisiEkle = new System.Windows.Forms.Button();
            this.dgvKisiler = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvPhoneNumbers1 = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageProjeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeler)).BeginInit();
            this.gbProjeler.SuspendLayout();
            this.tabPageKisiler.SuspendLayout();
            this.gbKisiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiler)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneNumbers1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.hakkindaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışYapToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.ÇıkışYapToolStripMenuItem_Click);
            // 
            // hakkindaToolStripMenuItem
            // 
            this.hakkindaToolStripMenuItem.Name = "hakkindaToolStripMenuItem";
            this.hakkindaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkindaToolStripMenuItem.Text = "Hakkında";
            this.hakkindaToolStripMenuItem.Click += new System.EventHandler(this.HakkindaToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1009, 22);
            this.statusStrip1.TabIndex = 6;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treeView1);
            this.splitContainer1.Size = new System.Drawing.Size(1009, 404);
            this.splitContainer1.SplitterDistance = 769;
            this.splitContainer1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 398);
            this.panel1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageProjeler);
            this.tabControl.Controls.Add(this.tabPageKisiler);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl.Location = new System.Drawing.Point(0, 7);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(767, 391);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            // 
            // tabPageProjeler
            // 
            this.tabPageProjeler.AutoScroll = true;
            this.tabPageProjeler.Controls.Add(this.dgvProjeler);
            this.tabPageProjeler.Controls.Add(this.gbProjeler);
            this.tabPageProjeler.Location = new System.Drawing.Point(4, 22);
            this.tabPageProjeler.Name = "tabPageProjeler";
            this.tabPageProjeler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProjeler.Size = new System.Drawing.Size(759, 365);
            this.tabPageProjeler.TabIndex = 0;
            this.tabPageProjeler.Text = "Projeler";
            this.tabPageProjeler.UseVisualStyleBackColor = true;
            // 
            // dgvProjeler
            // 
            this.dgvProjeler.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProjeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjeler.Location = new System.Drawing.Point(6, 61);
            this.dgvProjeler.Name = "dgvProjeler";
            this.dgvProjeler.Size = new System.Drawing.Size(739, 298);
            this.dgvProjeler.TabIndex = 44;
            this.dgvProjeler.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvProjeler_CellFormatting);
            // 
            // gbProjeler
            // 
            this.gbProjeler.Controls.Add(this.btnLinq3Projeler);
            this.gbProjeler.Controls.Add(this.btnLinq2Projeler);
            this.gbProjeler.Controls.Add(this.btnLinq1Projeler);
            this.gbProjeler.Controls.Add(this.btnProjeGuncelle);
            this.gbProjeler.Controls.Add(this.btnProjeSil);
            this.gbProjeler.Controls.Add(this.btnProjeEkle);
            this.gbProjeler.Location = new System.Drawing.Point(6, 0);
            this.gbProjeler.Name = "gbProjeler";
            this.gbProjeler.Size = new System.Drawing.Size(739, 55);
            this.gbProjeler.TabIndex = 43;
            this.gbProjeler.TabStop = false;
            // 
            // btnLinq3Projeler
            // 
            this.btnLinq3Projeler.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLinq3Projeler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLinq3Projeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(140)));
            this.btnLinq3Projeler.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLinq3Projeler.Location = new System.Drawing.Point(651, 11);
            this.btnLinq3Projeler.Name = "btnLinq3Projeler";
            this.btnLinq3Projeler.Size = new System.Drawing.Size(82, 38);
            this.btnLinq3Projeler.TabIndex = 10;
            this.btnLinq3Projeler.Text = "LINQ 3";
            this.btnLinq3Projeler.UseVisualStyleBackColor = false;
            this.btnLinq3Projeler.Click += new System.EventHandler(this.BtnLinq3Projeler_Click);
            this.btnLinq3Projeler.MouseHover += new System.EventHandler(this.btnLinq3Projeler_MouseHover);
            // 
            // btnLinq2Projeler
            // 
            this.btnLinq2Projeler.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLinq2Projeler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLinq2Projeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(140)));
            this.btnLinq2Projeler.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLinq2Projeler.Location = new System.Drawing.Point(563, 11);
            this.btnLinq2Projeler.Name = "btnLinq2Projeler";
            this.btnLinq2Projeler.Size = new System.Drawing.Size(82, 38);
            this.btnLinq2Projeler.TabIndex = 9;
            this.btnLinq2Projeler.Text = "LINQ 2";
            this.btnLinq2Projeler.UseVisualStyleBackColor = false;
            this.btnLinq2Projeler.Click += new System.EventHandler(this.BtnLinq2Projeler_Click);
            this.btnLinq2Projeler.MouseHover += new System.EventHandler(this.btnLinq2Projeler_MouseHover);
            // 
            // btnLinq1Projeler
            // 
            this.btnLinq1Projeler.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLinq1Projeler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLinq1Projeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(140)));
            this.btnLinq1Projeler.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLinq1Projeler.Location = new System.Drawing.Point(475, 11);
            this.btnLinq1Projeler.Name = "btnLinq1Projeler";
            this.btnLinq1Projeler.Size = new System.Drawing.Size(82, 38);
            this.btnLinq1Projeler.TabIndex = 8;
            this.btnLinq1Projeler.Text = "LINQ 1";
            this.btnLinq1Projeler.UseVisualStyleBackColor = false;
            this.btnLinq1Projeler.Click += new System.EventHandler(this.BtnLinq1Projeler_Click);
            this.btnLinq1Projeler.MouseHover += new System.EventHandler(this.btnLinq1Projeler_MouseHover);
            // 
            // btnProjeGuncelle
            // 
            this.btnProjeGuncelle.BackColor = System.Drawing.Color.Orange;
            this.btnProjeGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProjeGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(140)));
            this.btnProjeGuncelle.ForeColor = System.Drawing.Color.DarkRed;
            this.btnProjeGuncelle.Location = new System.Drawing.Point(186, 11);
            this.btnProjeGuncelle.Name = "btnProjeGuncelle";
            this.btnProjeGuncelle.Size = new System.Drawing.Size(82, 38);
            this.btnProjeGuncelle.TabIndex = 4;
            this.btnProjeGuncelle.Text = "PROJE GÜNCELLE";
            this.btnProjeGuncelle.UseVisualStyleBackColor = false;
            this.btnProjeGuncelle.Click += new System.EventHandler(this.BtnProjeGuncelle_Click);
            // 
            // btnProjeSil
            // 
            this.btnProjeSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnProjeSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProjeSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(140)));
            this.btnProjeSil.ForeColor = System.Drawing.Color.DarkRed;
            this.btnProjeSil.Location = new System.Drawing.Point(96, 11);
            this.btnProjeSil.Name = "btnProjeSil";
            this.btnProjeSil.Size = new System.Drawing.Size(84, 38);
            this.btnProjeSil.TabIndex = 3;
            this.btnProjeSil.Text = "PROJE SİL";
            this.btnProjeSil.UseVisualStyleBackColor = false;
            this.btnProjeSil.Click += new System.EventHandler(this.BtnProjeSil_Click);
            // 
            // btnProjeEkle
            // 
            this.btnProjeEkle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnProjeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProjeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(140)));
            this.btnProjeEkle.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnProjeEkle.Location = new System.Drawing.Point(6, 11);
            this.btnProjeEkle.Name = "btnProjeEkle";
            this.btnProjeEkle.Size = new System.Drawing.Size(84, 38);
            this.btnProjeEkle.TabIndex = 2;
            this.btnProjeEkle.Text = "PROJE OLUŞTUR";
            this.btnProjeEkle.UseVisualStyleBackColor = false;
            this.btnProjeEkle.Click += new System.EventHandler(this.BtnProjeEkle_Click);
            // 
            // tabPageKisiler
            // 
            this.tabPageKisiler.Controls.Add(this.gbKisiler);
            this.tabPageKisiler.Controls.Add(this.dgvKisiler);
            this.tabPageKisiler.Location = new System.Drawing.Point(4, 22);
            this.tabPageKisiler.Name = "tabPageKisiler";
            this.tabPageKisiler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKisiler.Size = new System.Drawing.Size(759, 365);
            this.tabPageKisiler.TabIndex = 1;
            this.tabPageKisiler.Text = "Kişiler";
            this.tabPageKisiler.UseVisualStyleBackColor = true;
            // 
            // gbKisiler
            // 
            this.gbKisiler.Controls.Add(this.btnLinq3Kisiler);
            this.gbKisiler.Controls.Add(this.btnLinq2Kisiler);
            this.gbKisiler.Controls.Add(this.btnLinq1Kisiler);
            this.gbKisiler.Controls.Add(this.btnKisiGuncelle);
            this.gbKisiler.Controls.Add(this.btnKisiSil);
            this.gbKisiler.Controls.Add(this.btnKisiEkle);
            this.gbKisiler.Location = new System.Drawing.Point(6, 0);
            this.gbKisiler.Name = "gbKisiler";
            this.gbKisiler.Size = new System.Drawing.Size(739, 55);
            this.gbKisiler.TabIndex = 45;
            this.gbKisiler.TabStop = false;
            // 
            // btnLinq3Kisiler
            // 
            this.btnLinq3Kisiler.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLinq3Kisiler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLinq3Kisiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(140)));
            this.btnLinq3Kisiler.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLinq3Kisiler.Location = new System.Drawing.Point(651, 11);
            this.btnLinq3Kisiler.Name = "btnLinq3Kisiler";
            this.btnLinq3Kisiler.Size = new System.Drawing.Size(82, 38);
            this.btnLinq3Kisiler.TabIndex = 7;
            this.btnLinq3Kisiler.Text = "LINQ 3";
            this.btnLinq3Kisiler.UseVisualStyleBackColor = false;
            this.btnLinq3Kisiler.Click += new System.EventHandler(this.BtnLinq3Kisiler_Click);
            // 
            // btnLinq2Kisiler
            // 
            this.btnLinq2Kisiler.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLinq2Kisiler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLinq2Kisiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(140)));
            this.btnLinq2Kisiler.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLinq2Kisiler.Location = new System.Drawing.Point(563, 11);
            this.btnLinq2Kisiler.Name = "btnLinq2Kisiler";
            this.btnLinq2Kisiler.Size = new System.Drawing.Size(82, 38);
            this.btnLinq2Kisiler.TabIndex = 6;
            this.btnLinq2Kisiler.Text = "LINQ 2";
            this.btnLinq2Kisiler.UseVisualStyleBackColor = false;
            this.btnLinq2Kisiler.Click += new System.EventHandler(this.BtnLinq2Kisiler_Click);
            // 
            // btnLinq1Kisiler
            // 
            this.btnLinq1Kisiler.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLinq1Kisiler.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLinq1Kisiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(140)));
            this.btnLinq1Kisiler.ForeColor = System.Drawing.Color.DarkRed;
            this.btnLinq1Kisiler.Location = new System.Drawing.Point(475, 11);
            this.btnLinq1Kisiler.Name = "btnLinq1Kisiler";
            this.btnLinq1Kisiler.Size = new System.Drawing.Size(82, 38);
            this.btnLinq1Kisiler.TabIndex = 5;
            this.btnLinq1Kisiler.Text = "LINQ 1";
            this.btnLinq1Kisiler.UseVisualStyleBackColor = false;
            this.btnLinq1Kisiler.Click += new System.EventHandler(this.BtnLinq1Kisiler_Click);
            // 
            // btnKisiGuncelle
            // 
            this.btnKisiGuncelle.BackColor = System.Drawing.Color.Orange;
            this.btnKisiGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKisiGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(140)));
            this.btnKisiGuncelle.ForeColor = System.Drawing.Color.DarkRed;
            this.btnKisiGuncelle.Location = new System.Drawing.Point(186, 11);
            this.btnKisiGuncelle.Name = "btnKisiGuncelle";
            this.btnKisiGuncelle.Size = new System.Drawing.Size(82, 38);
            this.btnKisiGuncelle.TabIndex = 4;
            this.btnKisiGuncelle.Text = "KİŞİ GÜNCELLE";
            this.btnKisiGuncelle.UseVisualStyleBackColor = false;
            this.btnKisiGuncelle.Click += new System.EventHandler(this.BtnKisiGuncelle_Click);
            // 
            // btnKisiSil
            // 
            this.btnKisiSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnKisiSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKisiSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(140)));
            this.btnKisiSil.ForeColor = System.Drawing.Color.DarkRed;
            this.btnKisiSil.Location = new System.Drawing.Point(96, 11);
            this.btnKisiSil.Name = "btnKisiSil";
            this.btnKisiSil.Size = new System.Drawing.Size(84, 38);
            this.btnKisiSil.TabIndex = 3;
            this.btnKisiSil.Text = "KİŞİ SİL";
            this.btnKisiSil.UseVisualStyleBackColor = false;
            this.btnKisiSil.Click += new System.EventHandler(this.BtnKisiSil_Click);
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnKisiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKisiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(140)));
            this.btnKisiEkle.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnKisiEkle.Location = new System.Drawing.Point(6, 11);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(84, 38);
            this.btnKisiEkle.TabIndex = 2;
            this.btnKisiEkle.Text = "KİŞİ OLUŞTUR";
            this.btnKisiEkle.UseVisualStyleBackColor = false;
            this.btnKisiEkle.Click += new System.EventHandler(this.BtnKisiEkle_Click);
            // 
            // dgvKisiler
            // 
            this.dgvKisiler.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKisiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKisiler.Location = new System.Drawing.Point(6, 61);
            this.dgvKisiler.Name = "dgvKisiler";
            this.dgvKisiler.Size = new System.Drawing.Size(739, 298);
            this.dgvKisiler.TabIndex = 46;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPhoneNumbers1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(759, 365);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Telefon Rehberi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvPhoneNumbers1
            // 
            this.dgvPhoneNumbers1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhoneNumbers1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhoneNumbers1.Location = new System.Drawing.Point(5, 6);
            this.dgvPhoneNumbers1.Name = "dgvPhoneNumbers1";
            this.dgvPhoneNumbers1.Size = new System.Drawing.Size(748, 353);
            this.dgvPhoneNumbers1.TabIndex = 47;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(236, 404);
            this.treeView1.TabIndex = 0;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaSayfa";
            this.Text = "Ana Sayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaSayfa_FormClosing);
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageProjeler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeler)).EndInit();
            this.gbProjeler.ResumeLayout(false);
            this.tabPageKisiler.ResumeLayout(false);
            this.gbKisiler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiler)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhoneNumbers1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem hakkindaToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageProjeler;
        private System.Windows.Forms.TabPage tabPageKisiler;
        private System.Windows.Forms.GroupBox gbProjeler;
        private System.Windows.Forms.Button btnProjeGuncelle;
        private System.Windows.Forms.Button btnProjeSil;
        private System.Windows.Forms.Button btnProjeEkle;
        private System.Windows.Forms.DataGridView dgvProjeler;
        private System.Windows.Forms.GroupBox gbKisiler;
        private System.Windows.Forms.Button btnKisiGuncelle;
        private System.Windows.Forms.Button btnKisiSil;
        private System.Windows.Forms.Button btnKisiEkle;
        private System.Windows.Forms.DataGridView dgvKisiler;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.Button btnLinq3Kisiler;
        private System.Windows.Forms.Button btnLinq2Kisiler;
        private System.Windows.Forms.Button btnLinq1Kisiler;
        private System.Windows.Forms.Button btnLinq3Projeler;
        private System.Windows.Forms.Button btnLinq2Projeler;
        private System.Windows.Forms.Button btnLinq1Projeler;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvPhoneNumbers1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
    }
}

