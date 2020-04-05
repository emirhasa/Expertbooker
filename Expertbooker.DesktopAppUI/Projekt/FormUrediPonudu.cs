using EkspertBooker.Model.Requests;
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
    public partial class FormUrediPonudu : Form
    {
        private readonly APIService _serviceEksperti = new APIService("Eksperti");
        private readonly APIService _serviceProjekti = new APIService("Projekti");
        private readonly APIService _serviceKorisnici = new APIService("Korisnici");
        private readonly APIService _servicePonude = new APIService("Ponude");
        private readonly int id_ponude;

        Model.Ponuda ponuda;
        Model.Ekspert ekspert;
        Model.Projekt projekt;
        Model.Korisnik korisnik;

        public FormUrediPonudu(int _id_ponude)
        {
            InitializeComponent();
            id_ponude = _id_ponude;
            if(id_ponude == 0)
            {
                MessageBox.Show("Greska u ucitavanju ponude!");
                Dispose(false);
                FormPonudePretraga forma = new FormPonudePretraga();
                forma.Show();
            }
        }

        private async void FormUrediPonudu_Load(object sender, EventArgs e)
        {
            ponuda = await _servicePonude.GetById<Model.Ponuda>(id_ponude);
            ekspert = await _serviceEksperti.GetById<Model.Ekspert>(ponuda.EkspertId);
            projekt = await _serviceProjekti.GetById<Model.Projekt>(ponuda.ProjektId);
            korisnik = await _serviceKorisnici.GetById<Model.Korisnik>(ekspert.KorisnikUloga.KorisnikId);

            textBoxEkspert.Text = korisnik.KorisnickoIme;
            textBoxProjekt.Text = projekt.Naziv;

            textBoxOpis.Text = ponuda.OpisPonude;

            numericUpDownCijena.Value = int.Parse(ponuda.Cijena.ToString());
        }

        private async void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                PonudaUpsertRequest request = new PonudaUpsertRequest
                {
                    Cijena = int.Parse(numericUpDownCijena.Value.ToString()),
                    EkspertId = ekspert.KorisnikId,
                    OpisPonude = textBoxOpis.Text,
                    ProjektId = ponuda.ProjektId,
                    VrijemePonude = ponuda.VrijemePonude,
                    Status = ponuda.Status
                };

                var result = await _servicePonude.Update<Model.Ponuda>(ponuda.PonudaId, request);
                if (result != null)
                {
                    MessageBox.Show("Promjene sacuvane!");
                }
                else
                {
                    MessageBox.Show("Problem prilikom spasavanja promjena!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Problem prilikom spremanja promjena. " + ex.Message);
            }
        }
    }
}
