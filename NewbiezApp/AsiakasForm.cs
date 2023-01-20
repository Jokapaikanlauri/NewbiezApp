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
    public partial class AsiakasForm : Form
    {
   
        private databaseContext dbcontext = new databaseContext();
        private Asiakas newCustomer;
        Posti p;
        Asiakas editedCustomer;
        Asiakas deletedCustomer;
        public AsiakasForm()
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
        private void LoadData()
        {
            using(dbcontext = new databaseContext())
            {
                asiakasDgv.DataSource = dbcontext.Asiakaat.ToList();

                for (int i = 0; i <= asiakasDgv.Columns.Count - 1; i++)
                {            
                    asiakasDgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                }
            }

        }
        private void AsiakasForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
   
        private void addAsiakasbtn_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                if(etunimiTb.Text == string.Empty || sukunimiTb.Text == string.Empty || puhnroTb.Text == string.Empty || emailTb.Text == string.Empty || lahiosTb.Text == string.Empty || postinroAsiakastb.Text == string.Empty)
                {
                    MessageBox.Show("Täytä kaikki tiedot ennen lisäämistä", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    using (dbcontext = new databaseContext())
                    {

                        newCustomer = new Asiakas();
                        newCustomer.Etunimi = etunimiTb.Text;
                        newCustomer.Sukunimi = sukunimiTb.Text;
                        newCustomer.Puhelinnro = puhnroTb.Text;
                        newCustomer.Email = emailTb.Text;
                        newCustomer.Lahiosoite = lahiosTb.Text;
                        newCustomer.Postinro = postinroAsiakastb.Text;

                        IfNotExists(postinroAsiakastb.Text);
                       
                        dbcontext.Asiakaat.Add(newCustomer);
                        dbcontext.SaveChanges();
                        LoadData();
                        MessageBox.Show("Uusi asiakas lisätty tietokantaan!","Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        

                    }  
                    
                  
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

            
                  
        }
        private void IfNotExists(string testString)
        {
            dbcontext = new databaseContext();
            IQueryable<Posti> testi = dbcontext.Postis.Where(o => o.Postinro == testString);
            
                if (testi.Any() == false)
                    {
                        p = new Posti();       
                        p.Postinro = postinroAsiakastb.Text;
                        p.Toimipaikka = postiToimipaikkatb.Text;
                        dbcontext.Postis.Add(p);
                        MessageBox.Show("Uusi toimipaikka lisätty");
                           
                    }
        }


        private void puhnroTb_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(puhnroTb.Text, "[^0-9]"))
            {
                puhnroTb.Text = puhnroTb.Text.Remove(puhnroTb.Text.Length - 1);
            }
        }

        private void postinroAsiakastb_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(postinroAsiakastb.Text, "[^0-9]"))
            {
                postinroAsiakastb.Text = postinroAsiakastb.Text.Remove(postinroAsiakastb.Text.Length - 1);
            }
           
        }

        private void getAsiakasbtn_Click(object sender, EventArgs e)
        {
            List<Asiakas> lista = dbcontext.Asiakaat
                        .Where(s => s.Etunimi == etunimiTb.Text || s.Sukunimi == sukunimiTb.Text)
                        .ToList();
            asiakasDgv.DataSource = lista;
        }
        
        private void asiakasDgv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(asiakasDgv.CurrentRow.Index != -1)
            {
                editedCustomer = new Asiakas();
                editedCustomer.AsiakasId = Convert.ToInt32(asiakasDgv.Rows[asiakasDgv.CurrentRow.Index].Cells[0].Value);
                using(dbcontext = new databaseContext())
                {
                    editedCustomer = dbcontext.Asiakaat.Where(x => x.AsiakasId == editedCustomer.AsiakasId).FirstOrDefault();
                    etunimiTb.Text = editedCustomer.Etunimi;
                    sukunimiTb.Text = editedCustomer.Sukunimi;
                    puhnroTb.Text = editedCustomer.Puhelinnro;
                    emailTb.Text = editedCustomer.Email;
                    lahiosTb.Text = editedCustomer.Lahiosoite;
                    postinroAsiakastb.Text = editedCustomer.Postinro;
                }
            }
            
        }

        private void editAsiakasbtn_Click(object sender, EventArgs e)
        {
            using (dbcontext = new databaseContext())
            {
                try
                {

                    if (etunimiTb.Text == string.Empty || sukunimiTb.Text == string.Empty || puhnroTb.Text == string.Empty || emailTb.Text == string.Empty || lahiosTb.Text == string.Empty || postinroAsiakastb.Text == string.Empty)
                    {
                        MessageBox.Show("Täytä kaikki tiedot ennen lisäämistä", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        editedCustomer = dbcontext.Asiakaat.Where(x => x.AsiakasId == editedCustomer.AsiakasId).FirstOrDefault();
                        editedCustomer.Etunimi = etunimiTb.Text;
                        editedCustomer.Sukunimi = sukunimiTb.Text;
                        editedCustomer.Puhelinnro = puhnroTb.Text;
                        editedCustomer.Email = emailTb.Text;
                        editedCustomer.Lahiosoite = lahiosTb.Text;
                        editedCustomer.Postinro = postinroAsiakastb.Text;

                        DialogResult answer = MessageBox.Show("Haluatko varmasti muokata asiakastietoja?", "Confirmation", MessageBoxButtons.YesNo);
                        if (answer == DialogResult.Yes)
                        {
                            IfNotExists(postinroAsiakastb.Text);
                            dbcontext.Update(editedCustomer);
                            dbcontext.SaveChanges();
                            MessageBox.Show("Asiakastietoja muokattu");
                            LoadData();
                        }
                        else if (answer == DialogResult.No)
                        {
                            MessageBox.Show("Asiakastietoja ei muokattu");
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        
        }

        private void paivitaAsiakasBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void delAsiakasbtn_Click(object sender, EventArgs e)
        {

            using (dbcontext = new databaseContext())
            {
                try
                {

                    if (etunimiTb.Text == string.Empty || sukunimiTb.Text == string.Empty || puhnroTb.Text == string.Empty || emailTb.Text == string.Empty || lahiosTb.Text == string.Empty || postinroAsiakastb.Text == string.Empty)
                    {
                        MessageBox.Show("Täytä kaikki tiedot ennen lisäämistä", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        editedCustomer = dbcontext.Asiakaat.Where(x => x.AsiakasId == editedCustomer.AsiakasId).FirstOrDefault();
                        editedCustomer.Etunimi = etunimiTb.Text;
                        editedCustomer.Sukunimi = sukunimiTb.Text;
                        editedCustomer.Puhelinnro = puhnroTb.Text;
                        editedCustomer.Email = emailTb.Text;
                        editedCustomer.Lahiosoite = lahiosTb.Text;
                        editedCustomer.Postinro = postinroAsiakastb.Text;

                        DialogResult answer = MessageBox.Show("Haluatko varmasti poistaa asiakastiedon?", "Confirmation", MessageBoxButtons.YesNo);
                        if (answer == DialogResult.Yes)
                        {
                            IfNotExists(postinroAsiakastb.Text);
                            dbcontext.Remove(editedCustomer);
                            dbcontext.SaveChanges();
                            MessageBox.Show("Asiakastieto poistettu");
                            LoadData();
                        }
                        else if (answer == DialogResult.No)
                        {
                            MessageBox.Show("Asiakastietoja ei muokattu");
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Asiakasta ei voi poistaa, koska asiakkaalla on varaus", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
    }
}
