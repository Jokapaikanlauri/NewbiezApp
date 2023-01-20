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
    public partial class RaporttiForm : Form
    {
        public RaporttiForm()
        {
            InitializeComponent();
        }

        private databaseContext dbcontext = new databaseContext();
        private List<NewbiezApp.Classes.Alue> alue;
        private List<NewbiezApp.Classes.Varaus> majoittumiset;
        private List<NewbiezApp.Classes.Palvelu> palvelut;
        private List<NewbiezApp.Classes.VarauksenPalvelut> ostetutPalvelut;
        private List<NewbiezApp.Classes.Mokki> mokit;
        private List<NewbiezApp.Classes.Lasku> laskut;
        private Alue toimialue;
        private Varaus majoitus;
        private Palvelu palvelu;
        private Lasku lasku;
        private VarauksenPalvelut varauksenpalvelu;

       
        private void RaporttiForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (dbcontext = new databaseContext())
            {
                beginRaportitdtp.Value = DateTime.Now.Date;
                endRaportitdtp.Value = DateTime.Now.Date;

                dataRaportitLb.Items.Clear();
                alue = new List<NewbiezApp.Classes.Alue>();
                palvelut = new List<NewbiezApp.Classes.Palvelu>();
                alueRaportitCmb.Items.Clear();
                lpalveluRaportitCmb.Items.Clear();
                alue = dbcontext.Alues.ToList();
                palvelut = dbcontext.Palvelus.ToList();

                try
                {
                    for(var i = 0; i < palvelut.Count; i++)
                    {
                        lpalveluRaportitCmb.Items.Add("ID: " + palvelut[i].PalveluId + " ;   "+ palvelut[i].Nimi);
                    }
                    for (var i = 0; i < alue.Count; i++)
                    {
                        alueRaportitCmb.Items.Add(alue[i].Nimi);
                    }

                    alueRaportitCmb.Items.Add("Kaikki alueet");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showRaportitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using(dbcontext = new databaseContext())
                {
                    DateTime huomenna = DateTime.Now;
                    TimeSpan pv = new TimeSpan(1, 0, 0, 0);
                    huomenna.Add(pv);

                    if (Raportitcmb.Text == "Majoittumiset")//jos haetaan majoittumisia
                    {

                        if (beginRaportitdtp.Value.Date > endRaportitdtp.Value.Date || endRaportitdtp.Value.Date > huomenna.Date || beginRaportitdtp.Value.Date > DateTime.Now.Date)
                        {//Raporttien loppupäivä ei voi olla ensimmäistä päivää aiemmin eikä raportteja voi hakea tulevaisuudesta (antaa virheen myös, jos yrittää hakea pelkästään
                         //tältä päivältä


                            MessageBox.Show("Raportin aikaväli virheellinen. \n Ole hyvä, ja tarkista hakuehdot.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
     
                        }
                        else if (alueRaportitCmb.Text == "")
                        {
                            MessageBox.Show("Valitse toimialue.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                            int count = 0;
             
                            majoitus = new Varaus();
                            toimialue = new Alue();
                            lasku = new Lasku();
                            mokit = new List<NewbiezApp.Classes.Mokki>();
                            majoittumiset = new List<NewbiezApp.Classes.Varaus>();
                            laskut = new List<NewbiezApp.Classes.Lasku>();
                            dataRaportitLb.Items.Clear(); //tyhjätään mahdollisen edellisen haun tulokset
                            /*Pitää hakea kaikki majoittumiset tietyltä ajalta ja tietyltä toimialueelta. Varaus ei sis. aluetta, mutta mökit kuuluvat aina johonkin alueeseen, 
                             haetaan siis kaikki tietyn alueen mökit, ja niiden kaikki varaukset tietyltä aikaväliltä*/

                            if(alueRaportitCmb.Text == "Kaikki alueet")
                            {
                                mokit = dbcontext.Mokkis.ToList();
                            }
                            else
                            {
                                toimialue = dbcontext.Alues.Where(a => a.Nimi == alueRaportitCmb.Text).FirstOrDefault();
                                foreach (Mokki m in dbcontext.Mokkis)
                                {
                                    if (m.AlueId == toimialue.AlueId)
                                    {
                                        mokit.Add(m);
                                    }
                                }
                            }
                           

                            //haetaan kaikki varaukset ajalta varauksen alkamispäivä klo 00:00:00 - varauksen loppumispäivä klo 23:59:59
                            //näin saadaan haettua myös varaukset, jotka ovat loppuneet tänään
                            DateTime loppupv = new DateTime();
                            TimeSpan keskiyo = new TimeSpan(23, 59, 59);
                            loppupv = endRaportitdtp.Value + keskiyo;

                             
                            /* Nyt käydään läpi kaikki varaukset ja mökkilistaan valikoidut mökit: jos varauksessa on sama mökkiID kuin listassa ja mikäli 
                            varauksen aloitus ja lopetuspvm:t osuvat hakuehtojen sisään, laitetaan se majoittumiset listaan*/
                            foreach (Varaus v in dbcontext.Varaus)
                            {
                                foreach (Mokki m in mokit)
                                {
                                    if (v.MokkiMokkiId == m.MokkiId)
                                    {
                                        if (v.VarattuAlkupvm >= beginRaportitdtp.Value && v.VarattuLoppupvm <= loppupv)
                                        {
                                            majoittumiset.Add(v);
                                        }
                                        else if((v.VarattuAlkupvm < beginRaportitdtp.Value && v.VarattuLoppupvm > loppupv) || 
                                            (v.VarattuAlkupvm < beginRaportitdtp.Value && (v.VarattuLoppupvm <= loppupv && v.VarattuLoppupvm >= beginRaportitdtp.Value)) ||
                                            ((v.VarattuAlkupvm >= beginRaportitdtp.Value && v.VarattuAlkupvm <= loppupv) && v.VarattuLoppupvm > loppupv))
                                        {//lasketaan niiden varauksien määrä, mitkä osuvat osittain samalle ajankohdalle
                                            count++;
                                        }
                                    }
                                }

                            }

                            string aloitusteksti;
                            //sitten tulostellaan listBoxiin
                            if(alueRaportitCmb.Text == "Kaikki alueet")
                            {
                                aloitusteksti = "Majoittumiset kaikilta alueilta, aikavälillä " + beginRaportitdtp.Value + " - " + loppupv + " :";
                            }
                            else
                            {
                                aloitusteksti = "Majoittumiset alueelta " + alueRaportitCmb.Text + ", aikavälillä " + beginRaportitdtp.Value + " - " + loppupv + " :";
                            }
                            
       
                            dataRaportitLb.Items.Add(aloitusteksti);

                            double kokosumma = 0;//kaikkien varausten kokonaissumma
                            int varausmaara = 0;//kaikkien varausten määrä yhteensä

                            tyhjantulostus();

                            string data = "";

                            foreach (Lasku l in dbcontext.Laskus)//haetaan kaikki laskut
                            {
                                laskut.Add(l);
                            }


                            foreach (Varaus m in majoittumiset)
                            {//Haetaan jokaisen varauksen hinta ja yhdistetään tiedot. HUOM! Jos varausta ei ole vielä laskutettu, niin hinta on 0 €

                                double summa = 0;
                                for (int i = 0; i < laskut.Count; i++)
                                {
                                    if (laskut[i].VarausId == m.VarausId)
                                    {
                                        summa = laskut[i].Summa;
                                        i = laskut.Count;
                                    }
                                }

                                data = "MökkiID: " + m.MokkiMokkiId + "    VarausID: " + m.VarausId + "    Aikavälillä " + m.VarattuAlkupvm + "  -  " + m.VarattuLoppupvm + "    Hinta: " + summa + " €";
                                dataRaportitLb.Items.Add(data);
                                kokosumma += summa;
                                varausmaara += 1;
                            }

                            tyhjantulostus();

                            //Summa summarum
                            dataRaportitLb.Items.Add("Varausten kokonaismäärä: " + varausmaara + " kpl         Varausten hinta yhteensä: " + kokosumma + " €");

                            if(count == 1)
                            {
                                tyhjantulostus();
                                dataRaportitLb.Items.Add("Lisäksi löytyi " + count + " varaus, joka on osittain kysytyllä aikavälillä.");
                            }
                            else if(count > 0)
                            {
                                tyhjantulostus();
                                dataRaportitLb.Items.Add("Lisäksi löytyi " + count + " varausta, jotka ovat osittain kysytyllä aikavälillä.");
                            }
                        }

                    }
                    else if (Raportitcmb.Text == "Palvelut")
                    {//Halutun ajanjakson ostettujen lisäpalveluiden kokonaishinta ja määrä tietyllä alueella

                        if (beginRaportitdtp.Value > endRaportitdtp.Value || endRaportitdtp.Value > huomenna || beginRaportitdtp.Value > DateTime.Now)
                        {//Raporttien loppupäivä ei voi olla ensimmäistä päivää aiemmin eikä raportteja voi hakea tulevaisuudesta (antaa virheen myös, jos yrittää hakea pelkästään
                         //tältä päivältä
                            MessageBox.Show("Raporttien päivämäärät ovat virheelliset.\n Ole hyvä, ja tarkista hakuehdot.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (alueRaportitCmb.Text == "")
                        {
                            MessageBox.Show("Valitse toimialue.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            int count = 0;
                            palvelu = new Palvelu();
                            majoitus = new Varaus();
                            toimialue = new Alue();
                            lasku = new Lasku();
                            palvelut = new List<NewbiezApp.Classes.Palvelu>();
                            ostetutPalvelut = new List<NewbiezApp.Classes.VarauksenPalvelut>();
                            majoittumiset = new List<NewbiezApp.Classes.Varaus>();
                            laskut = new List<NewbiezApp.Classes.Lasku>();
                            dataRaportitLb.Items.Clear(); //tyhjätään mahdollisen edellisen haun tulokset

                            if(alueRaportitCmb.Text == "Kaikki alueet")
                            {
                                palvelut = dbcontext.Palvelus.ToList();
                            }
                            else
                            {
                                //haetaan kaikki halutun alueen palvelut
                                toimialue = dbcontext.Alues.Where(a => a.Nimi == alueRaportitCmb.Text).FirstOrDefault();
                                foreach (Palvelu p in dbcontext.Palvelus)
                                {
                                    if (p.AlueId == toimialue.AlueId)
                                    {
                                        palvelut.Add(p);
                                    }
                                }
                            }
                           

                            DateTime loppupv = new DateTime();
                            TimeSpan keskiyo = new TimeSpan(23, 59, 59);
                            loppupv = endRaportitdtp.Value + keskiyo;

                            //haetaan kaikki ostetut palvelut (eli kaikki varauksen palvelut) ja verrataan niitä kysytyn alueen palveluihin
                            foreach (VarauksenPalvelut vp in dbcontext.VarauksenPalveluts)
                            {
                                foreach (Palvelu p in palvelut)
                                {
                                    if (vp.PalveluId == p.PalveluId)
                                    {//jos ostettu palvelu on sama, kuin halutun toimialueen palvelu, niin katsotaan, onko palvelu ostettu kysyttynä ajankohtana 
                                        majoitus = dbcontext.Varaus.Where(m => m.VarausId == vp.VarausId).FirstOrDefault();

                                        if (majoitus.VarattuAlkupvm >= beginRaportitdtp.Value && majoitus.VarattuLoppupvm <= loppupv)
                                        {//jos on, niin ostettu palvelu lisätään listaan
                                            ostetutPalvelut.Add(vp);
                                        }
                                        else if ((majoitus.VarattuAlkupvm < beginRaportitdtp.Value && majoitus.VarattuLoppupvm > loppupv) ||
                                            (majoitus.VarattuAlkupvm < beginRaportitdtp.Value && (majoitus.VarattuLoppupvm <= loppupv && majoitus.VarattuLoppupvm >= beginRaportitdtp.Value)) ||
                                            ((majoitus.VarattuAlkupvm >= beginRaportitdtp.Value && majoitus.VarattuAlkupvm <= loppupv) && majoitus.VarattuLoppupvm > loppupv))
                                        {//lasketaan niiden palveluiden määrä, mitkä osuvat osittain samalle ajankohdalle
                                        
                                            count += (int)vp.Lkm;
                                          
                                        }
                                    }
                                }
                            }

                            //sitten tulostellaan

                            string aloitusteksti;

                            if(alueRaportitCmb.Text == "Kaikki alueet")
                            {
                                aloitusteksti = "Ostetut lisäpalvelut kaikilta alueilta, aikavälillä " + beginRaportitdtp.Value + " - " + loppupv + " :";
                            }
                            else
                            {
                                aloitusteksti = "Ostetut lisäpalvelut alueelta " + alueRaportitCmb.Text + ", aikavälillä " + beginRaportitdtp.Value + " - " + loppupv + " :";
                            }
                            
                            dataRaportitLb.Items.Add(aloitusteksti);

                            double kokosumma = 0;//kaikkien ostettujen palveluiden kokonaissumma
                            long varausmaara = 0;//kaikkien ostettujen palveluiden määrä yhteensä

                            tyhjantulostus();

                            string data = "";

                            foreach (VarauksenPalvelut vp in ostetutPalvelut)
                            {
                                palvelu = dbcontext.Palvelus.Where(p => p.PalveluId == vp.PalveluId).FirstOrDefault(); //haetaan palvelu, joka näytetään (käytetään nimen ja summan esittämiseen)
                                string nimi = palvelu.Nimi;

                                majoitus = dbcontext.Varaus.Where(m => m.VarausId == vp.VarausId).FirstOrDefault();//haetaan varauksen aikaväli, johon palvelu liitetty  

                                //palvelun hinta
                                double summa = 0;
                                summa = palvelu.Hinta * vp.Lkm;

                                kokosumma += summa;
                                varausmaara += vp.Lkm;

                                data = "PalveluID: " + vp.PalveluId + "    Palvelu: " + nimi + "    VarausID: " + vp.VarausId + "    Aikavälillä " + majoitus.VarattuAlkupvm + "  -  " + majoitus.VarattuLoppupvm + "    Lkm: " + vp.Lkm
                                    + "    Hinta: " + summa + " €";
                                dataRaportitLb.Items.Add(data);

                            }

                            tyhjantulostus();
                         
                            //Summa summarum
                            dataRaportitLb.Items.Add("Ostettujen lisäpalveluiden kokonaismäärä: " + varausmaara + " kpl         Ostettujen lisäpalveluiden hinta yhteensä: " + kokosumma + " €");

                            if(count == 1)
                            {
                                tyhjantulostus();
                                dataRaportitLb.Items.Add("Lisäksi löytyi " + count + " ostettu lisäpalvelu, joka on osittain kysytyllä aikavälillä.");
                            }
                            else if (count > 0)
                            {
                                tyhjantulostus();
                                dataRaportitLb.Items.Add("Lisäksi löytyi " + count + " ostettua lisäpalvelua, jotka ovat osittain kysytyllä aikavälillä.");
                            }
                        }
                    }
                    else if(LpalveluRaportitCb.Checked == true)
                    {//Halutun lisäpalvelun myyntimäärä tietyllä ajanjaksolla TAI tietyllä alueella

                        if (lpalveluRaportitCmb.Text == "")
                        {
                            MessageBox.Show("Valitse lisäpalvelu, josta haluat raportin.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if(alueRaportitRb.Checked == true)
                        {


                            if(alueRaportitCmb.Text == "")
                            {
                                MessageBox.Show("Valitse alue, jolta haluat hakea.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                palvelu = new Palvelu();
                                majoitus = new Varaus();
                                toimialue = new Alue();
                                lasku = new Lasku();
                                ostetutPalvelut = new List<NewbiezApp.Classes.VarauksenPalvelut>();
                                dataRaportitLb.Items.Clear(); //tyhjätään mahdollisen edellisen haun tulokset

                                DateTime loppupv = new DateTime();
                                TimeSpan keskiyo = new TimeSpan(23, 59, 59);
                                loppupv = DateTime.Now.Date + keskiyo;


                                long ID = haeId();

                                //otetaan kysytty lisäpalvelu id:n perusteella
                                palvelu = dbcontext.Palvelus.Where(p => p.PalveluId == ID).FirstOrDefault();

                                if(alueRaportitCmb.Text == "Kaikki alueet")
                                {
                                    foreach (VarauksenPalvelut vp in dbcontext.VarauksenPalveluts)
                                    {//käydään kaikki alueet läpi
                                     // HUOM! tulevia palveluvarauksia ei lasketa, joten ne pitää rajata pois, haetaan majoituksen kautta ostetun palvelun ajankohta

                                        majoitus = dbcontext.Varaus.Where(m => m.VarausId == vp.VarausId).FirstOrDefault();

                                        if (vp.PalveluId == palvelu.PalveluId  && majoitus.VarattuLoppupvm <= loppupv)
                                        {
                                            ostetutPalvelut.Add(vp);
                                        }
                                    }
                                }
                                else
                                {
                                    toimialue = dbcontext.Alues.Where(a => a.Nimi == alueRaportitCmb.Text).FirstOrDefault();

                                    foreach (VarauksenPalvelut vp in dbcontext.VarauksenPalveluts)
                                    {//jos palvelua on ostettu ja mikäli palvelu on kysytyllä alueella 
                                     // HUOM! tulevia palveluvarauksia ei lasketa, joten ne pitää rajata pois, haetaan majoituksen kautta ostetun palvelun ajankohta

                                        majoitus = dbcontext.Varaus.Where(m => m.VarausId == vp.VarausId).FirstOrDefault();

                                        if (vp.PalveluId == palvelu.PalveluId && palvelu.AlueId == toimialue.AlueId && majoitus.VarattuLoppupvm <= loppupv)
                                        {
                                            ostetutPalvelut.Add(vp);
                                        }
                                    }
                                }


                                //sitten tulostellaan
                                string aloitusteksti;

                                if(alueRaportitCmb.Text == "Kaikki alueet")
                                {
                                    aloitusteksti = palvelu.Nimi + " -palvelun (ID: " + ID + ") myyntimäärä kaikilla alueilla :";
                                }
                                else
                                {
                                    aloitusteksti = palvelu.Nimi + " -palvelun (ID: " + ID + ") myyntimäärä alueella " + alueRaportitCmb.Text + " :";
                                }

                               

                                dataRaportitLb.Items.Add(aloitusteksti);

                                double kokosumma = 0;//kaikkien ostettujen palveluiden kokonaissumma
                                long myyntimaara = 0;//kaikkien ostettujen palveluiden määrä yhteensä

                                tyhjantulostus();

                                string data = "";

                                foreach (VarauksenPalvelut vp in ostetutPalvelut)
                                {
                                    palvelu = dbcontext.Palvelus.Where(p => p.PalveluId == vp.PalveluId).FirstOrDefault(); //haetaan palvelu, joka näytetään (käytetään nimen ja summan esittämiseen)
                                    string pnimi = palvelu.Nimi;

                                    //palvelun hinta
                                    double summa = 0;
                                    summa = palvelu.Hinta * vp.Lkm;

                                    kokosumma += summa;
                                    myyntimaara += vp.Lkm;

                                    data = "Lkm: " + vp.Lkm + "    Hinta: " + summa + " €";
                                    dataRaportitLb.Items.Add(data);

                                }

                                tyhjantulostus();

                                //Summa summarum
                                dataRaportitLb.Items.Add("Lisäpalvelun myyntimäärä: " + myyntimaara + " kpl         Myydyn lisäpalvelun hinta yhteensä: " + kokosumma + " €");

                            }

                        }
                        else if(aikaRaportitRb.Checked == true)
                        {


                            if (beginRaportitdtp.Value.Date > endRaportitdtp.Value.Date || endRaportitdtp.Value.Date > huomenna || beginRaportitdtp.Value.Date > DateTime.Now.Date)
                            {//Raporttien loppupäivä ei voi olla ensimmäistä päivää aiemmin eikä raportteja voi hakea tulevaisuudesta (antaa virheen myös, jos yrittää hakea pelkästään
                             //tältä päivältä
                                MessageBox.Show("Raporttien päivämäärät ovat virheelliset.\n Ole hyvä, ja tarkista hakuehdot.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                int count = 0;
                                palvelu = new Palvelu();
                                majoitus = new Varaus();
                                toimialue = new Alue();
                                lasku = new Lasku();
                                ostetutPalvelut = new List<NewbiezApp.Classes.VarauksenPalvelut>();
                                dataRaportitLb.Items.Clear(); //tyhjätään mahdollisen edellisen haun tulokset

                                long ID = haeId();

                                //otetaan kysytty lisäpalvelu id:n perusteella
                                palvelu = dbcontext.Palvelus.Where(p => p.PalveluId == ID).FirstOrDefault();


                                DateTime loppupv = new DateTime();
                                TimeSpan keskiyo = new TimeSpan(23, 59, 59);
                                loppupv = endRaportitdtp.Value + keskiyo;

                                //haetaan kaikki ostetut palvelut (eli kaikki varauksen palvelut) ja verrataan niitä kysyttyyn palveluun ja tarkistetaan päiväykset
                                foreach (VarauksenPalvelut vp in dbcontext.VarauksenPalveluts)
                                {
                                    majoitus = dbcontext.Varaus.Where(m => m.VarausId == vp.VarausId).FirstOrDefault();

                                    if (vp.PalveluId == palvelu.PalveluId && (majoitus.VarattuAlkupvm >= beginRaportitdtp.Value && majoitus.VarattuLoppupvm <= loppupv))
                                    {
                                        ostetutPalvelut.Add(vp);

                                    }
                                    else if (vp.PalveluId == palvelu.PalveluId && ((majoitus.VarattuAlkupvm < beginRaportitdtp.Value && majoitus.VarattuLoppupvm > loppupv) ||
                                            (majoitus.VarattuAlkupvm < beginRaportitdtp.Value && (majoitus.VarattuLoppupvm <= loppupv && majoitus.VarattuLoppupvm >= beginRaportitdtp.Value)) ||
                                            ((majoitus.VarattuAlkupvm >= beginRaportitdtp.Value && majoitus.VarattuAlkupvm <= loppupv) && majoitus.VarattuLoppupvm > loppupv)))
                                    {//lasketaan niiden palveluiden määrä, mitkä osuvat osittain samalle ajankohdalle
                                        count += (int)vp.Lkm;
                                    }

                                }

                                //tulostus

                                string aloitusteksti = palvelu.Nimi + " -palvelun (ID: " + ID + ") myyntimäärä aikavälillä " + beginRaportitdtp.Value + "  -  " + loppupv;

                                dataRaportitLb.Items.Add(aloitusteksti);

                                double kokosumma = 0;//kaikkien ostettujen palveluiden kokonaissumma
                                long myyntimaara = 0;//kaikkien ostettujen palveluiden määrä yhteensä

                                tyhjantulostus();
                                string data = "";

                                foreach (VarauksenPalvelut vp in ostetutPalvelut)
                                {
                                    palvelu = dbcontext.Palvelus.Where(p => p.PalveluId == vp.PalveluId).FirstOrDefault(); //haetaan palvelu, joka näytetään (käytetään nimen ja summan esittämiseen)
                                    string pnimi = palvelu.Nimi;

                                    //palvelun hinta
                                    double summa = 0;
                                    summa = palvelu.Hinta * vp.Lkm;

                                    kokosumma += summa;
                                    myyntimaara += vp.Lkm;

                                    data = "Lkm: " + vp.Lkm + "    Hinta: " + summa + " €";
                                    dataRaportitLb.Items.Add(data);

                                }

                                tyhjantulostus();

                                //Summa summarum
                                dataRaportitLb.Items.Add("Lisäpalvelun myyntimäärä: " + myyntimaara + " kpl         Myydyn lisäpalvelun hinta yhteensä: " + kokosumma + " €");

                                if(count == 1)
                                {
                                    tyhjantulostus();
                                    dataRaportitLb.Items.Add("Lisäksi löytyi " + count + " myyty lisäpalvelu, joka on osittain kysytyllä aikavälillä.");
                                }
                                else if (count > 0)
                                {
                                    tyhjantulostus();
                                    dataRaportitLb.Items.Add("Lisäksi löytyi " + count + " myytyä lisäpalvelua, jotka ovat osittain kysytyllä aikavälillä.");
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Valitse, haluatko hakea alueelta vai aikaväliltä.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valitse raportin tyyppi.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private long haeId()
        {//haetaan palvelun id palvelun nimestä
            long ID;
            string nimi = lpalveluRaportitCmb.Text;
            string id = "";

            for (var i = 0; i < nimi.Length; i++)
            {
                char merkki = nimi[i];
                if (char.IsNumber(merkki))
                {
                    id += merkki;
                }
                else if(merkki == ';')//siltä varalta, että palvelun nimessä on tekstiä, niin käytetään tätä erottamaan id muista numeroista
                {
                    i = nimi.Length;
                }
            }
             ID = long.Parse(id);

            return ID;
        }
        private void Raportitcmb_Click(object sender, EventArgs e)
        {//jos haetaan kaikkia majoituksia tai palveluita, niin ei voida hakea tiettyä palvelua
            LpalveluRaportitCb.Checked = false;
            lpalveluRaportitCmb.Text = "";
            alueRaportitRb.Checked = false;
            aikaRaportitRb.Checked = false;
        }

        private void LpalveluRaportitCb_CheckedChanged(object sender, EventArgs e)
        {//jos haetaan tiettyä palvelua, niin ei voida hakea kaikkia majoituksia tai palveluita
            if(LpalveluRaportitCb.Checked == true)
            {
                Raportitcmb.Text = "";
            }

        }

        private void alueRaportitRb_CheckedChanged(object sender, EventArgs e)
        {
            if(alueRaportitRb.Checked == true)
            {
                beginRaportitdtp.Value = DateTime.Now.Date;
                endRaportitdtp.Value = DateTime.Now.Date;
            }
        }

        private void aikaRaportitRb_CheckedChanged(object sender, EventArgs e)
        {
            if(aikaRaportitRb.Checked == true)
            {
                alueRaportitCmb.Text = "";
            }
        }

        private void tyhjantulostus()
        {
            string tyhja = "";
            for (int i = 1; i <= 2; i++)//tyhjän tulostus, helpottaa hakutulosten lukemista
            {
                dataRaportitLb.Items.Add(tyhja);
            }
        }

 
    }
}
