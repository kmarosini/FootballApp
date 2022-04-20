namespace FootballApp
{
    partial class IgracInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IgracInfo));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKapetan = new System.Windows.Forms.Label();
            this.lblBroj = new System.Windows.Forms.Label();
            this.lblPozicija = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblFavorit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOdaberiIgraca = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lblKapetan
            // 
            resources.ApplyResources(this.lblKapetan, "lblKapetan");
            this.lblKapetan.Name = "lblKapetan";
            // 
            // lblBroj
            // 
            resources.ApplyResources(this.lblBroj, "lblBroj");
            this.lblBroj.Name = "lblBroj";
            // 
            // lblPozicija
            // 
            resources.ApplyResources(this.lblPozicija, "lblPozicija");
            this.lblPozicija.Name = "lblPozicija";
            // 
            // lblIme
            // 
            resources.ApplyResources(this.lblIme, "lblIme");
            this.lblIme.Name = "lblIme";
            // 
            // lblFavorit
            // 
            resources.ApplyResources(this.lblFavorit, "lblFavorit");
            this.lblFavorit.Name = "lblFavorit";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbOdaberiIgraca
            // 
            resources.ApplyResources(this.cbOdaberiIgraca, "cbOdaberiIgraca");
            this.cbOdaberiIgraca.Name = "cbOdaberiIgraca";
            this.cbOdaberiIgraca.UseVisualStyleBackColor = true;
            this.cbOdaberiIgraca.CheckedChanged += new System.EventHandler(this.cbOdaberiIgraca_CheckedChanged);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // btnSpremi
            // 
            resources.ApplyResources(this.btnSpremi, "btnSpremi");
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // pbSlika
            // 
            resources.ApplyResources(this.pbSlika, "pbSlika");
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.TabStop = false;
            this.pbSlika.DoubleClick += new System.EventHandler(this.pbSlika_DoubleClick);
            // 
            // IgracInfo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.cbOdaberiIgraca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFavorit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblKapetan);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.lblPozicija);
            this.Controls.Add(this.lblIme);
            this.Name = "IgracInfo";
            this.Load += new System.EventHandler(this.IgracInfo_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IgracInfo_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKapetan;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.Label lblPozicija;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblFavorit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbOdaberiIgraca;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSpremi;
    }
}
