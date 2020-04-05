namespace EkspertBooker.DesktopAppUI.Korisnik
{
    partial class FormPoslodavciPretraga
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxUkljuciFilter = new System.Windows.Forms.CheckBox();
            this.numericUpDownBrojProjekata = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewRecenzije = new System.Windows.Forms.DataGridView();
            this.dataGridViewPoslodavci = new System.Windows.Forms.DataGridView();
            this.PoslodavacId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProsjecnaOcjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojZavrsenihProjekata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojProjekata)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecenzije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoslodavci)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxUkljuciFilter);
            this.groupBox1.Controls.Add(this.numericUpDownBrojProjekata);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 60);
            this.groupBox1.TabIndex = 3;
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
            // buttonPrikazi
            // 
            this.buttonPrikazi.Location = new System.Drawing.Point(295, 16);
            this.buttonPrikazi.Name = "buttonPrikazi";
            this.buttonPrikazi.Size = new System.Drawing.Size(71, 56);
            this.buttonPrikazi.TabIndex = 5;
            this.buttonPrikazi.Text = "Prikazi";
            this.buttonPrikazi.UseVisualStyleBackColor = true;
            this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewRecenzije);
            this.groupBox2.Location = new System.Drawing.Point(375, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 431);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recenzije - klik na poslodavac row";
            // 
            // dataGridViewRecenzije
            // 
            this.dataGridViewRecenzije.AllowUserToAddRows = false;
            this.dataGridViewRecenzije.AllowUserToDeleteRows = false;
            this.dataGridViewRecenzije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecenzije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewRecenzije.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewRecenzije.MultiSelect = false;
            this.dataGridViewRecenzije.Name = "dataGridViewRecenzije";
            this.dataGridViewRecenzije.ReadOnly = true;
            this.dataGridViewRecenzije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRecenzije.Size = new System.Drawing.Size(446, 403);
            this.dataGridViewRecenzije.TabIndex = 0;
            // 
            // dataGridViewPoslodavci
            // 
            this.dataGridViewPoslodavci.AllowUserToAddRows = false;
            this.dataGridViewPoslodavci.AllowUserToDeleteRows = false;
            this.dataGridViewPoslodavci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPoslodavci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PoslodavacId,
            this.ProsjecnaOcjena,
            this.BrojZavrsenihProjekata});
            this.dataGridViewPoslodavci.Location = new System.Drawing.Point(13, 79);
            this.dataGridViewPoslodavci.Name = "dataGridViewPoslodavci";
            this.dataGridViewPoslodavci.ReadOnly = true;
            this.dataGridViewPoslodavci.Size = new System.Drawing.Size(353, 360);
            this.dataGridViewPoslodavci.TabIndex = 9;
            this.dataGridViewPoslodavci.Click += new System.EventHandler(this.dataGridViewPoslodavci_Click);
            // 
            // PoslodavacId
            // 
            this.PoslodavacId.DataPropertyName = "KorisnikId";
            this.PoslodavacId.HeaderText = "PoslodavacId";
            this.PoslodavacId.Name = "PoslodavacId";
            this.PoslodavacId.ReadOnly = true;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Komentar";
            this.dataGridViewTextBoxColumn1.HeaderText = "Komentar";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ocjena";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ocjena";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Vrijeme";
            this.dataGridViewTextBoxColumn3.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // FormPoslodavciPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 446);
            this.Controls.Add(this.dataGridViewPoslodavci);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonPrikazi);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPoslodavciPretraga";
            this.Text = "Poslodavci - recenzije";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBrojProjekata)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecenzije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoslodavci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxUkljuciFilter;
        private System.Windows.Forms.NumericUpDown numericUpDownBrojProjekata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrikazi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewRecenzije;
        private System.Windows.Forms.DataGridView dataGridViewPoslodavci;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoslodavacId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProsjecnaOcjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojZavrsenihProjekata;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}