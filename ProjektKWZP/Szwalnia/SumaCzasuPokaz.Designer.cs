﻿namespace Szwalnia
{
    partial class SumaCzasuPokaz
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
            this.lblTytul = new System.Windows.Forms.Label();
            this.dgvSumaCzasu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumaCzasu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTytul
            // 
            this.lblTytul.AutoSize = true;
            this.lblTytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTytul.Location = new System.Drawing.Point(13, 25);
            this.lblTytul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTytul.Name = "lblTytul";
            this.lblTytul.Size = new System.Drawing.Size(960, 39);
            this.lblTytul.TabIndex = 3;
            this.lblTytul.Text = "Sumy czasow dla poszczegolnych procesow technologicznych";
            // 
            // dgvSumaCzasu
            // 
            this.dgvSumaCzasu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSumaCzasu.Location = new System.Drawing.Point(13, 112);
            this.dgvSumaCzasu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSumaCzasu.Name = "dgvSumaCzasu";
            this.dgvSumaCzasu.RowHeadersWidth = 51;
            this.dgvSumaCzasu.Size = new System.Drawing.Size(1024, 325);
            this.dgvSumaCzasu.TabIndex = 2;
            // 
            // SumaCzasuPokaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 450);
            this.Controls.Add(this.lblTytul);
            this.Controls.Add(this.dgvSumaCzasu);
            this.Name = "SumaCzasuPokaz";
            this.Text = "Suma_Czasu_Pokaz";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumaCzasu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTytul;
        private System.Windows.Forms.DataGridView dgvSumaCzasu;
    }
}