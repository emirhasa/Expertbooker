using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkspertBooker.DesktopAppUI.Reporting
{
    public partial class FormIzvjestaj : Form
    {
        private readonly APIService _serviceRecenzijeEksperti = new APIService("RecenzijeOEksperti");
        private readonly APIService _serviceRecenzijePoslodavci = new APIService("RecenzijeOPoslodavci");

        private readonly APIService _serviceEksperti = new APIService("Eksperti");
        private readonly APIService _servicePoslodavci = new APIService("Poslodavci");

        private readonly APIService _serviceProjekti = new APIService("Projekti");

        public FormIzvjestaj()
        {
            InitializeComponent();
        }

        private async void FormIzvjestaj_Load(object sender, EventArgs e)
        {
            try
            {
                var eksperti = await _serviceEksperti.Get<List<Model.Ekspert>>(null);
                int broj_eksperti = 0;
                int broj_poslodavci = 0;
                int broj_projekti = 0;

                if (eksperti != null)
                {
                    if (eksperti.Count > 0)
                    {
                        broj_eksperti = eksperti.Count;
                    }
                }

                var poslodavci = await _servicePoslodavci.Get<List<Model.Poslodavac>>(null);
                if (poslodavci != null)
                {
                    broj_poslodavci = poslodavci.Count;
                }

                var projekti = await _serviceProjekti.Get<List<Model.Projekt>>(null);
                if (projekti != null)
                {
                    broj_projekti = projekti.Count;
                }

                var recenzije_o_eksperti = await _serviceRecenzijeEksperti.Get<List<Model.RecenzijaOEkspert>>(null);
                int ukupno_recenzije_eksperti = 0;
                if (recenzije_o_eksperti != null)
                {
                    ukupno_recenzije_eksperti = recenzije_o_eksperti.Count;
                }

                int eksperti_ocjene_sum = 0;
                decimal eksperti_prosjecna_ocjena = 0;
                if (ukupno_recenzije_eksperti > 0)
                {
                    foreach (Model.RecenzijaOEkspert recenzija in recenzije_o_eksperti)
                    {
                        eksperti_ocjene_sum += recenzija.Ocjena;
                    }
                    eksperti_prosjecna_ocjena = Decimal.Round((decimal)eksperti_ocjene_sum / ukupno_recenzije_eksperti, 2);
                }

                int ukupno_recenzije_poslodavci = 0;
                int poslodavci_ocjene_sum = 0;
                decimal poslodavci_prosjecna_ocjena = 0;

                var recenzije_o_poslodavci = await _serviceRecenzijePoslodavci.Get<List<Model.RecenzijaOPoslodavac>>(null);
                if (recenzije_o_poslodavci != null)
                {
                    ukupno_recenzije_poslodavci = recenzije_o_poslodavci.Count;
                    foreach (Model.RecenzijaOPoslodavac recenzija in recenzije_o_poslodavci)
                    {
                        poslodavci_ocjene_sum += recenzija.Ocjena;
                    }
                    poslodavci_prosjecna_ocjena = Decimal.Round((decimal)poslodavci_ocjene_sum / ukupno_recenzije_poslodavci, 2);
                }

                textBoxUkupnoProjekti.Text = broj_projekti.ToString();
                textBoxUkupnoPoslodavciOcjena.Text = poslodavci_prosjecna_ocjena.ToString();
                textBoxUkupnoEkspertiOcjena.Text = eksperti_prosjecna_ocjena.ToString();

                textBoxUkupnoEksperti.Text = broj_eksperti.ToString();
                textBoxUkupnoPoslodavci.Text = broj_poslodavci.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Dispose(false);
            }
        }
    }
}
