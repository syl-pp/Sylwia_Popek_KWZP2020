﻿namespace Szwalnia
{
    partial class ElementSzczegoly
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
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.lblElement = new System.Windows.Forms.Label();
            this.dgvSzczegol = new System.Windows.Forms.DataGridView();
            this.txtOkres = new System.Windows.Forms.TextBox();
            this.lblNazwa = new System.Windows.Forms.Label();
            this.lblOkres = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzczegol)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazwa
            // 
            this.txtNazwa.Location = new System.Drawing.Point(119, 58);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(100, 20);
            this.txtNazwa.TabIndex = 2;
            // 
            // lblElement
            // 
            this.lblElement.AutoSize = true;
            this.lblElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblElement.Location = new System.Drawing.Point(13, 9);
            this.lblElement.Name = "lblElement";
            this.lblElement.Size = new System.Drawing.Size(86, 31);
            this.lblElement.TabIndex = 3;
            this.lblElement.Text = "label1";
            // 
            // dgvSzczegol
            // 
            this.dgvSzczegol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSzczegol.Location = new System.Drawing.Point(12, 136);
            this.dgvSzczegol.Name = "dgvSzczegol";
            this.dgvSzczegol.Size = new System.Drawing.Size(776, 311);
            this.dgvSzczegol.TabIndex = 4;
            // 
            // txtOkres
            // 
            this.txtOkres.Location = new System.Drawing.Point(119, 104);
            this.txtOkres.Name = "txtOkres";
            this.txtOkres.Size = new System.Drawing.Size(100, 20);
            this.txtOkres.TabIndex = 2;
            // 
            // lblNazwa
            // 
            this.lblNazwa.AutoSize = true;
            this.lblNazwa.Location = new System.Drawing.Point(16, 65);
            this.lblNazwa.Name = "lblNazwa";
            this.lblNazwa.Size = new System.Drawing.Size(40, 13);
            this.lblNazwa.TabIndex = 5;
            this.lblNazwa.Text = "Nazwa";
            // 
            // lblOkres
            // 
            this.lblOkres.AutoSize = true;
            this.lblOkres.Location = new System.Drawing.Point(16, 107);
            this.lblOkres.Name = "lblOkres";
            this.lblOkres.Size = new System.Drawing.Size(97, 13);
            this.lblOkres.TabIndex = 5;
            this.lblOkres.Text = "Okres przydatnosci";
            // 
            // Element_szczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOkres);
            this.Controls.Add(this.lblNazwa);
            this.Controls.Add(this.dgvSzczegol);
            this.Controls.Add(this.lblElement);
            this.Controls.Add(this.txtOkres);
            this.Controls.Add(this.txtNazwa);
            this.Name = "Element_szczegoly";
            this.Text = "Okno szczegolow elementow";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSzczegol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.Label lblElement;
        private System.Windows.Forms.DataGridView dgvSzczegol;
        private System.Windows.Forms.TextBox txtOkres;
        private System.Windows.Forms.Label lblNazwa;
        private System.Windows.Forms.Label lblOkres;
    }
}