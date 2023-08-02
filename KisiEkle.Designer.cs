namespace pys
{
    partial class KisiEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KisiEkle));
            this.clbKisiler = new System.Windows.Forms.CheckedListBox();
            this.btnKisiEkle = new System.Windows.Forms.Button();
            this.btnYeniKisiOlustur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbKisiler
            // 
            this.clbKisiler.FormattingEnabled = true;
            this.clbKisiler.Location = new System.Drawing.Point(13, 13);
            this.clbKisiler.Name = "clbKisiler";
            this.clbKisiler.Size = new System.Drawing.Size(237, 259);
            this.clbKisiler.TabIndex = 0;
            this.clbKisiler.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.clbKisiler_Format);
            // 
            // btnKisiEkle
            // 
            this.btnKisiEkle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKisiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKisiEkle.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnKisiEkle.Location = new System.Drawing.Point(173, 278);
            this.btnKisiEkle.Name = "btnKisiEkle";
            this.btnKisiEkle.Size = new System.Drawing.Size(77, 23);
            this.btnKisiEkle.TabIndex = 38;
            this.btnKisiEkle.Text = "EKLE";
            this.btnKisiEkle.UseVisualStyleBackColor = false;
            // 
            // btnYeniKisiOlustur
            // 
            this.btnYeniKisiOlustur.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnYeniKisiOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniKisiOlustur.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnYeniKisiOlustur.Location = new System.Drawing.Point(13, 278);
            this.btnYeniKisiOlustur.Name = "btnYeniKisiOlustur";
            this.btnYeniKisiOlustur.Size = new System.Drawing.Size(123, 23);
            this.btnYeniKisiOlustur.TabIndex = 39;
            this.btnYeniKisiOlustur.Text = "YENİ KİŞİ OLUŞTUR";
            this.btnYeniKisiOlustur.UseVisualStyleBackColor = false;
            this.btnYeniKisiOlustur.Click += new System.EventHandler(this.btnYeniKisiOlustur_Click);
            // 
            // KisiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(262, 307);
            this.Controls.Add(this.btnYeniKisiOlustur);
            this.Controls.Add(this.btnKisiEkle);
            this.Controls.Add(this.clbKisiler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KisiEkle";
            this.Text = "Projeye Kişi Ekle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbKisiler;
        private System.Windows.Forms.Button btnKisiEkle;
        private System.Windows.Forms.Button btnYeniKisiOlustur;
    }
}