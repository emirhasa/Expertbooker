namespace EkspertBooker.DesktopAppUI.Korisnik
{
    partial class FormKorisnikDetalji
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
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clbRole = new System.Windows.Forms.CheckedListBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPasswordPotvrda = new System.Windows.Forms.TextBox();
            this.buttonSacuvaj = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonSlika = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSlika = new System.Windows.Forms.TextBox();
            this.errorProviderKorisnici = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(35, 41);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(176, 20);
            this.textBoxIme.TabIndex = 8;
            this.textBoxIme.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxIme_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "UserName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "PasswordPotvrda";
            // 
            // clbRole
            // 
            this.clbRole.FormattingEnabled = true;
            this.clbRole.Location = new System.Drawing.Point(256, 41);
            this.clbRole.Name = "clbRole";
            this.clbRole.Size = new System.Drawing.Size(209, 94);
            this.clbRole.TabIndex = 16;
            this.clbRole.Validating += new System.ComponentModel.CancelEventHandler(this.clbRole_Validating);
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(35, 95);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(176, 20);
            this.textBoxPrezime.TabIndex = 17;
            this.textBoxPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPrezime_Validating);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(35, 153);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(176, 20);
            this.textBoxEmail.TabIndex = 18;
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(35, 219);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(176, 20);
            this.textBoxTelefon.TabIndex = 19;
            this.textBoxTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTelefon_Validating);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(35, 275);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(176, 20);
            this.textBoxUsername.TabIndex = 20;
            this.textBoxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUsername_Validating);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(35, 353);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(176, 20);
            this.textBoxPassword.TabIndex = 21;
            this.textBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPassword_Validating);
            // 
            // textBoxPasswordPotvrda
            // 
            this.textBoxPasswordPotvrda.Location = new System.Drawing.Point(35, 407);
            this.textBoxPasswordPotvrda.Name = "textBoxPasswordPotvrda";
            this.textBoxPasswordPotvrda.PasswordChar = '*';
            this.textBoxPasswordPotvrda.Size = new System.Drawing.Size(176, 20);
            this.textBoxPasswordPotvrda.TabIndex = 22;
            this.textBoxPasswordPotvrda.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPasswordPotvrda_Validating);
            // 
            // buttonSacuvaj
            // 
            this.buttonSacuvaj.Location = new System.Drawing.Point(24, 462);
            this.buttonSacuvaj.Name = "buttonSacuvaj";
            this.buttonSacuvaj.Size = new System.Drawing.Size(210, 31);
            this.buttonSacuvaj.TabIndex = 23;
            this.buttonSacuvaj.Text = "Sačuvaj";
            this.buttonSacuvaj.UseVisualStyleBackColor = true;
            this.buttonSacuvaj.Click += new System.EventHandler(this.buttonSacuvaj_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(256, 180);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(283, 276);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 24;
            this.pictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // buttonSlika
            // 
            this.buttonSlika.Location = new System.Drawing.Point(464, 150);
            this.buttonSlika.Name = "buttonSlika";
            this.buttonSlika.Size = new System.Drawing.Size(75, 23);
            this.buttonSlika.TabIndex = 25;
            this.buttonSlika.Text = "Slika";
            this.buttonSlika.UseVisualStyleBackColor = true;
            this.buttonSlika.Click += new System.EventHandler(this.buttonSlika_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(24, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 119);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBoxSlika
            // 
            this.textBoxSlika.Enabled = false;
            this.textBoxSlika.Location = new System.Drawing.Point(256, 150);
            this.textBoxSlika.Name = "textBoxSlika";
            this.textBoxSlika.Size = new System.Drawing.Size(202, 20);
            this.textBoxSlika.TabIndex = 27;
            // 
            // errorProviderKorisnici
            // 
            this.errorProviderKorisnici.ContainerControl = this;
            // 
            // FormKorisnikDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 505);
            this.Controls.Add(this.textBoxSlika);
            this.Controls.Add(this.buttonSlika);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonSacuvaj);
            this.Controls.Add(this.textBoxPasswordPotvrda);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.clbRole);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormKorisnikDetalji";
            this.Text = "Korisnik Detalji";
            this.Load += new System.EventHandler(this.FormKorisnikDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox clbRole;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPasswordPotvrda;
        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSlika;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSlika;
        private System.Windows.Forms.ErrorProvider errorProviderKorisnici;
    }
}