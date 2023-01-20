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

    public partial class MokitForm : Form
    {
        private databaseContext dbcontext = new databaseContext();
        private Mokki newMokki;
        Alue a;
        Posti p;
        Mokki editedMokki;
        

        public MokitForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void miniPalvelupb_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<PalveluForm>().Any())
            {
                Application.OpenForms.OfType<PalveluForm>().First().BringToFront();
            }
            else
            {
                PalveluForm Palvelu = new PalveluForm();
                Palvelu.Show();
            }
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


        private void LoadData()
        {
            using (dbcontext = new databaseContext())
            {
                mokitDgv.DataSource = dbcontext.Mokkis.ToList();
                alueMokitCb.DataSource = dbcontext.Alues.ToList();
                alueMokitCb.DisplayMember = "Nimi";
            }                                                           //Tässä ladataan DataGridViewiin tiedot
            for (int i = 0; i <= mokitDgv.Columns.Count - 1; i++)
            {
                mokitDgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
        }

        private void MokitForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void IfPostiNotExists(string testString)
        {
            dbcontext = new databaseContext();
            IQueryable<Posti> testi = dbcontext.Postis.Where(o => o.Postinro == testString);

            if (testi.Any() == false)
            {
                p = new Posti();

                p.Postinro = postinroMokitTb.Text;
                p.Toimipaikka = toimipaikkaMokitTb.Text;

                dbcontext.Postis.Add(p);
                MessageBox.Show("Uusi toimipaikka lisätty");
            }
        }

        private void IfAlueNotExists(string testString1)
        {
            dbcontext = new databaseContext();
            IQueryable<Alue> testi1 = dbcontext.Alues.Where(o => o.Nimi == testString1);

            if (testi1.Any() == false)
            {
                a = new Alue();
                //a.AlueId = testString1;
                a.Nimi = alueMokitCb.Text;
                dbcontext.Alues.Add(a);
                dbcontext.SaveChanges();
                MessageBox.Show("Uusi alue lisätty");
            }
        }

        private void mokitDgv_DoubleClick(object sender, EventArgs e)   //Tässä funktiossa kirjoitetaan tekstikenttiin klikatun rivin tiedot
        {
            if (mokitDgv.CurrentRow.Index != -1)
            {
                editedMokki = new Mokki();
                a = new Alue();
                p = new Posti();

                editedMokki.MokkiId = Convert.ToInt32(mokitDgv.Rows[mokitDgv.CurrentRow.Index].Cells[0].Value);
                using (dbcontext = new databaseContext())
                {
                    editedMokki = dbcontext.Mokkis.Where(x => x.MokkiId == editedMokki.MokkiId).FirstOrDefault();
                    a = dbcontext.Alues.Where(a => a.AlueId == editedMokki.AlueId).FirstOrDefault();
                    p = dbcontext.Postis.Where(p => p.Postinro == editedMokki.Postinro).FirstOrDefault();
                    mokkinimiTb.Text = editedMokki.Mokkinimi;
                    osoiteMokitTb.Text = editedMokki.Katuosoite;
                    kuvausMokitTb.Text = editedMokki.Kuvaus;
                    varusteluMokitTb.Text = editedMokki.Varustelu;
                    alueMokitCb.Text = a.Nimi;
                    postinroMokitTb.Text = editedMokki.Postinro;
                    toimipaikkaMokitTb.Text = p.Toimipaikka;
                    hintaMokitnup.Value = (decimal)editedMokki.Hinta;
                    hloMokitnup.Value = (decimal)editedMokki.Henkilomaara;
                }
            }
        }

        private void addMokitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (mokkinimiTb.Text == "" || alueMokitCb.Text == "" || osoiteMokitTb.Text == ""|| postinroMokitTb.Text == "" 
                    || hintaMokitnup.Value == 0 || hloMokitnup.Value == 0)
                {
                    MessageBox.Show("Täytä kaikki tiedot ennen lisäämistä", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (dbcontext = new databaseContext())
                    {
                        newMokki = new Mokki();
                        a = new Alue();
                        p = new Posti();
                        newMokki.Postinro = postinroMokitTb.Text;
                        newMokki.Mokkinimi = mokkinimiTb.Text;
                        newMokki.Katuosoite = osoiteMokitTb.Text;
                        newMokki.Hinta = (double)hintaMokitnup.Value;
                        newMokki.Kuvaus = kuvausMokitTb.Text;
                        newMokki.Henkilomaara = long.Parse(hloMokitnup.Text);
                        newMokki.Varustelu = varusteluMokitTb.Text;
                        a = (Alue)alueMokitCb.SelectedValue;
                        if (a == null)
                        {
                            IfAlueNotExists(alueMokitCb.Text);
                        }
                        else
                        {
                            newMokki.AlueId = a.AlueId;
                        }

                        p.Postinro = postinroMokitTb.Text;
                        p.Toimipaikka = toimipaikkaMokitTb.Text;
                        
                        newMokki.AlueId = a.AlueId;

                        IfPostiNotExists(postinroMokitTb.Text);

                        dbcontext.Mokkis.Add(newMokki);
                        dbcontext.SaveChanges();
                        MessageBox.Show("Uusi mökki lisätty");
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveMokitbtn_Click(object sender, EventArgs e)
        {
            using (dbcontext = new databaseContext())
            {
                dbcontext.SaveChanges();
                LoadData();
            }
        }

        private void deleteMokitbtn_Click(object sender, EventArgs e)
        {
            using (dbcontext = new databaseContext())
            {
                try
                {
                    if (mokkinimiTb.Text == "" || alueMokitCb.SelectedValue == null || osoiteMokitTb.Text == "" ||
                        postinroMokitTb.Text == "" || hintaMokitnup.Value == null || hloMokitnup.Value == null)
                    {
                        MessageBox.Show("Täytä kaikki tiedot ennen lisäämistä", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        editedMokki = dbcontext.Mokkis.Where(x => x.MokkiId == editedMokki.MokkiId).FirstOrDefault();
                        editedMokki.Mokkinimi = mokkinimiTb.Text;


                        DialogResult answer = MessageBox.Show("Haluatko varmasti poistaa mökkitiedon?", "Confirmation", MessageBoxButtons.YesNo);
                        if (answer == DialogResult.Yes)
                        {
                            dbcontext.Remove(editedMokki);
                            dbcontext.SaveChanges();
                            LoadData();
                            MessageBox.Show("Mökkitiedot poistettu");
                        }
                        else
                        {
                            MessageBox.Show("Mökkitietoja ei poistettu");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mökkitietoja ei voitu poistaa sillä mökille on tehty varaus.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void getMokitbtn_Click(object sender, EventArgs e)
        {
            using (dbcontext = new databaseContext())
            {
                List<Mokki> lista = dbcontext.Mokkis
                .Where(s => s.Mokkinimi == mokkinimiTb.Text || s.Alue == alueMokitCb.SelectedValue)
                .ToList();
                mokitDgv.DataSource = lista;
            }
        }

        private void editMokitbtn_Click(object sender, EventArgs e)
        {
            using (dbcontext = new databaseContext())
            {
                try
                {

                    if (mokkinimiTb.Text == "" || alueMokitCb.Text == "" || osoiteMokitTb.Text == "" ||
                        postinroMokitTb.Text == "" || hintaMokitnup.Value == null || hloMokitnup.Value == null)
                    {
                        MessageBox.Show("Täytä kaikki tiedot ennen muokkaamista", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        editedMokki = dbcontext.Mokkis.Where(x => x.MokkiId == editedMokki.MokkiId).FirstOrDefault();
                        editedMokki.Mokkinimi = mokkinimiTb.Text;
                        editedMokki.Katuosoite = osoiteMokitTb.Text;
                        editedMokki.Kuvaus = kuvausMokitTb.Text;
                        editedMokki.Varustelu = varusteluMokitTb.Text;
                        editedMokki.Postinro = postinroMokitTb.Text;
                        editedMokki.Hinta = double.Parse(hintaMokitnup.Text);
                        editedMokki.Henkilomaara = long.Parse(hloMokitnup.Text);

                        DialogResult answer = MessageBox.Show("Haluatko varmasti muokata palvelutietoja?", "Confirmation", MessageBoxButtons.YesNo);
                        if (answer == DialogResult.Yes)
                        {
                            dbcontext.Update(editedMokki);
                            dbcontext.SaveChanges();
                            MessageBox.Show("Mökkitietoja muokattu");
                            LoadData();
                        }
                        else if (answer == DialogResult.No)
                        {
                            MessageBox.Show("Mökkitietoj ei muokattu");
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Palvelu on käytössä varauksella", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}