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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRangLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skupIgracaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRangLista
            // 
            this.dgvRangLista.AutoGenerateColumns = false;
            this.dgvRangLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRangLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.captainDataGridViewCheckBoxColumn,
            this.shirtnumberDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.goalNumberDataGridViewTextBoxColumn,
            this.yellowCardDataGridViewTextBoxColumn,
            this.isFavouriteDataGridViewCheckBoxColumn});
            this.dgvRangLista.DataSource = this.skupIgracaBindingSource;
            this.dgvRangLista.Location = new System.Drawing.Point(8, 59);
            this.dgvRangLista.Name = "dgvRangLista";
            this.dgvRangLista.Size = new System.Drawing.Size(785, 333);
            this.dgvRangLista.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // captainDataGridViewCheckBoxColumn
            // 
            this.captainDataGridViewCheckBoxColumn.DataPropertyName = "Captain";
            this.captainDataGridViewCheckBoxColumn.HeaderText = "Captain";
            this.captainDataGridViewCheckBoxColumn.Name = "captainDataGridViewCheckBoxColumn";
            // 
            // shirtnumberDataGridViewTextBoxColumn
            // 
            this.shirtnumberDataGridViewTextBoxColumn.DataPropertyName = "Shirt_number";
            this.shirtnumberDataGridViewTextBoxColumn.HeaderText = "Shirt_number";
            this.shirtnumberDataGridViewTextBoxColumn.Name = "shirtnumberDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // goalNumberDataGridViewTextBoxColumn
            // 
            this.goalNumberDataGridViewTextBoxColumn.DataPropertyName = "GoalNumber";
            this.goalNumberDataGridViewTextBoxColumn.HeaderText = "GoalNumber";
            this.goalNumberDataGridViewTextBoxColumn.Name = "goalNumberDataGridViewTextBoxColumn";
            // 
            // yellowCardDataGridViewTextBoxColumn
            // 
            this.yellowCardDataGridViewTextBoxColumn.DataPropertyName = "YellowCard";
            this.yellowCardDataGridViewTextBoxColumn.HeaderText = "YellowCard";
            this.yellowCardDataGridViewTextBoxColumn.Name = "yellowCardDataGridViewTextBoxColumn";
            // 
            // isFavouriteDataGridViewCheckBoxColumn
            // 
            this.isFavouriteDataGridViewCheckBoxColumn.DataPropertyName = "IsFavourite";
            this.isFavouriteDataGridViewCheckBoxColumn.HeaderText = "IsFavourite";
            this.isFavouriteDataGridViewCheckBoxColumn.Name = "isFavouriteDataGridViewCheckBoxColumn";
            // 
            // skupIgracaBindingSource
            // 
            this.skupIgracaBindingSource.DataSource = typeof(ApiCollector.SkupIgraca);
            // 
            // btnRangListPrint
            // 
            this.btnRangListPrint.Location = new System.Drawing.Point(315, 12);
            this.btnRangListPrint.Name = "btnRangListPrint";
            this.btnRangListPrint.Size = new System.Drawing.Size(127, 28);
            this.btnRangListPrint.TabIndex = 4;
            this.btnRangListPrint.Text = "Print";
            this.btnRangListPrint.UseVisualStyleBackColor = true;
            this.btnRangListPrint.Click += new System.EventHandler(this.btnRangListPrint_Click);
            // 
            // RangLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRangListPrint);
            this.Controls.Add(this.dgvRangLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RangLista";
            this.Text = "RangLista";
            this.Load += new System.EventHandler(this.RangLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRangLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skupIgracaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRangLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn captainDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shirtnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yellowCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isFavouriteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource skupIgracaBindingSource;
        private System.Windows.Forms.Button btnRangListPrint;
    }
}