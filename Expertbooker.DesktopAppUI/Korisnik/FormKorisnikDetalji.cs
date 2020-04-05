using EkspertBooker.Model.Requests;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkspertBooker.DesktopAppUI.Korisnik
{
    public partial class FormKorisnikDetalji : Form
    {
        private int? _selected_id;
        private readonly APIService _service = new APIService("Korisnici");
        private readonly APIService _serviceUloge = new APIService("Uloge");
        private readonly APIService _serviceSlike = new APIService("KorisniciSlike");
        private Model.Korisnik korisnik = null; //trenutno ucitani korisnik

        KorisnikUpsertRequest request = new KorisnikUpsertRequest();
        public FormKorisnikDetalji(int? id = null)
        {
            try
            {
                InitializeComponent();
                if (id != null) _selected_id = id;
                LoadUloge();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problem prilikom ucitavanja uloga");
                Dispose(false);
            }
        }

        private async void LoadUloge()
        {
            try
            {
                var result = await _serviceUloge.Get<List<Model.Uloga>>(null);
                clbRole.DisplayMember = "Naziv";
                foreach (var role in result)
                {
                    clbRole.Items.Add(role);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Dispose(false);
            }
        }

        private async void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                //TODO: optimize this, separate tasks into functions and simplify logic
                request.Ime = textBoxIme.Text;
                request.Prezime = textBoxPrezime.Text;
                request.Email = textBoxEmail.Text;
                request.Telefon = textBoxTelefon.Text;
                request.KorisnickoIme = textBoxUsername.Text;
                request.Password = textBoxPassword.Text;
                request.PasswordConfirmation = textBoxPasswordPotvrda.Text;
                //Uloge = uloge
                foreach (Model.Uloga item in clbRole.CheckedItems)
                {
                    request.Uloge.Add(item);
                }
                if (_selected_id == null)
                {
                    //if insert
                    if (textBoxPassword.Text == textBoxPasswordPotvrda.Text)
                    {
                        try
                        {
                            //ima li korisnik sa istim mailom, username?
                            bool isti_mail = false;
                            bool isti_username = false;
                            var provjera = await _service.Get<List<Model.Korisnik>>(null);
                            if (provjera != null)
                            {
                                foreach (Model.Korisnik korisnik in provjera)
                                {
                                    if (request.KorisnickoIme == korisnik.KorisnickoIme)
                                    {
                                        isti_username = true;
                                        break;
                                    }
                                    if (request.Email == korisnik.Email)
                                    {
                                        isti_mail = true;
                                        break;
                                    }
                                }
                                if ((isti_mail || isti_username) == true)
                                {
                                    if (isti_mail)
                                    {
                                        MessageBox.Show("Korisnik nije unesen, vec postoji korisnik sa datim mailom!");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Korsisnik nije unesen, vec postoji korisnik sa istim username!");
                                    }
                                }
                            }
                            var response = await _service.Insert<Model.Korisnik>(request);
                            if (response.KorisnikId > 0)
                            {
                                MessageBox.Show("Korisnik unesen!");
                                //upload slike
                                if (request.Slika != null)
                                {
                                    var result = await _serviceSlike.Insert<Model.KorisnikSlika>(new KorisnikSlikaUpsertRequest
                                    {
                                        KorisnikId = response.KorisnikId,
                                        ProfilnaSlika = request.Slika
                                    });
                                }
                                _selected_id = response.KorisnikId;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            Dispose(false);

                        }
                    } else
                    {
                        MessageBox.Show("Passwordi se razlikuju!");
                    }
                }
                else
                {
                    //update sa passsword update
                    if (!string.IsNullOrWhiteSpace(textBoxPassword.Text))
                    {
                        if (textBoxPassword.Text == textBoxPasswordPotvrda.Text)
                        {
                            try
                            {
                                bool slika_promijenjena = false;
                                var response = await _service.Update<Model.Korisnik>(_selected_id, request);
                                if (response.KorisnikId > 0)
                                {
                                    //upload slika
                                    if (request.Slika != null)
                                    {
                                        var result = await _serviceSlike.Update<Model.KorisnikSlika>(response.KorisnikId, new KorisnikSlikaUpsertRequest
                                        {
                                            KorisnikId = response.KorisnikId,
                                            ProfilnaSlika = request.Slika
                                        });
                                        slika_promijenjena = true;
                                    }
                                }
                                if (slika_promijenjena)
                                {
                                    MessageBox.Show("Korisnik info sacuvan, password promijenjen, slika promijenjena!");
                                }
                                else
                                {
                                    MessageBox.Show("Korisnik info sacuvan, password promijenjen!");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                Dispose(false);
                            }
                        } else
                        {
                            MessageBox.Show("Ako zelite mijenjati password, oba passworda se moraju slagati! Ako ne zelite mijenjati, samo izbrisite vrijednosti iz password polja");
                        }
                    } else
                    {
                        //update bez password update
                        try
                        {
                            bool slika_promijenjena = false;
                            var response = await _service.Update<Model.Korisnik>(_selected_id, request);
                            if (response.KorisnikId > 0)
                            {
                                //upload slika //ugraditi f-ju
                                if (request.Slika != null)
                                {
                                    KorisnikSlikaUpsertRequest slika_upload = new KorisnikSlikaUpsertRequest
                                    {
                                        KorisnikId = response.KorisnikId,
                                        ProfilnaSlika = request.Slika
                                    };
                                    if (korisnik.KorisnikSlika != null)
                                    { //update slike
                                        var result = await _serviceSlike.Update<Model.KorisnikSlika>(response.KorisnikSlika.KorisnikId, slika_upload);
                                        if (result != null)
                                        {
                                            slika_promijenjena = true;
                                        }
                                    } else
                                    {
                                        //nova slika
                                        var result = await _serviceSlike.Insert<Model.KorisnikSlika>(slika_upload);
                                        if (result != null)
                                        {
                                            slika_promijenjena = true;
                                        }
                                    }
                                }
                                if (slika_promijenjena)
                                {
                                    MessageBox.Show("Korisnik info sacuvan, slika promijenjena!");
                                } else
                                {
                                    MessageBox.Show("Korisnik info sacuvan!");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            Dispose(false);
                        }
                    }

                }

            }
        }

        private async void FormKorisnikDetalji_Load(object sender, EventArgs e)
        {
            try
            {
                if (_selected_id.HasValue)
                {
                    korisnik = await _service.GetById<Model.Korisnik>(_selected_id);
                    if (korisnik.KorisnikId != 0)
                    {
                        textBoxIme.Text = korisnik.Ime;
                        textBoxPrezime.Text = korisnik.Prezime;
                        textBoxEmail.Text = korisnik.Email;
                        textBoxTelefon.Text = korisnik.Telefon;
                        textBoxUsername.Text = korisnik.KorisnickoIme;
                        textBoxUsername.Enabled = false;
                        List<int> indexi = new List<int>();
                        foreach (Model.KorisnikUloga uloga in korisnik.KorisnikUloge)
                        {
                            foreach (Model.Uloga item in clbRole.Items)
                            {
                                if (item.UlogaId == uloga.UlogaId) indexi.Add(clbRole.Items.IndexOf(item));
                            }
                        }

                        foreach (int index in indexi)
                        {
                            clbRole.SetItemChecked(index, true);
                        }
                        clbRole.Enabled = false;
                        //load slika

                        if (korisnik.KorisnikSlika != null)
                        {
                            Image image = ByteToImage(korisnik.KorisnikSlika.ProfilnaSlika);
                            pictureBox.Image = image;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Problem prilikom učitavanja korisnika");
                Dispose(false);
            }
        }

        private Bitmap ByteToImage(byte[] blob)
        {
            try
            {
                MemoryStream mStream = new MemoryStream();
                byte[] pData = blob;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                Bitmap bm = new Bitmap(mStream, false);
                mStream.Dispose();
                return bm;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Dispose(false);
                return null;
            }
        }

        private void buttonSlika_Click(object sender, EventArgs e)
        {
            try
            {
                int size = -1;
                var result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var fileName = openFileDialog1.FileName;
                    var file = File.ReadAllBytes(fileName);
                    if (file.Length > (1024 * 512)) throw new Exception("Prevelika slika, molimo upload slike manji od ~ 500kb");
                    request.Slika = file;
                    textBoxSlika.Text = fileName;

                    Image image = Image.FromFile(fileName);
                    pictureBox.Image = image;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                request.Slika = null;
                textBoxSlika.Text = null;
            }
        }

        private void textBoxIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIme.Text))
            {
                errorProviderKorisnici.SetError(textBoxIme, Properties.Resources.errorObaveznoPolje);
                e.Cancel = true;
            }
            else
            {
                errorProviderKorisnici.SetError(textBoxIme, null);
            }
        }

        private void textBoxPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPrezime.Text))
            {
                errorProviderKorisnici.SetError(textBoxPrezime, Properties.Resources.errorObaveznoPolje);
                e.Cancel = true;
            }
            else
            {
                errorProviderKorisnici.SetError(textBoxPrezime, null);
            }
        }

        private void textBoxUsername_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxUsername.Text.Length < 4)
            {
                errorProviderKorisnici.SetError(textBoxUsername, Properties.Resources.errorViseKaraktera);
                e.Cancel = true;
            }
            else
            {
                errorProviderKorisnici.SetError(textBoxUsername, null);
            }
        }

        private void textBoxTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTelefon.Text))
            {
                errorProviderKorisnici.SetError(textBoxTelefon, Properties.Resources.errorObaveznoPolje);
                e.Cancel = true;
            }
            else
            {
                errorProviderKorisnici.SetError(textBoxTelefon, null);
            }
        }

        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (_selected_id == null)
            {
                if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
                {
                    errorProviderKorisnici.SetError(textBoxPassword, Properties.Resources.errorObaveznoPolje);
                    e.Cancel = true;
                }
                else
                {
                    errorProviderKorisnici.SetError(textBoxPassword, null);
                }
            }
        }
        private void textBoxPasswordPotvrda_Validating(object sender, CancelEventArgs e)
        {
            if (_selected_id == null)
            {
                if (string.IsNullOrWhiteSpace(textBoxPasswordPotvrda.Text))
                {
                    errorProviderKorisnici.SetError(textBoxPasswordPotvrda, Properties.Resources.errorObaveznoPolje);
                    e.Cancel = true;
                }
                else
                {
                    errorProviderKorisnici.SetError(textBoxPasswordPotvrda, null);
                }
            }
        }



        private void clbRole_Validating(object sender, CancelEventArgs e)
        {
            if(clbRole.CheckedItems.Count == 0)
            {
                errorProviderKorisnici.SetError(clbRole, Properties.Resources.errorObaveznoPolje);
                e.Cancel = true;
            } else
            {
                errorProviderKorisnici.SetError(clbRole, null);
            }
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                errorProviderKorisnici.SetError(textBoxEmail, Properties.Resources.errorObaveznoPolje);
                e.Cancel = true;
            } else
            {
                try
                {
                    MailAddress provjera = new MailAddress(textBoxEmail.Text);
                    errorProviderKorisnici.SetError(textBoxEmail, null);
                }
                catch
                {
                    errorProviderKorisnici.SetError(textBoxEmail, "Mail nije validan!");
                    e.Cancel = true;
                }
            }
        }
    }
}
