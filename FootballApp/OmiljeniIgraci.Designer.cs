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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OmiljeniIgraci));
            this.btnResetOmiljenihIgraca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flpFavoritIgraci = new System.Windows.Forms.FlowLayoutPanel();
            this.flpSviIgraci = new System.Windows.Forms.FlowLayoutPanel();
            this.imgLoad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResetOmiljenihIgraca
            // 
            this.btnResetOmiljenihIgraca.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.btnResetOmiljenihIgraca, "btnResetOmiljenihIgraca");
            this.btnResetOmiljenihIgraca.Name = "btnResetOmiljenihIgraca";
            this.btnResetOmiljenihIgraca.UseVisualStyleBackColor = false;
            this.btnResetOmiljenihIgraca.Click += new System.EventHandler(this.btnResetOmiljenihIgraca_Click);
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
            // flpFavoritIgraci
            // 
            this.flpFavoritIgraci.AllowDrop = true;
            resources.ApplyResources(this.flpFavoritIgraci, "flpFavoritIgraci");
            this.flpFavoritIgraci.Name = "flpFavoritIgraci";
            this.flpFavoritIgraci.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpFavoritIgraci_DragDrop);
            this.flpFavoritIgraci.DragEnter += new System.Windows.Forms.DragEventHandler(this.flpFavoritIgraci_DragEnter);
            // 
            // flpSviIgraci
            // 
            resources.ApplyResources(this.flpSviIgraci, "flpSviIgraci");
            this.flpSviIgraci.Name = "flpSviIgraci";
            // 
            // imgLoad
            // 
            this.imgLoad.Image = global::FootballApp.Resursi.loading;
            resources.ApplyResources(this.imgLoad, "imgLoad");
            this.imgLoad.Name = "imgLoad";
            this.imgLoad.TabStop = false;
            // 
            // OmiljeniIgraci
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imgLoad);
            this.Controls.Add(this.btnResetOmiljenihIgraca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpFavoritIgraci);
            this.Controls.Add(this.flpSviIgraci);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OmiljeniIgraci";
            this.Load += new System.EventHandler(this.OmiljeniIgraci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetOmiljenihIgraca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpFavoritIgraci;
        private System.Windows.Forms.FlowLayoutPanel flpSviIgraci;
        private System.Windows.Forms.PictureBox imgLoad;
    }
}