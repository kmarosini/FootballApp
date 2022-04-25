namespace FootballApp
{
    partial class RangLista
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RangLista));
            this.btnRangListPrint = new System.Windows.Forms.Button();
            this.flpStatistika = new System.Windows.Forms.FlowLayoutPanel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.skupIgracaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.skupIgracaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRangListPrint
            // 
            resources.ApplyResources(this.btnRangListPrint, "btnRangListPrint");
            this.btnRangListPrint.Name = "btnRangListPrint";
            this.btnRangListPrint.UseVisualStyleBackColor = true;
            this.btnRangListPrint.Click += new System.EventHandler(this.btnRangListPrint_Click_1);
            // 
            // flpStatistika
            // 
            resources.ApplyResources(this.flpStatistika, "flpStatistika");
            this.flpStatistika.Name = "flpStatistika";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // skupIgracaBindingSource
            // 
            this.skupIgracaBindingSource.DataSource = typeof(ApiCollector.SkupIgraca);
            // 
            // RangLista
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpStatistika);
            this.Controls.Add(this.btnRangListPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RangLista";
            this.Load += new System.EventHandler(this.RangLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skupIgracaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource skupIgracaBindingSource;
        private System.Windows.Forms.Button btnRangListPrint;
        private System.Windows.Forms.FlowLayoutPanel flpStatistika;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}