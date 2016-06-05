﻿namespace WindowsFormsApplication1
{
    partial class BestellingOpnemen
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dranken = new System.Windows.Forms.Button();
            this.btn_DINERnaarBESTELLING = new System.Windows.Forms.Button();
            this.listview_diner = new System.Windows.Forms.ListView();
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Voorraad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_stuurbestelling = new System.Windows.Forms.Button();
            this.btn_verwijderBestelling = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listview_huidige_bestelling = new System.Windows.Forms.ListView();
            this.bestelling = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aantal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.btn_lunch = new System.Windows.Forms.Button();
            this.btn_diner = new System.Windows.Forms.Button();
            this.flow_menuCategorie = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Bestelling opnemen";
            // 
            // btn_dranken
            // 
            this.btn_dranken.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_dranken.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dranken.ForeColor = System.Drawing.Color.White;
            this.btn_dranken.Location = new System.Drawing.Point(10, 64);
            this.btn_dranken.Name = "btn_dranken";
            this.btn_dranken.Size = new System.Drawing.Size(238, 52);
            this.btn_dranken.TabIndex = 55;
            this.btn_dranken.Text = "Dranken";
            this.btn_dranken.UseVisualStyleBackColor = false;
            this.btn_dranken.Click += new System.EventHandler(this.btn_LUNCHnaarDRANKEN_Click);
            // 
            // btn_DINERnaarBESTELLING
            // 
            this.btn_DINERnaarBESTELLING.BackColor = System.Drawing.Color.Maroon;
            this.btn_DINERnaarBESTELLING.ForeColor = System.Drawing.Color.White;
            this.btn_DINERnaarBESTELLING.Location = new System.Drawing.Point(10, 9);
            this.btn_DINERnaarBESTELLING.Name = "btn_DINERnaarBESTELLING";
            this.btn_DINERnaarBESTELLING.Size = new System.Drawing.Size(111, 49);
            this.btn_DINERnaarBESTELLING.TabIndex = 78;
            this.btn_DINERnaarBESTELLING.Text = "Terug naar Bestelling Menu";
            this.btn_DINERnaarBESTELLING.UseVisualStyleBackColor = false;
            this.btn_DINERnaarBESTELLING.Click += new System.EventHandler(this.btn_DINERnaarBESTELLING_Click);
            // 
            // listview_diner
            // 
            this.listview_diner.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam,
            this.Prijs,
            this.Voorraad});
            this.listview_diner.FullRowSelect = true;
            this.listview_diner.GridLines = true;
            this.listview_diner.Location = new System.Drawing.Point(10, 207);
            this.listview_diner.Name = "listview_diner";
            this.listview_diner.Size = new System.Drawing.Size(378, 238);
            this.listview_diner.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listview_diner.TabIndex = 81;
            this.listview_diner.UseCompatibleStateImageBehavior = false;
            this.listview_diner.View = System.Windows.Forms.View.Details;
            this.listview_diner.SelectedIndexChanged += new System.EventHandler(this.listview_diner_SelectedIndexChanged);
            // 
            // Voorraad
            // 
            this.Voorraad.Width = 53;
            // 
            // btn_stuurbestelling
            // 
            this.btn_stuurbestelling.BackColor = System.Drawing.Color.LightGreen;
            this.btn_stuurbestelling.Location = new System.Drawing.Point(672, 459);
            this.btn_stuurbestelling.Name = "btn_stuurbestelling";
            this.btn_stuurbestelling.Size = new System.Drawing.Size(93, 41);
            this.btn_stuurbestelling.TabIndex = 82;
            this.btn_stuurbestelling.Text = "Stuur Bestelling";
            this.btn_stuurbestelling.UseVisualStyleBackColor = false;
            // 
            // btn_verwijderBestelling
            // 
            this.btn_verwijderBestelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verwijderBestelling.Location = new System.Drawing.Point(405, 449);
            this.btn_verwijderBestelling.Name = "btn_verwijderBestelling";
            this.btn_verwijderBestelling.Size = new System.Drawing.Size(177, 50);
            this.btn_verwijderBestelling.TabIndex = 84;
            this.btn_verwijderBestelling.Text = "Verwijder hele bestelling";
            this.btn_verwijderBestelling.UseVisualStyleBackColor = true;
            this.btn_verwijderBestelling.Click += new System.EventHandler(this.btn_verwijderGerecht_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 85;
            this.label2.Text = "Dinerkaart Gerechten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(527, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 86;
            this.label3.Text = "Huidige bestelling";
            // 
            // listview_huidige_bestelling
            // 
            this.listview_huidige_bestelling.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bestelling,
            this.aantal});
            this.listview_huidige_bestelling.FullRowSelect = true;
            this.listview_huidige_bestelling.GridLines = true;
            this.listview_huidige_bestelling.Location = new System.Drawing.Point(393, 207);
            this.listview_huidige_bestelling.Name = "listview_huidige_bestelling";
            this.listview_huidige_bestelling.Size = new System.Drawing.Size(378, 238);
            this.listview_huidige_bestelling.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listview_huidige_bestelling.TabIndex = 87;
            this.listview_huidige_bestelling.UseCompatibleStateImageBehavior = false;
            this.listview_huidige_bestelling.View = System.Windows.Forms.View.Details;
            this.listview_huidige_bestelling.SelectedIndexChanged += new System.EventHandler(this.listview_huidige_bestelling_SelectedIndexChanged);
            // 
            // bestelling
            // 
            this.bestelling.Text = "Bestelling";
            this.bestelling.Width = 300;
            // 
            // aantal
            // 
            this.aantal.Text = "Aantal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 30);
            this.button1.TabIndex = 88;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_lunch
            // 
            this.btn_lunch.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_lunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lunch.ForeColor = System.Drawing.Color.White;
            this.btn_lunch.Location = new System.Drawing.Point(527, 64);
            this.btn_lunch.Name = "btn_lunch";
            this.btn_lunch.Size = new System.Drawing.Size(241, 52);
            this.btn_lunch.TabIndex = 96;
            this.btn_lunch.Text = "Lunch";
            this.btn_lunch.UseVisualStyleBackColor = false;
            // 
            // btn_diner
            // 
            this.btn_diner.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_diner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_diner.ForeColor = System.Drawing.Color.White;
            this.btn_diner.Location = new System.Drawing.Point(268, 64);
            this.btn_diner.Name = "btn_diner";
            this.btn_diner.Size = new System.Drawing.Size(238, 52);
            this.btn_diner.TabIndex = 97;
            this.btn_diner.Text = "Diner";
            this.btn_diner.UseVisualStyleBackColor = false;
            // 
            // flow_menuCategorie
            // 
            this.flow_menuCategorie.Location = new System.Drawing.Point(10, 123);
            this.flow_menuCategorie.Name = "flow_menuCategorie";
            this.flow_menuCategorie.Size = new System.Drawing.Size(758, 57);
            this.flow_menuCategorie.TabIndex = 98;
            // 
            // DinerKaart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 502);
            this.Controls.Add(this.flow_menuCategorie);
            this.Controls.Add(this.btn_diner);
            this.Controls.Add(this.btn_lunch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listview_huidige_bestelling);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_verwijderBestelling);
            this.Controls.Add(this.listview_diner);
            this.Controls.Add(this.btn_stuurbestelling);
            this.Controls.Add(this.btn_DINERnaarBESTELLING);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dranken);
            this.Name = "DinerKaart";
            this.Text = "DinerKaart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dranken;
        private System.Windows.Forms.Button btn_DINERnaarBESTELLING;
        private System.Windows.Forms.ListView listview_diner;
        private System.Windows.Forms.Button btn_stuurbestelling;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Prijs;
        private System.Windows.Forms.ColumnHeader Voorraad;
        private System.Windows.Forms.Button btn_verwijderBestelling;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listview_huidige_bestelling;
        private System.Windows.Forms.ColumnHeader bestelling;
        private System.Windows.Forms.ColumnHeader aantal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_lunch;
        private System.Windows.Forms.Button btn_diner;
        private System.Windows.Forms.FlowLayoutPanel flow_menuCategorie;
    }
}