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
            this.dgvRangLista = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.captainDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.shirtnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yellowCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isFavouriteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.skupIgracaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRangListPrint = new System.Windows.Forms.Button();
            this.SlikaColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRangLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skupIgracaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRangLista
            // 
            resources.ApplyResources(this.dgvRangLista, "dgvRangLista");
            this.dgvRangLista.AutoGenerateColumns = false;
            this.dgvRangLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRangLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.captainDataGridViewCheckBoxColumn,
            this.shirtnumberDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.goalNumberDataGridViewTextBoxColumn,
            this.yellowCardDataGridViewTextBoxColumn,
            this.isFavouriteDataGridViewCheckBoxColumn,
            this.SlikaColumn});
            this.dgvRangLista.DataSource = this.skupIgracaBindingSource;
            this.dgvRangLista.Name = "dgvRangLista";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // captainDataGridViewCheckBoxColumn
            // 
            this.captainDataGridViewCheckBoxColumn.DataPropertyName = "Captain";
            resources.ApplyResources(this.captainDataGridViewCheckBoxColumn, "captainDataGridViewCheckBoxColumn");
            this.captainDataGridViewCheckBoxColumn.Name = "captainDataGridViewCheckBoxColumn";
            // 
            // shirtnumberDataGridViewTextBoxColumn
            // 
            this.shirtnumberDataGridViewTextBoxColumn.DataPropertyName = "Shirt_number";
            resources.ApplyResources(this.shirtnumberDataGridViewTextBoxColumn, "shirtnumberDataGridViewTextBoxColumn");
            this.shirtnumberDataGridViewTextBoxColumn.Name = "shirtnumberDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            resources.ApplyResources(this.positionDataGridViewTextBoxColumn, "positionDataGridViewTextBoxColumn");
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // goalNumberDataGridViewTextBoxColumn
            // 
            this.goalNumberDataGridViewTextBoxColumn.DataPropertyName = "GoalNumber";
            resources.ApplyResources(this.goalNumberDataGridViewTextBoxColumn, "goalNumberDataGridViewTextBoxColumn");
            this.goalNumberDataGridViewTextBoxColumn.Name = "goalNumberDataGridViewTextBoxColumn";
            // 
            // yellowCardDataGridViewTextBoxColumn
            // 
            this.yellowCardDataGridViewTextBoxColumn.DataPropertyName = "YellowCard";
            resources.ApplyResources(this.yellowCardDataGridViewTextBoxColumn, "yellowCardDataGridViewTextBoxColumn");
            this.yellowCardDataGridViewTextBoxColumn.Name = "yellowCardDataGridViewTextBoxColumn";
            // 
            // isFavouriteDataGridViewCheckBoxColumn
            // 
            this.isFavouriteDataGridViewCheckBoxColumn.DataPropertyName = "IsFavourite";
            resources.ApplyResources(this.isFavouriteDataGridViewCheckBoxColumn, "isFavouriteDataGridViewCheckBoxColumn");
            this.isFavouriteDataGridViewCheckBoxColumn.Name = "isFavouriteDataGridViewCheckBoxColumn";
            // 
            // skupIgracaBindingSource
            // 
            this.skupIgracaBindingSource.DataSource = typeof(ApiCollector.SkupIgraca);
            // 
            // btnRangListPrint
            // 
            resources.ApplyResources(this.btnRangListPrint, "btnRangListPrint");
            this.btnRangListPrint.Name = "btnRangListPrint";
            this.btnRangListPrint.UseVisualStyleBackColor = true;
            this.btnRangListPrint.Click += new System.EventHandler(this.btnRangListPrint_Click);
            // 
            // SlikaColumn
            // 
            resources.ApplyResources(this.SlikaColumn, "SlikaColumn");
            this.SlikaColumn.Name = "SlikaColumn";
            // 
            // RangLista
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRangListPrint);
            this.Controls.Add(this.dgvRangLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RangLista";
            this.Load += new System.EventHandler(this.RangLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRangLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skupIgracaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRangLista;
        private System.Windows.Forms.BindingSource skupIgracaBindingSource;
        private System.Windows.Forms.Button btnRangListPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn captainDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shirtnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yellowCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isFavouriteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn SlikaColumn;
    }
}