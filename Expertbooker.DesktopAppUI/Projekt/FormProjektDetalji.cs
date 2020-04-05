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

namespace EkspertBooker.DesktopAppUI.Projekt
{
    public partial class FormProjektDetalji : Form
    {
        private readonly APIService _serviceProjekti = new APIService("Projekti");
        private readonly APIService _serviceKategorije = new APIService("Kategorije");
        private readonly APIService _serviceProjektDetalji = new APIService("ProjektDetalji");
        //private ProjektUpsertRequest request;
        public int? _id;
        public Model.Projekt projekt = null;
        public FormProjektDetalji(int? id=null)
        {
            InitializeComponent();
            if (id != null) _id = id;
        }
        private async void FormDodajProjekt_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadKategorije();
                dateTimePickerDatumPocetka.Value = DateTime.Now;
                if (_id != null)
                {
                    projekt = await _serviceProjekti.GetById<Model.Projekt>(_id);
                    decimal _trajanje, _budzet;
                    //ucitaj vrijednosti u polja(edit)
                    textBoxNazivProjekta.Text = projekt.Naziv;
                    textBoxKratkiOpis.Text = projekt.KratkiOpis;
                    textBoxDetaljniOpis.Text = projekt.DetaljniOpis;
                    if (projekt.DatumPocetka.HasValue)
                    {
                        dateTimePickerDatumPocetka.Value = projekt.DatumPocetka.Value;
                    }
                    decimal.TryParse(projekt.TrajanjeDana.ToString(), out _trajanje);
                    numericUpDownTrajanje.Value = _trajanje;
                    decimal.TryParse(projekt.Budzet.ToString(), out _budzet);
                    numericUpDownBudzet.Value = _budzet;
                    int selected_index = 0;
                    foreach (Model.Kategorija item in comboBoxKategorija.Items)
                    {
                        if (item.KategorijaId == projekt.KategorijaId)
                        {
                            selected_index = comboBoxKategorija.Items.IndexOf(item);
                            break;
                        }
                    }
                    comboBoxKategorija.SelectedIndex = selected_index;
                    if (projekt.Hitan == true)
                    {
                        checkBoxHitan.CheckState = CheckState.Checked;
                    }

                    if (projekt.StanjeId == "Aktivan")
                    {
                        label10.Visible = false;
                        label11.Text = "Detalji aktivan projekat";
                        textBoxAktivanDetaljanOpis.Enabled = true;
                        textBoxNapomena.Enabled = true;
                        if (projekt.ProjektDetalji != null)
                        {
                            textBoxAktivanDetaljanOpis.Text = projekt.ProjektDetalji.AktivanDetaljanOpis;
                            textBoxNapomena.Text = projekt.ProjektDetalji.Napomena;
                        }
                        buttonSacuvajDetalji.Enabled = true;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " Vjerovatno greška pri učitanju kategorija!");
                Dispose(false);
            }
        }

        private async Task LoadKategorije()
        {
            var result = await _serviceKategorije.Get<List<Model.Kategorija>>(null);
            result.Insert(0, new Model.Kategorija());
            comboBoxKategorija.DataSource = result;
            comboBoxKategorija.DisplayMember = "Naziv";
            comboBoxKategorija.ValueMember = "KategorijaId";
        }

        private void textBoxNazivProjekta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNazivProjekta.Text))
            {
                errorProviderDodajProjekt.SetError(textBoxNazivProjekta, Properties.Resources.errorObaveznoPolje);
                e.Cancel = true;
            }
            else
            {
                errorProviderDodajProjekt.SetError(textBoxNazivProjekta, null);
            }
        }

        private void textBoxKratkiOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxKratkiOpis.Text))
            {
                errorProviderDodajProjekt.SetError(textBoxKratkiOpis, Properties.Resources.errorObaveznoPolje);
                e.Cancel = true;
            }
            else
            {
                errorProviderDodajProjekt.SetError(textBoxKratkiOpis, null);
            }
        }

        private void textBoxDetaljniOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDetaljniOpis.Text))
            {
                errorProviderDodajProjekt.SetError(textBoxDetaljniOpis, Properties.Resources.errorObaveznoPolje);
                e.Cancel = true;
            }
            else
            {
                errorProviderDodajProjekt.SetError(textBoxDetaljniOpis, null);
            }
        }

        private void dateTimePickerDatumPocetka_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePickerDatumPocetka.Value == null )
            {
                errorProviderDodajProjekt.SetError(dateTimePickerDatumPocetka, Properties.Resources.errorObaveznoPolje);
                e.Cancel = true;
            } else
            {
                errorProviderDodajProjekt.SetError(dateTimePickerDatumPocetka, null);
            }
        }

        private void numericUpDownTrajanje_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDownTrajanje.Value == 0)
            {
                errorProviderDodajProjekt.SetError(numericUpDownTrajanje, Properties.Resources.errorVeceOdNula);
                e.Cancel = true;
            }
            else
            {
                errorProviderDodajProjekt.SetError(numericUpDownTrajanje, null);
            }
        }

        private void comboBoxKategorija_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxKategorija.SelectedIndex == 0)
            {
                errorProviderDodajProjekt.SetError(comboBoxKategorija, Properties.Resources.errorObaveznoPolje);
                e.Cancel = true;
            }
            else
            {
                errorProviderDodajProjekt.SetError(comboBoxKategorija, null);
            }
        }

        private void numericUpDownBudzet_Validating(object sender, CancelEventArgs e)
        {
            if (numericUpDownBudzet.Value == 0)
            {
                errorProviderDodajProjekt.SetError(numericUpDownBudzet, Properties.Resources.errorVeceOdNula);
                e.Cancel = true;
            }
            else
            {
                errorProviderDodajProjekt.SetError(numericUpDownBudzet, null);
            }
        }

        private async void buttonDodajProjekat_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren())
                {
                    var insert = new ProjektUpsertRequest
                    {
                        Naziv = textBoxNazivProjekta.Text,
                        KratkiOpis = textBoxKratkiOpis.Text,
                        DetaljniOpis = textBoxDetaljniOpis.Text,
                        DatumObjave = DateTime.Now,
                        DatumPocetka = dateTimePickerDatumPocetka.Value,
                        TrajanjeDana = int.Parse(numericUpDownTrajanje.Value.ToString()),
                        KategorijaId = int.Parse(comboBoxKategorija.SelectedValue.ToString()),
                        Budzet = int.Parse(numericUpDownBudzet.Value.ToString()),
                        Hitan = checkBoxHitan.Checked,
                        StanjeId = "Licitacija",
                    };
                    if (_id == null)
                    {
                        //insert
                        //default Poslodavac
                        insert.PoslodavacId = 2;
                        try
                        {
                            var result = await _serviceProjekti.Insert<Model.Projekt>(insert);
                            if (result.ProjektId > 0)
                            {
                                MessageBox.Show("Operacija uspješna!");
                                _id = result.ProjektId;
                            }
                            else
                            {
                                MessageBox.Show("Greska! Jeste li dobro podesili localhost/port?");
                            }
                        }
                        catch (FlurlHttpException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        //edit
                        insert.PoslodavacId = projekt.PoslodavacId;
                        try
                        {
                            var result = await _serviceProjekti.Update<Model.Projekt>(_id, insert);
                            if (result.ProjektId > 0)
                            {
                                MessageBox.Show("Operacija uspješna!");
                                Dispose(false);
                            }
                            else
                            {
                                MessageBox.Show("Greska! Jeste li dobro podesili localhost/port?");
                            }
                        }
                        catch (FlurlHttpException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                Dispose(false);
            }
        }

        private async void buttonBrisiProjekat_Click(object sender, EventArgs e)
        {
            try
            {
                if (_id != null)
                {
                    var result = await _serviceProjekti.Delete<bool>(_id);
                    if (result == true)
                    {
                        MessageBox.Show("Projekt izbrisan!");
                        Dispose(false);
                    }
                    else
                    {
                        MessageBox.Show("Greska prilikom brisanja");
                    }
                }
                else
                {
                    MessageBox.Show("Operacija uspješna!");
                    Dispose(false);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Dispose(false);
            }
        }

        private void textBoxAutorUsername_TextChanged(object sender, EventArgs e)
        {
            //validirati putem APIService da li postoji Autor username za poslodavca koji je specificiran
        }

        private async void buttonSacuvajDetalji_Click(object sender, EventArgs e)
        {
            try
            {
                ProjektDetaljiUpsertRequest request = new ProjektDetaljiUpsertRequest
                {
                    AktivanDetaljanOpis = textBoxAktivanDetaljanOpis.Text,
                    Napomena = textBoxNapomena.Text,
                    ProjektId = projekt.ProjektId
                };

                var result = await _serviceProjektDetalji.Update<Model.ProjektDetalji>(projekt.ProjektId, request);
                MessageBox.Show("Operacija uspjesna!");              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Dispose(false);
            }
        }
    }
}
