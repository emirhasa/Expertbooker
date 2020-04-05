namespace EkspertBooker.DesktopAppUI.Projekt
{
    partial class FormProjektDetalji
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
            this.textBoxNazivProjekta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKratkiOpis = new System.Windows.Forms.TextBox();
            this.textBoxDetaljniOpis = new System.Windows.Forms.TextBox();
            this.dateTimePickerDatumPocetka = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownTrajanje = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxKategorija = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownBudzet = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxHitan = new System.Windows.Forms.CheckBox();
            this.buttonSacuvaj = new System.Windows.Forms.Button();
            this.errorProviderDodajProjekt = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSacuvajDetalji = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxNapomena = new System.Windows.Forms.TextBox();
            this.textBoxAktivanDetaljanOpis = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrajanje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBudzet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDodajProjekt)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNazivProjekta
            // 
            this.textBoxNazivProjekta.Location = new System.Drawing.Point(48, 43);
            this.textBoxNazivProjekta.Name = "textBoxNazivProjekta";
            this.textBoxNazivProjekta.Size = new System.Drawing.Size(233, 20);
            this.textBoxNazivProjekta.TabIndex = 0;
            this.textBoxNazivProjekta.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNazivProjekta_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv projekta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kratki opis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Detaljni opis";
            // 
            // textBoxKratkiOpis
            // 
            this.textBoxKratkiOpis.Location = new System.Drawing.Point(48, 91);
            this.textBoxKratkiOpis.Multiline = true;
            this.textBoxKratkiOpis.Name = "textBoxKratkiOpis";
            this.textBoxKratkiOpis.Size = new System.Drawing.Size(233, 49);
            this.textBoxKratkiOpis.TabIndex = 4;
            this.textBoxKratkiOpis.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxKratkiOpis_Validating);
            // 
            // textBoxDetaljniOpis
            // 
            this.textBoxDetaljniOpis.Location = new System.Drawing.Point(48, 169);
            this.textBoxDetaljniOpis.Multiline = true;
            this.textBoxDetaljniOpis.Name = "textBoxDetaljniOpis";
            this.textBoxDetaljniOpis.Size = new System.Drawing.Size(233, 213);
            this.textBoxDetaljniOpis.TabIndex = 5;
            this.textBoxDetaljniOpis.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDetaljniOpis_Validating);
            // 
            // dateTimePickerDatumPocetka
            // 
            this.dateTimePickerDatumPocetka.CustomFormat = "dd.MM.yyyy";
            this.dateTimePickerDatumPocetka.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDatumPocetka.Location = new System.Drawing.Point(310, 42);
            this.dateTimePickerDatumPocetka.MinDate = new System.DateTime(2018, 6, 3, 0, 0, 0, 0);
            this.dateTimePickerDatumPocetka.Name = "dateTimePickerDatumPocetka";
            this.dateTimePickerDatumPocetka.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDatumPocetka.TabIndex = 6;
            this.dateTimePickerDatumPocetka.Value = new System.DateTime(2020, 1, 31, 1, 29, 57, 0);
            this.dateTimePickerDatumPocetka.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerDatumPocetka_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datum pocetka";
            // 
            // numericUpDownTrajanje
            // 
            this.numericUpDownTrajanje.Location = new System.Drawing.Point(310, 92);
            this.numericUpDownTrajanje.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numericUpDownTrajanje.Name = "numericUpDownTrajanje";
            this.numericUpDownTrajanje.Size = new System.Drawing.Size(161, 20);
            this.numericUpDownTrajanje.TabIndex = 8;
            this.numericUpDownTrajanje.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTrajanje.Validating += new System.ComponentModel.CancelEventHandler(this.numericUpDownTrajanje_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Trajanje";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dana";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kategorija";
            // 
            // comboBoxKategorija
            // 
            this.comboBoxKategorija.FormattingEnabled = true;
            this.comboBoxKategorija.Location = new System.Drawing.Point(310, 169);
            this.comboBoxKategorija.Name = "comboBoxKategorija";
            this.comboBoxKategorija.Size = new System.Drawing.Size(161, 21);
            this.comboBoxKategorija.TabIndex = 13;
            this.comboBoxKategorija.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxKategorija_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Budzet(u KM)";
            // 
            // numericUpDownBudzet
            // 
            this.numericUpDownBudzet.Location = new System.Drawing.Point(310, 225);
            this.numericUpDownBudzet.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numericUpDownBudzet.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownBudzet.Name = "numericUpDownBudzet";
            this.numericUpDownBudzet.Size = new System.Drawing.Size(161, 20);
            this.numericUpDownBudzet.TabIndex = 15;
            this.numericUpDownBudzet.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownBudzet.Validating += new System.ComponentModel.CancelEventHandler(this.numericUpDownBudzet_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(477, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "KM";
            // 
            // checkBoxHitan
            // 
            this.checkBoxHitan.AutoSize = true;
            this.checkBoxHitan.Location = new System.Drawing.Point(310, 268);
            this.checkBoxHitan.Name = "checkBoxHitan";
            this.checkBoxHitan.Size = new System.Drawing.Size(92, 17);
            this.checkBoxHitan.TabIndex = 17;
            this.checkBoxHitan.Text = "Hitan projekat";
            this.checkBoxHitan.UseVisualStyleBackColor = true;
            // 
            // buttonSacuvaj
            // 
            this.buttonSacuvaj.Location = new System.Drawing.Point(310, 332);
            this.buttonSacuvaj.Name = "buttonSacuvaj";
            this.buttonSacuvaj.Size = new System.Drawing.Size(200, 50);
            this.buttonSacuvaj.TabIndex = 18;
            this.buttonSacuvaj.Text = "Sacuvaj";
            this.buttonSacuvaj.UseVisualStyleBackColor = true;
            this.buttonSacuvaj.Click += new System.EventHandler(this.buttonDodajProjekat_Click);
            // 
            // errorProviderDodajProjekt
            // 
            this.errorProviderDodajProjekt.BlinkRate = 100;
            this.errorProviderDodajProjekt.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSacuvajDetalji);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxNapomena);
            this.groupBox1.Controls.Add(this.textBoxAktivanDetaljanOpis);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(557, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 368);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodatni detalji";
            // 
            // buttonSacuvajDetalji
            // 
            this.buttonSacuvajDetalji.Enabled = false;
            this.buttonSacuvajDetalji.Location = new System.Drawing.Point(13, 263);
            this.buttonSacuvajDetalji.Name = "buttonSacuvajDetalji";
            this.buttonSacuvajDetalji.Size = new System.Drawing.Size(314, 24);
            this.buttonSacuvajDetalji.TabIndex = 21;
            this.buttonSacuvajDetalji.Text = "Sacuvaj - dodatno";
            this.buttonSacuvajDetalji.UseVisualStyleBackColor = true;
            this.buttonSacuvajDetalji.Click += new System.EventHandler(this.buttonSacuvajDetalji_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Napomena";
            // 
            // textBoxNapomena
            // 
            this.textBoxNapomena.Enabled = false;
            this.textBoxNapomena.Location = new System.Drawing.Point(10, 210);
            this.textBoxNapomena.Multiline = true;
            this.textBoxNapomena.Name = "textBoxNapomena";
            this.textBoxNapomena.Size = new System.Drawing.Size(317, 49);
            this.textBoxNapomena.TabIndex = 21;
            // 
            // textBoxAktivanDetaljanOpis
            // 
            this.textBoxAktivanDetaljanOpis.Enabled = false;
            this.textBoxAktivanDetaljanOpis.Location = new System.Drawing.Point(10, 52);
            this.textBoxAktivanDetaljanOpis.Multiline = true;
            this.textBoxAktivanDetaljanOpis.Name = "textBoxAktivanDetaljanOpis";
            this.textBoxAktivanDetaljanOpis.Size = new System.Drawing.Size(317, 128);
            this.textBoxAktivanDetaljanOpis.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(257, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Sacekati da poslodavac i ekspert dodju do dogovora";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(219, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Projekat nije aktivan, nema dodatnih detalja. ";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FormProjektDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 406);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSacuvaj);
            this.Controls.Add(this.checkBoxHitan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDownBudzet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxKategorija);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownTrajanje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerDatumPocetka);
            this.Controls.Add(this.textBoxDetaljniOpis);
            this.Controls.Add(this.textBoxKratkiOpis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNazivProjekta);
            this.Name = "FormProjektDetalji";
            this.Text = "Projekt Detalji";
            this.Load += new System.EventHandler(this.FormDodajProjekt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrajanje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBudzet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDodajProjekt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNazivProjekta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKratkiOpis;
        private System.Windows.Forms.TextBox textBoxDetaljniOpis;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumPocetka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownTrajanje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxKategorija;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownBudzet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxHitan;
        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.ErrorProvider errorProviderDodajProjekt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxNapomena;
        private System.Windows.Forms.TextBox textBoxAktivanDetaljanOpis;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button buttonSacuvajDetalji;
    }
}