using EkspertBooker.Model;
using EkspertBooker.Model.Requests;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkspertBooker.DesktopAppUI.Security
{
    public partial class FormLogin : Form
    {
        APIService _service = new APIService("Korisnici");
        public FormLogin()
        {
            InitializeComponent();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                try
                {
                    APIService.Username = textBoxUsername.Text;
                    APIService.Password = textBoxLozinka.Text;
                    var korisnik = await _service.Get<List<Model.Korisnik>>(new KorisniciSearchRequest
                    {
                        Username = APIService.Username
                    });
                    Model.Korisnik provjera = korisnik[0];
                    List<KorisnikUloga> uloge = provjera.KorisnikUloge.ToList();
                    bool nadjen = false;
                    foreach(var uloga in uloge)
                    {
                        if (uloga.Uloga.Naziv == "Administrator") nadjen = true;
                    }
                    if(!nadjen)
                    {
                        MessageBox.Show("Neka se na admin panel loguje samo admninistrator");
                        return;
                    }
                    FormIndex frm = new FormIndex();
                    Dispose(false);
                    frm.Show();
                    MessageBox.Show("Uspjesan login!");
                }
                catch (FlurlHttpException er)
                {
                    if (er.Call.Response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                        MessageBox.Show("Pogrešan password ili lozinka!", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Server error!", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                errorProvider.SetError(textBoxUsername, Properties.Resources.errorObaveznoPolje);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBoxUsername, null);
            }
        }

        private void textBoxLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxLozinka.Text))
            {
                errorProvider.SetError(textBoxLozinka, Properties.Resources.errorObaveznoPolje);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBoxLozinka, null);
            }
        }
    }
}
