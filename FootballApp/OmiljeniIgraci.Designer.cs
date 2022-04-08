namespace FootballApp
{
    partial class OmiljeniIgraci
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
            this.btnResetOmiljenihIgraca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flpFavoritIgraci = new System.Windows.Forms.FlowLayoutPanel();
            this.flpSviIgraci = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnResetOmiljenihIgraca
            // 
            this.btnResetOmiljenihIgraca.BackColor = System.Drawing.Color.Firebrick;
            this.btnResetOmiljenihIgraca.Location = new System.Drawing.Point(567, 28);
            this.btnResetOmiljenihIgraca.Name = "btnResetOmiljenihIgraca";
            this.btnResetOmiljenihIgraca.Size = new System.Drawing.Size(75, 23);
            this.btnResetOmiljenihIgraca.TabIndex = 11;
            this.btnResetOmiljenihIgraca.Text = "Reset";
            this.btnResetOmiljenihIgraca.UseVisualStyleBackColor = false;
            this.btnResetOmiljenihIgraca.Click += new System.EventHandler(this.btnResetOmiljenihIgraca_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Omiljeni igraci:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Igraci:";
            // 
            // flpFavoritIgraci
            // 
            this.flpFavoritIgraci.AllowDrop = true;
            this.flpFavoritIgraci.AutoScroll = true;
            this.flpFavoritIgraci.Location = new System.Drawing.Point(406, 68);
            this.flpFavoritIgraci.Name = "flpFavoritIgraci";
            this.flpFavoritIgraci.Size = new System.Drawing.Size(378, 355);
            this.flpFavoritIgraci.TabIndex = 8;
            this.flpFavoritIgraci.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpFavoritIgraci_DragDrop);
            this.flpFavoritIgraci.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpFavoritIgraci_DragEnter);
            // 
            // flpSviIgraci
            // 
            this.flpSviIgraci.AutoScroll = true;
            this.flpSviIgraci.Location = new System.Drawing.Point(17, 68);
            this.flpSviIgraci.Name = "flpSviIgraci";
            this.flpSviIgraci.Size = new System.Drawing.Size(383, 355);
            this.flpSviIgraci.TabIndex = 7;
            // 
            // OmiljeniIgraci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResetOmiljenihIgraca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpFavoritIgraci);
            this.Controls.Add(this.flpSviIgraci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OmiljeniIgraci";
            this.Text = "OmiljeniIgraci";
            this.Load += new System.EventHandler(this.OmiljeniIgraci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetOmiljenihIgraca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpFavoritIgraci;
        private System.Windows.Forms.FlowLayoutPanel flpSviIgraci;
    }
}