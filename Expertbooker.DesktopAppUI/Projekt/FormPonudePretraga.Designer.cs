namespace EkspertBooker.DesktopAppUI.Projekt
{
    partial class FormPonudePretraga
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
            this.dataGridViewProjekti = new System.Windows.Forms.DataGridView();
            this.ProjektId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projekti = new System.Windows.Forms.Label();
            this.dataGridViewPonude = new System.Windows.Forms.DataGridView();
            this.Ponude = new System.Windows.Forms.Label();
            this.PonudaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjekti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPonude)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProjekti
            // 
            this.dataGridViewProjekti.AllowUserToAddRows = false;
            this.dataGridViewProjekti.AllowUserToDeleteRows = false;
            this.dataGridViewProjekti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjekti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjektId,
            this.Naziv});
            this.dataGridViewProjekti.Location = new System.Drawing.Point(12, 29);
            this.dataGridViewProjekti.MultiSelect = false;
            this.dataGridViewProjekti.Name = "dataGridViewProjekti";
            this.dataGridViewProjekti.ReadOnly = true;
            this.dataGridViewProjekti.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProjekti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProjekti.Size = new System.Drawing.Size(250, 402);
            this.dataGridViewProjekti.TabIndex = 8;
            this.dataGridViewProjekti.Click += new System.EventHandler(this.dataGridViewProjekti_Click);
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
            // Projekti
            // 
            this.Projekti.AutoSize = true;
            this.Projekti.Location = new System.Drawing.Point(13, 13);
            this.Projekti.Name = "Projekti";
            this.Projekti.Size = new System.Drawing.Size(177, 13);
            this.Projekti.TabIndex = 9;
            this.Projekti.Text = "Projekti(ponuda - klik na projekt red)";
            // 
            // dataGridViewPonude
            // 
            this.dataGridViewPonude.AllowUserToAddRows = false;
            this.dataGridViewPonude.AllowUserToDeleteRows = false;
            this.dataGridViewPonude.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPonude.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PonudaId,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Cijena});
            this.dataGridViewPonude.Location = new System.Drawing.Point(286, 29);
            this.dataGridViewPonude.MultiSelect = false;
            this.dataGridViewPonude.Name = "dataGridViewPonude";
            this.dataGridViewPonude.ReadOnly = true;
            this.dataGridViewPonude.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPonude.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPonude.Size = new System.Drawing.Size(582, 402);
            this.dataGridViewPonude.TabIndex = 10;
            this.dataGridViewPonude.Click += new System.EventHandler(this.dataGridViewPonude_Click);
            // 
            // Ponude
            // 
            this.Ponude.AutoSize = true;
            this.Ponude.Location = new System.Drawing.Point(283, 13);
            this.Ponude.Name = "Ponude";
            this.Ponude.Size = new System.Drawing.Size(166, 13);
            this.Ponude.TabIndex = 11;
            this.Ponude.Text = "Ponude(uredi - klik na projekt red)";
            // 
            // PonudaId
            // 
            this.PonudaId.DataPropertyName = "PonudaId";
            this.PonudaId.Frozen = true;
            this.PonudaId.HeaderText = "PonudaId";
            this.PonudaId.Name = "PonudaId";
            this.PonudaId.ReadOnly = true;
            this.PonudaId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PonudaId.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EkspertId";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "EkspertId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OpisPonude";
            this.dataGridViewTextBoxColumn2.HeaderText = "Opis";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 350;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Width = 80;
            // 
            // FormPonudePretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 437);
            this.Controls.Add(this.Ponude);
            this.Controls.Add(this.dataGridViewPonude);
            this.Controls.Add(this.Projekti);
            this.Controls.Add(this.dataGridViewProjekti);
            this.Name = "FormPonudePretraga";
            this.Text = "Pretraga projekti - ponuda";
            this.Load += new System.EventHandler(this.FormPonudePretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjekti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPonude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProjekti;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjektId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.Label Projekti;
        private System.Windows.Forms.DataGridView dataGridViewPonude;
        private System.Windows.Forms.Label Ponude;
        private System.Windows.Forms.DataGridViewTextBoxColumn PonudaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
    }
}