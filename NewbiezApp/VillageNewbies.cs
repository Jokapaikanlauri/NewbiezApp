using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.Data.Entity;
using NewbiezApp.Classes;

namespace NewbiezApp
{
    public partial class VillageNewbies : Form
    {
        public VillageNewbies()
        {
            InitializeComponent();
           
        }
        

        //T‰ll‰ hetkell‰ luo useita formeja p‰‰llekk‰in. Kuinka saada ylim‰‰r‰iset pois?

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void mokitpb_Click(object sender, EventArgs e)
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

        private void laskutuspb_Click(object sender, EventArgs e)
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

        private void asiakastiedotpb_Click(object sender, EventArgs e)
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

        private void varauksetpb_Click(object sender, EventArgs e)
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

        private void palvelupb_Click(object sender, EventArgs e)
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
    }
}
