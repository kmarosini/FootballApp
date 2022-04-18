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
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Kapetan:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Broj:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pozicija:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ime:";
            // 
            // lblKapetan
            // 
            this.lblKapetan.AutoSize = true;
            this.lblKapetan.Location = new System.Drawing.Point(71, 105);
            this.lblKapetan.Name = "lblKapetan";
            this.lblKapetan.Size = new System.Drawing.Size(35, 13);
            this.lblKapetan.TabIndex = 11;
            this.lblKapetan.Text = "label3";
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.Location = new System.Drawing.Point(71, 82);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(35, 13);
            this.lblBroj.TabIndex = 10;
            this.lblBroj.Text = "label2";
            // 
            // lblPozicija
            // 
            this.lblPozicija.AutoSize = true;
            this.lblPozicija.Location = new System.Drawing.Point(71, 59);
            this.lblPozicija.Name = "lblPozicija";
            this.lblPozicija.Size = new System.Drawing.Size(35, 13);
            this.lblPozicija.TabIndex = 9;
            this.lblPozicija.Text = "label1";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(71, 34);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(35, 13);
            this.lblIme.TabIndex = 8;
            this.lblIme.Text = "label1";
            // 
            // lblFavorit
            // 
            this.lblFavorit.AutoSize = true;
            this.lblFavorit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavorit.Location = new System.Drawing.Point(127, 12);
            this.lblFavorit.Name = "lblFavorit";
            this.lblFavorit.Size = new System.Drawing.Size(0, 25);
            this.lblFavorit.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ODABERI:";
            // 
            // cbOdaberiIgraca
            // 
            this.cbOdaberiIgraca.AutoSize = true;
            this.cbOdaberiIgraca.Location = new System.Drawing.Point(74, 132);
            this.cbOdaberiIgraca.Name = "cbOdaberiIgraca";
            this.cbOdaberiIgraca.Size = new System.Drawing.Size(15, 14);
            this.cbOdaberiIgraca.TabIndex = 18;
            this.cbOdaberiIgraca.UseVisualStyleBackColor = true;
            this.cbOdaberiIgraca.CheckedChanged += new System.EventHandler(this.cbOdaberiIgraca_CheckedChanged);
            // 
            // IgracInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
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
    }
}
