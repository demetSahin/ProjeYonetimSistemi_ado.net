using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using pys.Properties;
using System.Linq;
using System.ComponentModel;

namespace pys
{
    partial class ProjeOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjeOlustur));
            this.labelProjeAdi = new System.Windows.Forms.Label();
            this.tbProjeAdi = new System.Windows.Forms.TextBox();
            this.tbStratejikEtki = new System.Windows.Forms.TextBox();
            this.labelStratejikEtki = new System.Windows.Forms.Label();
            this.tbProjeNo = new System.Windows.Forms.TextBox();
            this.labelProjeNo = new System.Windows.Forms.Label();
            this.tbProjeYurutucusu = new System.Windows.Forms.TextBox();
            this.labelProjeYurutucusu = new System.Windows.Forms.Label();
            this.tbAmac = new System.Windows.Forms.TextBox();
            this.labelProjeAmaci = new System.Windows.Forms.Label();
            this.labelKayitTarihi = new System.Windows.Forms.Label();
            this.tbKapsam = new System.Windows.Forms.TextBox();
            this.labelProjeKapsami = new System.Windows.Forms.Label();
            this.tbProblemTanimi = new System.Windows.Forms.TextBox();
            this.labelProblemTanimi = new System.Windows.Forms.Label();
            this.dtpKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpProjeBaslangici = new System.Windows.Forms.DateTimePicker();
            this.labelProjeBaslangici = new System.Windows.Forms.Label();
            this.dtpProjeBitisi = new System.Windows.Forms.DateTimePicker();
            this.labelProjeBitisi = new System.Windows.Forms.Label();
            this.dtpTahminiBaslangic = new System.Windows.Forms.DateTimePicker();
            this.labelTahminiBaslangic = new System.Windows.Forms.Label();
            this.dtpTahminiBitis = new System.Windows.Forms.DateTimePicker();
            this.labelTahminiBitis = new System.Windows.Forms.Label();
            this.labelProjeDurumu = new System.Windows.Forms.Label();
            this.cbProjeDurumu = new System.Windows.Forms.ComboBox();
            this.labelParasalGetiri = new System.Windows.Forms.Label();
            this.cbGetiriTipi = new System.Windows.Forms.ComboBox();
            this.labelGetiriTipi = new System.Windows.Forms.Label();
            this.labelProjeEkibi = new System.Windows.Forms.Label();
            this.cbProjeYurutucusu = new System.Windows.Forms.ComboBox();
            this.btnDokumanEkle = new System.Windows.Forms.Button();
            this.lbProjeDokumanlari = new System.Windows.Forms.ListBox();
            this.labelProjeDokumanlari = new System.Windows.Forms.Label();
            this.cbProjeTipi = new System.Windows.Forms.ComboBox();
            this.labelProjeTipi = new System.Windows.Forms.Label();
            this.lbKmTaslari = new System.Windows.Forms.ListBox();
            this.btnKmTasiCikar = new System.Windows.Forms.Button();
            this.labelKmTaslari = new System.Windows.Forms.Label();
            this.tbKmTasiEkle = new System.Windows.Forms.TextBox();
            this.btnKmTasiEkle = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.buttonProjeEkle = new System.Windows.Forms.Button();
            this.clbKisiler = new System.Windows.Forms.CheckedListBox();
            this.tbParasalGetiri = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelProjeAdi
            // 
            this.labelProjeAdi.AutoSize = true;
            this.labelProjeAdi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelProjeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProjeAdi.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelProjeAdi.Location = new System.Drawing.Point(13, 13);
            this.labelProjeAdi.Name = "labelProjeAdi";
            this.labelProjeAdi.Size = new System.Drawing.Size(70, 13);
            this.labelProjeAdi.TabIndex = 0;
            this.labelProjeAdi.Text = "Proje Adı : ";
            // 
            // tbProjeAdi
            // 
            this.tbProjeAdi.Location = new System.Drawing.Point(135, 10);
            this.tbProjeAdi.Name = "tbProjeAdi";
            this.tbProjeAdi.Size = new System.Drawing.Size(221, 20);
            this.tbProjeAdi.TabIndex = 1;
            // 
            // tbStratejikEtki
            // 
            this.tbStratejikEtki.Location = new System.Drawing.Point(135, 36);
            this.tbStratejikEtki.Name = "tbStratejikEtki";
            this.tbStratejikEtki.Size = new System.Drawing.Size(221, 20);
            this.tbStratejikEtki.TabIndex = 3;
            this.tbStratejikEtki.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelStratejikEtki
            // 
            this.labelStratejikEtki.AutoSize = true;
            this.labelStratejikEtki.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStratejikEtki.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStratejikEtki.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelStratejikEtki.Location = new System.Drawing.Point(13, 39);
            this.labelStratejikEtki.Name = "labelStratejikEtki";
            this.labelStratejikEtki.Size = new System.Drawing.Size(101, 13);
            this.labelStratejikEtki.TabIndex = 2;
            this.labelStratejikEtki.Text = "Stratejik Etkisi : ";
            this.labelStratejikEtki.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbProjeNo
            // 
            this.tbProjeNo.Location = new System.Drawing.Point(135, 62);
            this.tbProjeNo.Name = "tbProjeNo";
            this.tbProjeNo.Size = new System.Drawing.Size(221, 20);
            this.tbProjeNo.TabIndex = 5;
            // 
            // labelProjeNo
            // 
            this.labelProjeNo.AutoSize = true;
            this.labelProjeNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelProjeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProjeNo.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelProjeNo.Location = new System.Drawing.Point(13, 65);
            this.labelProjeNo.Name = "labelProjeNo";
            this.labelProjeNo.Size = new System.Drawing.Size(68, 13);
            this.labelProjeNo.TabIndex = 4;
            this.labelProjeNo.Text = "Proje No : ";
            // 
            // tbProjeYurutucusu
            // 
            this.tbProjeYurutucusu.Location = new System.Drawing.Point(135, 88);
            this.tbProjeYurutucusu.Name = "tbProjeYurutucusu";
            this.tbProjeYurutucusu.Size = new System.Drawing.Size(221, 20);
            this.tbProjeYurutucusu.TabIndex = 7;
            // 
            // labelProjeYurutucusu
            // 
            this.labelProjeYurutucusu.AutoSize = true;
            this.labelProjeYurutucusu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelProjeYurutucusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProjeYurutucusu.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelProjeYurutucusu.Location = new System.Drawing.Point(13, 91);
            this.labelProjeYurutucusu.Name = "labelProjeYurutucusu";
            this.labelProjeYurutucusu.Size = new System.Drawing.Size(116, 13);
            this.labelProjeYurutucusu.TabIndex = 6;
            this.labelProjeYurutucusu.Text = "Proje Yürütücüsü : ";
            // 
            // tbAmac
            // 
            this.tbAmac.Location = new System.Drawing.Point(135, 114);
            this.tbAmac.Name = "tbAmac";
            this.tbAmac.Size = new System.Drawing.Size(221, 20);
            this.tbAmac.TabIndex = 9;
            // 
            // labelProjeAmaci
            // 
            this.labelProjeAmaci.AutoSize = true;
            this.labelProjeAmaci.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelProjeAmaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProjeAmaci.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelProjeAmaci.Location = new System.Drawing.Point(13, 117);
            this.labelProjeAmaci.Name = "labelProjeAmaci";
            this.labelProjeAmaci.Size = new System.Drawing.Size(46, 13);
            this.labelProjeAmaci.TabIndex = 8;
            this.labelProjeAmaci.Text = "Amaç :";
            // 
            // labelKayitTarihi
            // 
            this.labelKayitTarihi.AutoSize = true;
            this.labelKayitTarihi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelKayitTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKayitTarihi.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelKayitTarihi.Location = new System.Drawing.Point(13, 195);
            this.labelKayitTarihi.Name = "labelKayitTarihi";
            this.labelKayitTarihi.Size = new System.Drawing.Size(83, 13);
            this.labelKayitTarihi.TabIndex = 12;
            this.labelKayitTarihi.Text = "Kayıt Tarihi : ";
            // 
            // tbKapsam
            // 
            this.tbKapsam.Location = new System.Drawing.Point(135, 166);
            this.tbKapsam.Name = "tbKapsam";
            this.tbKapsam.Size = new System.Drawing.Size(221, 20);
            this.tbKapsam.TabIndex = 15;
            // 
            // labelProjeKapsami
            // 
            this.labelProjeKapsami.AutoSize = true;
            this.labelProjeKapsami.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelProjeKapsami.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProjeKapsami.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelProjeKapsami.Location = new System.Drawing.Point(13, 169);
            this.labelProjeKapsami.Name = "labelProjeKapsami";
            this.labelProjeKapsami.Size = new System.Drawing.Size(59, 13);
            this.labelProjeKapsami.TabIndex = 14;
            this.labelProjeKapsami.Text = "Kapsam :";
            // 
            // tbProblemTanimi
            // 
            this.tbProblemTanimi.Location = new System.Drawing.Point(135, 140);
            this.tbProblemTanimi.Name = "tbProblemTanimi";
            this.tbProblemTanimi.Size = new System.Drawing.Size(221, 20);
            this.tbProblemTanimi.TabIndex = 17;
            // 
            // labelProblemTanimi
            // 
            this.labelProblemTanimi.AutoSize = true;
            this.labelProblemTanimi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelProblemTanimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProblemTanimi.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelProblemTanimi.Location = new System.Drawing.Point(13, 143);
            this.labelProblemTanimi.Name = "labelProblemTanimi";
            this.labelProblemTanimi.Size = new System.Drawing.Size(101, 13);
            this.labelProblemTanimi.TabIndex = 16;
            this.labelProblemTanimi.Text = "Problem Tanımı :";
            // 
            // dtpKayitTarihi
            // 
            this.dtpKayitTarihi.Location = new System.Drawing.Point(135, 193);
            this.dtpKayitTarihi.Name = "dtpKayitTarihi";
            this.dtpKayitTarihi.Size = new System.Drawing.Size(221, 20);
            this.dtpKayitTarihi.TabIndex = 18;
            // 
            // dtpProjeBaslangici
            // 
            this.dtpProjeBaslangici.Location = new System.Drawing.Point(135, 221);
            this.dtpProjeBaslangici.Name = "dtpProjeBaslangici";
            this.dtpProjeBaslangici.Size = new System.Drawing.Size(221, 20);
            this.dtpProjeBaslangici.TabIndex = 20;
            // 
            // labelProjeBaslangici
            // 
            this.labelProjeBaslangici.AutoSize = true;
            this.labelProjeBaslangici.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelProjeBaslangici.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProjeBaslangici.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelProjeBaslangici.Location = new System.Drawing.Point(13, 223);
            this.labelProjeBaslangici.Name = "labelProjeBaslangici";
            this.labelProjeBaslangici.Size = new System.Drawing.Size(106, 13);
            this.labelProjeBaslangici.TabIndex = 19;
            this.labelProjeBaslangici.Text = "Proje Başlangıcı :";
            // 
            // dtpProjeBitisi
            // 
            this.dtpProjeBitisi.Location = new System.Drawing.Point(135, 249);
            this.dtpProjeBitisi.Name = "dtpProjeBitisi";
            this.dtpProjeBitisi.Size = new System.Drawing.Size(221, 20);
            this.dtpProjeBitisi.TabIndex = 22;
            // 
            // labelProjeBitisi
            // 
            this.labelProjeBitisi.AutoSize = true;
            this.labelProjeBitisi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelProjeBitisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProjeBitisi.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelProjeBitisi.Location = new System.Drawing.Point(13, 251);
            this.labelProjeBitisi.Name = "labelProjeBitisi";
            this.labelProjeBitisi.Size = new System.Drawing.Size(75, 13);
            this.labelProjeBitisi.TabIndex = 21;
            this.labelProjeBitisi.Text = "Proje Bitişi :";
            // 
            // dtpTahminiBaslangic
            // 
            this.dtpTahminiBaslangic.Location = new System.Drawing.Point(135, 276);
            this.dtpTahminiBaslangic.Name = "dtpTahminiBaslangic";
            this.dtpTahminiBaslangic.Size = new System.Drawing.Size(221, 20);
            this.dtpTahminiBaslangic.TabIndex = 24;
            // 
            // labelTahminiBaslangic
            // 
            this.labelTahminiBaslangic.AutoSize = true;
            this.labelTahminiBaslangic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTahminiBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTahminiBaslangic.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelTahminiBaslangic.Location = new System.Drawing.Point(13, 278);
            this.labelTahminiBaslangic.Name = "labelTahminiBaslangic";
            this.labelTahminiBaslangic.Size = new System.Drawing.Size(118, 13);
            this.labelTahminiBaslangic.TabIndex = 23;
            this.labelTahminiBaslangic.Text = "Tahmini Başlangıç :";
            // 
            // dtpTahminiBitis
            // 
            this.dtpTahminiBitis.Location = new System.Drawing.Point(135, 304);
            this.dtpTahminiBitis.Name = "dtpTahminiBitis";
            this.dtpTahminiBitis.Size = new System.Drawing.Size(221, 20);
            this.dtpTahminiBitis.TabIndex = 26;
            // 
            // labelTahminiBitis
            // 
            this.labelTahminiBitis.AutoSize = true;
            this.labelTahminiBitis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTahminiBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTahminiBitis.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelTahminiBitis.Location = new System.Drawing.Point(13, 306);
            this.labelTahminiBitis.Name = "labelTahminiBitis";
            this.labelTahminiBitis.Size = new System.Drawing.Size(87, 13);
            this.labelTahminiBitis.TabIndex = 25;
            this.labelTahminiBitis.Text = "Tahmini Bitiş :";
            // 
            // labelProjeDurumu
            // 
            this.labelProjeDurumu.AutoSize = true;
            this.labelProjeDurumu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelProjeDurumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProjeDurumu.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelProjeDurumu.Location = new System.Drawing.Point(412, 16);
            this.labelProjeDurumu.Name = "labelProjeDurumu";
            this.labelProjeDurumu.Size = new System.Drawing.Size(95, 13);
            this.labelProjeDurumu.TabIndex = 27;
            this.labelProjeDurumu.Text = "Proje Durumu : ";
            // 
            // cbProjeDurumu
            // 
            this.cbProjeDurumu.DisplayMember = "Description";
            this.cbProjeDurumu.FormattingEnabled = true;
            this.cbProjeDurumu.Location = new System.Drawing.Point(534, 11);
            this.cbProjeDurumu.Name = "cbProjeDurumu";
            this.cbProjeDurumu.Size = new System.Drawing.Size(221, 21);
            this.cbProjeDurumu.TabIndex = 29;
            this.cbProjeDurumu.ValueMember = "Value";
            // 
            // labelParasalGetiri
            // 
            this.labelParasalGetiri.AutoSize = true;
            this.labelParasalGetiri.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelParasalGetiri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelParasalGetiri.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelParasalGetiri.Location = new System.Drawing.Point(412, 41);
            this.labelParasalGetiri.Name = "labelParasalGetiri";
            this.labelParasalGetiri.Size = new System.Drawing.Size(95, 13);
            this.labelParasalGetiri.TabIndex = 30;
            this.labelParasalGetiri.Text = "Parasal Getiri : ";
            // 
            // cbGetiriTipi
            // 
            this.cbGetiriTipi.DisplayMember = "Description";
            this.cbGetiriTipi.FormattingEnabled = true;
            this.cbGetiriTipi.Location = new System.Drawing.Point(534, 64);
            this.cbGetiriTipi.Name = "cbGetiriTipi";
            this.cbGetiriTipi.Size = new System.Drawing.Size(221, 21);
            this.cbGetiriTipi.TabIndex = 33;
            this.cbGetiriTipi.ValueMember = "Value";
            // 
            // labelGetiriTipi
            // 
            this.labelGetiriTipi.AutoSize = true;
            this.labelGetiriTipi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGetiriTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGetiriTipi.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelGetiriTipi.Location = new System.Drawing.Point(412, 69);
            this.labelGetiriTipi.Name = "labelGetiriTipi";
            this.labelGetiriTipi.Size = new System.Drawing.Size(74, 13);
            this.labelGetiriTipi.TabIndex = 32;
            this.labelGetiriTipi.Text = "Getiri Tipi : ";
            // 
            // labelProjeEkibi
            // 
            this.labelProjeEkibi.AutoSize = true;
            this.labelProjeEkibi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelProjeEkibi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProjeEkibi.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelProjeEkibi.Location = new System.Drawing.Point(412, 94);
            this.labelProjeEkibi.Name = "labelProjeEkibi";
            this.labelProjeEkibi.Size = new System.Drawing.Size(80, 13);
            this.labelProjeEkibi.TabIndex = 34;
            this.labelProjeEkibi.Text = "Proje Ekibi : ";
            // 
            // cbProjeYurutucusu
            // 
            this.cbProjeYurutucusu.DisplayMember = "Description";
            this.cbProjeYurutucusu.FormattingEnabled = true;
            this.cbProjeYurutucusu.Location = new System.Drawing.Point(135, 87);
            this.cbProjeYurutucusu.Name = "cbProjeYurutucusu";
            this.cbProjeYurutucusu.Size = new System.Drawing.Size(221, 21);
            this.cbProjeYurutucusu.TabIndex = 38;
            this.cbProjeYurutucusu.ValueMember = "Value";
            // 
            // btnDokumanEkle
            // 
            this.btnDokumanEkle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDokumanEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDokumanEkle.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDokumanEkle.Location = new System.Drawing.Point(721, 153);
            this.btnDokumanEkle.Name = "btnDokumanEkle";
            this.btnDokumanEkle.Size = new System.Drawing.Size(34, 23);
            this.btnDokumanEkle.TabIndex = 41;
            this.btnDokumanEkle.Text = "+";
            this.btnDokumanEkle.UseVisualStyleBackColor = false;
            this.btnDokumanEkle.Click += new System.EventHandler(this.btnDokumanEkle_Click);
            // 
            // lbProjeDokumanlari
            // 
            this.lbProjeDokumanlari.FormattingEnabled = true;
            this.lbProjeDokumanlari.Location = new System.Drawing.Point(534, 153);
            this.lbProjeDokumanlari.Name = "lbProjeDokumanlari";
            this.lbProjeDokumanlari.Size = new System.Drawing.Size(181, 56);
            this.lbProjeDokumanlari.TabIndex = 40;
            // 
            // labelProjeDokumanlari
            // 
            this.labelProjeDokumanlari.AutoSize = true;
            this.labelProjeDokumanlari.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelProjeDokumanlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProjeDokumanlari.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelProjeDokumanlari.Location = new System.Drawing.Point(412, 156);
            this.labelProjeDokumanlari.Name = "labelProjeDokumanlari";
            this.labelProjeDokumanlari.Size = new System.Drawing.Size(122, 13);
            this.labelProjeDokumanlari.TabIndex = 39;
            this.labelProjeDokumanlari.Text = "Proje Dokümanları : ";
            // 
            // cbProjeTipi
            // 
            this.cbProjeTipi.DisplayMember = "Description";
            this.cbProjeTipi.FormattingEnabled = true;
            this.cbProjeTipi.Location = new System.Drawing.Point(534, 215);
            this.cbProjeTipi.Name = "cbProjeTipi";
            this.cbProjeTipi.Size = new System.Drawing.Size(221, 21);
            this.cbProjeTipi.TabIndex = 43;
            this.cbProjeTipi.ValueMember = "Value";
            // 
            // labelProjeTipi
            // 
            this.labelProjeTipi.AutoSize = true;
            this.labelProjeTipi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelProjeTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProjeTipi.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelProjeTipi.Location = new System.Drawing.Point(412, 220);
            this.labelProjeTipi.Name = "labelProjeTipi";
            this.labelProjeTipi.Size = new System.Drawing.Size(73, 13);
            this.labelProjeTipi.TabIndex = 42;
            this.labelProjeTipi.Text = "Proje Tipi : ";
            // 
            // lbKmTaslari
            // 
            this.lbKmTaslari.FormattingEnabled = true;
            this.lbKmTaslari.Location = new System.Drawing.Point(534, 242);
            this.lbKmTaslari.Name = "lbKmTaslari";
            this.lbKmTaslari.Size = new System.Drawing.Size(181, 56);
            this.lbKmTaslari.TabIndex = 44;
            // 
            // btnKmTasiCikar
            // 
            this.btnKmTasiCikar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKmTasiCikar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKmTasiCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKmTasiCikar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnKmTasiCikar.Location = new System.Drawing.Point(721, 242);
            this.btnKmTasiCikar.Name = "btnKmTasiCikar";
            this.btnKmTasiCikar.Size = new System.Drawing.Size(34, 23);
            this.btnKmTasiCikar.TabIndex = 45;
            this.btnKmTasiCikar.Text = "x";
            this.btnKmTasiCikar.UseVisualStyleBackColor = false;
            this.btnKmTasiCikar.Click += new System.EventHandler(this.btnKmTasiCikar_Click);
            // 
            // labelKmTaslari
            // 
            this.labelKmTaslari.AutoSize = true;
            this.labelKmTaslari.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelKmTaslari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKmTaslari.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelKmTaslari.Location = new System.Drawing.Point(413, 245);
            this.labelKmTaslari.Name = "labelKmTaslari";
            this.labelKmTaslari.Size = new System.Drawing.Size(113, 13);
            this.labelKmTaslari.TabIndex = 46;
            this.labelKmTaslari.Text = "Kilometre Taşları : ";
            // 
            // tbKmTasiEkle
            // 
            this.tbKmTasiEkle.Location = new System.Drawing.Point(534, 304);
            this.tbKmTasiEkle.Multiline = true;
            this.tbKmTasiEkle.Name = "tbKmTasiEkle";
            this.tbKmTasiEkle.Size = new System.Drawing.Size(181, 23);
            this.tbKmTasiEkle.TabIndex = 47;
            // 
            // btnKmTasiEkle
            // 
            this.btnKmTasiEkle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKmTasiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKmTasiEkle.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnKmTasiEkle.Location = new System.Drawing.Point(721, 304);
            this.btnKmTasiEkle.Name = "btnKmTasiEkle";
            this.btnKmTasiEkle.Size = new System.Drawing.Size(34, 23);
            this.btnKmTasiEkle.TabIndex = 48;
            this.btnKmTasiEkle.Text = "+";
            this.btnKmTasiEkle.UseVisualStyleBackColor = false;
            this.btnKmTasiEkle.Click += new System.EventHandler(this.btnKmTasiEkle_Click);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label.ForeColor = System.Drawing.Color.DarkBlue;
            this.label.Location = new System.Drawing.Point(412, 283);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(113, 44);
            this.label.TabIndex = 49;
            this.label.Text = "Kilometre taşlarını giriniz ve \"+\" butonuna basınız -->";
            // 
            // buttonProjeEkle
            // 
            this.buttonProjeEkle.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonProjeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProjeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonProjeEkle.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonProjeEkle.Location = new System.Drawing.Point(329, 342);
            this.buttonProjeEkle.Name = "buttonProjeEkle";
            this.buttonProjeEkle.Size = new System.Drawing.Size(138, 23);
            this.buttonProjeEkle.TabIndex = 50;
            this.buttonProjeEkle.Text = "PROJE EKLE";
            this.buttonProjeEkle.UseVisualStyleBackColor = false;
            this.buttonProjeEkle.Click += new System.EventHandler(this.buttonProjeEkle_Click);
            // 
            // clbKisiler
            // 
            this.clbKisiler.FormattingEnabled = true;
            this.clbKisiler.Location = new System.Drawing.Point(534, 91);
            this.clbKisiler.Name = "clbKisiler";
            this.clbKisiler.Size = new System.Drawing.Size(221, 49);
            this.clbKisiler.TabIndex = 51;
            // 
            // tbParasalGetiri
            // 
            this.tbParasalGetiri.Location = new System.Drawing.Point(534, 38);
            this.tbParasalGetiri.Name = "tbParasalGetiri";
            this.tbParasalGetiri.Size = new System.Drawing.Size(221, 20);
            this.tbParasalGetiri.TabIndex = 31;
            // 
            // ProjeOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(771, 377);
            this.Controls.Add(this.clbKisiler);
            this.Controls.Add(this.buttonProjeEkle);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnKmTasiEkle);
            this.Controls.Add(this.tbKmTasiEkle);
            this.Controls.Add(this.labelKmTaslari);
            this.Controls.Add(this.btnKmTasiCikar);
            this.Controls.Add(this.lbKmTaslari);
            this.Controls.Add(this.cbProjeTipi);
            this.Controls.Add(this.labelProjeTipi);
            this.Controls.Add(this.btnDokumanEkle);
            this.Controls.Add(this.lbProjeDokumanlari);
            this.Controls.Add(this.labelProjeDokumanlari);
            this.Controls.Add(this.cbProjeYurutucusu);
            this.Controls.Add(this.labelProjeEkibi);
            this.Controls.Add(this.cbGetiriTipi);
            this.Controls.Add(this.labelGetiriTipi);
            this.Controls.Add(this.tbParasalGetiri);
            this.Controls.Add(this.labelParasalGetiri);
            this.Controls.Add(this.cbProjeDurumu);
            this.Controls.Add(this.labelProjeDurumu);
            this.Controls.Add(this.dtpTahminiBitis);
            this.Controls.Add(this.labelTahminiBitis);
            this.Controls.Add(this.dtpTahminiBaslangic);
            this.Controls.Add(this.labelTahminiBaslangic);
            this.Controls.Add(this.dtpProjeBitisi);
            this.Controls.Add(this.labelProjeBitisi);
            this.Controls.Add(this.dtpProjeBaslangici);
            this.Controls.Add(this.labelProjeBaslangici);
            this.Controls.Add(this.dtpKayitTarihi);
            this.Controls.Add(this.tbProblemTanimi);
            this.Controls.Add(this.labelProblemTanimi);
            this.Controls.Add(this.tbKapsam);
            this.Controls.Add(this.labelProjeKapsami);
            this.Controls.Add(this.labelKayitTarihi);
            this.Controls.Add(this.tbAmac);
            this.Controls.Add(this.labelProjeAmaci);
            this.Controls.Add(this.labelProjeYurutucusu);
            this.Controls.Add(this.tbProjeNo);
            this.Controls.Add(this.labelProjeNo);
            this.Controls.Add(this.tbStratejikEtki);
            this.Controls.Add(this.labelStratejikEtki);
            this.Controls.Add(this.tbProjeAdi);
            this.Controls.Add(this.labelProjeAdi);
            this.Controls.Add(this.tbProjeYurutucusu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjeOlustur";
            this.Text = "Proje Ekle";
            this.Load += new System.EventHandler(this.ProjeOlustur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProjeAdi;
        private System.Windows.Forms.TextBox tbProjeAdi;
        private System.Windows.Forms.TextBox tbStratejikEtki;
        private System.Windows.Forms.Label labelStratejikEtki;
        private System.Windows.Forms.TextBox tbProjeNo;
        private System.Windows.Forms.Label labelProjeNo;
        private System.Windows.Forms.TextBox tbProjeYurutucusu;
        private System.Windows.Forms.Label labelProjeYurutucusu;
        private System.Windows.Forms.TextBox tbAmac;
        private System.Windows.Forms.Label labelProjeAmaci;
        private System.Windows.Forms.Label labelKayitTarihi;
        private System.Windows.Forms.TextBox tbKapsam;
        private System.Windows.Forms.Label labelProjeKapsami;
        private System.Windows.Forms.TextBox tbProblemTanimi;
        private System.Windows.Forms.Label labelProblemTanimi;
        private System.Windows.Forms.DateTimePicker dtpKayitTarihi;
        private System.Windows.Forms.DateTimePicker dtpProjeBaslangici;
        private System.Windows.Forms.Label labelProjeBaslangici;
        private System.Windows.Forms.DateTimePicker dtpProjeBitisi;
        private System.Windows.Forms.Label labelProjeBitisi;
        private System.Windows.Forms.DateTimePicker dtpTahminiBaslangic;
        private System.Windows.Forms.Label labelTahminiBaslangic;
        private System.Windows.Forms.DateTimePicker dtpTahminiBitis;
        private System.Windows.Forms.Label labelTahminiBitis;
        private System.Windows.Forms.Label labelProjeDurumu;
        private System.Windows.Forms.ComboBox cbProjeDurumu;
        private System.Windows.Forms.Label labelParasalGetiri;
        private System.Windows.Forms.ComboBox cbGetiriTipi;
        private System.Windows.Forms.Label labelGetiriTipi;
        private System.Windows.Forms.Label labelProjeEkibi;
        private System.Windows.Forms.ComboBox cbProjeYurutucusu;
        private System.Windows.Forms.Button btnDokumanEkle;
        private System.Windows.Forms.ListBox lbProjeDokumanlari;
        private System.Windows.Forms.Label labelProjeDokumanlari;
        private System.Windows.Forms.ComboBox cbProjeTipi;
        private System.Windows.Forms.Label labelProjeTipi;
        private System.Windows.Forms.ListBox lbKmTaslari;
        private System.Windows.Forms.Button btnKmTasiCikar;
        private System.Windows.Forms.Label labelKmTaslari;
        private System.Windows.Forms.TextBox tbKmTasiEkle;
        private System.Windows.Forms.Button btnKmTasiEkle;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonProjeEkle;
        private System.Windows.Forms.CheckedListBox clbKisiler;
        private System.Windows.Forms.TextBox tbParasalGetiri;
    }
}