using System;
using System.Collections.Generic;
using System.ComponentModel;
using NewbiezApp.Classes;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewbiezApp
{
    public partial class LaskutForm : Form
    {
       

        public LaskutForm()
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

        private databaseContext dbcontext = new databaseContext();


        private void LoadData()
        {
            using (dbcontext = new databaseContext())

            {
                laskutDgv.DataSource = dbcontext.Laskus.ToList();
                varausIDcb.DataSource = dbcontext.Laskus.ToList();
                varausIDcb.DisplayMember = "VarausId";
                varausIDcb.SelectedItem = null;
            }
            for (int i = 0; i <= laskutDgv.Columns.Count - 1; i++)
            {
                laskutDgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            varausIDcb.Text = "";
            laskuIDtb.Text = "";
            summaLaskutNum.Value = 0;
            alvLaskutNum.Value = 0;

        }

        private void LaskuForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void getLaskutbtn_Click(object sender, EventArgs e)
        {
            //Laskun hakeminen laskun ID:n perusteella
            try
            {
                if (laskuIDtb.Text != "")
                {
                    using (dbcontext = new databaseContext())
                    {
                        List<Lasku> laskuja = dbcontext.Laskus
                            .Where(l => l.LaskuId == long.Parse(laskuIDtb.Text)) 
                            .ToList();
                        laskutDgv.DataSource = laskuja;
                    }

                }
                else
                {
                    MessageBox.Show("Hae laskua laskun ID:n perusteella.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void editLaskutbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbcontext = new databaseContext())
                {

                    if (varausIDcb == null || laskuIDtb == null || summaLaskutNum == null || alvLaskutNum == null)
                    {
                        MessageBox.Show("Täytä kaikki tiedot ennen lisäämistä", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        editedLasku = dbcontext.Laskus.Where(a => a.LaskuId == editedLasku.LaskuId).FirstOrDefault();
                        if (muistutusLaskuNum.Visible = true)
                        {
                            editedLasku.Summa = (double)summaLaskutNum.Value + (double)muistutusLaskuNum.Value;
                        }
                        else
                        {
                            editedLasku.Summa = (double)summaLaskutNum.Value;
                        }

                        editedLasku.Alv = (double)alvLaskutNum.Value;
                        editedLasku.Tila = tilaLaskutcb.Text;


                        DialogResult answer = MessageBox.Show("Haluatko varmasti muokata laskun tietoja?", "Confirmation", MessageBoxButtons.YesNo);
                        if (answer == DialogResult.Yes)
                        {
                            //Laskun tila täytyy olla joko "Sent", "Paid" tai "Reminded"
                            if (tilaLaskutcb.Text == "Sent" || tilaLaskutcb.Text == "Paid" || tilaLaskutcb.Text == "Reminded")
                            {
                                dbcontext.Update(editedLasku);
                                dbcontext.SaveChanges();
                                MessageBox.Show("Laskun tiedot päivitetty.");
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("Tarkista laskun tila");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Laskun tietoja ei muokattu.");
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public static string passingID;
        public static string passingVID;
        public static string passingKulut;
      
        private void showLaskutbtn_Click(object sender, EventArgs e)
        {
            if (varausIDcb.Text != "" && laskuIDtb.Text != "")
            {
                passingID = laskuIDtb.Text;
                passingVID = varausIDcb.Text;
            passingKulut = summaLaskutNum.Text;
                EsikatseluForm Esikatselu = new EsikatseluForm();
                Esikatselu.ShowDialog();

            }
            else
            {
                MessageBox.Show("Valitse esikatseltava lasku listalta.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        Lasku editedLasku;



        private void laskutDgv_MouseClick(object sender, MouseEventArgs e)
        {
            varausIDcb.Text = "";
            tilaLaskutcb.Text = "";
            if (laskutDgv.CurrentRow.Index != -1)
            {

                editedLasku = new Lasku();

                editedLasku.LaskuId = Convert.ToInt32(laskutDgv.Rows[laskutDgv.CurrentRow.Index].Cells[0].Value);
                using (dbcontext = new databaseContext())
                {
                    editedLasku = dbcontext.Laskus.Where(k => k.LaskuId == editedLasku.LaskuId).FirstOrDefault();
                    varausIDcb.SelectedText = editedLasku.VarausId.ToString();
                    laskuIDtb.Text = editedLasku.LaskuId.ToString();
                    summaLaskutNum.Value = (decimal)editedLasku.Summa;
                    alvLaskutNum.Value = (decimal)editedLasku.Alv;
                    tilaLaskutcb.SelectedText = editedLasku.Tila;
                 

                    //Jos lasku on maksettu, ei laskun tietoja voi enää muuttaa 
                    if (editedLasku.Tila == "Paid")
                    {
                        laskuIDtb.Enabled = false;
                        varausIDcb.Enabled = false;
                        summaLaskutNum.Enabled = false;
                        alvLaskutNum.Enabled = false;
                        tilaLaskutcb.Enabled = false;

                    }
                    else
                    {
                        laskuIDtb.Enabled = true;
                        varausIDcb.Enabled = false;
                        summaLaskutNum.Enabled = true;
                        alvLaskutNum.Enabled = true;
                        tilaLaskutcb.Enabled = true;
                    }
                }

            }

        }

        private void refreshLaskutbtn_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void tilaLaskutcb_TextChanged(object sender, EventArgs e)
        {
            //Laskun muistutusmaksu
            if (tilaLaskutcb.Text == "Reminded")
            {
                muistutusLaskulbl.Visible = true;
                muistutusLaskuNum.Visible = true;
            }
            else
            {
                muistutusLaskulbl.Visible = false;
                muistutusLaskuNum.Visible = false;
            }

        }

    }
}
