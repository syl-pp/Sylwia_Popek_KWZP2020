namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.chkButtomEnabled = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtButtonLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 169);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(260, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "CHANGE ME";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkButtomEnabled
            // 
            this.chkButtomEnabled.AutoSize = true;
            this.chkButtomEnabled.Location = new System.Drawing.Point(95, 127);
            this.chkButtomEnabled.Name = "chkButtomEnabled";
            this.chkButtomEnabled.Size = new System.Drawing.Size(125, 21);
            this.chkButtomEnabled.TabIndex = 1;
            this.chkButtomEnabled.Text = "Wyłącz / Włącz";
            this.chkButtomEnabled.UseVisualStyleBackColor = true;
            this.chkButtomEnabled.CheckedChanged += new System.EventHandler(this.chkButtomEnabled_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Laboratorium KWZP";
            // 
            // txtButtonLabel
            // 
            this.txtButtonLabel.Location = new System.Drawing.Point(12, 74);
            this.txtButtonLabel.Name = "txtButtonLabel";
            this.txtButtonLabel.Size = new System.Drawing.Size(274, 22);
            this.txtButtonLabel.TabIndex = 3;
            this.txtButtonLabel.TextChanged += new System.EventHandler(this.txtButtonLabel_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.txtButtonLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkButtomEnabled);
            this.Controls.Add(this.btnClose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkButtomEnabled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtButtonLabel;
    }
}

