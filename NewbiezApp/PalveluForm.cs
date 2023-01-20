using Microsoft.EntityFrameworkCore;
using NewbiezApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewbiezApp
{
    public partial class PalveluForm : Form
    {
        private databaseContext dbcontext = new databaseContext();
        private Palvelu p;
        private Alue a;
        private Palvelu editedPalvelu;
        public PalveluForm()
        {
            InitializeComponent();
        }

        private void logopb_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<VillageNewbies>().Any())
            {
                Application.OpenForms.OfType<VillageNewbies>().First().BringToFront();
            }
            else
            {
                VillageNewbies VillageNewbies = new VillageNewbies();
                VillageNewbies.Show();
            }
        }

        private void miniLaskutuspb_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<LaskutForm>().Any())
            {
                Application.OpenForms.OfType<LaskutForm>().First().BringToFront();
            }
            else
            {
                LaskutForm Laskut = new LaskutForm();
                Laskut.Show();
            }

        }

        private void miniAsiakastiedotpb_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AsiakasForm>().Any())
            {
                Application.OpenForms.OfType<AsiakasForm>().First().BringToFront();
            }
            else
            {
                AsiakasForm Asiakas = new AsiakasForm();
                Asiakas.Show();
            }
        }

        private void miniMokitpb_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<MokitForm>().Any())
            {
                Application.OpenForms.OfType<MokitForm>().First().BringToFront();
            }
            else
            {
                MokitForm Mokit = new MokitForm();
                Mokit.Show();
            }

        }

        private void miniVarauksetpb_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<VarausForm>().Any())
            {
                Application.OpenForms.OfType<VarausForm>().First().BringToFront();
            }
            else
            {
                VarausForm Varaus = new VarausForm();
                Varaus.Show();
            }
        }

        private void PalveluForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }



        private void LoadData()
        {
            
            using(dbcontext = new databaseContext())
            {
                palveluDgv.DataSource = dbcontext.Palvelus.ToList();
                palveluAlueCb.DataSource = dbcontext.Alues.ToList();
                palveluAlueCb.DisplayMember = "Nimi";
                //palveluAlueCb.ValueMember = "AlueId";
            }
            for (int i = 0; i <= palveluDgv.Columns.Count - 1; i++)
            {
                palveluDgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
        }

  

        private void addPalvelubtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (palveluAlueCb == null || nimiPalvelutb.Text == string.Empty || tyyppiPalvelutb.Text == string.Empty || kuvausPalvelutb.Text == string.Empty)
                {
                    MessageBox.Show("Täytä kaikki tiedot ennen lisäämistä", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    using (dbcontext = new databaseContext())
                    {

                        p = new Palvelu();
                        p.Nimi = nimiPalvelutb.Text;
                        a = (Alue)palveluAlueCb.SelectedValue;
                        p.AlueId = a.AlueId;
                        p.Tyyppi = long.Parse(tyyppiPalvelutb.Text);
                        p.Kuvaus = kuvausPalvelutb.Text;
                        p.Hinta = (double)hintaPalveluNum.Value;
                        p.Alv = (double)alvPalveluNum.Value;
             
 
                        dbcontext.Palvelus.Add(p);
                        dbcontext.SaveChanges();
                        LoadData();
                        MessageBox.Show("Uusi lisäpalvelu lisätty tietokantaan!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tyyppiPalvelutb_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tyyppiPalvelutb.Text, "[^0-9]"))
            {
                tyyppiPalvelutb.Text = tyyppiPalvelutb.Text.Remove(tyyppiPalvelutb.Text.Length - 1);
            }

        }

        private void editPalvelubtn_Click(object sender, EventArgs e)
        {
            using (dbcontext = new databaseContext())
            {
                try
                {

                    if (palveluAlueCb == null || nimiPalvelutb.Text == string.Empty || tyyppiPalvelutb.Text == string.Empty || kuvausPalvelutb.Text == string.Empty)
                    {
                        MessageBox.Show("Täytä kaikki tiedot ennen muokkaamista", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        
                        editedPalvelu = dbcontext.Palvelus.Where(x => x.PalveluId == editedPalvelu.PalveluId).FirstOrDefault();
                        editedPalvelu.Nimi = nimiPalvelutb.Text;
                        editedPalvelu.Alue = (Alue)palveluAlueCb.SelectedValue;
                        editedPalvelu.Tyyppi = long.Parse(tyyppiPalvelutb.Text);
                        editedPalvelu.Kuvaus = kuvausPalvelutb.Text;
                        editedPalvelu.Hinta = (double)hintaPalveluNum.Value;
                        editedPalvelu.Alv = (double)alvPalveluNum.Value;

                        DialogResult answer = MessageBox.Show("Haluatko varmasti muokata palvelutietoja?", "Confirmation", MessageBoxButtons.YesNo);
                        if (answer == DialogResult.Yes)
                        {    
                            dbcontext.Update(editedPalvelu);
                            dbcontext.SaveChanges();
                            MessageBox.Show("Palvelutietoja muokattu");
                            LoadData();
                        }
                        else if (answer == DialogResult.No)
                        {
                            MessageBox.Show("Palvelutietoja ei muokattu");
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Palvelu on käytössä varauksella", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void palveluDgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (palveluDgv.CurrentRow.Index != -1)
            {
                editedPalvelu = new Palvelu();
                editedPalvelu.PalveluId = Convert.ToInt32(palveluDgv.Rows[palveluDgv.CurrentRow.Index].Cells[0].Value);
                using (dbcontext = new databaseContext())
                {
                    editedPalvelu = dbcontext.Palvelus.Where(x => x.PalveluId == editedPalvelu.PalveluId).FirstOrDefault();
                    nimiPalvelutb.Text = editedPalvelu.Nimi;
                    palveluIDPalvelutb.Text = editedPalvelu.PalveluId.ToString();

                    tyyppiPalvelutb.Text = editedPalvelu.Tyyppi.ToString();
                    kuvausPalvelutb.Text= editedPalvelu.Kuvaus;
                    hintaPalveluNum.Value = (decimal)editedPalvelu.Hinta;
                    alvPalveluNum.Value = (decimal)editedPalvelu.Alv;
                }
            }

        }

        private void getPalvelubtn_Click(object sender, EventArgs e)
        {
            using (dbcontext = new databaseContext())
            {
                List<Palvelu> lista = dbcontext.Palvelus
                .Where(s => s.Nimi == nimiPalvelutb.Text || s.Alue == palveluAlueCb.SelectedValue)
                .ToList();
                palveluDgv.DataSource = lista;
            }

        }

        private void refreshPalveluBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void delPalveluBtn_Click(object sender, EventArgs e)
        {
            using (dbcontext = new databaseContext())
            {
                try
                {

                    if (palveluAlueCb == null || nimiPalvelutb.Text == string.Empty || tyyppiPalvelutb.Text == string.Empty || kuvausPalvelutb.Text == string.Empty)
                    {
                        MessageBox.Show("Täytä kaikki tiedot ennen postamista", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        editedPalvelu = dbcontext.Palvelus.Where(x => x.PalveluId == editedPalvelu.PalveluId).FirstOrDefault();
                        editedPalvelu.Nimi = nimiPalvelutb.Text;
                        //editedPalvelu.Alue = (Alue)palveluAlueCb.SelectedValue;
                        //editedPalvelu.Tyyppi = long.Parse(tyyppiPalvelutb.Text);
                        //editedPalvelu.Kuvaus = kuvausPalvelutb.Text;
                        //editedPalvelu.Hinta = (double)hintaPalveluNum.Value;
                        //editedPalvelu.Alv = (double)alvPalveluNum.Value;

                        DialogResult answer = MessageBox.Show("Haluatko varmasti poistaa palvelutietoja?", "Confirmation", MessageBoxButtons.YesNo);
                        if (answer == DialogResult.Yes)
                        {
                            dbcontext.Remove(editedPalvelu);
                            dbcontext.SaveChanges();
                            MessageBox.Show("Palvelutieto poistettu");
                            LoadData();
                        }
                        else if (answer == DialogResult.No)
                        {
                            MessageBox.Show("Palvelutietoja ei poistettu");
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
