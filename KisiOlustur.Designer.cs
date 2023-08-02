namespace pys
{
    partial class KisiOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KisiOlustur));
            this.tbAdi = new System.Windows.Forms.TextBox();
            this.labelAdi = new System.Windows.Forms.Label();
            this.tbSoyadi = new System.Windows.Forms.TextBox();
            this.labelSoyadi = new System.Windows.Forms.Label();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.gbCinsiyet = new System.Windows.Forms.GroupBox();
            this.labelEposta = new System.Windows.Forms.Label();
            this.tbEposta = new System.Windows.Forms.TextBox();
            this.mtbTelefon = new System.Windows.Forms.MaskedTextBox();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelDogumTarihi = new System.Windows.Forms.Label();
            this.mtbDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.btnKisiOlustur = new System.Windows.Forms.Button();
            this.rtbAdres = new System.Windows.Forms.RichTextBox();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelIsTecrubesi = new System.Windows.Forms.Label();
            this.nudIsTecrubesi = new System.Windows.Forms.NumericUpDown();
            this.gbCinsiyet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIsTecrubesi)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAdi
            // 
            this.tbAdi.Location = new System.Drawing.Point(134, 6);
            this.tbAdi.Name = "tbAdi";
            this.tbAdi.Size = new System.Drawing.Size(221, 20);
            this.tbAdi.TabIndex = 3;
            // 
            // labelAdi
            // 
            this.labelAdi.AutoSize = true;
            this.labelAdi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdi.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelAdi.Location = new System.Drawing.Point(12, 9);
            this.labelAdi.Name = "labelAdi";
            this.labelAdi.Size = new System.Drawing.Size(37, 13);
            this.labelAdi.TabIndex = 2;
            this.labelAdi.Text = "Adı : ";
            // 
            // tbSoyadi
            // 
            this.tbSoyadi.Location = new System.Drawing.Point(134, 32);
            this.tbSoyadi.Name = "tbSoyadi";
            this.tbSoyadi.Size = new System.Drawing.Size(221, 20);
            this.tbSoyadi.TabIndex = 5;
            // 
            // labelSoyadi
            // 
            this.labelSoyadi.AutoSize = true;
            this.labelSoyadi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoyadi.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelSoyadi.Location = new System.Drawing.Point(12, 35);
            this.labelSoyadi.Name = "labelSoyadi";
            this.labelSoyadi.Size = new System.Drawing.Size(57, 13);
            this.labelSoyadi.TabIndex = 4;
            this.labelSoyadi.Text = "Soyadı : ";
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(123, 19);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 1;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(33, 19);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(52, 17);
            this.rbKadin.TabIndex = 0;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // gbCinsiyet
            // 
            this.gbCinsiyet.Controls.Add(this.rbErkek);
            this.gbCinsiyet.Controls.Add(this.rbKadin);
            this.gbCinsiyet.Location = new System.Drawing.Point(134, 58);
            this.gbCinsiyet.Name = "gbCinsiyet";
            this.gbCinsiyet.Size = new System.Drawing.Size(221, 51);
            this.gbCinsiyet.TabIndex = 37;
            this.gbCinsiyet.TabStop = false;
            this.gbCinsiyet.Text = "Cinsiyet";
            // 
            // labelEposta
            // 
            this.labelEposta.AutoSize = true;
            this.labelEposta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEposta.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelEposta.Location = new System.Drawing.Point(12, 118);
            this.labelEposta.Name = "labelEposta";
            this.labelEposta.Size = new System.Drawing.Size(61, 13);
            this.labelEposta.TabIndex = 38;
            this.labelEposta.Text = "e-posta : ";
            // 
            // tbEposta
            // 
            this.tbEposta.Location = new System.Drawing.Point(134, 115);
            this.tbEposta.Name = "tbEposta";
            this.tbEposta.Size = new System.Drawing.Size(221, 20);
            this.tbEposta.TabIndex = 39;
            // 
            // mtbTelefon
            // 
            this.mtbTelefon.Location = new System.Drawing.Point(134, 141);
            this.mtbTelefon.Mask = "(999) 000-0000";
            this.mtbTelefon.Name = "mtbTelefon";
            this.mtbTelefon.Size = new System.Drawing.Size(221, 20);
            this.mtbTelefon.TabIndex = 40;
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTelefon.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelTelefon.Location = new System.Drawing.Point(12, 144);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(62, 13);
            this.labelTelefon.TabIndex = 41;
            this.labelTelefon.Text = "Telefon : ";
            // 
            // labelDogumTarihi
            // 
            this.labelDogumTarihi.AutoSize = true;
            this.labelDogumTarihi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDogumTarihi.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelDogumTarihi.Location = new System.Drawing.Point(12, 170);
            this.labelDogumTarihi.Name = "labelDogumTarihi";
            this.labelDogumTarihi.Size = new System.Drawing.Size(94, 13);
            this.labelDogumTarihi.TabIndex = 43;
            this.labelDogumTarihi.Text = "Doğum Tarihi : ";
            // 
            // mtbDogumTarihi
            // 
            this.mtbDogumTarihi.Location = new System.Drawing.Point(134, 167);
            this.mtbDogumTarihi.Mask = "00/00/0000";
            this.mtbDogumTarihi.Name = "mtbDogumTarihi";
            this.mtbDogumTarihi.Size = new System.Drawing.Size(221, 20);
            this.mtbDogumTarihi.TabIndex = 42;
            this.mtbDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // btnKisiOlustur
            // 
            this.btnKisiOlustur.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKisiOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKisiOlustur.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnKisiOlustur.Location = new System.Drawing.Point(134, 299);
            this.btnKisiOlustur.Name = "btnKisiOlustur";
            this.btnKisiOlustur.Size = new System.Drawing.Size(77, 23);
            this.btnKisiOlustur.TabIndex = 44;
            this.btnKisiOlustur.Text = "OLUŞTUR";
            this.btnKisiOlustur.UseVisualStyleBackColor = false;
            this.btnKisiOlustur.Click += new System.EventHandler(this.btnKisiOlustur_Click);
            // 
            // rtbAdres
            // 
            this.rtbAdres.Location = new System.Drawing.Point(134, 194);
            this.rtbAdres.Name = "rtbAdres";
            this.rtbAdres.Size = new System.Drawing.Size(221, 60);
            this.rtbAdres.TabIndex = 45;
            this.rtbAdres.Text = "";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdres.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelAdres.Location = new System.Drawing.Point(12, 197);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(51, 13);
            this.labelAdres.TabIndex = 47;
            this.labelAdres.Text = "Adres : ";
            // 
            // labelIsTecrubesi
            // 
            this.labelIsTecrubesi.AutoSize = true;
            this.labelIsTecrubesi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIsTecrubesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelIsTecrubesi.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelIsTecrubesi.Location = new System.Drawing.Point(12, 263);
            this.labelIsTecrubesi.Name = "labelIsTecrubesi";
            this.labelIsTecrubesi.Size = new System.Drawing.Size(115, 13);
            this.labelIsTecrubesi.TabIndex = 49;
            this.labelIsTecrubesi.Text = "İş Tecrübesi (Yıl) : ";
            // 
            // nudIsTecrubesi
            // 
            this.nudIsTecrubesi.Location = new System.Drawing.Point(134, 261);
            this.nudIsTecrubesi.Name = "nudIsTecrubesi";
            this.nudIsTecrubesi.Size = new System.Drawing.Size(221, 20);
            this.nudIsTecrubesi.TabIndex = 50;
            // 
            // KisiOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(371, 334);
            this.Controls.Add(this.nudIsTecrubesi);
            this.Controls.Add(this.labelIsTecrubesi);
            this.Controls.Add(this.labelAdres);
            this.Controls.Add(this.rtbAdres);
            this.Controls.Add(this.btnKisiOlustur);
            this.Controls.Add(this.labelDogumTarihi);
            this.Controls.Add(this.mtbDogumTarihi);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.mtbTelefon);
            this.Controls.Add(this.tbEposta);
            this.Controls.Add(this.labelEposta);
            this.Controls.Add(this.gbCinsiyet);
            this.Controls.Add(this.tbSoyadi);
            this.Controls.Add(this.labelSoyadi);
            this.Controls.Add(this.tbAdi);
            this.Controls.Add(this.labelAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KisiOlustur";
            this.Text = "Kişi Oluştur";
            this.Load += new System.EventHandler(this.KisiOlustur_Load);
            this.gbCinsiyet.ResumeLayout(false);
            this.gbCinsiyet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIsTecrubesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAdi;
        private System.Windows.Forms.Label labelAdi;
        private System.Windows.Forms.TextBox tbSoyadi;
        private System.Windows.Forms.Label labelSoyadi;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.GroupBox gbCinsiyet;
        private System.Windows.Forms.Label labelEposta;
        private System.Windows.Forms.TextBox tbEposta;
        private System.Windows.Forms.MaskedTextBox mtbTelefon;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelDogumTarihi;
        private System.Windows.Forms.MaskedTextBox mtbDogumTarihi;
        private System.Windows.Forms.Button btnKisiOlustur;
        private System.Windows.Forms.RichTextBox rtbAdres;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelIsTecrubesi;
        private System.Windows.Forms.NumericUpDown nudIsTecrubesi;
    }
}