﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class BarOverzicht : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Location = Owner.Location;
            this.Size = Owner.Size;
        }
        public BarOverzicht()
        {
            InitializeComponent();
        }

        private void btn_BARnaarHM_Click(object sender, EventArgs e)
        {
            HoofdMenu TerugNaarHoofdmenu = new HoofdMenu();
            TerugNaarHoofdmenu.Show();
            TerugNaarHoofdmenu.Left = this.Left;
            TerugNaarHoofdmenu.Top = this.Top;
            TerugNaarHoofdmenu.Size = this.Size;
            this.Hide();
        }
    }
}