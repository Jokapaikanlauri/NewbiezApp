using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewbiezApp.Classes;
using System.Data;

namespace NewbiezApp
{
    
    public partial class EsikatseluForm : Form
    {
        private databaseContext dbcontext = new databaseContext();

        public override string Text { get; set; }

        public EsikatseluForm()
        {
            InitializeComponent();
        }

        Varaus erittelyVaraus;
        Asiakas erittelyAsiakas;
        Mokki erittelyMokki;
        VarauksenPalvelut erittelyVarauksenPalvelut;
        Palvelu erittelyPalvelu;
        Lasku erittelyLasku;

        private void EsikatseluForm_Load(object sender, EventArgs e)
        {
            LoadData();

        }


        private void LoadData()
        {
            laskuidErilbl.Text = LaskutForm.passingID;
            string vID = LaskutForm.passingVID;
            string kulut = LaskutForm.passingKulut;
            varausidErilbl.Text = vID;
            erittelyVaraus = new Varaus();
            erittelyAsiakas = new Asiakas();
            erittelyMokki = new Mokki();
            erittelyVarauksenPalvelut = new VarauksenPalvelut();
            erittelyPalvelu = new Palvelu();
            erittelyLasku = new Lasku();


            using (dbcontext)
            {
                //Varauksista
                erittelyVaraus = dbcontext.Varaus.Where(e => e.VarausId.ToString() == vID).FirstOrDefault();
                string asID = erittelyVaraus.AsiakasId.ToString();
                pvmErilbl.Text = (erittelyVaraus.VarattuAlkupvm + " - " + erittelyVaraus.VarattuLoppupvm);

                //Asiakkaista nimi, puhelinnumero + osoite
                erittelyAsiakas = dbcontext.Asiakaat.Where(a => a.AsiakasId.ToString() == asID).FirstOrDefault();
                nimiErilbl.Text = (erittelyAsiakas.Etunimi + " " + erittelyAsiakas.Sukunimi);
                puhnroErilbl.Text = erittelyAsiakas.Puhelinnro.ToString();
                osoiteErilbl.Text = erittelyAsiakas.Lahiosoite.ToString();
                string moID = erittelyVaraus.MokkiMokkiId.ToString();

                //Mökeistä mökin nimi, summa, katuosoite, postinro + alue
                erittelyMokki = dbcontext.Mokkis.Where(i => i.MokkiId.ToString() == moID).FirstOrDefault();
                mokkiErilbl.Text = erittelyMokki.Mokkinimi;
                sijaintiErilbl.Text = (erittelyMokki.Katuosoite + "  " + erittelyMokki.Postinro.ToString() + " " + erittelyMokki.Alue);

                TimeSpan tt;
                int uli;

                TimeSpan? v = erittelyVaraus.VarattuLoppupvm - erittelyVaraus.VarattuAlkupvm;
                if (v.HasValue)
                {
                    tt = v.Value;
                    uli = (int)tt.Days;
                }
                else
                {
                    uli = 0;
                }

                //Hintojen laskeminen
                double dMokkii = (double)erittelyMokki.Hinta;
                double dMokkiAlvi = (dMokkii - dMokkii * 92 / 100);
                double dMokkiSummai = (erittelyMokki.Hinta * (double)uli);

                //Pyöristykset hintoihin
                double dMokki = Math.Round((Double)dMokkii, 2);
                double dMokkiAlv = Math.Round((Double)dMokkiAlvi, 2);
                double dMokkiSumma = Math.Round((Double)dMokkiSummai, 2);

                //Hinnat esille
                hintamokkiErilbl.Text = dMokki.ToString() + " € / yö";
                alvmokkiErilbl.Text = dMokkiAlv.ToString() + " €";
                summamokkiErilbl.Text = dMokkiSumma.ToString() + " €";


                //Laskuista Summa + ALV
                erittelyLasku = dbcontext.Laskus.Where(u => u.VarausId.ToString() == vID).FirstOrDefault();
                //alvmokkiErilbl.Text = erittelyLasku.Alv.ToString();
                //summamokkiErilbl.Text = (erittelyLasku.Summa.ToString() + " €");
                double dSumma;
                double dErotus;

                erittelyVarauksenPalvelut = dbcontext.VarauksenPalveluts.Where(j => j.VarausId.ToString() == vID).FirstOrDefault();


                if (erittelyVarauksenPalvelut == null)
                {
                    palvelutErilbl.Text = "-";
                    hintapalveluErilbl.Text = "";
                    palvelutsummaErilbl.Text = "";
                    alvpalvelutErilbl.Text = "";

                    dSumma = dMokkiSumma;

                     dErotus = dSumma - dMokkiSumma;


                }
                else
                {
                    //Varauksen palvelulla haetaan oikean varauksen palvelut
                    string pID = erittelyVarauksenPalvelut.PalveluId.ToString();

                    //Palveluista nimi + hinta
                    erittelyPalvelu = dbcontext.Palvelus.Where(j => j.PalveluId.ToString() == pID).FirstOrDefault();

                    palvelutErilbl.Text = erittelyPalvelu.Nimi;

                    double dPalvelutHinta = (double)erittelyPalvelu.Hinta;
                    hintapalveluErilbl.Text = erittelyPalvelu.Hinta.ToString() + " €";
                    double ps = erittelyPalvelu.Hinta * (double)erittelyVarauksenPalvelut.Lkm;
                    palvelutsummaErilbl.Text = ps.ToString() + " €";

                    double dPalvelutAlv = (double)erittelyPalvelu.Alv;
                    alvpalvelutErilbl.Text = erittelyPalvelu.Alv.ToString() + " €";
                    dSumma = dMokkiSumma + ps;

                     dErotus = dSumma - dMokkiSumma - ps;

                }
                //Lasketaan laskun mahdolliset lisäkulut (tai vähennykset, jos laskun loppusumma pienempi kuin varauksista muodostunut summa
                double kulutt = Convert.ToDouble(kulut);
                double kvv = kulutt - dSumma;

                if (kvv < 0)
                {
                    lisakulutlbl.Text = "Vähennykset";
                }
            
      
                lkulutSummalbl.Text = kulutt - dSumma + " €";

                laskusummaErilbl.Text = kulutt.ToString() + " €";

                

            }

        }
    }
}