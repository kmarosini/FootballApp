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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OmiljeniTim));
            this.btnSpremiOmiljeniTim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOmiljeniTim = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIzabraniTim = new System.Windows.Forms.Label();
            this.imgLoad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpremiOmiljeniTim
            // 
            resources.ApplyResources(this.btnSpremiOmiljeniTim, "btnSpremiOmiljeniTim");
            this.btnSpremiOmiljeniTim.Name = "btnSpremiOmiljeniTim";
            this.btnSpremiOmiljeniTim.UseVisualStyleBackColor = true;
            this.btnSpremiOmiljeniTim.Click += new System.EventHandler(this.btnSpremiOmiljeniTim_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cbOmiljeniTim
            // 
            this.cbOmiljeniTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOmiljeniTim.FormattingEnabled = true;
            resources.ApplyResources(this.cbOmiljeniTim, "cbOmiljeniTim");
            this.cbOmiljeniTim.Name = "cbOmiljeniTim";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label2.Name = "label2";
            // 
            // lblIzabraniTim
            // 
            resources.ApplyResources(this.lblIzabraniTim, "lblIzabraniTim");
            this.lblIzabraniTim.Name = "lblIzabraniTim";
            // 
            // imgLoad
            // 
            this.imgLoad.Image = global::FootballApp.Resursi.loading;
            resources.ApplyResources(this.imgLoad, "imgLoad");
            this.imgLoad.Name = "imgLoad";
            this.imgLoad.TabStop = false;
            // 
            // OmiljeniTim
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imgLoad);
            this.Controls.Add(this.lblIzabraniTim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSpremiOmiljeniTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOmiljeniTim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OmiljeniTim";
            this.Load += new System.EventHandler(this.OmiljeniTim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremiOmiljeniTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOmiljeniTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIzabraniTim;
        private System.Windows.Forms.PictureBox imgLoad;
    }
}