using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballApp
{
    public partial class InformacijeOUtakmici : Form
    {
        public InformacijeOUtakmici()
        {
            InitializeComponent();
        }

        private async void InformacijeOUtakmici_Load(object sender, EventArgs e)
        {
            List<ApiCollector.Games.Root> utakmica = await ApiCollector.PrepareForForm.DohvatiIgraca();
            dgvUtakmica.DataSource = utakmica;
        }

        private void btnPrintDetalja_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "Karlo's Soccer App";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "KarloMarosini";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dgvUtakmica);

        }
    }
}
