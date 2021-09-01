using Controle.Relatorio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rango
{
    public partial class FrmVisualizar : Form
    {
        int idCliente;
        DateTime dataIncio, dataFim;


        public FrmVisualizar()
        {
            InitializeComponent();
        }


        public FrmVisualizar(int idCliente, DateTime dataIncio, DateTime dataFim)
        {
            InitializeComponent();

            this.idCliente = idCliente;

            this.dataIncio = dataIncio;
            this.dataFim = dataFim;
        }

        private void ListarRelatorio(int idCliente, DateTime dataIncio, DateTime dataFim)
        {
            Extrato extrato = new Extrato();
            List<ReportParameter> reportParameters = new List<ReportParameter>();

            reportParameters.Add(new ReportParameter("DataInicio", dataIncio.ToString("d")));
            reportParameters.Add(new ReportParameter("DataFim", dataFim.ToString("d")));


            DataTable dataTable = new DataTable();
            dataTable = extrato.Produto(idCliente, dataIncio, dataFim);



            this.RpwRelatorio.LocalReport.DataSources.Clear();
            this.RpwRelatorio.LocalReport.DataSources.Add(new ReportDataSource("ExtratoProdutoDataSet", dataTable));
            this.RpwRelatorio.LocalReport.ReportPath = @"Relatorio\ExtratoProduto.rdlc";
            this.RpwRelatorio.LocalReport.SetParameters(reportParameters);



            this.RpwRelatorio.SetDisplayMode(DisplayMode.PrintLayout);
            this.RpwRelatorio.ZoomMode = ZoomMode.Percent;
            this.RpwRelatorio.ZoomPercent = 100;
            this.RpwRelatorio.RefreshReport();
        }


        private void FrmVisualizar_Load(object sender, EventArgs e)
        {

            ListarRelatorio(idCliente, dataIncio, dataFim);
        }
    }
}
