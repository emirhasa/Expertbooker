namespace EkspertBooker.DesktopAppUI.Recenzije
{
    partial class FormRecenzijaDetalji
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProjekti = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEksperti = new System.Windows.Forms.ComboBox();
            this.comboBoxPoslodavci = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownOcjena = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKomentar = new System.Windows.Forms.TextBox();
            this.buttonSacuvaj = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonEkspert = new System.Windows.Forms.RadioButton();
            this.radioButtonPoslodavac = new System.Windows.Forms.RadioButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOcjena)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projekat";
            // 
            // comboBoxProjekti
            // 
            this.comboBoxProjekti.FormattingEnabled = true;
            this.comboBoxProjekti.Location = new System.Drawing.Point(25, 33);
            this.comboBoxProjekti.Name = "comboBoxProjekti";
            this.comboBoxProjekti.Size = new System.Drawing.Size(170, 21);
            this.comboBoxProjekti.TabIndex = 2;
            this.comboBoxProjekti.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxProjekti_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ekspert";
            // 
            // comboBoxEksperti
            // 
            this.comboBoxEksperti.FormattingEnabled = true;
            this.comboBoxEksperti.Location = new System.Drawing.Point(231, 33);
            this.comboBoxEksperti.Name = "comboBoxEksperti";
            this.comboBoxEksperti.Size = new System.Drawing.Size(178, 21);
            this.comboBoxEksperti.TabIndex = 4;
            this.comboBoxEksperti.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxEksperti_Validating);
            // 
            // comboBoxPoslodavci
            // 
            this.comboBoxPoslodavci.FormattingEnabled = true;
            this.comboBoxPoslodavci.Location = new System.Drawing.Point(25, 87);
            this.comboBoxPoslodavci.Name = "comboBoxPoslodavci";
            this.comboBoxPoslodavci.Size = new System.Drawing.Size(170, 21);
            this.comboBoxPoslodavci.TabIndex = 5;
            this.comboBoxPoslodavci.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxPoslodavci_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Poslodavac";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 107);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericUpDownOcjena);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxKomentar);
            this.groupBox2.Location = new System.Drawing.Point(25, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 162);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalji";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ocjena(1-10)";
            // 
            // numericUpDownOcjena
            // 
            this.numericUpDownOcjena.Location = new System.Drawing.Point(10, 127);
            this.numericUpDownOcjena.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownOcjena.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownOcjena.Name = "numericUpDownOcjena";
            this.numericUpDownOcjena.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownOcjena.TabIndex = 2;
            this.numericUpDownOcjena.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownOcjena.Validating += new System.ComponentModel.CancelEventHandler(this.numericUpDownOcjena_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Komentar";
            // 
            // textBoxKomentar
            // 
            this.textBoxKomentar.Location = new System.Drawing.Point(6, 43);
            this.textBoxKomentar.Multiline = true;
            this.textBoxKomentar.Name = "textBoxKomentar";
            this.textBoxKomentar.Size = new System.Drawing.Size(378, 55);
            this.textBoxKomentar.TabIndex = 0;
            // 
            // buttonSacuvaj
            // 
            this.buttonSacuvaj.Location = new System.Drawing.Point(31, 368);
            this.buttonSacuvaj.Name = "buttonSacuvaj";
            this.buttonSacuvaj.Size = new System.Drawing.Size(418, 23);
            this.buttonSacuvaj.TabIndex = 9;
            this.buttonSacuvaj.Text = "Sacuvaj";
            this.buttonSacuvaj.UseVisualStyleBackColor = true;
            this.buttonSacuvaj.Click += new System.EventHandler(this.buttonSacuvaj_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonEkspert);
            this.groupBox3.Controls.Add(this.radioButtonPoslodavac);
            this.groupBox3.Location = new System.Drawing.Point(25, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 42);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recenzija o";
            // 
            // radioButtonEkspert
            // 
            this.radioButtonEkspert.AutoSize = true;
            this.radioButtonEkspert.Location = new System.Drawing.Point(98, 20);
            this.radioButtonEkspert.Name = "radioButtonEkspert";
            this.radioButtonEkspert.Size = new System.Drawing.Size(67, 17);
            this.radioButtonEkspert.TabIndex = 1;
            this.radioButtonEkspert.TabStop = true;
            this.radioButtonEkspert.Text = "Ekspertu";
            this.radioButtonEkspert.UseVisualStyleBackColor = true;
            // 
            // radioButtonPoslodavac
            // 
            this.radioButtonPoslodavac.AutoSize = true;
            this.radioButtonPoslodavac.Location = new System.Drawing.Point(10, 19);
            this.radioButtonPoslodavac.Name = "radioButtonPoslodavac";
            this.radioButtonPoslodavac.Size = new System.Drawing.Size(81, 17);
            this.radioButtonPoslodavac.TabIndex = 0;
            this.radioButtonPoslodavac.TabStop = true;
            this.radioButtonPoslodavac.Text = "Poslodavcu";
            this.radioButtonPoslodavac.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormRecenzijaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 403);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonSacuvaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPoslodavci);
            this.Controls.Add(this.comboBoxEksperti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxProjekti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormRecenzijaDetalji";
            this.Text = "Recenzija Detalji";
            this.Load += new System.EventHandler(this.FormRecenzijaDetalji_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOcjena)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProjekti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEksperti;
        private System.Windows.Forms.ComboBox comboBoxPoslodavci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownOcjena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKomentar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonEkspert;
        private System.Windows.Forms.RadioButton radioButtonPoslodavac;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}