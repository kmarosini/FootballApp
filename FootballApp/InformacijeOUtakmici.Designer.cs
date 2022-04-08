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
            this.dgvUtakmica = new System.Windows.Forms.DataGridView();
            this.rootBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hometeamcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awayteamcountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintDetalja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUtakmica
            // 
            this.dgvUtakmica.AutoGenerateColumns = false;
            this.dgvUtakmica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtakmica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationDataGridViewTextBoxColumn,
            this.attendanceDataGridViewTextBoxColumn,
            this.hometeamcountryDataGridViewTextBoxColumn,
            this.awayteamcountryDataGridViewTextBoxColumn});
            this.dgvUtakmica.DataSource = this.rootBindingSource;
            this.dgvUtakmica.Location = new System.Drawing.Point(12, 59);
            this.dgvUtakmica.Name = "dgvUtakmica";
            this.dgvUtakmica.Size = new System.Drawing.Size(776, 333);
            this.dgvUtakmica.TabIndex = 4;
            // 
            // rootBindingSource
            // 
            this.rootBindingSource.DataSource = typeof(ApiCollector.Games.Root);
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // attendanceDataGridViewTextBoxColumn
            // 
            this.attendanceDataGridViewTextBoxColumn.DataPropertyName = "attendance";
            this.attendanceDataGridViewTextBoxColumn.HeaderText = "attendance";
            this.attendanceDataGridViewTextBoxColumn.Name = "attendanceDataGridViewTextBoxColumn";
            // 
            // hometeamcountryDataGridViewTextBoxColumn
            // 
            this.hometeamcountryDataGridViewTextBoxColumn.DataPropertyName = "home_team_country";
            this.hometeamcountryDataGridViewTextBoxColumn.HeaderText = "home_team_country";
            this.hometeamcountryDataGridViewTextBoxColumn.Name = "hometeamcountryDataGridViewTextBoxColumn";
            // 
            // awayteamcountryDataGridViewTextBoxColumn
            // 
            this.awayteamcountryDataGridViewTextBoxColumn.DataPropertyName = "away_team_country";
            this.awayteamcountryDataGridViewTextBoxColumn.HeaderText = "away_team_country";
            this.awayteamcountryDataGridViewTextBoxColumn.Name = "awayteamcountryDataGridViewTextBoxColumn";
            // 
            // btnPrintDetalja
            // 
            this.btnPrintDetalja.Location = new System.Drawing.Point(339, 12);
            this.btnPrintDetalja.Name = "btnPrintDetalja";
            this.btnPrintDetalja.Size = new System.Drawing.Size(98, 24);
            this.btnPrintDetalja.TabIndex = 5;
            this.btnPrintDetalja.Text = "Print";
            this.btnPrintDetalja.UseVisualStyleBackColor = true;
            this.btnPrintDetalja.Click += new System.EventHandler(this.btnPrintDetalja_Click);
            // 
            // InformacijeOUtakmici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrintDetalja);
            this.Controls.Add(this.dgvUtakmica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformacijeOUtakmici";
            this.Text = "InformacijeOUtakmici";
            this.Load += new System.EventHandler(this.InformacijeOUtakmici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtakmica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rootBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUtakmica;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hometeamcountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn awayteamcountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rootBindingSource;
        private System.Windows.Forms.Button btnPrintDetalja;
    }
}