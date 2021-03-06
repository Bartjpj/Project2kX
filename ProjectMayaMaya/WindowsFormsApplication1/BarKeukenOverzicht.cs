﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class BarKeukenOverzicht : Form
    {
        BestellingenDAO bestellingenDAO;
        List<MenuItem> bestellingslijst = new List<MenuItem>();
        private int tafelNr;
        private bool barView;
        int i = 0;
       
        protected override void OnLoad(EventArgs e) // is de verwijzing, niets veranderen AUB 
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }

        public BarKeukenOverzicht(BestellingenDAO bestellingenDAO, bool barView) // geef een bestellingDAO als constructor mee.
        {
           InitializeComponent();
           this.barView = barView;
           this.bestellingenDAO = bestellingenDAO; // zet BarOverzichtDAO gelijk aan de BarOverzichtDAO object in de class

           if (barView)
           {
               this.Text = "Baroverzicht";
           }
           else
           {
               this.Text = "Keukenoverzicht";
           }

           bestellingslijst = bestellingenDAO.haalMenuItems(barView, true); // haal de bestelling op
           DisplayBestellingen(); // methode die de bestellingen displayed in the listview
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tafelNr = Int32.Parse(btn.Text.Substring(5).Trim()); // button in flowpanel wordt getrimmed de tekst tafel wordt eraf gehaald en je houdt een nummer over die wordt in de variabele tafelNr gestopt

            // ... moet de parameter tafelNr meegeven aan de Dao zodat een query gemaakt kan worden om deze specifieke tafel op te halen
            listView1.Items.Clear();

            List<MenuItem> items = bestellingenDAO.haalBestellingTafel(tafelNr, barView);
           // parameter wordt hier meegegeven aan Dao zodat er per tafel de bestellingen opgehaald kunnen worden.
            i = 0;
            foreach (MenuItem barKeukenOverzicht in items)
            {
               
                voegListViewItemsToe(barKeukenOverzicht,i);// het barOverzicht object wordt hier aan de methode voegListVietItemsToe meegegeven zodat de items in de listview kunnen komen.

                i++;
            
            }
        }

        private void btn_BARnaarHM_Click(object sender, EventArgs e)
        {

            InlogSchermBediening TerugNaarInlogscherm = new InlogSchermBediening();

            TerugNaarInlogscherm.Show();
            TerugNaarInlogscherm.Left = this.Left; // geeft de grote aan van deze form voor het te openen form
            TerugNaarInlogscherm.Top = this.Top;
            TerugNaarInlogscherm.Size = this.Size;
            this.Hide();
        }
        

        private void voegListViewItemsToe(MenuItem menuItem, int i)
        {
          
            
            ListViewItem lijstItem = new ListViewItem(menuItem.tafel_id.ToString());
            lijstItem.SubItems.Add(menuItem.naam.ToString());
            lijstItem.SubItems.Add(menuItem.aantal.ToString());
            lijstItem.SubItems.Add(menuItem.datum_tijd.ToString());
            if (i == 0)
            {
                lijstItem.SubItems.Add(menuItem.opmerking);
            }
            else
            {
                lijstItem.SubItems.Add("");
            }
            listView1.Items.Add(lijstItem);
        } // methode om listviewItems toe te voegen 
       
        private void DisplayBestellingen()
        {
            listView1.Items.Clear();
            i = 0;
            foreach (MenuItem barKeukenOverzicht in this.bestellingslijst)
            {
                voegListViewItemsToe(barKeukenOverzicht,i);
                i++;

            }
            createTafels();
        } // methode om de bestellingen te laten zien


        private void btn_BestellingGereed_Click(object sender, EventArgs e)
        {
     
            for (int i = listView1.Items.Count - 1; i >= 0; i--) // selecteer eerste item van listview indien geklikt op button in flowpanel om vervolgens te verwijderen
            {
                if (listView1.Items[i].Selected)// als listview item selected dan verwijderen op moment dat er geklikt wordt.
                {
                    listView1.Items[i].Remove();
                }
            }
            // update tafel in dao
            bestellingenDAO.updateTafelsGereed(tafelNr,barView); 
            bestellingslijst = bestellingenDAO.haalMenuItems(barView, true); // vul de bestelling lijst opnieuw
            DisplayBestellingen(); // laat bestelling weer zien

        } // gereedknop om bestelling gereed te melden en de listview te legen. Indien bestelling gereed.

        private void btn_refresh_Click(object sender, EventArgs e) // refresh button, hier wordt de hele lijst van openstaande bestellingen voor de bar opgehaald uit de database. Deze worden vervolgens in de listview gezet.
        {
            // vul de bestelling lijst opnieuw
            bestellingslijst = bestellingenDAO.haalMenuItems(barView, true); 
            DisplayBestellingen(); // laat bestelling weer zien
        }
 
        private void createTafels() // methode om de tafels in het flowpanel te weergeven.
        {
            List<int> tafelNummers = bestellingenDAO.haalTafelNrOp(barView); // haalt de tafelnr's op uit de database en stopt ze in een list van tafelnummers
            List<int> tafelNummersDistinct = tafelNummers.Distinct().ToList(); // zorgt ervoor dat er geen dubbele tafelnummers in de flowpanel zitten en stopt die weer in een nieuwe lijst
            lopendeBestellingTafels.Controls.Clear(); // cleared eerst de hele flowpanel
            foreach (int tafelNummer in tafelNummersDistinct) 
            {
                // maakt per tafelnummer die is opgehaald in de database een button aan waar op geklikt kan worden.
                Button b = new Button();
                b.Tag = tafelNummer;
                b.Name = "Tafel " + tafelNummer.ToString();
                b.Text = "Tafel " + tafelNummer.ToString();
                b.BackColor = ColorTranslator.FromHtml("#571128");
                b.AutoSize = false;
                b.Click += new EventHandler(button_Click);
                lopendeBestellingTafels.Controls.Add(b);
            }
        }

        private void btn_dagoverzicht_Click(object sender, EventArgs e) // button om het gehele dagoverzicht van alle bestellingen te zien van de afgelopen 24 uur.
        {

            listView1.Items.Clear();
            i = 0;
            foreach (MenuItem barKeukenOverzicht in bestellingenDAO.haalMenuItems(barView, false))
            {
                voegListViewItemsToe(barKeukenOverzicht, i);
                i++;
            }
           
        }

        private void BarOverzicht_Load(object sender, EventArgs e)
        {

        }

    
       


}
}
