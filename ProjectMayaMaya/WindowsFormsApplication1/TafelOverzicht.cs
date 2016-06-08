﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TafelOverzicht : Form
    {
        protected override void OnLoad(EventArgs e) // is de verwijzing voor de grootte van de form, niets veranderen AUB
        {
            //base.OnLoad(e);
            //this.Location = Owner.Location;
            //this.Size = Owner.Size;
        }
        TafelOverzichtDAO TafelOverzichtDAO;
        List<TafelOverzichtClass> tafellijst = new List<TafelOverzichtClass>();

        BestellingOpnemen start;

        public TafelOverzicht()
        {
            InitializeComponent();
        }

        private void btn_TAFELnaarHM_Click(object sender, EventArgs e)
        {
            HoofdMenu TerugNaarHoofdmenu = new HoofdMenu();
            TerugNaarHoofdmenu.Show();
            TerugNaarHoofdmenu.Left = this.Left;
            TerugNaarHoofdmenu.Top = this.Top;
            TerugNaarHoofdmenu.Size = this.Size;
        }

        private void rbtn_BestellingOpnemen_CheckedChanged(object sender, EventArgs e)
        {

        }
        //public void button1_Click(object sender, EventArgs e)
        //{
        //    foreach (TafelOverzichtClass TafelOverzicht in TafelOverzichtDAO.haalTafelOverzicht_TabelOp())
        //    {

        //        ListViewItem lijstitem = new ListViewItem(TafelOverzicht.TafelId.ToString());
        //        lijstitem.SubItems.Add(TafelOverzicht.TafelId.ToString());
        //        lijstitem.SubItems.Add(TafelOverzicht.Bezet.ToString());
        //        listView_tafeloverzicht.Items.Add(lijstitem);

        //    }
        //}
        //-----------------TAFELS--------------------------------:
        // BestellingMenu bestellingmenuActiveren = new BestellingMenu();

        int tafelgetal;
        //1
        public void btn_Tafel1_Click(object sender, EventArgs e)
        {
            maakTimer1();
            tafelgetal = 1;
        }
        public void maakTimer1()
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);
            
            ////maak een timer aan.
            //System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();
            //t1.Interval = 1000;
            //t1.Tick += new EventHandler(t1_Tick);
            ////t1.Start();
        }

        public void startTimerEcht(bool start, System.Windows.Forms.Timer t1)
        {
            if (start == true)
            {
                t1.Start();
            }
        }

        //2
        public void btn_Tafel2_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);

        }

        //3
        public void btn_Tafel3_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);

        }

        //4
        public void btn_Tafel4_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);

        }

        //5
        public void btn_Tafel5_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);

        }

        //6
        public void btn_Tafel6_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);

        }

        //7
        public void btn_Tafel7_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);

        }

        //8
        public void btn_Tafel8_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);

        }

        //9
        public void btn_Tafel9_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);

        }

        //10
        public void btn_Tafel10_Click(object sender, EventArgs e)
        {
            KiesOpname openKiesopname = new KiesOpname();
            openKiesopname.Show(this);

        }
        //---------------TIMERS-------------------------:
        //zetten van int voor de timer


        public void lbl_tijdtafel1_Click(object sender, EventArgs e)
        {
        }

        public void Tafel1kleur(bool bezett1, bool tafelkleurt1)
        {

        }

    }
}
