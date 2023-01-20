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
    public partial class VarausForm : Form
    {

        public VarausForm()
        {
            InitializeComponent();

        }

        private databaseContext dbcontext = new databaseContext();
        private Asiakas customer;
        private Varaus newBooking;
        private Varaus editedBooking;
        private Varaus deletedBooking;
        private Varaus isAlreadyBooked;
        private Lasku newBill;
        private Lasku sentBill;
        private Lasku isBill;
        private Palvelu palvelu;
        private Mokki mokki;
        private List<NewbiezApp.Classes.Palvelu> palvelunNimi = new List<NewbiezApp.Classes.Palvelu>();
        private List<NewbiezApp.Classes.VarauksenPalvelut> kaikkipalvelut = new List<NewbiezApp.Classes.VarauksenPalvelut>();
        private VarauksenPalvelut varauksenpalvelu;
        private VarauksenPalvelut deletedvarauksenpalvelu;
        private VarauksenPalvelut samapalvelu;

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

        private void showRapportBtn_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<RaporttiForm>().Any())
            {
                Application.OpenForms.OfType<RaporttiForm>().First().BringToFront();
            }
            else
            {
                RaporttiForm Raportit = new RaporttiForm();
                Raportit.Show();
            }
        }

        //NAVIGOINTI LOPPUU ---- VARSINAINEN KOODI ALKAA

        private void LoadData()
        {
            using (dbcontext = new databaseContext())
            {
                varausDgv.DataSource = dbcontext.Varaus.ToList();
                varauksenPalvelutdgv.DataSource = dbcontext.VarauksenPalveluts.ToList();
                palvelunNimiVarausCmb.Items.Clear(); //tyhjätään, ettei tule montaa kertaa
                palvelunNimi = dbcontext.Palvelus.ToList();

                try
                {//haetaan palveluiden nimet ja laitetaan esille
                    for (var i = 0; i < palvelunNimi.Count; i++)
                    {
                        palvelunNimiVarausCmb.Items.Add("ID: " + palvelunNimi[i].PalveluId + " ;  " + palvelunNimi[i].Nimi);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void VarausForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void refreshVarausbtn_Click(object sender, EventArgs e)
        {//jotta saadaan kaikki varaukset haettua tarvittaessa
            LoadData();
        }

        private void firstDayVarausdtp_ValueChanged(object sender, EventArgs e)
        {
            /*Kun varauksen ensimmäinen päivä on valittu, vaihtuu sama päivä automaattisesti viimeisen varauspäivän kohdalle
             (kiva pieni lisätoiminto, mikä hiukan nopeuttaa päivien valintaa)*/

            lastDayVarausdtp.Value = firstDayVarausdtp.Value;

        }

        private void addVarausbtn_Click(object sender, EventArgs e) //uuden varauksen tekeminen
        {
            try
            {
                using (dbcontext = new databaseContext())
                {
                    bool onnistuiko;
                    long id;

                    //tarkistetaan, onko asiakasta jo tietojärjestelmässä
                    customer = new Asiakas();
                    onnistuiko = long.TryParse(asiakasIDVaraustb.Text, out long asiakasid);
                    if (onnistuiko)
                    {
                        customer = dbcontext.Asiakaat.Where(a => a.AsiakasId == asiakasid).FirstOrDefault();
                    }

                    //tarkistetaan, onko mökkiä olemassa
                    mokki = new Mokki();
                    onnistuiko = long.TryParse(mokkiIDVaraustb.Text, out long mokkid);
                    if (onnistuiko)
                    {
                        mokki = dbcontext.Mokkis.Where(m => m.MokkiId == mokkid).FirstOrDefault();   
                    }


                    if (asiakasIDVaraustb.Text == "" || mokkiIDVaraustb.Text == "" || reservedVarausdtp.Value == reservedVarausdtp.MinDate ||
                                            confirmedVarausdtp.Value == confirmedVarausdtp.MinDate || firstDayVarausdtp.Value == firstDayVarausdtp.MinDate ||
                                            lastDayVarausdtp.Value == lastDayVarausdtp.MinDate)
                    {
                        MessageBox.Show("Täytä kaikki tiedot ennen uuden varauksen lisäämistä.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (firstDayVarausdtp.Value.Date >= lastDayVarausdtp.Value.Date || firstDayVarausdtp.Value.Date <= DateTime.Now.Date)
                    {//varauksen loppupäivä ei voi olla aloituspäivää pienempi, minimivaraus on 1 yö, eikä uusia varauksia voi tehdä menneisyyteen


                        if (firstDayVarausdtp.Value.Date > lastDayVarausdtp.Value.Date)
                        {
                            MessageBox.Show("Varauksen loppumispäivä virheellinen.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if(firstDayVarausdtp.Value.Date == DateTime.Now.Date)
                        {
                            MessageBox.Show("Varaus täytyy tehdä viimeistään varauksen alkamista edeltävänä päivänä.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (firstDayVarausdtp.Value.Date == lastDayVarausdtp.Value.Date)
                        {
                            MessageBox.Show("Varauksen vähimmäiskesto on 1 yö.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }    
                        else
                        {
                            MessageBox.Show("Varausta ei voi tehdä menneisyyteen.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                    else if(customer == null || mokki == null)
                    {
                        //jos asiakasid:tä ei ole olemassa, annetaan virheilmoitus ja jos mökkiä ei ole olemassa, niin tulee myöskin virheilmoitus
                        if(customer == null)
                        {
                            MessageBox.Show("Asiakkaan tietoja ei ole vielä tallennettu järjestelmään. Tallenna ensin asiakkaan tiedot.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Mökkiä tietoja ei ole vielä tallennettu järjestelmään. Tallenna ensin mökin tiedot.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    else
                    {

                        newBooking = new Varaus();
                        isAlreadyBooked = new Varaus();

                        newBooking.AsiakasId = asiakasid;
                        
                        newBooking.MokkiMokkiId = mokkid;
                        isAlreadyBooked.MokkiMokkiId = mokkid;

                        string pvm;

                        pvm = reservedVarausdtp.Value.ToString("yyyy-MM-dd");
                        newBooking.VarattuPvm = DateTime.Parse(pvm);

                        pvm = confirmedVarausdtp.Value.ToString("yyyy-MM-dd");
                        newBooking.VahvistusPvm = DateTime.Parse(pvm);

                        pvm = firstDayVarausdtp.Value.ToString("yyyy-MM-dd");
                        newBooking.VarattuAlkupvm = DateTime.Parse(pvm);

                        pvm = lastDayVarausdtp.Value.ToString("yyyy-MM-dd");
                        newBooking.VarattuLoppupvm = DateTime.Parse(pvm);

                        //Päällekkäisten varausten tarkistus tähän
                        bool onkoVarattu = DateCheck(newBooking);

                        if (onkoVarattu == true)
                        {
                            MessageBox.Show("Valitsemasi mökki on jo varattu kyseisenä ajankohtana.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //jos päällekkäisiä varauksia ei löytynyt

                            dbcontext.Varaus.Add(newBooking);
                            dbcontext.SaveChanges();
                            MessageBox.Show("Uusi varaus lisätty tietokantaan!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                    }
                }
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void getVarausbtn_Click(object sender, EventArgs e)
        {//varauksen hakeminen ja näyttäminen dgv:ssä
            try
            {
                // haetaan asiakasid:n perusteella, eli käyttäjän/työntekijän tulee ensin selvittää asiakkaan nimi ja hänen asiakasID:nsä, että
                //varausta voidaan etsiä

                using(dbcontext = new databaseContext())
                {
                    if (asiakasIDVaraustb.Text != "")
                    {
                        List<Varaus> kaikkivaraukset = dbcontext.Varaus.Where(v => v.AsiakasId == long.Parse(asiakasIDVaraustb.Text)).ToList();
                        varausDgv.DataSource = kaikkivaraukset;
                    }
                    else
                    {
                        MessageBox.Show("Hae varausta asiakas ID:n perusteella.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void varausDgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {//klikatun varauksen näyttäminen textbokseissa
            try
            {
                if (varausDgv.CurrentRow.Index != -1)
                {
                    if(e.RowIndex != -1) //Ei anna virhettä headeria klikatessa
                    {
                        using (dbcontext = new databaseContext())
                        {
                            editedBooking = new Varaus();
                            DataGridViewRow row = varausDgv.Rows[e.RowIndex];
                            long varausId;
                            bool onnistuiko = long.TryParse(row.Cells[0].Value.ToString(), out varausId);
                            if (onnistuiko)
                            {
                                //haetaan varaus datagridview:stä textboxeihin näkyviin

                                editedBooking.VarausId = varausId;
                                editedBooking = dbcontext.Varaus.Where(v => v.VarausId == editedBooking.VarausId).FirstOrDefault();
                                varausIDtb.Text = editedBooking.VarausId.ToString();
                                asiakasIDVaraustb.Text = editedBooking.AsiakasId.ToString();
                                mokkiIDVaraustb.Text = editedBooking.MokkiMokkiId.ToString();
                                reservedVarausdtp.Value = editedBooking.VarattuPvm.Value;
                                confirmedVarausdtp.Value = editedBooking.VahvistusPvm.Value;
                                firstDayVarausdtp.Value = editedBooking.VarattuAlkupvm.Value;
                                lastDayVarausdtp.Value = editedBooking.VarattuLoppupvm.Value;

                                //jos meillä on haettu varaus onnistuneesti, niin haetaan myös sen jo varatut palvelut

                                if (varausIDtb.Text != "")
                                {
                                    List<VarauksenPalvelut> kaikkipalvelut = dbcontext.VarauksenPalveluts.Where(p => p.VarausId == long.Parse(varausIDtb.Text)).ToList();
                                    varauksenPalvelutdgv.DataSource = kaikkipalvelut;
                                }



                                //varaukseen saa lisättyä palveluita vain sellaisilta alueilta, jotka ovat mökin kanssa samalla alueella
                                palvelunNimiVarausCmb.Items.Clear(); //tyhjätään, jotta ylimääräiset ei näy
                                palvelunNimi = dbcontext.Palvelus.ToList();

                                //haetaan varauksen mökki ja sen alueid
                                mokki = new Mokki();
                                mokki.MokkiId = editedBooking.MokkiMokkiId;
                                mokki = dbcontext.Mokkis.Where(m => m.MokkiId == editedBooking.MokkiMokkiId).FirstOrDefault();

                                //verrataan jokaisen palvelun alueid:tä mökin alueid:seen, jos täsmää, niin annetaan ns "näytille"
                                foreach (Palvelu p in palvelunNimi)
                                {
                                    if(p.AlueId == mokki.AlueId)
                                    {
                                        palvelunNimiVarausCmb.Items.Add("ID: " + p.PalveluId + " ;  " + p.Nimi);
                                    }
                                }

                                //katsotaan, onko haetusta varauksesta tehty/lähetetty lasku
                                sentBill = new Lasku();
                                onnistuiko = long.TryParse(row.Cells[0].Value.ToString(), out varausId);
                                if (onnistuiko)
                                {
                                    //laitetaan (dgv:stä haetun) varauksen varausId haettavan laskun VarausId:ksi
                                    sentBill.VarausId = varausId;

                                    //haetaan Laskujen puolelta samalla varausID:llä olevaa laskua
                                    isBill = new Lasku();
                                    isBill.VarausId = varausId;
                                    isBill = dbcontext.Laskus.Where(b => b.VarausId == sentBill.VarausId).FirstOrDefault();

                                    if (isBill != null)
                                    {
                                        if (sentBill.VarausId == isBill.VarausId)
                                        {
                                            //jos lasku on jo muodostettu, niin varausta ei voi muokata, poistaa eikä siitä voi muodostaa uutta laskua

                                            asiakasIDVaraustb.ReadOnly = true;
                                            asiakasIDVaraustb.Enabled = false;
                                            mokkiIDVaraustb.ReadOnly = true;
                                            mokkiIDVaraustb.Enabled = false;
                                            reservedVarausdtp.Enabled = false;
                                            confirmedVarausdtp.Enabled = false;
                                            firstDayVarausdtp.Enabled = false;
                                            lastDayVarausdtp.Enabled = false;
                                            editVarausbtn.Enabled = false;
                                            deleteVarausbtn.Enabled = false;
                                            sendBillVarauscb.Enabled = false;
                                            sendBillVarauscb.Visible = false;
                                            billCreatedVarauslbl.Visible = true; //kerrotaan käyttäjälle, miksi napit eivät toimi
                                            addPalveluVarausbtn.Enabled = false;
                                            editPalveluVarausbtn.Enabled = false;
                                            deletePalveluVarausbtn.Enabled = false;
                                        }
                                    }
                                    else //jos varauksesta ei ole tehty laskua, sitä voi muokata
                                    {
                                        asiakasIDVaraustb.ReadOnly = false;
                                        asiakasIDVaraustb.Enabled = true;
                                        mokkiIDVaraustb.ReadOnly = false;
                                        mokkiIDVaraustb.Enabled = true;
                                        reservedVarausdtp.Enabled = true;
                                        confirmedVarausdtp.Enabled = true;
                                        firstDayVarausdtp.Enabled = true;
                                        lastDayVarausdtp.Enabled = true;
                                        editVarausbtn.Enabled = true;
                                        deleteVarausbtn.Enabled = true;
                                        sendBillVarauscb.Enabled = true;
                                        sendBillVarauscb.Visible = true;
                                        billCreatedVarauslbl.Visible = false;
                                        addPalveluVarausbtn.Enabled = true;
                                        editPalveluVarausbtn.Enabled = true;
                                        deletePalveluVarausbtn.Enabled = true;
                                    }
                                }
                            }
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void editVarausbtn_Click(object sender, EventArgs e)
        {//olemassa olevan varauksen muokkaaminen, muokkausnappi toimii tallennusnappina
            try
            { 
                if (varausIDtb.Text == "" || asiakasIDVaraustb.Text == "" || mokkiIDVaraustb.Text == "" 
                    || reservedVarausdtp.Value == reservedVarausdtp.MinDate || confirmedVarausdtp.Value == confirmedVarausdtp.MinDate
                    || firstDayVarausdtp.Value == firstDayVarausdtp.MinDate || lastDayVarausdtp.Value == lastDayVarausdtp.MinDate)
                {
                    MessageBox.Show("Täytä kaikki tiedot ennen varauksen muokkaamista.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (firstDayVarausdtp.Value.Date >= lastDayVarausdtp.Value.Date || firstDayVarausdtp.Value.Date <= DateTime.Now.Date)
                {//varauksen loppupäivä ei voi olla aloituspäivää pienempi, minimivaraus on 1 yö, eikä uusia varauksia voi tehdä menneisyyteen


                    if (firstDayVarausdtp.Value.Date > lastDayVarausdtp.Value.Date)
                    {
                        MessageBox.Show("Varauksen loppumispäivä virheellinen.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (firstDayVarausdtp.Value.Date == DateTime.Now.Date)
                    {
                        MessageBox.Show("Varauksen muokkaaminen täytyy tehdä viimeistään varauksen alkamista edeltävänä päivänä.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (firstDayVarausdtp.Value.Date == lastDayVarausdtp.Value.Date)
                    {
                        MessageBox.Show("Varauksen vähimmäiskesto on 1 yö.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Varausta ei voi tehdä menneisyyteen.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    bool onnistuiko;
                    long id;

                    using (dbcontext = new databaseContext())
                    {
                        editedBooking = dbcontext.Varaus.Where(v => v.VarausId == editedBooking.VarausId).FirstOrDefault();
                        isAlreadyBooked = new Varaus();

                        onnistuiko = long.TryParse(asiakasIDVaraustb.Text, out id);
                        if (onnistuiko)
                        {
                            editedBooking.AsiakasId = id;
                        }

                        onnistuiko = long.TryParse(mokkiIDVaraustb.Text, out id);
                        if (onnistuiko)
                        {
                            editedBooking.MokkiMokkiId = id;
                        }

                        string pvm; 

                        pvm = reservedVarausdtp.Value.ToString("yyyy-MM-dd");
                        editedBooking.VarattuPvm = DateTime.Parse(pvm);

                        pvm = confirmedVarausdtp.Value.ToString("yyyy-MM-dd");
                        editedBooking.VahvistusPvm = DateTime.Parse(pvm);

                        pvm = firstDayVarausdtp.Value.ToString("yyyy-MM-dd");
                        editedBooking.VarattuAlkupvm = DateTime.Parse(pvm);

                        pvm = lastDayVarausdtp.Value.ToString("yyyy-MM-dd");
                        editedBooking.VarattuLoppupvm = DateTime.Parse(pvm);

                            

                        DialogResult dialogresult = MessageBox.Show("Haluatko varmasti muokata varausta?", "Confimation", MessageBoxButtons.YesNo);

                        if (dialogresult == DialogResult.Yes)
                        {

                            //Vielä päällekkäisten varausten tarkistus tähän
                            bool onkoVarattu = DateCheck(editedBooking);

                            if (onkoVarattu == true)
                            {
                                MessageBox.Show("Valitsemasi mökki on jo varattu kyseisenä ajankohtana.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                //jos päällekkäisiä varauksia ei löytynyt

                                dbcontext.Update(editedBooking);
                                dbcontext.SaveChanges();
                                MessageBox.Show("Varaustietoja muokattu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                            }
                        }
                        else if (dialogresult == DialogResult.No)
                        {
                            MessageBox.Show("Varaustietoja ei muokattu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteVarausbtn_Click(object sender, EventArgs e)
        {//asiakkaan peruman varauksen poistaminen
            try//HUOM! PALVELUT PITÄÄ POISTAA ENSIN; JOTTA VARAUKSEN PYSTYY POISTAMAAN.
            {
                deletedBooking = new Varaus();

                //kun sopiva varaus on valittu, sen voi poistaa. Haetaan varausid tekstikentästä
                //huom! tekstikentästä pystyy vain lukemaan varauksia -> kun varaus on valittu, niin sen id tulee luettavaksi tekstikenttään
                if (varausIDtb.Text != "")
                {  
                    using (dbcontext = new databaseContext())
                    {
                        bool onnistuiko = long.TryParse(varausIDtb.Text, out long Poistaid);
                        if(onnistuiko)
                        {
                            deletedBooking.VarausId = Poistaid;
                            deletedBooking = dbcontext.Varaus.Where(v => v.VarausId == deletedBooking.VarausId).FirstOrDefault();

                            DialogResult dialogresult = MessageBox.Show("Haluatko varmasti poistaa varauksen?", "Confirmation", MessageBoxButtons.YesNo);

                            if (dialogresult == DialogResult.Yes)
                            {
                                dbcontext.Remove(deletedBooking);
                                dbcontext.SaveChanges();
                                MessageBox.Show("Varaus poistettu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                            }
                            else if (dialogresult == DialogResult.No)
                            {
                                MessageBox.Show("Varaus säilytetään järjestelmässä toistaiseksi.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Valitse ensin varaus, jonka haluat poistaa.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Poista ensin kaikki varauksen palvelut, jotta voit poistaa varauksen.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void sendBillVarauscb_CheckedChanged(object sender, EventArgs e)
        {//laskun muodostaminen toteutuneesta varauksesta
            try
            {
                if(sendBillVarauscb.Checked == true)
                {
                    if (varausIDtb.Text != "")
                    {
                        DialogResult dialogresult = MessageBox.Show("Haluatko varmasti muodostaa varauksesta laskun?", "Confirmation", MessageBoxButtons.YesNo);

                        if (dialogresult == DialogResult.Yes)
                        {

                            //muodosta & lähetä lasku
                            using (dbcontext = new databaseContext())
                            {
                                newBill = new Lasku();
                                bool onnistuiko = long.TryParse(varausIDtb.Text, out long varausID);

                                if (onnistuiko)
                                {
                                    newBill.VarausId = varausID;

                                    //haetaan kaikki varauksen palvelut, joissa on sama varausid (ja niiden lukumäärä). 
                                    //Haetaan myös mökin hinta ja kerrotaan se ajalla. Sitten lasketaan varaukselle hinta

                                    double mokinhinta = 0;
                                    double mokinalv = 0;
                                    double kokohinta = 0;
                                    double kokoalv = 0;

                                    //haetaan varaus, josta ollaan tekemässä laskua
                                    editedBooking = new Varaus();
                                    editedBooking.VarausId = varausID;
                                    editedBooking = dbcontext.Varaus.Where(v => v.VarausId == editedBooking.VarausId).FirstOrDefault();

                                    //haetaan kyseinen mökki, joka sis. varaukseen
                                    mokki = new Mokki();
                                    mokki.MokkiId = editedBooking.MokkiMokkiId;
                                    mokki = dbcontext.Mokkis.Where(m => m.MokkiId == mokki.MokkiId).FirstOrDefault();

                                    //Montako yötä oltiin mökissä 
                                    TimeSpan ts;
                                    int aika;
                                    ts = editedBooking.VarattuLoppupvm.Value - editedBooking.VarattuAlkupvm.Value;
                                    aika = (int)ts.Days;

                                    //mökin koko hinta(sis alv) + alv 
                                    mokinhinta = aika * mokki.Hinta;
                                    mokinalv = mokinhinta - (0.92 * mokinhinta);
                                    
                                    //haetaan kaikki palvelut, mitä varauksella oli
                                    foreach(VarauksenPalvelut vp in dbcontext.VarauksenPalveluts)
                                    {
                                        if(vp.VarausId == varausID)
                                        {
                                            kaikkipalvelut.Add(vp);
                                        }
                                    }

                                    double palvelunhinta = 0;
                                    double palvelunalv = 0;
                                    long palvelunlkm = 0;

                                    //lasketaan varauksen kaikkien palveluiden summat(sis alv) ja alv
                                    foreach(VarauksenPalvelut vp in kaikkipalvelut)
                                    {
                                        palvelu = new Palvelu();
                                        palvelu.PalveluId = vp.PalveluId;
                                        palvelu = dbcontext.Palvelus.Where(p => p.PalveluId == palvelu.PalveluId).FirstOrDefault();

                                        palvelunlkm = vp.Lkm;
                                        palvelunhinta += palvelu.Hinta * palvelunlkm;
                                        palvelunalv += palvelu.Alv * palvelunlkm;
                                    }

                                    //Näiden perusteella annetaan varaukselle hinta
                                    newBill.Summa = palvelunhinta + mokinhinta;
                                    newBill.Alv = palvelunalv + mokinalv;
                                    newBill.Tila = "Sent";

                                    dbcontext.Laskus.Add(newBill);
                                    dbcontext.SaveChanges();
                                    MessageBox.Show("Lasku muodostettu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadData();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Laskua ei muodostettu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {   
                        MessageBox.Show("Valitse ensin varaus, josta haluat muodostaa laskun.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                    }

                    sendBillVarauscb.Checked = false;
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void emptyVarausbtn_Click(object sender, EventArgs e)
        {//jotta saadaan syötettyä uusia tietoja vanhojen varauksien tarkastelun jälkeen

            asiakasIDVaraustb.ReadOnly = false;
            asiakasIDVaraustb.Enabled = true;
            mokkiIDVaraustb.ReadOnly = false;
            mokkiIDVaraustb.Enabled = true;
            reservedVarausdtp.Enabled = true;
            confirmedVarausdtp.Enabled = true;
            firstDayVarausdtp.Enabled = true;
            lastDayVarausdtp.Enabled = true;
            editVarausbtn.Enabled = true;
            deleteVarausbtn.Enabled = true;
            sendBillVarauscb.Enabled = true;
            sendBillVarauscb.Visible = true;
            billCreatedVarauslbl.Visible = false;
            addPalveluVarausbtn.Enabled = true;
            editPalveluVarausbtn.Enabled = true;
            deletePalveluVarausbtn.Enabled = true;

            varausIDtb.Text = null;
            asiakasIDVaraustb.Text = null;
            mokkiIDVaraustb.Text = null;
            reservedVarausdtp.Value = DateTime.Now;
            confirmedVarausdtp.Value = DateTime.Now;
            firstDayVarausdtp.Value = DateTime.Now;
            lastDayVarausdtp.Value = DateTime.Now;

            //palvelut
            palvelunNimiVarausCmb.Text = null;
            palveluLkmVarausNud.Value = 0;


            //päivitetään vielä varauksen palveluiden mahdollisesti valittavat vaihtoehdot
            using (dbcontext = new databaseContext())
            {
                palvelunNimiVarausCmb.Items.Clear(); //tyhjätään, ettei tule montaa kertaa
                palvelunNimi = dbcontext.Palvelus.ToList();

                //haetaan palveluiden nimet ja laitetaan esille
                for (var i = 0; i < palvelunNimi.Count; i++)
                {
                    palvelunNimiVarausCmb.Items.Add("ID: " + palvelunNimi[i].PalveluId + " ;  " + palvelunNimi[i].Nimi);
                }
            }
 
        }
       

        private void addPalveluVarausbtn_Click(object sender, EventArgs e)
        {//lisätään varaukseen palveluita 
         //samaa palvelua ei voi liittää samaan varaukseen montaa kertaa :) palvelua ei voi myöskään lisätä, jos varausta ei ole olemassa

            try
            {
                //huom! pitää tarkistaa, että on varaus, johon palvelua yritetään laittaa
                if (varausIDtb.Text == "")
                {
                    MessageBox.Show("Valitse ensin varaus, johon haluat liittää palveluita.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if ( palvelunNimiVarausCmb.Text == "" || palveluLkmVarausNud.Value == 0)
                {
                    MessageBox.Show("Anna palvelu ja palvelun lukumäärä.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using (dbcontext = new databaseContext())
                    {
                        varauksenpalvelu = new VarauksenPalvelut();

                        string id = haeId();

                        varauksenpalvelu.VarausId = long.Parse(varausIDtb.Text);
                        varauksenpalvelu.PalveluId = long.Parse(id);
                        varauksenpalvelu.Lkm = (long)palveluLkmVarausNud.Value;

                        //katsotaan, onko samaa palvelua annettu jo varaukselle
                        samapalvelu = new VarauksenPalvelut();
                        samapalvelu = dbcontext.VarauksenPalveluts.Where(s => s.PalveluId == varauksenpalvelu.PalveluId && s.VarausId == varauksenpalvelu.VarausId).FirstOrDefault();

                        if(samapalvelu == null)//jos samaa palvelua ei ole
                        {
                            dbcontext.VarauksenPalveluts.Add(varauksenpalvelu);
                            dbcontext.SaveChanges();
                            MessageBox.Show("Palvelu lisätty varaukseen.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Varauksella on jo valitsemasi palvelu. \n Voit muokata tai poistaa palvelun.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editPalveluVarausbtn_Click(object sender, EventArgs e)
        {//tietyn varauksen palveluiden muokkaus

            try
            {


                if (varausIDtb.Text == "") //jos ollaan klikattu suoraan palvelua, eikä varausta ole valittu ensin
                {
                    MessageBox.Show("Valitse ensin varaus, jonka palveluita haluat muokata.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (palvelunNimiVarausCmb.Text == "" || palveluLkmVarausNud.Value == 0)
                {
                    if(palvelunNimiVarausCmb.Text == "")
                    {
                        MessageBox.Show("Valitse palvelu, jota haluat muokata.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Anna palvelun lukumäärä.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    using (dbcontext = new databaseContext())
                    {
                        varauksenpalvelu.VarausId = long.Parse(varausIDtb.Text);
                        string id = haeId();
                        varauksenpalvelu.PalveluId = long.Parse(id);

                        varauksenpalvelu = dbcontext.VarauksenPalveluts.Where(v => v.VarausId == varauksenpalvelu.VarausId && v.PalveluId == varauksenpalvelu.PalveluId).FirstOrDefault();

                            
                        varauksenpalvelu.Lkm = (long)palveluLkmVarausNud.Value;

                        
                        DialogResult dialogresult = MessageBox.Show("Haluatko varmasti muokata varauksen palvelua?", "Confirmation", MessageBoxButtons.YesNo);

                        if (dialogresult == DialogResult.Yes)
                        {
                            dbcontext.Update(varauksenpalvelu);
                            dbcontext.SaveChanges();
                            MessageBox.Show("Varauksen palvelua muokattu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);                                LoadData();
                        }
                        else if (dialogresult == DialogResult.No)
                        {
                            MessageBox.Show("Varauksen palvelua ei muokattu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletePalveluVarausbtn_Click(object sender, EventArgs e)
        {//poistetaan varauksesta palveluita

            try
            {
                deletedvarauksenpalvelu = new VarauksenPalvelut();

                //kun palvelu on valittu, sen voi poistaa. Haetaan varausid tekstikentästä ja poistettavan palvelun id ja lkm
                //huom! pitää valita ensin varaus ja sitten poistettava palvelu. Palvelua ei siis voi poistaa ns. "yleisnäkymästä"


                if (varausIDtb.Text != "" && palvelunNimiVarausCmb.Text != "" && palveluLkmVarausNud.Value != 0) 
                {
                    using (dbcontext = new databaseContext())
                    {
                        string id = haeId();

                        bool onnistuiko = long.TryParse(id, out long Poistaid);
                        if (onnistuiko)
                        {
                            deletedvarauksenpalvelu.VarausId = long.Parse(varausIDtb.Text);
                            deletedvarauksenpalvelu = dbcontext.VarauksenPalveluts.Where(p => p.PalveluId == Poistaid && p.VarausId == deletedvarauksenpalvelu.VarausId).FirstOrDefault();

                            DialogResult dialogresult = MessageBox.Show("Haluatko varmasti poistaa palvelun varauksesta?", "Confirmation", MessageBoxButtons.YesNo);

                            if (dialogresult == DialogResult.Yes)
                            {
                                dbcontext.Remove(deletedvarauksenpalvelu);
                                dbcontext.SaveChanges();
                                MessageBox.Show("Palvelu poistettu varauksesta.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData();
                            }
                            else if (dialogresult == DialogResult.No)
                            {
                                MessageBox.Show("Palvelu sisältyy varaukseen toistaiseksi.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                }
                else
                {//jos ollaan klikattu suoraan palvelua, eikä varausta ole valittu ensin
                    MessageBox.Show("Valitse ensin varaus ja poistettava palvelu.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void varauksenPalvelutdgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (varauksenPalvelutdgv.CurrentRow.Index != -1)
                {
                    if (e.RowIndex != -1)
                    {
                        using (dbcontext = new databaseContext())
                        {
                            varauksenpalvelu = new VarauksenPalvelut();

                            DataGridViewRow row = varauksenPalvelutdgv.Rows[e.RowIndex];

                            long palveluId;
                            long varausId = long.Parse(row.Cells[0].Value.ToString());
                            bool onnistuiko = long.TryParse(row.Cells[1].Value.ToString(), out palveluId);
                            if (onnistuiko)
                            {
                                //haetaan palvelu datagridview:stä textboxeihin näkyviin

                                varauksenpalvelu = dbcontext.VarauksenPalveluts.Where(p => p.VarausId == varausId && p.PalveluId == palveluId).FirstOrDefault();

                                palveluLkmVarausNud.Value = varauksenpalvelu.Lkm;

                                //haetaan palvelun ja palveluid:n avulla palvelulle nimi
                                palvelu = new Palvelu();


                                palvelu = dbcontext.Palvelus.Where(p => p.PalveluId == palveluId).FirstOrDefault();
                                palvelunNimiVarausCmb.Text = "ID: " + palveluId + " ;  " + palvelu.Nimi.ToString();

                            }
                        }
                    }
                       
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string haeId()
        {//haetaan palvelun id palvelun nimestä

            string nimi = palvelunNimiVarausCmb.Text;
            string id = "";

            for (var i = 0; i < nimi.Length; i++)
            {
                char merkki = nimi[i];
                if (char.IsNumber(merkki))
                {
                    id += merkki;
                }
                else if (merkki == ';')//siltä varalta, että palvelun nimessä on tekstiä, niin käytetään tätä erottamaan id muista numeroista
                {
                    i = nimi.Length;
                }
            }

            return id;
        }

        private bool DateCheck(Varaus booking)
        {
            
           // tänne ei tule using dbcontextia, sillä sitä käytetään jo
            
           //Vielä päällekkäisten varausten tarkistus tähän: haetaan ensin kaikki varaukset

           List<Varaus> kaikkivaraukset = dbcontext.Varaus.ToList();
           bool onkoVarattu = false;

            for (var i = 0; i < kaikkivaraukset.Count; i++)
            {//käydään kaikki varaukset läpi
                isAlreadyBooked = kaikkivaraukset[i];

                if (booking.VarausId != isAlreadyBooked.VarausId)
                {
                    if (isAlreadyBooked.MokkiMokkiId == booking.MokkiMokkiId)
                    {//jos mökkiId on sama, niin katsotaan onko varausten päivät samoja

                        DateTime d1 = new DateTime();
                        TimeSpan span = new TimeSpan(1, 0, 0, 0); //aikaväli 1 pv

                        /*Riittää kun tutkitaan seuraavasti:
                         1) ovatko varauksen päivät täsmälleen samat
                         2) onko valitun varauksen aloituspvm aiemmin varatun ajanjakson sisällä
                         3) onko aiemman varauksen aloituspvm myöhemmin varatun ajanjakson sisällä
                         Täällä käydään läpi sitä, onko valitun varauksen aloituspvm sama kuin mikään vanhojen varauksien ns. alku- tai välipäivistä*/

                        //jos varauksien alkupäivämäärät ovat samat
                        if (isAlreadyBooked.VarattuAlkupvm.Value == booking.VarattuAlkupvm.Value)
                        {
                            onkoVarattu = true;
                            i = kaikkivaraukset.Count;
                        }
                        else if (isAlreadyBooked.VarattuAlkupvm.Value < booking.VarattuAlkupvm.Value)
                        {//jos aiempi varaus ti-pe välillä ja toinen perhe yrittää tulla paikalle esim to

                            for (d1 = isAlreadyBooked.VarattuAlkupvm.Value; d1 <= isAlreadyBooked.VarattuLoppupvm.Value; d1 = d1.Add(span))
                            {
                                if (d1 == booking.VarattuAlkupvm.Value)
                                {
                                    onkoVarattu = true;
                                    i = kaikkivaraukset.Count;
                                    d1 = isAlreadyBooked.VarattuLoppupvm.Value;
                                }

                            }
                        }
                        else if (isAlreadyBooked.VarattuAlkupvm.Value > booking.VarattuAlkupvm.Value)
                        {//jos uusi varaus esim ti-pe välillä ja vanha varaus alkaa esim saman viikon ke

                            for (d1 = booking.VarattuAlkupvm.Value; d1 <= booking.VarattuLoppupvm.Value; d1 = d1.Add(span))
                            {
                                if (d1 == isAlreadyBooked.VarattuAlkupvm.Value)
                                {
                                    onkoVarattu = true;
                                    i = kaikkivaraukset.Count;
                                    d1 = booking.VarattuLoppupvm.Value;
                                }
                            }

                        }
                    }
                }
            }

                return onkoVarattu;
            
        }
    }
}
