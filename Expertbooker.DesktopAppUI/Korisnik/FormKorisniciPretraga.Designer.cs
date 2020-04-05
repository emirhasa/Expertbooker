namespace EkspertBooker.DesktopAppUI.Korisnik
{
    partial class FormKorisniciPretraga
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
            this.labelKorisnici1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKorisniciSearchIme = new System.Windows.Forms.TextBox();
            this.textBoxKorisniciSearchPrezime = new System.Windows.Forms.TextBox();
            this.buttonKorisniciPrikazi = new System.Windows.Forms.Button();
            this.groupBoxKorisniciPrikaz = new System.Windows.Forms.GroupBox();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTipKorisnika = new System.Windows.Forms.GroupBox();
            this.checkBoxEksperti = new System.Windows.Forms.CheckBox();
            this.checkBoxPoslodavci = new System.Windows.Forms.CheckBox();
            this.checkBoxAdministratori = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxKorisniciPrikaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.groupBoxTipKorisnika.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelKorisnici1
            // 
            this.labelKorisnici1.AutoSize = true;
            this.labelKorisnici1.Location = new System.Drawing.Point(37, 20);
            this.labelKorisnici1.Name = "labelKorisnici1";
            this.labelKorisnici1.Size = new System.Drawing.Size(24, 13);
            this.labelKorisnici1.TabIndex = 4;
            this.labelKorisnici1.Text = "Ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prezime";
            // 
            // textBoxKorisniciSearchIme
            // 
            this.textBoxKorisniciSearchIme.Location = new System.Drawing.Point(40, 36);
            this.textBoxKorisniciSearchIme.Name = "textBoxKorisniciSearchIme";
            this.textBoxKorisniciSearchIme.Size = new System.Drawing.Size(287, 20);
            this.textBoxKorisniciSearchIme.TabIndex = 6;
            // 
            // textBoxKorisniciSearchPrezime
            // 
            this.textBoxKorisniciSearchPrezime.Location = new System.Drawing.Point(40, 86);
            this.textBoxKorisniciSearchPrezime.Name = "textBoxKorisniciSearchPrezime";
            this.textBoxKorisniciSearchPrezime.Size = new System.Drawing.Size(286, 20);
            this.textBoxKorisniciSearchPrezime.TabIndex = 7;
            // 
            // buttonKorisniciPrikazi
            // 
            this.buttonKorisniciPrikazi.Location = new System.Drawing.Point(350, 36);
            this.buttonKorisniciPrikazi.Name = "buttonKorisniciPrikazi";
            this.buttonKorisniciPrikazi.Size = new System.Drawing.Size(122, 23);
            this.buttonKorisniciPrikazi.TabIndex = 8;
            this.buttonKorisniciPrikazi.Text = "Prikazi";
            this.buttonKorisniciPrikazi.UseVisualStyleBackColor = true;
            this.buttonKorisniciPrikazi.Click += new System.EventHandler(this.buttonKorisniciPrikazi_Click);
            // 
            // groupBoxKorisniciPrikaz
            // 
            this.groupBoxKorisniciPrikaz.Controls.Add(this.dgvKorisnici);
            this.groupBoxKorisniciPrikaz.Location = new System.Drawing.Point(40, 112);
            this.groupBoxKorisniciPrikaz.Name = "groupBoxKorisniciPrikaz";
            this.groupBoxKorisniciPrikaz.Size = new System.Drawing.Size(664, 329);
            this.groupBoxKorisniciPrikaz.TabIndex = 9;
            this.groupBoxKorisniciPrikaz.TabStop = false;
            this.groupBoxKorisniciPrikaz.Text = "Korisnici";
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Id});
            this.dgvKorisnici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKorisnici.Location = new System.Drawing.Point(3, 16);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(658, 310);
            this.dgvKorisnici.TabIndex = 0;
            this.dgvKorisnici.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKorisnici_CellMouseDoubleClick);
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "KorisnikId";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // groupBoxTipKorisnika
            // 
            this.groupBoxTipKorisnika.Controls.Add(this.checkBoxEksperti);
            this.groupBoxTipKorisnika.Controls.Add(this.checkBoxPoslodavci);
            this.groupBoxTipKorisnika.Controls.Add(this.checkBoxAdministratori);
            this.groupBoxTipKorisnika.Location = new System.Drawing.Point(350, 70);
            this.groupBoxTipKorisnika.Name = "groupBoxTipKorisnika";
            this.groupBoxTipKorisnika.Size = new System.Drawing.Size(319, 36);
            this.groupBoxTipKorisnika.TabIndex = 13;
            this.groupBoxTipKorisnika.TabStop = false;
            this.groupBoxTipKorisnika.Text = "Uloge";
            // 
            // checkBoxEksperti
            // 
            this.checkBoxEksperti.AutoSize = true;
            this.checkBoxEksperti.Location = new System.Drawing.Point(218, 16);
            this.checkBoxEksperti.Name = "checkBoxEksperti";
            this.checkBoxEksperti.Size = new System.Drawing.Size(64, 17);
            this.checkBoxEksperti.TabIndex = 2;
            this.checkBoxEksperti.Text = "Eksperti";
            this.checkBoxEksperti.UseVisualStyleBackColor = true;
            // 
            // checkBoxPoslodavci
            // 
            this.checkBoxPoslodavci.AutoSize = true;
            this.checkBoxPoslodavci.Location = new System.Drawing.Point(112, 16);
            this.checkBoxPoslodavci.Name = "checkBoxPoslodavci";
            this.checkBoxPoslodavci.Size = new System.Drawing.Size(78, 17);
            this.checkBoxPoslodavci.TabIndex = 1;
            this.checkBoxPoslodavci.Text = "Poslodavci";
            this.checkBoxPoslodavci.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdministratori
            // 
            this.checkBoxAdministratori.AutoSize = true;
            this.checkBoxAdministratori.Location = new System.Drawing.Point(7, 16);
            this.checkBoxAdministratori.Name = "checkBoxAdministratori";
            this.checkBoxAdministratori.Size = new System.Drawing.Size(88, 17);
            this.checkBoxAdministratori.TabIndex = 0;
            this.checkBoxAdministratori.Text = "Administratori";
            this.checkBoxAdministratori.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "0 uloga checked(filter iskljucen) = all uloge checked";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Korisnik detalji = row double click";
            // 
            // FormKorisniciPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxKorisniciPrikaz);
            this.Controls.Add(this.buttonKorisniciPrikazi);
            this.Controls.Add(this.textBoxKorisniciSearchPrezime);
            this.Controls.Add(this.textBoxKorisniciSearchIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelKorisnici1);
            this.Controls.Add(this.groupBoxTipKorisnika);
            this.Name = "FormKorisniciPretraga";
            this.Text = "Pretraga korisnika";
            this.groupBoxKorisniciPrikaz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.groupBoxTipKorisnika.ResumeLayout(false);
            this.groupBoxTipKorisnika.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKorisnici1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKorisniciSearchIme;
        private System.Windows.Forms.TextBox textBoxKorisniciSearchPrezime;
        private System.Windows.Forms.Button buttonKorisniciPrikazi;
        private System.Windows.Forms.GroupBox groupBoxKorisniciPrikaz;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.GroupBox groupBoxTipKorisnika;
        private System.Windows.Forms.CheckBox checkBoxEksperti;
        private System.Windows.Forms.CheckBox checkBoxPoslodavci;
        private System.Windows.Forms.CheckBox checkBoxAdministratori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}