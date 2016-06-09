﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
   public class BestellingOpnemenDAO
    {


        public List<MenuItemsClass> haalMenuItemsOp(int categorie) // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Menuitem WHERE categorie_id = " + categorie, conn); // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();

            List<MenuItemsClass> DinerKaartTable = new List<MenuItemsClass>();

            while (reader.Read())
            {
                int menu_id = (int)reader["menu_id"];
                int categorie_id = (int)reader["categorie_id"];
                string naam = (string)reader["naam"];
                double prijs = (double)reader["prijs"];
                int voorraad = (int)reader["voorraad"];

                MenuItemsClass DinerKaartDAO = new MenuItemsClass(menu_id, categorie_id, naam, prijs, voorraad);
                DinerKaartTable.Add(DinerKaartDAO);
            }

            conn.Close();
            return DinerKaartTable;
        }

        public List<MenukaartClass> haalKaartenOp() // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Menukaart", conn); // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();

            List<MenukaartClass> KaartenTable = new List<MenukaartClass>();

            while (reader.Read())
            {
                int kaart_id = (int)reader["kaart_id"];
                string naam = (string)reader["naam"];

                MenukaartClass KaartenDAO = new MenukaartClass(kaart_id, naam);
                KaartenTable.Add(KaartenDAO);
            }

            conn.Close();
            return KaartenTable;
        }


        public List<MenucategorieClass> haalCategorieOp(int kaart) // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT categorie_id, kaart_id, naam FROM Menucategorie WHERE kaart_id = " + kaart, conn); // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();

            List<MenucategorieClass> CategorieTable = new List<MenucategorieClass>();

            while (reader.Read())
            {
                int categorie_id = (int)reader["categorie_id"];
                int kaart_id = (int)reader["kaart_id"];
                string naam = (string)reader["naam"];

                MenucategorieClass CategorieDAO = new MenucategorieClass(categorie_id, kaart_id, naam);
                CategorieTable.Add(CategorieDAO);
            }

            conn.Close();
            return CategorieTable;
        }

        public List<int> haalBestellingIdOp()
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT bestelling_id FROM Bestelling", conn); // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();

            List<int> Bestellingen = new List<int>();

            while (reader.Read())
            {
                int bestelling_id = (int)reader["bestelling_id"];
                Bestellingen.Add(bestelling_id);
            }
            conn.Close();
            return Bestellingen;
        }



        public void VerstuurBestelling(List<int> Menu_ID, List<int> Aantal, int tafel, int BestellingID, DateTime actueleTijd, string opmerking, int personeel_id)
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            var IDenAantal = Menu_ID.Zip(Aantal, (id, aantal) => new { Menu_ID = id, Aantal = aantal }); //maak één lijst van 2 lijsten zodat je er met één foreach doorheen kan lopen.
            foreach (var idAantal in IDenAantal)
            {
                SqlCommand command = new SqlCommand("INSERT INTO Bestelling (bestelling_id, tafel_id, kaart_id, personeel_id, datum_tijd, keuken_gereed, bar_gereed, opmerking) VALUES (" + BestellingID + ", " + tafel + ", " + 1 + ", " + 1 + ", '" + actueleTijd + "', " + 0 + ", " + 0 + ", '" + opmerking + "');", conn); // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
                command.ExecuteNonQuery();
                SqlCommand command2 = new SqlCommand("INSERT INTO BestellingItems (BestellingId, ItemId, Aantal) VALUES (" + BestellingID + ", " + idAantal.Menu_ID + ", " + idAantal.Aantal + ");", conn);
                command2.ExecuteNonQuery();

            }
            conn.Close();
        }

        public void WijzigVoorraad(int menu_id, int aantal)
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("UPDATE Menuitem SET voorraad = voorraad - " + aantal + " WHERE menu_id = " + menu_id, conn); // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            command.ExecuteNonQuery();
            
            conn.Close();
        }



        public List<TafelOverzichtClass> haalTafelOp() // deze methode haalt de gegevens op voor het BestellingMenu overzicht
        {
            string connString = ConfigurationManager
            .ConnectionStrings["BestellingConnectionStringSQL"]
            .ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT bestelling_id FROM Bestelling", conn); // deze query zorgt ervoor dat we alle data hebben die we bij BestellingMenu nodig hebben 
            SqlDataReader reader = command.ExecuteReader();

            List<TafelOverzichtClass> TafelTable = new List<TafelOverzichtClass>();

            while (reader.Read())
            {
                int TafelId = (int)reader["TafelId"];
                bool Bezet = (bool)reader["Bezet"];

                TafelOverzichtClass TafelTableDAO = new TafelOverzichtClass(TafelId, Bezet);
                TafelTable.Add(TafelTableDAO);
            }

            conn.Close();
            return TafelTable;
        }
    }
}


