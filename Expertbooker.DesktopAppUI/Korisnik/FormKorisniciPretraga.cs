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

namespace EkspertBooker.DesktopAppUI.Korisnik
{
    public partial class FormKorisniciPretraga : Form
    {
        private readonly APIService _APIservice = new APIService("Korisnici");
        public FormKorisniciPretraga()
        {
            InitializeComponent();
        }

        private void dgvKorisnici_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selected_id = dgvKorisnici.SelectedRows[0].Cells[2].Value;
            FormKorisnikDetalji form = new FormKorisnikDetalji((int)selected_id);
            form.Show();
        }

        private async void buttonKorisniciPrikazi_Click(object sender, EventArgs e)
        {
            var search = new KorisniciSearchRequest()
            {
                Ime = textBoxKorisniciSearchIme.Text,
                Prezime = textBoxKorisniciSearchPrezime.Text,
                Administratori = checkBoxAdministratori.Checked,
                Poslodavci = checkBoxPoslodavci.Checked,
                Eksperti = checkBoxEksperti.Checked
            };

            var result = await _APIservice.Get<List<Model.Korisnik>>(search);
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = result;
        }

    }
}
