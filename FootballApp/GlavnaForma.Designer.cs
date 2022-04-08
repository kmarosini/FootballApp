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
            this.btnDetalji.Location = new System.Drawing.Point(557, 404);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(109, 34);
            this.btnDetalji.TabIndex = 12;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // btnRangLista
            // 
            this.btnRangLista.Location = new System.Drawing.Point(424, 404);
            this.btnRangLista.Name = "btnRangLista";
            this.btnRangLista.Size = new System.Drawing.Size(109, 34);
            this.btnRangLista.TabIndex = 11;
            this.btnRangLista.Text = "Rang lista";
            this.btnRangLista.UseVisualStyleBackColor = true;
            this.btnRangLista.Click += new System.EventHandler(this.btnRangLista_Click);
            // 
            // btnPostavke
            // 
            this.btnPostavke.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPostavke.Location = new System.Drawing.Point(683, 404);
            this.btnPostavke.Name = "btnPostavke";
            this.btnPostavke.Size = new System.Drawing.Size(109, 34);
            this.btnPostavke.TabIndex = 10;
            this.btnPostavke.Text = "Postavke";
            this.btnPostavke.UseVisualStyleBackColor = false;
            this.btnPostavke.Click += new System.EventHandler(this.btnPostavke_Click);
            // 
            // btnOmiljeniIgraci
            // 
            this.btnOmiljeniIgraci.Location = new System.Drawing.Point(286, 404);
            this.btnOmiljeniIgraci.Name = "btnOmiljeniIgraci";
            this.btnOmiljeniIgraci.Size = new System.Drawing.Size(109, 34);
            this.btnOmiljeniIgraci.TabIndex = 9;
            this.btnOmiljeniIgraci.Text = "Omiljeni igraci";
            this.btnOmiljeniIgraci.UseVisualStyleBackColor = true;
            this.btnOmiljeniIgraci.Click += new System.EventHandler(this.btnOmiljeniIgraci_Click);
            // 
            // btnOmiljeniTim
            // 
            this.btnOmiljeniTim.Location = new System.Drawing.Point(151, 404);
            this.btnOmiljeniTim.Name = "btnOmiljeniTim";
            this.btnOmiljeniTim.Size = new System.Drawing.Size(109, 34);
            this.btnOmiljeniTim.TabIndex = 8;
            this.btnOmiljeniTim.Text = "Omiljeni tim";
            this.btnOmiljeniTim.UseVisualStyleBackColor = true;
            this.btnOmiljeniTim.Click += new System.EventHandler(this.btnOmiljeniTim_Click);
            // 
            // btnJezikPrvenstvo
            // 
            this.btnJezikPrvenstvo.Location = new System.Drawing.Point(16, 404);
            this.btnJezikPrvenstvo.Name = "btnJezikPrvenstvo";
            this.btnJezikPrvenstvo.Size = new System.Drawing.Size(109, 34);
            this.btnJezikPrvenstvo.TabIndex = 7;
            this.btnJezikPrvenstvo.Text = "Prvenstvo / Jezik";
            this.btnJezikPrvenstvo.UseVisualStyleBackColor = true;
            this.btnJezikPrvenstvo.Click += new System.EventHandler(this.btnJezikPrvenstvo_Click);
            // 
            // pnlGlavniPanel
            // 
            this.pnlGlavniPanel.BackColor = System.Drawing.Color.White;
            this.pnlGlavniPanel.Location = new System.Drawing.Point(-1, -3);
            this.pnlGlavniPanel.Name = "pnlGlavniPanel";
            this.pnlGlavniPanel.Size = new System.Drawing.Size(804, 401);
            this.pnlGlavniPanel.TabIndex = 13;
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlGlavniPanel);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnRangLista);
            this.Controls.Add(this.btnPostavke);
            this.Controls.Add(this.btnOmiljeniIgraci);
            this.Controls.Add(this.btnOmiljeniTim);
            this.Controls.Add(this.btnJezikPrvenstvo);
            this.Name = "GlavnaForma";
            this.Text = "Glavna forma";
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

