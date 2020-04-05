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

namespace EkspertBooker.DesktopAppUI.Projekt
{
    public partial class FormNovaPonuda : Form
    {
        private readonly APIService _serviceEksperti = new APIService("Eksperti");
        private readonly APIService _serviceProjekti = new APIService("Projekti");
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");
        private readonly APIService _servicePonude = new APIService("Ponude");
        public FormNovaPonuda()
        {
            InitializeComponent();
            comboBoxEksperti.DisplayMember = "Korisnik";
            comboBoxProjekti.DisplayMember = "Naziv";
        }

        private async void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                Model.Ekspert ekspert = (Model.Ekspert)comboBoxEksperti.SelectedItem;
                Model.Projekt projekt = (Model.Projekt)comboBoxProjekti.SelectedItem;
                bool unesen = false;
                PonudaUpsertRequest request = new PonudaUpsertRequest
                {
                    EkspertId = ekspert.KorisnikId,
                    Cijena = int.Parse(numericUpDownCijena.Value.ToString()),
                    OpisPonude = textBoxOpis.Text,
                    ProjektId = projekt.ProjektId,
                    VrijemePonude = DateTime.Now
                };
                try
                {
                    var result = await _servicePonude.Insert<Model.Ponuda>(request);
                    unesen = true;
                    MessageBox.Show("Uspjesna operacija!");
                }
                catch(FlurlHttpException ex)
                {
                    if(ex.Call.HttpStatus == System.Net.HttpStatusCode.Conflict)
                    {
                        MessageBox.Show("Konflikt u unosenju ponude, mozda je projekt u drugoj fazi ili?...");
                    } else
                    {
                        MessageBox.Show("Greska u unosu!");
                    }
                }
                
            }
        }

        private async void FormNovaPonuda_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadPodaci();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " Vjerovatno trenutno nema projekata/eksperata. Dodajte ih!");
                Dispose(false);
            }
        }

        private async Task LoadPodaci()
        {
            List<Model.Projekt> lista_projekti = await _serviceProjekti.Get<List<Model.Projekt>>(null);
            List<Model.Ekspert> lista_eksperti = await _serviceEksperti.Get<List<Model.Ekspert>>(null);

            foreach (var item in lista_eksperti)
            {
                item.Korisnik = await _serviceKorisnici.GetById<Model.Korisnik>(item.KorisnikUloga.KorisnikId);
            }

            foreach (Model.Projekt item in lista_projekti)
            {
                if (item.StanjeId == "Licitacija") 
                comboBoxProjekti.Items.Add(item);
            }

            foreach (Model.Ekspert item in lista_eksperti)
            {
                comboBoxEksperti.Items.Add(item);
            }
        }

        private void comboBoxEksperti_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxEksperti.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBoxEksperti, Properties.Resources.errorObaveznoPolje);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(comboBoxEksperti, null);
            }
        }

        private void comboBoxProjekti_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxProjekti.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBoxProjekti, Properties.Resources.errorObaveznoPolje);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(comboBoxProjekti, null);
            }
        }

        private void numericUpDownCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numericUpDownCijena.Value.ToString()))
            {
                errorProvider.SetError(comboBoxProjekti, Properties.Resources.errorObaveznoPolje);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(comboBoxProjekti, null);
            }
        }
    }
}
