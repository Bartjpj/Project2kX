﻿namespace WindowsFormsApplication1
{
    partial class HoofdMenu
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
            this.btn_HMnaarKeuken = new System.Windows.Forms.Button();
            this.btn_HMnaarBediening = new System.Windows.Forms.Button();
            this.btn_HMnaarBar = new System.Windows.Forms.Button();
            this.lbl_HMtekst = new System.Windows.Forms.Label();
            this.lbl_aanwijzingtekst = new System.Windows.Forms.Label();
            this.btn_ExitWindows = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_HMnaarKeuken
            // 
            this.btn_HMnaarKeuken.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HMnaarKeuken.Location = new System.Drawing.Point(187, 187);
            this.btn_HMnaarKeuken.Name = "btn_HMnaarKeuken";
            this.btn_HMnaarKeuken.Size = new System.Drawing.Size(390, 49);
            this.btn_HMnaarKeuken.TabIndex = 0;
            this.btn_HMnaarKeuken.Text = "Keuken";
            this.btn_HMnaarKeuken.UseVisualStyleBackColor = true;
            // 
            // btn_HMnaarBediening
            // 
            this.btn_HMnaarBediening.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HMnaarBediening.Location = new System.Drawing.Point(187, 348);
            this.btn_HMnaarBediening.Name = "btn_HMnaarBediening";
            this.btn_HMnaarBediening.Size = new System.Drawing.Size(387, 45);
            this.btn_HMnaarBediening.TabIndex = 2;
            this.btn_HMnaarBediening.Text = "Bediening";
            this.btn_HMnaarBediening.UseVisualStyleBackColor = true;
            // 
            // btn_HMnaarBar
            // 
            this.btn_HMnaarBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HMnaarBar.Location = new System.Drawing.Point(187, 266);
            this.btn_HMnaarBar.Name = "btn_HMnaarBar";
            this.btn_HMnaarBar.Size = new System.Drawing.Size(390, 49);
            this.btn_HMnaarBar.TabIndex = 3;
            this.btn_HMnaarBar.Text = "Bar";
            this.btn_HMnaarBar.UseVisualStyleBackColor = true;
            // 
            // lbl_HMtekst
            // 
            this.lbl_HMtekst.AutoSize = true;
            this.lbl_HMtekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HMtekst.Location = new System.Drawing.Point(284, 9);
            this.lbl_HMtekst.Name = "lbl_HMtekst";
            this.lbl_HMtekst.Size = new System.Drawing.Size(211, 42);
            this.lbl_HMtekst.TabIndex = 4;
            this.lbl_HMtekst.Text = "Hoofdmenu";
            // 
            // lbl_aanwijzingtekst
            // 
            this.lbl_aanwijzingtekst.AutoSize = true;
            this.lbl_aanwijzingtekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aanwijzingtekst.Location = new System.Drawing.Point(183, 123);
            this.lbl_aanwijzingtekst.Name = "lbl_aanwijzingtekst";
            this.lbl_aanwijzingtekst.Size = new System.Drawing.Size(240, 24);
            this.lbl_aanwijzingtekst.TabIndex = 5;
            this.lbl_aanwijzingtekst.Text = "Gelieve uw afdeling kiezen:";
            // 
            // btn_ExitWindows
            // 
            this.btn_ExitWindows.Location = new System.Drawing.Point(586, 482);
            this.btn_ExitWindows.Name = "btn_ExitWindows";
            this.btn_ExitWindows.Size = new System.Drawing.Size(196, 75);
            this.btn_ExitWindows.TabIndex = 6;
            this.btn_ExitWindows.Text = "Exit naar Windows";
            this.btn_ExitWindows.UseVisualStyleBackColor = true;
            // 
            // HoofdMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 569);
            this.Controls.Add(this.btn_ExitWindows);
            this.Controls.Add(this.lbl_aanwijzingtekst);
            this.Controls.Add(this.lbl_HMtekst);
            this.Controls.Add(this.btn_HMnaarBar);
            this.Controls.Add(this.btn_HMnaarBediening);
            this.Controls.Add(this.btn_HMnaarKeuken);
            this.Name = "HoofdMenu";
            this.Text = "HoofdMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_HMnaarKeuken;
        private System.Windows.Forms.Button btn_HMnaarBediening;
        private System.Windows.Forms.Button btn_HMnaarBar;
        private System.Windows.Forms.Label lbl_HMtekst;
        private System.Windows.Forms.Label lbl_aanwijzingtekst;
        private System.Windows.Forms.Button btn_ExitWindows;
    }
}