using CrystalDecisions.CrystalReports.Engine;
using MainUI.Datasets;
using MainUI.Forms.Admin_Forms;
using ObjectLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI.Dialog
{
    public partial class Invoice_Printer : Form
    {
        public ReportDocument invoice { get; set; }
        public List<OrderSlip> GetSlipDetails {get; set;}
        public int _width { get; set; }
        public int Order_Id { get; set; }
        public long Order_Qty { get; set; }
        Homepage hmp;
        public Invoice_Printer(Homepage hmpg)
        {
            InitializeComponent();
            hmp = hmpg;
        }
        private void LoadReport(ReportDocument rpt)
        {
            rptGlobalViewer.ReportSource = rpt;
            rptGlobalViewer.Refresh();
        }

        private void btnSaveInvoice_Click(object sender, EventArgs e)
        {
            rptGlobalViewer.PrintReport();
            if(rbtnYes.Checked == true)
            {
                hmp.validateSalesEntry("Finished");
            }
            else if (rbtnNo.Checked == true)
            {
                hmp.validateSalesEntry("Pending");
            }
            Dispose();
        }
        private string GetPaymentStatus()
        {
            if(rbtnYes.Checked == true)
            {
                return "Paid";
            }
            else
            {
                return "";
            }
        }
        public void SetInvoice(List<OrderSlip> lst, int width)
        {
                invoice.SetDataSource(lst);
                Width = width;
                invoice.SetParameterValue("payment", GetPaymentStatus());
                invoice.SetParameterValue("txtRepresentative", hmp.labelCurrentUserName.Text);
                LoadReport(invoice);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
            hmp.GetSlipDetails.Clear();
        }

        public void rbtnYes_CheckedChanged(object sender, EventArgs e)
        {
            if((sender) == rbtnYes)
            {
                SetInvoice(GetSlipDetails, _width);
            }
            else if((sender) == rbtnNo)
            {
                SetInvoice(GetSlipDetails, _width);
            }
        }
    }
}
