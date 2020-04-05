namespace EkspertBooker.DesktopAppUI
{
    partial class FormIndex
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projektToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektiPretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajProjekatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledajPonudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaKategorijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKategorijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciPretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaEkspertiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPoslodavciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recenzijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recenzijeOPoslodavcimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recenzijeOEkspertimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajRecenzijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvjestajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ponudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPonudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledPonudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ponudeProjektiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projektiPonudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPonudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projektToolStripMenuItem,
            this.kategorijaToolStripMenuItem,
            this.korisniciToolStripMenuItem,
            this.recenzijeToolStripMenuItem,
            this.reportingToolStripMenuItem,
            this.ponudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projektToolStripMenuItem
            // 
            this.projektToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projektiPretragaToolStripMenuItem,
            this.dodajProjekatToolStripMenuItem,
            this.pregledajPonudeToolStripMenuItem});
            this.projektToolStripMenuItem.Name = "projektToolStripMenuItem";
            this.projektToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.projektToolStripMenuItem.Text = "Projekt / ponuda";
            // 
            // projektiPretragaToolStripMenuItem
            // 
            this.projektiPretragaToolStripMenuItem.Name = "projektiPretragaToolStripMenuItem";
            this.projektiPretragaToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.projektiPretragaToolStripMenuItem.Text = "Pregledaj / uredi projekte";
            this.projektiPretragaToolStripMenuItem.Click += new System.EventHandler(this.projektiPretragaToolStripMenuItem_Click);
            // 
            // dodajProjekatToolStripMenuItem
            // 
            this.dodajProjekatToolStripMenuItem.Name = "dodajProjekatToolStripMenuItem";
            this.dodajProjekatToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.dodajProjekatToolStripMenuItem.Text = "Dodaj projekat";
            this.dodajProjekatToolStripMenuItem.Click += new System.EventHandler(this.dodajProjekatToolStripMenuItem_Click);
            // 
            // pregledajPonudeToolStripMenuItem
            // 
            this.pregledajPonudeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projektiPonudeToolStripMenuItem,
            this.novaPonudaToolStripMenuItem1});
            this.pregledajPonudeToolStripMenuItem.Name = "pregledajPonudeToolStripMenuItem";
            this.pregledajPonudeToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.pregledajPonudeToolStripMenuItem.Text = "Ponuda";
            // 
            // kategorijaToolStripMenuItem
            // 
            this.kategorijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaKategorijaToolStripMenuItem,
            this.dodajKategorijuToolStripMenuItem});
            this.kategorijaToolStripMenuItem.Name = "kategorijaToolStripMenuItem";
            this.kategorijaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.kategorijaToolStripMenuItem.Text = "Kategorije";
            // 
            // listaKategorijaToolStripMenuItem
            // 
            this.listaKategorijaToolStripMenuItem.Name = "listaKategorijaToolStripMenuItem";
            this.listaKategorijaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.listaKategorijaToolStripMenuItem.Text = "Uredi kategorije";
            this.listaKategorijaToolStripMenuItem.Click += new System.EventHandler(this.listaKategorijaToolStripMenuItem_Click);
            // 
            // dodajKategorijuToolStripMenuItem
            // 
            this.dodajKategorijuToolStripMenuItem.Name = "dodajKategorijuToolStripMenuItem";
            this.dodajKategorijuToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.dodajKategorijuToolStripMenuItem.Text = "Dodaj kategoriju";
            this.dodajKategorijuToolStripMenuItem.Click += new System.EventHandler(this.dodajKategorijuToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciPretragaToolStripMenuItem,
            this.dodajKorisnikaToolStripMenuItem,
            this.listaEkspertiToolStripMenuItem,
            this.listaPoslodavciToolStripMenuItem});
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // korisniciPretragaToolStripMenuItem
            // 
            this.korisniciPretragaToolStripMenuItem.Name = "korisniciPretragaToolStripMenuItem";
            this.korisniciPretragaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.korisniciPretragaToolStripMenuItem.Text = "Korisnici pretraga";
            this.korisniciPretragaToolStripMenuItem.Click += new System.EventHandler(this.korisniciPretragaToolStripMenuItem_Click);
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajKorisnikaToolStripMenuItem_Click);
            // 
            // listaEkspertiToolStripMenuItem
            // 
            this.listaEkspertiToolStripMenuItem.Name = "listaEkspertiToolStripMenuItem";
            this.listaEkspertiToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.listaEkspertiToolStripMenuItem.Text = "Detalji eksperti";
            this.listaEkspertiToolStripMenuItem.Click += new System.EventHandler(this.listaEkspertiToolStripMenuItem_Click);
            // 
            // listaPoslodavciToolStripMenuItem
            // 
            this.listaPoslodavciToolStripMenuItem.Name = "listaPoslodavciToolStripMenuItem";
            this.listaPoslodavciToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.listaPoslodavciToolStripMenuItem.Text = "Detalji poslodavci";
            this.listaPoslodavciToolStripMenuItem.Click += new System.EventHandler(this.listaPoslodavciToolStripMenuItem_Click);
            // 
            // recenzijeToolStripMenuItem
            // 
            this.recenzijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recenzijeOPoslodavcimaToolStripMenuItem,
            this.recenzijeOEkspertimaToolStripMenuItem,
            this.dodajRecenzijuToolStripMenuItem});
            this.recenzijeToolStripMenuItem.Name = "recenzijeToolStripMenuItem";
            this.recenzijeToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.recenzijeToolStripMenuItem.Text = "Recenzije";
            // 
            // recenzijeOPoslodavcimaToolStripMenuItem
            // 
            this.recenzijeOPoslodavcimaToolStripMenuItem.Name = "recenzijeOPoslodavcimaToolStripMenuItem";
            this.recenzijeOPoslodavcimaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.recenzijeOPoslodavcimaToolStripMenuItem.Text = "Recenzije o poslodavcima";
            this.recenzijeOPoslodavcimaToolStripMenuItem.Click += new System.EventHandler(this.recenzijeOPoslodavcimaToolStripMenuItem_Click);
            // 
            // recenzijeOEkspertimaToolStripMenuItem
            // 
            this.recenzijeOEkspertimaToolStripMenuItem.Name = "recenzijeOEkspertimaToolStripMenuItem";
            this.recenzijeOEkspertimaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.recenzijeOEkspertimaToolStripMenuItem.Text = "Recenzije o ekspertima";
            this.recenzijeOEkspertimaToolStripMenuItem.Click += new System.EventHandler(this.recenzijeOEkspertimaToolStripMenuItem_Click);
            // 
            // dodajRecenzijuToolStripMenuItem
            // 
            this.dodajRecenzijuToolStripMenuItem.Name = "dodajRecenzijuToolStripMenuItem";
            this.dodajRecenzijuToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.dodajRecenzijuToolStripMenuItem.Text = "Dodaj recenziju";
            this.dodajRecenzijuToolStripMenuItem.Click += new System.EventHandler(this.dodajRecenzijuToolStripMenuItem_Click);
            // 
            // reportingToolStripMenuItem
            // 
            this.reportingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izvjestajToolStripMenuItem});
            this.reportingToolStripMenuItem.Name = "reportingToolStripMenuItem";
            this.reportingToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.reportingToolStripMenuItem.Text = "Reporting";
            // 
            // izvjestajToolStripMenuItem
            // 
            this.izvjestajToolStripMenuItem.Name = "izvjestajToolStripMenuItem";
            this.izvjestajToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.izvjestajToolStripMenuItem.Text = "Izvjestaj";
            this.izvjestajToolStripMenuItem.Click += new System.EventHandler(this.izvjestajToolStripMenuItem_Click);
            // 
            // ponudaToolStripMenuItem
            // 
            this.ponudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaPonudaToolStripMenuItem,
            this.pregledPonudaToolStripMenuItem});
            this.ponudaToolStripMenuItem.Name = "ponudaToolStripMenuItem";
            this.ponudaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ponudaToolStripMenuItem.Text = "Ponuda";
            // 
            // novaPonudaToolStripMenuItem
            // 
            this.novaPonudaToolStripMenuItem.Name = "novaPonudaToolStripMenuItem";
            this.novaPonudaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.novaPonudaToolStripMenuItem.Text = "Nova ponuda";
            this.novaPonudaToolStripMenuItem.Click += new System.EventHandler(this.novaPonudaToolStripMenuItem_Click);
            // 
            // pregledPonudaToolStripMenuItem
            // 
            this.pregledPonudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ponudeProjektiToolStripMenuItem});
            this.pregledPonudaToolStripMenuItem.Name = "pregledPonudaToolStripMenuItem";
            this.pregledPonudaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.pregledPonudaToolStripMenuItem.Text = "Pregled ponuda";
            // 
            // ponudeProjektiToolStripMenuItem
            // 
            this.ponudeProjektiToolStripMenuItem.Name = "ponudeProjektiToolStripMenuItem";
            this.ponudeProjektiToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ponudeProjektiToolStripMenuItem.Text = "Ponude - projekti";
            this.ponudeProjektiToolStripMenuItem.Click += new System.EventHandler(this.ponudeProjektiToolStripMenuItem_Click);
            // 
            // projektiPonudeToolStripMenuItem
            // 
            this.projektiPonudeToolStripMenuItem.Name = "projektiPonudeToolStripMenuItem";
            this.projektiPonudeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.projektiPonudeToolStripMenuItem.Text = "Projekti - ponude";
            this.projektiPonudeToolStripMenuItem.Click += new System.EventHandler(this.projektiPonudeToolStripMenuItem_Click);
            // 
            // novaPonudaToolStripMenuItem1
            // 
            this.novaPonudaToolStripMenuItem1.Name = "novaPonudaToolStripMenuItem1";
            this.novaPonudaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.novaPonudaToolStripMenuItem1.Text = "Nova ponuda";
            this.novaPonudaToolStripMenuItem1.Click += new System.EventHandler(this.novaPonudaToolStripMenuItem1_Click);
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormIndex";
            this.Text = "EkspertBooker v14.3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projektToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektiPretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajProjekatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledajPonudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaKategorijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKategorijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciPretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaEkspertiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaPoslodavciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recenzijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recenzijeOPoslodavcimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recenzijeOEkspertimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajRecenzijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvjestajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ponudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaPonudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledPonudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ponudeProjektiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projektiPonudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaPonudaToolStripMenuItem1;
    }
}

