namespace EkspertBooker.DesktopAppUI.Projekt
{
    partial class FormUrediPonudu
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
            this.numericUpDownCijena = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSacuvaj = new System.Windows.Forms.Button();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEkspert = new System.Windows.Forms.TextBox();
            this.textBoxProjekt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCijena)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownCijena
            // 
            this.numericUpDownCijena.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCijena.Location = new System.Drawing.Point(12, 180);
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
            this.numericUpDownCijena.TabIndex = 10;
            this.numericUpDownCijena.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cijena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Aproksimacija, u KM";
            // 
            // buttonSacuvaj
            // 
            this.buttonSacuvaj.Location = new System.Drawing.Point(12, 206);
            this.buttonSacuvaj.Name = "buttonSacuvaj";
            this.buttonSacuvaj.Size = new System.Drawing.Size(398, 23);
            this.buttonSacuvaj.TabIndex = 13;
            this.buttonSacuvaj.Text = "Sacuvaj";
            this.buttonSacuvaj.UseVisualStyleBackColor = true;
            this.buttonSacuvaj.Click += new System.EventHandler(this.buttonSacuvaj_Click);
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(13, 93);
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(401, 55);
            this.textBoxOpis.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Opis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ekspert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Projekt";
            // 
            // textBoxEkspert
            // 
            this.textBoxEkspert.Enabled = false;
            this.textBoxEkspert.Location = new System.Drawing.Point(16, 35);
            this.textBoxEkspert.Name = "textBoxEkspert";
            this.textBoxEkspert.Size = new System.Drawing.Size(164, 20);
            this.textBoxEkspert.TabIndex = 18;
            // 
            // textBoxProjekt
            // 
            this.textBoxProjekt.Enabled = false;
            this.textBoxProjekt.Location = new System.Drawing.Point(208, 35);
            this.textBoxProjekt.Name = "textBoxProjekt";
            this.textBoxProjekt.Size = new System.Drawing.Size(202, 20);
            this.textBoxProjekt.TabIndex = 19;
            // 
            // FormUrediPonudu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 240);
            this.Controls.Add(this.textBoxProjekt);
            this.Controls.Add(this.textBoxEkspert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.buttonSacuvaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownCijena);
            this.Name = "FormUrediPonudu";
            this.Text = "Uredi Ponudu";
            this.Load += new System.EventHandler(this.FormUrediPonudu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCijena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownCijena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEkspert;
        private System.Windows.Forms.TextBox textBoxProjekt;
    }
}