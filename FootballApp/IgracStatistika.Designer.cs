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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IgracStatistika));
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblBrojZabijenih
            // 
            resources.ApplyResources(this.lblBrojZabijenih, "lblBrojZabijenih");
            this.lblBrojZabijenih.Name = "lblBrojZabijenih";
            // 
            // lblBrojZutih
            // 
            resources.ApplyResources(this.lblBrojZutih, "lblBrojZutih");
            this.lblBrojZutih.Name = "lblBrojZutih";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lblNaziv
            // 
            resources.ApplyResources(this.lblNaziv, "lblNaziv");
            this.lblNaziv.Name = "lblNaziv";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // pbSlika
            // 
            resources.ApplyResources(this.pbSlika, "pbSlika");
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.TabStop = false;
            // 
            // IgracStatistika
            // 
            resources.ApplyResources(this, "$this");
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
