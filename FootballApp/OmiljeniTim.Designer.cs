namespace FootballApp
{
    partial class OmiljeniTim
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
            this.btnSpremiOmiljeniTim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOmiljeniTim = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSpremiOmiljeniTim
            // 
            this.btnSpremiOmiljeniTim.Location = new System.Drawing.Point(353, 263);
            this.btnSpremiOmiljeniTim.Name = "btnSpremiOmiljeniTim";
            this.btnSpremiOmiljeniTim.Size = new System.Drawing.Size(108, 28);
            this.btnSpremiOmiljeniTim.TabIndex = 5;
            this.btnSpremiOmiljeniTim.Text = "Spremi";
            this.btnSpremiOmiljeniTim.UseVisualStyleBackColor = true;
            this.btnSpremiOmiljeniTim.Click += new System.EventHandler(this.btnSpremiOmiljeniTim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Omiljeni tim:";
            // 
            // cbOmiljeniTim
            // 
            this.cbOmiljeniTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOmiljeniTim.FormattingEnabled = true;
            this.cbOmiljeniTim.Location = new System.Drawing.Point(324, 129);
            this.cbOmiljeniTim.Name = "cbOmiljeniTim";
            this.cbOmiljeniTim.Size = new System.Drawing.Size(162, 21);
            this.cbOmiljeniTim.TabIndex = 3;
            // 
            // OmiljeniTim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSpremiOmiljeniTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOmiljeniTim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OmiljeniTim";
            this.Text = "OmiljeniTim";
            this.Load += new System.EventHandler(this.OmiljeniTim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremiOmiljeniTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOmiljeniTim;
    }
}