namespace FootballApp
{
    partial class GlavnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnRangLista = new System.Windows.Forms.Button();
            this.btnPostavke = new System.Windows.Forms.Button();
            this.btnOmiljeniIgraci = new System.Windows.Forms.Button();
            this.btnOmiljeniTim = new System.Windows.Forms.Button();
            this.btnJezikPrvenstvo = new System.Windows.Forms.Button();
            this.pnlGlavniPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnDetalji
            // 
            resources.ApplyResources(this.btnDetalji, "btnDetalji");
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // btnRangLista
            // 
            resources.ApplyResources(this.btnRangLista, "btnRangLista");
            this.btnRangLista.Name = "btnRangLista";
            this.btnRangLista.UseVisualStyleBackColor = true;
            this.btnRangLista.Click += new System.EventHandler(this.btnRangLista_Click);
            // 
            // btnPostavke
            // 
            resources.ApplyResources(this.btnPostavke, "btnPostavke");
            this.btnPostavke.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPostavke.Name = "btnPostavke";
            this.btnPostavke.UseVisualStyleBackColor = false;
            this.btnPostavke.Click += new System.EventHandler(this.btnPostavke_Click);
            // 
            // btnOmiljeniIgraci
            // 
            resources.ApplyResources(this.btnOmiljeniIgraci, "btnOmiljeniIgraci");
            this.btnOmiljeniIgraci.Name = "btnOmiljeniIgraci";
            this.btnOmiljeniIgraci.UseVisualStyleBackColor = true;
            this.btnOmiljeniIgraci.Click += new System.EventHandler(this.btnOmiljeniIgraci_Click);
            // 
            // btnOmiljeniTim
            // 
            resources.ApplyResources(this.btnOmiljeniTim, "btnOmiljeniTim");
            this.btnOmiljeniTim.Name = "btnOmiljeniTim";
            this.btnOmiljeniTim.UseVisualStyleBackColor = true;
            this.btnOmiljeniTim.Click += new System.EventHandler(this.btnOmiljeniTim_Click);
            // 
            // btnJezikPrvenstvo
            // 
            resources.ApplyResources(this.btnJezikPrvenstvo, "btnJezikPrvenstvo");
            this.btnJezikPrvenstvo.Name = "btnJezikPrvenstvo";
            this.btnJezikPrvenstvo.UseVisualStyleBackColor = true;
            this.btnJezikPrvenstvo.Click += new System.EventHandler(this.btnJezikPrvenstvo_Click);
            // 
            // pnlGlavniPanel
            // 
            resources.ApplyResources(this.pnlGlavniPanel, "pnlGlavniPanel");
            this.pnlGlavniPanel.BackColor = System.Drawing.Color.White;
            this.pnlGlavniPanel.Name = "pnlGlavniPanel";
            // 
            // GlavnaForma
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.pnlGlavniPanel);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnRangLista);
            this.Controls.Add(this.btnPostavke);
            this.Controls.Add(this.btnOmiljeniIgraci);
            this.Controls.Add(this.btnOmiljeniTim);
            this.Controls.Add(this.btnJezikPrvenstvo);
            this.Name = "GlavnaForma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GlavnaForma_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnRangLista;
        private System.Windows.Forms.Button btnPostavke;
        private System.Windows.Forms.Button btnOmiljeniIgraci;
        private System.Windows.Forms.Button btnOmiljeniTim;
        private System.Windows.Forms.Button btnJezikPrvenstvo;
        private System.Windows.Forms.Panel pnlGlavniPanel;
    }
}

