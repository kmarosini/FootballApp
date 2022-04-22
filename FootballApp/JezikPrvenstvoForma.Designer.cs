namespace FootballApp
{
    partial class JezikPrvenstvoForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JezikPrvenstvoForma));
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbJezik = new System.Windows.Forms.ComboBox();
            this.cbPrvenstvo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIzabranoPrvenstvo = new System.Windows.Forms.Label();
            this.lblIzabraniJezik = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            resources.ApplyResources(this.btnSpremi, "btnSpremi");
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbJezik
            // 
            resources.ApplyResources(this.cbJezik, "cbJezik");
            this.cbJezik.FormattingEnabled = true;
            this.cbJezik.Items.AddRange(new object[] {
            resources.GetString("cbJezik.Items"),
            resources.GetString("cbJezik.Items1")});
            this.cbJezik.Name = "cbJezik";
            // 
            // cbPrvenstvo
            // 
            resources.ApplyResources(this.cbPrvenstvo, "cbPrvenstvo");
            this.cbPrvenstvo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrvenstvo.FormattingEnabled = true;
            this.cbPrvenstvo.Items.AddRange(new object[] {
            resources.GetString("cbPrvenstvo.Items"),
            resources.GetString("cbPrvenstvo.Items1")});
            this.cbPrvenstvo.Name = "cbPrvenstvo";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblIzabranoPrvenstvo
            // 
            resources.ApplyResources(this.lblIzabranoPrvenstvo, "lblIzabranoPrvenstvo");
            this.lblIzabranoPrvenstvo.Name = "lblIzabranoPrvenstvo";
            // 
            // lblIzabraniJezik
            // 
            resources.ApplyResources(this.lblIzabraniJezik, "lblIzabraniJezik");
            this.lblIzabraniJezik.Name = "lblIzabraniJezik";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // JezikPrvenstvoForma
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblIzabraniJezik);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblIzabranoPrvenstvo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbJezik);
            this.Controls.Add(this.cbPrvenstvo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JezikPrvenstvoForma";
            this.Load += new System.EventHandler(this.JezikPrvenstvoForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbJezik;
        private System.Windows.Forms.ComboBox cbPrvenstvo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIzabranoPrvenstvo;
        private System.Windows.Forms.Label lblIzabraniJezik;
        private System.Windows.Forms.Label label6;
    }
}