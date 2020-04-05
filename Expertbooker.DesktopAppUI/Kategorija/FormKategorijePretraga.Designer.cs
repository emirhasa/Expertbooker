namespace EkspertBooker.DesktopAppUI.Kategorija
{
    partial class FormKategorijePretraga
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
            this.dataGridViewKategorije = new System.Windows.Forms.DataGridView();
            this.buttonDodajKategoriju = new System.Windows.Forms.Button();
            this.textBoxKategorijaNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUrediNoviNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUrediNaziv = new System.Windows.Forms.TextBox();
            this.buttonUrediKategoriju = new System.Windows.Forms.Button();
            this.buttonObrisiKategoriju = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorije)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewKategorije
            // 
            this.dataGridViewKategorije.AllowUserToAddRows = false;
            this.dataGridViewKategorije.AllowUserToDeleteRows = false;
            this.dataGridViewKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKategorije.Location = new System.Drawing.Point(12, 33);
            this.dataGridViewKategorije.MultiSelect = false;
            this.dataGridViewKategorije.Name = "dataGridViewKategorije";
            this.dataGridViewKategorije.ReadOnly = true;
            this.dataGridViewKategorije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKategorije.Size = new System.Drawing.Size(251, 299);
            this.dataGridViewKategorije.TabIndex = 0;
            this.dataGridViewKategorije.Click += new System.EventHandler(this.dataGridViewKategorije_Click);
            // 
            // buttonDodajKategoriju
            // 
            this.buttonDodajKategoriju.Location = new System.Drawing.Point(293, 59);
            this.buttonDodajKategoriju.Name = "buttonDodajKategoriju";
            this.buttonDodajKategoriju.Size = new System.Drawing.Size(208, 39);
            this.buttonDodajKategoriju.TabIndex = 1;
            this.buttonDodajKategoriju.Text = "Dodaj kategoriju";
            this.buttonDodajKategoriju.UseVisualStyleBackColor = true;
            this.buttonDodajKategoriju.Click += new System.EventHandler(this.buttonDodajKategoriju_Click);
            // 
            // textBoxKategorijaNaziv
            // 
            this.textBoxKategorijaNaziv.Location = new System.Drawing.Point(293, 33);
            this.textBoxKategorijaNaziv.Name = "textBoxKategorijaNaziv";
            this.textBoxKategorijaNaziv.Size = new System.Drawing.Size(208, 20);
            this.textBoxKategorijaNaziv.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista poslovnih kategorija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nova kategorija";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(284, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 109);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 325);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxUrediNoviNaziv);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxUrediNaziv);
            this.groupBox3.Controls.Add(this.buttonUrediKategoriju);
            this.groupBox3.Location = new System.Drawing.Point(284, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 210);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Uredi kategoriju";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Novi naziv";
            // 
            // textBoxUrediNoviNaziv
            // 
            this.textBoxUrediNoviNaziv.Enabled = false;
            this.textBoxUrediNoviNaziv.Location = new System.Drawing.Point(9, 92);
            this.textBoxUrediNoviNaziv.Name = "textBoxUrediNoviNaziv";
            this.textBoxUrediNoviNaziv.Size = new System.Drawing.Size(208, 20);
            this.textBoxUrediNoviNaziv.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trenutni naziv";
            // 
            // textBoxUrediNaziv
            // 
            this.textBoxUrediNaziv.Enabled = false;
            this.textBoxUrediNaziv.Location = new System.Drawing.Point(9, 40);
            this.textBoxUrediNaziv.Name = "textBoxUrediNaziv";
            this.textBoxUrediNaziv.Size = new System.Drawing.Size(208, 20);
            this.textBoxUrediNaziv.TabIndex = 8;
            // 
            // buttonUrediKategoriju
            // 
            this.buttonUrediKategoriju.Enabled = false;
            this.buttonUrediKategoriju.Location = new System.Drawing.Point(9, 130);
            this.buttonUrediKategoriju.Name = "buttonUrediKategoriju";
            this.buttonUrediKategoriju.Size = new System.Drawing.Size(208, 39);
            this.buttonUrediKategoriju.TabIndex = 8;
            this.buttonUrediKategoriju.Text = "Sacuvaj promjene";
            this.buttonUrediKategoriju.UseVisualStyleBackColor = true;
            this.buttonUrediKategoriju.Click += new System.EventHandler(this.buttonUrediKategoriju_Click);
            // 
            // buttonObrisiKategoriju
            // 
            this.buttonObrisiKategoriju.BackColor = System.Drawing.Color.LightCoral;
            this.buttonObrisiKategoriju.Enabled = false;
            this.buttonObrisiKategoriju.Location = new System.Drawing.Point(293, 303);
            this.buttonObrisiKategoriju.Name = "buttonObrisiKategoriju";
            this.buttonObrisiKategoriju.Size = new System.Drawing.Size(208, 21);
            this.buttonObrisiKategoriju.TabIndex = 13;
            this.buttonObrisiKategoriju.Text = "Obrisi kategoriju";
            this.buttonObrisiKategoriju.UseVisualStyleBackColor = false;
            this.buttonObrisiKategoriju.Click += new System.EventHandler(this.buttonObrisiKategoriju_Click);
            // 
            // FormKategorijePretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 350);
            this.Controls.Add(this.buttonObrisiKategoriju);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKategorijaNaziv);
            this.Controls.Add(this.buttonDodajKategoriju);
            this.Controls.Add(this.dataGridViewKategorije);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormKategorijePretraga";
            this.Text = "Kategorije";
            this.Load += new System.EventHandler(this.FormKategorijePretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategorije)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKategorije;
        private System.Windows.Forms.Button buttonDodajKategoriju;
        private System.Windows.Forms.TextBox textBoxKategorijaNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUrediNoviNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUrediNaziv;
        private System.Windows.Forms.Button buttonUrediKategoriju;
        private System.Windows.Forms.Button buttonObrisiKategoriju;
    }
}