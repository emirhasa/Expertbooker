using EkspertBooker.Model;
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

namespace EkspertBooker.DesktopAppUI.Kategorija
{
    public partial class FormKategorijePretraga : Form
    {
        private readonly APIService _kategorijeService = new APIService("Kategorije");
        private readonly APIService _projektiService = new APIService("Projekti");
        //dodati provjeru i za eksperte, pretplate na kategorije
        public FormKategorijePretraga()
        {
            InitializeComponent();
        }

        private async Task LoadKategorije()
        {
            try
            {
                var lista = await _kategorijeService.Get<List<Model.Kategorija>>(null);
                dataGridViewKategorije.DataSource = lista;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void FormKategorijePretraga_Load(object sender, EventArgs e)
        {
            await LoadKategorije();
        }

        private async void buttonDodajKategoriju_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxKategorijaNaziv.Text))
                {
                    MessageBox.Show("Unesite naziv kategorije!");
                }
                else
                {
                    var lista = await _kategorijeService.Get<List<Model.Kategorija>>(null);
                    bool nadjen = false;
                    if (lista != null)
                    {
                        if (lista.Count > 0)
                        {
                            foreach (var item in lista)
                            {
                                if (item.Naziv == textBoxKategorijaNaziv.Text)
                                {
                                    MessageBox.Show("Naziv vec postoji, izaberite drugi!");
                                    nadjen = true;
                                    break;
                                }
                            }
                        }
                    }
                    if (!nadjen)
                    {
                        MessageBox.Show("Kategorija dodana!");
                        await _kategorijeService.Insert<Model.Kategorija>(new Model.Kategorija { Naziv = textBoxKategorijaNaziv.Text });
                        LoadKategorije();
                        textBoxKategorijaNaziv.Text = "";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Greška prilikom dodavanja kategorije. " + ex.Message);
            }
        }

        private void dataGridViewKategorije_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxUrediNaziv.Text = dataGridViewKategorije.SelectedRows[0].Cells[1].Value.ToString();
                textBoxUrediNoviNaziv.Enabled = true;
                buttonUrediKategoriju.Enabled = true;
                buttonObrisiKategoriju.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Greška prilikom selektovanja kategorije. " + ex.Message);
            }
        }
        private async void buttonUrediKategoriju_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxUrediNoviNaziv.Text))
                {
                    MessageBox.Show("Unesite novi naziv!");
                }
                else
                {
                    int _urediId = int.Parse(dataGridViewKategorije.SelectedRows[0].Cells[0].Value.ToString());
                    var model = await _kategorijeService.Update<Model.Kategorija>(_urediId, new KategorijaUpsertRequest { Naziv = textBoxUrediNoviNaziv.Text });
                    if (model != null)
                    {
                        MessageBox.Show("Kategorija uredjena!");
                        textBoxUrediNaziv.Text = "";
                        textBoxUrediNoviNaziv.Text = "";
                        textBoxUrediNoviNaziv.Enabled = false;
                        buttonObrisiKategoriju.Enabled = false;
                        LoadKategorije();
                    }
                    else
                    {
                        MessageBox.Show("Problem prilikom uredjenja!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Greška prilikom uređivanja kategorije. " +ex.Message);
            }
        }

        private async void buttonObrisiKategoriju_Click(object sender, EventArgs e)
        {
            try
            {
                int _brisatiId = int.Parse(dataGridViewKategorije.SelectedRows[0].Cells[0].Value.ToString());
                //Da li ima projekata ili drugih entiteta koji se vezu za datu kategoriju
                //ako ima ne moze se brisati
                var request = new ProjektiSearchRequest
                {
                    KategorijaId = _brisatiId
                };
                var list = await _projektiService.Get<List<Model.Projekt>>(request);
                if (list == null)
                {
                    await _kategorijeService.Delete<bool>(_brisatiId);
                    MessageBox.Show("Kategorija uspjesno obrisana!");
                    textBoxUrediNaziv.Text = "";
                    textBoxUrediNoviNaziv.Text = "";
                    textBoxUrediNoviNaziv.Enabled = false;
                    buttonObrisiKategoriju.Enabled = false;
                    LoadKategorije();
                }
                else
                {
                    MessageBox.Show("Vjerovatno postoje projekti koji koriste kategoriju, pa se ne može obrisati...");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Greška prilikom brisanja kategorije. " + ex.Message);
            }
        }
    }
}
