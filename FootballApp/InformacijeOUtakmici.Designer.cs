namespace FootballApp
{
    partial class InformacijeOUtakmici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacijeOUtakmici));
            this.dgvUtakmica = new System.Windows.Forms.DataGridView();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hometeamcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayteamcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rootBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrintDetalja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUtakmica
            // 
            resources.ApplyResources(this.dgvUtakmica, "dgvUtakmica");
            this.dgvUtakmica.AutoGenerateColumns = false;
            this.dgvUtakmica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtakmica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationDataGridViewTextBoxColumn,
            this.attendanceDataGridViewTextBoxColumn,
            this.hometeamcountryDataGridViewTextBoxColumn,
            this.awayteamcountryDataGridViewTextBoxColumn});
            this.dgvUtakmica.DataSource = this.rootBindingSource;
            this.dgvUtakmica.Name = "dgvUtakmica";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            resources.ApplyResources(this.locationDataGridViewTextBoxColumn, "locationDataGridViewTextBoxColumn");
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // attendanceDataGridViewTextBoxColumn
            // 
            this.attendanceDataGridViewTextBoxColumn.DataPropertyName = "attendance";
            resources.ApplyResources(this.attendanceDataGridViewTextBoxColumn, "attendanceDataGridViewTextBoxColumn");
            this.attendanceDataGridViewTextBoxColumn.Name = "attendanceDataGridViewTextBoxColumn";
            // 
            // hometeamcountryDataGridViewTextBoxColumn
            // 
            this.hometeamcountryDataGridViewTextBoxColumn.DataPropertyName = "home_team_country";
            resources.ApplyResources(this.hometeamcountryDataGridViewTextBoxColumn, "hometeamcountryDataGridViewTextBoxColumn");
            this.hometeamcountryDataGridViewTextBoxColumn.Name = "hometeamcountryDataGridViewTextBoxColumn";
            // 
            // awayteamcountryDataGridViewTextBoxColumn
            // 
            this.awayteamcountryDataGridViewTextBoxColumn.DataPropertyName = "away_team_country";
            resources.ApplyResources(this.awayteamcountryDataGridViewTextBoxColumn, "awayteamcountryDataGridViewTextBoxColumn");
            this.awayteamcountryDataGridViewTextBoxColumn.Name = "awayteamcountryDataGridViewTextBoxColumn";
            // 
            // rootBindingSource
            // 
            this.rootBindingSource.DataSource = typeof(ApiCollector.Games.Root);
            // 
            // btnPrintDetalja
            // 
            resources.ApplyResources(this.btnPrintDetalja, "btnPrintDetalja");
            this.btnPrintDetalja.Name = "btnPrintDetalja";
            this.btnPrintDetalja.UseVisualStyleBackColor = true;
            this.btnPrintDetalja.Click += new System.EventHandler(this.btnPrintDetalja_Click);
            // 
            // InformacijeOUtakmici
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrintDetalja);
            this.Controls.Add(this.dgvUtakmica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformacijeOUtakmici";
            this.Load += new System.EventHandler(this.InformacijeOUtakmici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUtakmica;
        private System.Windows.Forms.BindingSource rootBindingSource;
        private System.Windows.Forms.Button btnPrintDetalja;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hometeamcountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayteamcountryDataGridViewTextBoxColumn;
    }
}