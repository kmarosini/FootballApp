namespace FootballApp
{
    partial class IgracStatistika
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblBrojZabijenih = new System.Windows.Forms.Label();
            this.lblBrojZutih = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broj zabijenih:";
            // 
            // lblBrojZabijenih
            // 
            this.lblBrojZabijenih.AutoSize = true;
            this.lblBrojZabijenih.Location = new System.Drawing.Point(229, 69);
            this.lblBrojZabijenih.Name = "lblBrojZabijenih";
            this.lblBrojZabijenih.Size = new System.Drawing.Size(35, 13);
            this.lblBrojZabijenih.TabIndex = 2;
            this.lblBrojZabijenih.Text = "label2";
            // 
            // lblBrojZutih
            // 
            this.lblBrojZutih.AutoSize = true;
            this.lblBrojZutih.Location = new System.Drawing.Point(214, 103);
            this.lblBrojZutih.Name = "lblBrojZutih";
            this.lblBrojZutih.Size = new System.Drawing.Size(35, 13);
            this.lblBrojZutih.TabIndex = 4;
            this.lblBrojZutih.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Broj žutih:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(194, 34);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(35, 13);
            this.lblNaziv.TabIndex = 6;
            this.lblNaziv.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Naziv:";
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(13, 3);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(129, 160);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSlika.TabIndex = 0;
            this.pbSlika.TabStop = false;
            // 
            // IgracStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblBrojZutih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBrojZabijenih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbSlika);
            this.Name = "IgracStatistika";
            this.Size = new System.Drawing.Size(357, 166);
            this.Load += new System.EventHandler(this.IgracStatistika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBrojZabijenih;
        private System.Windows.Forms.Label lblBrojZutih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label label6;
    }
}
