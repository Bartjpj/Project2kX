﻿namespace WindowsFormsApplication1
{
    partial class BarOverzicht
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_OpenstaandeBestellingenKeuken = new System.Windows.Forms.Label();
            this.Bestelling_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_BARnaarHM = new System.Windows.Forms.Button();
            this.btn_BestellingGereed = new System.Windows.Forms.Button();
            this.lb_Baroverzicht = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_OpenstaandeBestellingenKeuken
            // 
            this.lbl_OpenstaandeBestellingenKeuken.AutoSize = true;
            this.lbl_OpenstaandeBestellingenKeuken.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OpenstaandeBestellingenKeuken.Location = new System.Drawing.Point(263, 88);
            this.lbl_OpenstaandeBestellingenKeuken.Name = "lbl_OpenstaandeBestellingenKeuken";
            this.lbl_OpenstaandeBestellingenKeuken.Size = new System.Drawing.Size(237, 24);
            this.lbl_OpenstaandeBestellingenKeuken.TabIndex = 1;
            this.lbl_OpenstaandeBestellingenKeuken.Text = "Openstaande Bestellingen:";
            // 
            // Bestelling_id
            // 
            this.Bestelling_id.Text = "Bestelling_id";
            // 
            // btn_BARnaarHM
            // 
            this.btn_BARnaarHM.Location = new System.Drawing.Point(12, 12);
            this.btn_BARnaarHM.Name = "btn_BARnaarHM";
            this.btn_BARnaarHM.Size = new System.Drawing.Size(128, 46);
            this.btn_BARnaarHM.TabIndex = 2;
            this.btn_BARnaarHM.Text = "Terug naar Hoofdmenu";
            this.btn_BARnaarHM.UseVisualStyleBackColor = true;
            this.btn_BARnaarHM.Click += new System.EventHandler(this.btn_BARnaarHM_Click);
            // 
            // btn_BestellingGereed
            // 
            this.btn_BestellingGereed.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_BestellingGereed.ForeColor = System.Drawing.Color.Black;
            this.btn_BestellingGereed.Location = new System.Drawing.Point(555, 405);
            this.btn_BestellingGereed.Name = "btn_BestellingGereed";
            this.btn_BestellingGereed.Size = new System.Drawing.Size(154, 45);
            this.btn_BestellingGereed.TabIndex = 5;
            this.btn_BestellingGereed.Text = "Gereed";
            this.btn_BestellingGereed.UseVisualStyleBackColor = false;
            this.btn_BestellingGereed.Click += new System.EventHandler(this.btn_BestellingGereed_Click);
            // 
            // lb_Baroverzicht
            // 
            this.lb_Baroverzicht.FormattingEnabled = true;
            this.lb_Baroverzicht.Location = new System.Drawing.Point(12, 141);
            this.lb_Baroverzicht.Name = "lb_Baroverzicht";
            this.lb_Baroverzicht.Size = new System.Drawing.Size(755, 225);
            this.lb_Baroverzicht.TabIndex = 6;
            this.lb_Baroverzicht.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // BarOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 463);
            this.Controls.Add(this.lb_Baroverzicht);
            this.Controls.Add(this.btn_BestellingGereed);
            this.Controls.Add(this.btn_BARnaarHM);
            this.Controls.Add(this.lbl_OpenstaandeBestellingenKeuken);
            this.Name = "BarOverzicht";
            this.Text = "BarOverzicht";
            this.Load += new System.EventHandler(this.BarOverzicht_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_OpenstaandeBestellingenKeuken;
        private System.Windows.Forms.ColumnHeader Bestelling_id;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btn_BARnaarHM;
        private System.Windows.Forms.Button btn_BestellingGereed;
        private System.Windows.Forms.ListBox lb_Baroverzicht;
    }
}