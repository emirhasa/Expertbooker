using EkspertBooker.DesktopAppUI.Kategorija;
using EkspertBooker.DesktopAppUI.Korisnik;
using EkspertBooker.DesktopAppUI.Projekt;
using EkspertBooker.DesktopAppUI.Recenzije;
using EkspertBooker.DesktopAppUI.Reporting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkspertBooker.DesktopAppUI
{
    public partial class FormIndex : Form
    {
        public FormIndex()
        {
            InitializeComponent();
        }

        private void dodajProjekatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProjektDetalji forma = new FormProjektDetalji();
            forma.Show();
        }

        private void projektiPretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProjektPretraga forma = new FormProjektPretraga();
            forma.Show();
        }

        private void listaKategorijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKategorijePretraga forma = new FormKategorijePretraga();
            forma.Show();
        }

        private void dodajKategorijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKategorijePretraga forma = new FormKategorijePretraga();
            forma.Show();
        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKorisnikDetalji forma = new FormKorisnikDetalji();
            forma.Show();
        }

        private void korisniciPretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKorisniciPretraga forma = new FormKorisniciPretraga();
            forma.Show();
        }

        private void listaEkspertiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEkspertiPretraga forma = new FormEkspertiPretraga();
            forma.Show();
        }

        private void listaPoslodavciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPoslodavciPretraga forma = new FormPoslodavciPretraga();
            forma.Show();
        }

        private void recenzijeOPoslodavcimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPoslodavciPretraga forma = new FormPoslodavciPretraga();
            forma.Show();
        }

        private void recenzijeOEkspertimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEkspertiPretraga forma = new FormEkspertiPretraga();
            forma.Show();
        }

        private void dodajRecenzijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecenzijaDetalji forma = new FormRecenzijaDetalji();
            forma.Show();
        }

        private void izvjestajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIzvjestaj forma = new FormIzvjestaj();
            forma.Show();
        }

        private void novaPonudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovaPonuda forma = new FormNovaPonuda();
            forma.Show();
        }

        private void ponudeProjektiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPonudePretraga forma = new FormPonudePretraga();
            forma.Show();
        }

        private void projektiPonudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPonudePretraga forma = new FormPonudePretraga();
            forma.Show();
        }

        private void novaPonudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormNovaPonuda forma = new FormNovaPonuda();
            forma.Show();
        }
    }
}
