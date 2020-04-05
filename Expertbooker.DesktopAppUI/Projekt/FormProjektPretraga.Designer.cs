namespace EkspertBooker.DesktopAppUI.Projekt
{
    partial class FormProjektPretraga
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxKategorija = new System.Windows.Forms.ComboBox();
            this.dataGridViewProjekti = new System.Windows.Forms.DataGridView();
            this.ProjektId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KratkiOpis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrajanjeDana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumObjave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxHitan = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjekti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategorija";
            // 
            // comboBoxKategorija
            // 
            this.comboBoxKategorija.FormattingEnabled = true;
            this.comboBoxKategorija.Location = new System.Drawing.Point(30, 32);
            this.comboBoxKategorija.Name = "comboBoxKategorija";
            this.comboBoxKategorija.Size = new System.Drawing.Size(145, 21);
            this.comboBoxKategorija.TabIndex = 6;
            // 
            // dataGridViewProjekti
            // 
            this.dataGridViewProjekti.AllowUserToAddRows = false;
            this.dataGridViewProjekti.AllowUserToDeleteRows = false;
            this.dataGridViewProjekti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjekti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjektId,
            this.Naziv,
            this.KratkiOpis,
            this.TrajanjeDana,
            this.DatumObjave,
            this.Kategorija,
            this.Status});
            this.dataGridViewProjekti.Location = new System.Drawing.Point(30, 77);
            this.dataGridViewProjekti.MultiSelect = false;
            this.dataGridViewProjekti.Name = "dataGridViewProjekti";
            this.dataGridViewProjekti.ReadOnly = true;
            this.dataGridViewProjekti.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProjekti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProjekti.Size = new System.Drawing.Size(749, 361);
            this.dataGridViewProjekti.TabIndex = 7;
            this.dataGridViewProjekti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewProjekti_MouseDoubleClick);
            // 
            // ProjektId
            // 
            this.ProjektId.DataPropertyName = "ProjektId";
            this.ProjektId.HeaderText = "ProjektId";
            this.ProjektId.Name = "ProjektId";
            this.ProjektId.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // KratkiOpis
            // 
            this.KratkiOpis.DataPropertyName = "KratkiOpis";
            this.KratkiOpis.HeaderText = "Kratak Opis";
            this.KratkiOpis.Name = "KratkiOpis";
            this.KratkiOpis.ReadOnly = true;
            // 
            // TrajanjeDana
            // 
            this.TrajanjeDana.DataPropertyName = "TrajanjeDana";
            this.TrajanjeDana.HeaderText = "Duzina projekta(dani)";
            this.TrajanjeDana.Name = "TrajanjeDana";
            this.TrajanjeDana.ReadOnly = true;
            // 
            // DatumObjave
            // 
            this.DatumObjave.DataPropertyName = "DatumObjave";
            this.DatumObjave.HeaderText = "Datum Objave";
            this.DatumObjave.Name = "DatumObjave";
            this.DatumObjave.ReadOnly = true;
            // 
            // Kategorija
            // 
            this.Kategorija.DataPropertyName = "Kategorija";
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "StanjeId";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // buttonPrikazi
            // 
            this.buttonPrikazi.AccessibleName = "";
            this.buttonPrikazi.Location = new System.Drawing.Point(661, 30);
            this.buttonPrikazi.Name = "buttonPrikazi";
            this.buttonPrikazi.Size = new System.Drawing.Size(118, 23);
            this.buttonPrikazi.TabIndex = 8;
            this.buttonPrikazi.Text = "Prikazi";
            this.buttonPrikazi.UseVisualStyleBackColor = true;
            this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(224, 32);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(131, 20);
            this.textBoxNaziv.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Naziv";
            // 
            // checkBoxHitan
            // 
            this.checkBoxHitan.AutoSize = true;
            this.checkBoxHitan.Location = new System.Drawing.Point(410, 34);
            this.checkBoxHitan.Name = "checkBoxHitan";
            this.checkBoxHitan.Size = new System.Drawing.Size(84, 17);
            this.checkBoxHitan.TabIndex = 11;
            this.checkBoxHitan.Text = "Hitni projekti";
            this.checkBoxHitan.UseVisualStyleBackColor = true;
            // 
            // FormProjektPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxHitan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.buttonPrikazi);
            this.Controls.Add(this.dataGridViewProjekti);
            this.Controls.Add(this.comboBoxKategorija);
            this.Controls.Add(this.label1);
            this.Name = "FormProjektPretraga";
            this.Text = "Projekti - pretraga";
            this.Load += new System.EventHandler(this.FormProjektPretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjekti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKategorija;
        private System.Windows.Forms.DataGridView dataGridViewProjekti;
        private System.Windows.Forms.Button buttonPrikazi;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxHitan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjektId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn KratkiOpis;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrajanjeDana;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumObjave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}