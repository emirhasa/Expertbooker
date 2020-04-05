namespace EkspertBooker.DesktopAppUI.Projekt
{
    partial class FormNovaPonuda
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
            this.comboBoxEksperti = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProjekti = new System.Windows.Forms.ComboBox();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownCijena = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSacuvaj = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCijena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEksperti
            // 
            this.comboBoxEksperti.FormattingEnabled = true;
            this.comboBoxEksperti.Location = new System.Drawing.Point(29, 43);
            this.comboBoxEksperti.Name = "comboBoxEksperti";
            this.comboBoxEksperti.Size = new System.Drawing.Size(170, 21);
            this.comboBoxEksperti.TabIndex = 3;
            this.comboBoxEksperti.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxEksperti_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ekspert";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Projekti(stanje - licitacija)";
            // 
            // comboBoxProjekti
            // 
            this.comboBoxProjekti.FormattingEnabled = true;
            this.comboBoxProjekti.Location = new System.Drawing.Point(260, 43);
            this.comboBoxProjekti.Name = "comboBoxProjekti";
            this.comboBoxProjekti.Size = new System.Drawing.Size(170, 21);
            this.comboBoxProjekti.TabIndex = 6;
            this.comboBoxProjekti.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxProjekti_Validating);
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(29, 105);
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(401, 55);
            this.textBoxOpis.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Opis";
            // 
            // numericUpDownCijena
            // 
            this.numericUpDownCijena.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCijena.Location = new System.Drawing.Point(32, 192);
            this.numericUpDownCijena.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownCijena.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCijena.Name = "numericUpDownCijena";
            this.numericUpDownCijena.Size = new System.Drawing.Size(94, 20);
            this.numericUpDownCijena.TabIndex = 9;
            this.numericUpDownCijena.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCijena.Validating += new System.ComponentModel.CancelEventHandler(this.numericUpDownCijena_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cijena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Aproksimacija, u KM";
            // 
            // buttonSacuvaj
            // 
            this.buttonSacuvaj.Location = new System.Drawing.Point(32, 236);
            this.buttonSacuvaj.Name = "buttonSacuvaj";
            this.buttonSacuvaj.Size = new System.Drawing.Size(398, 23);
            this.buttonSacuvaj.TabIndex = 12;
            this.buttonSacuvaj.Text = "Sacuvaj";
            this.buttonSacuvaj.UseVisualStyleBackColor = true;
            this.buttonSacuvaj.Click += new System.EventHandler(this.buttonSacuvaj_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // FormNovaPonuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 271);
            this.Controls.Add(this.buttonSacuvaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownCijena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.comboBoxProjekti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEksperti);
            this.Name = "FormNovaPonuda";
            this.Text = "Nova ponuda";
            this.Load += new System.EventHandler(this.FormNovaPonuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCijena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEksperti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProjekti;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownCijena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}