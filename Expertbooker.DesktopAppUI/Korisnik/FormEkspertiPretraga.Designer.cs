namespace EkspertBooker.DesktopAppUI.Korisnik
{
    partial class FormEkspertiPretraga
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
            this.numericUpDownBrojProjekata = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxUkljuciFilter = new System.Windows.Forms.CheckBox();
            this.dataGridViewEksperti = new System.Windows.Forms.DataGridView();
            this.EkspertId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProsjecnaOcjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojZavrsenihProjekata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewRecenzije = new System.Windows.Forms.DataGridView();
            this.Komentar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRecenzije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojProjekata)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEksperti)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecenzije)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownBrojProjekata
            // 
            this.numericUpDownBrojProjekata.Location = new System.Drawing.Point(141, 36);
            this.numericUpDownBrojProjekata.Name = "numericUpDownBrojProjekata";
            this.numericUpDownBrojProjekata.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBrojProjekata.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broj zavrsenih projekata >";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxUkljuciFilter);
            this.groupBox1.Controls.Add(this.numericUpDownBrojProjekata);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filteri";
            // 
            // checkBoxUkljuciFilter
            // 
            this.checkBoxUkljuciFilter.AutoSize = true;
            this.checkBoxUkljuciFilter.Location = new System.Drawing.Point(9, 18);
            this.checkBoxUkljuciFilter.Name = "checkBoxUkljuciFilter";
            this.checkBoxUkljuciFilter.Size = new System.Drawing.Size(80, 17);
            this.checkBoxUkljuciFilter.TabIndex = 2;
            this.checkBoxUkljuciFilter.Text = "Ukljuci filter";
            this.checkBoxUkljuciFilter.UseVisualStyleBackColor = true;
            this.checkBoxUkljuciFilter.CheckedChanged += new System.EventHandler(this.checkBoxUkljuciFilter_CheckedChanged);
            // 
            // dataGridViewEksperti
            // 
            this.dataGridViewEksperti.AllowUserToAddRows = false;
            this.dataGridViewEksperti.AllowUserToDeleteRows = false;
            this.dataGridViewEksperti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEksperti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EkspertId,
            this.ProsjecnaOcjena,
            this.BrojZavrsenihProjekata});
            this.dataGridViewEksperti.Location = new System.Drawing.Point(12, 78);
            this.dataGridViewEksperti.MultiSelect = false;
            this.dataGridViewEksperti.Name = "dataGridViewEksperti";
            this.dataGridViewEksperti.ReadOnly = true;
            this.dataGridViewEksperti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEksperti.Size = new System.Drawing.Size(354, 357);
            this.dataGridViewEksperti.TabIndex = 3;
            this.dataGridViewEksperti.Click += new System.EventHandler(this.dataGridViewEksperti_Click);
            // 
            // EkspertId
            // 
            this.EkspertId.DataPropertyName = "KorisnikId";
            this.EkspertId.HeaderText = "EkspertId";
            this.EkspertId.Name = "EkspertId";
            this.EkspertId.ReadOnly = true;
            // 
            // ProsjecnaOcjena
            // 
            this.ProsjecnaOcjena.DataPropertyName = "ProsjecnaOcjena";
            this.ProsjecnaOcjena.HeaderText = "Prosjecna Ocjena";
            this.ProsjecnaOcjena.Name = "ProsjecnaOcjena";
            this.ProsjecnaOcjena.ReadOnly = true;
            // 
            // BrojZavrsenihProjekata
            // 
            this.BrojZavrsenihProjekata.DataPropertyName = "BrojZavrsenihProjekata";
            this.BrojZavrsenihProjekata.HeaderText = "Broj Zavrsenih Projekata";
            this.BrojZavrsenihProjekata.Name = "BrojZavrsenihProjekata";
            this.BrojZavrsenihProjekata.ReadOnly = true;
            // 
            // buttonPrikazi
            // 
            this.buttonPrikazi.Location = new System.Drawing.Point(295, 12);
            this.buttonPrikazi.Name = "buttonPrikazi";
            this.buttonPrikazi.Size = new System.Drawing.Size(71, 56);
            this.buttonPrikazi.TabIndex = 4;
            this.buttonPrikazi.Text = "Prikazi";
            this.buttonPrikazi.UseVisualStyleBackColor = true;
            this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewRecenzije);
            this.groupBox2.Location = new System.Drawing.Point(373, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 423);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recenzije - klik na ekspert row";
            // 
            // dataGridViewRecenzije
            // 
            this.dataGridViewRecenzije.AllowUserToAddRows = false;
            this.dataGridViewRecenzije.AllowUserToDeleteRows = false;
            this.dataGridViewRecenzije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecenzije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Komentar,
            this.Ocjena,
            this.DatumRecenzije});
            this.dataGridViewRecenzije.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewRecenzije.MultiSelect = false;
            this.dataGridViewRecenzije.Name = "dataGridViewRecenzije";
            this.dataGridViewRecenzije.ReadOnly = true;
            this.dataGridViewRecenzije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRecenzije.Size = new System.Drawing.Size(444, 403);
            this.dataGridViewRecenzije.TabIndex = 0;
            // 
            // Komentar
            // 
            this.Komentar.DataPropertyName = "Komentar";
            this.Komentar.HeaderText = "Komentar";
            this.Komentar.Name = "Komentar";
            this.Komentar.ReadOnly = true;
            this.Komentar.Width = 250;
            // 
            // Ocjena
            // 
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            this.Ocjena.Width = 50;
            // 
            // DatumRecenzije
            // 
            this.DatumRecenzije.DataPropertyName = "Vrijeme";
            this.DatumRecenzije.HeaderText = "Datum";
            this.DatumRecenzije.Name = "DatumRecenzije";
            this.DatumRecenzije.ReadOnly = true;
            // 
            // FormEkspertiPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 444);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonPrikazi);
            this.Controls.Add(this.dataGridViewEksperti);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEkspertiPretraga";
            this.Text = "Eksperti - recenzije";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojProjekata)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEksperti)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecenzije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownBrojProjekata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewEksperti;
        private System.Windows.Forms.Button buttonPrikazi;
        private System.Windows.Forms.CheckBox checkBoxUkljuciFilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewRecenzije;
        private System.Windows.Forms.DataGridViewTextBoxColumn EkspertId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProsjecnaOcjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojZavrsenihProjekata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Komentar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRecenzije;
    }
}