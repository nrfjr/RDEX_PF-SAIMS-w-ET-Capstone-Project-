using MainUI.Forms.Admin_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainUI.Reports;
using CrystalDecisions.CrystalReports.Engine;
using System.Xml;
using UtilitiesLibrary;
using MainUI.Datasets;

namespace MainUI.Dialog
{
    public partial class Printer : Form
    {
        Homepage hmp;
        public Printer(Homepage hmpg)
        {
            InitializeComponent();
            hmp = hmpg;
        }
        private void LoadReport(ReportDocument rpt)
        {
            rptGlobalViewer.ReportSource = rpt;
            rptGlobalViewer.Refresh();
        }
        public void setTitle(string title)
        {
            labelTitle.Text = title;
        }
        private string GetFarmName()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(SystemPath.FarmPath);
            return xmlDoc.SelectSingleNode("/ Farm / Name").InnerText;
        }
        public void SetPondStatusReport(ReportDocument rpt)
        {
            rpt.SetParameterValue("txtFarmName", GetFarmName());
            rpt.SetParameterValue("txtManager", hmp.labelCurrentUserName.Text);
            LoadReport(rpt);
        }
        public void SetMaterialRequestSlip(ReportDocument rpt)
        {
            rpt.SetParameterValue("txtManager", hmp.labelCurrentUserName.Text);
            LoadReport(rpt);
        }
        public void SetProductionSamplingWithRemarks(Remarks rm, ReportDocument rpt)
        {
            rpt.SetParameterValue("txtRemarks", rm.txtSampRemarks.Text);
            rpt.SetParameterValue("pondNum", Int32.Parse(hmp.cmbWeeklyProduction.Text));
            rpt.SetParameterValue("txtManager", hmp.labelCurrentUserName.Text);
            LoadReport(rpt);
        }
        public void SetProductionSampling(ReportDocument rpt)
        {
            rpt.SetParameterValue("txtRemarks", "");
            rpt.SetParameterValue("pondNum", hmp.cmbWeeklyProduction.Text);
            rpt.SetParameterValue("txtManager", hmp.labelCurrentUserName.Text);
            LoadReport(rpt);
        }
        public void SetProductionResult(Result_Parameters rp, ReportDocument rpt)
        {
            rpt.SetParameterValue("txtUtility", rp.txtUtility.Text);
            rpt.SetParameterValue("dtFrom", DateTime.Parse(rp.dtpFrom.Value.ToString("dd/MM/yyyy")));
            rpt.SetParameterValue("dtTo", DateTime.Parse(rp.dtpTo.Value.ToString("dd/MM/yyyy")));
            rpt.SetParameterValue("farmName", rp.txtFarmName.Text);
            rpt.SetParameterValue("txtManager", hmp.labelCurrentUserName.Text);
            LoadReport(rpt);
        }
        public void SetWithdrawalSlip(ReportDocument rpt, List<WithdrawSlip> lst, int width)
        {
            rpt.SetDataSource(lst);
            Width = width;
            rpt.SetParameterValue("txtEncoder", hmp.labelCurrentUserName.Text);
            rpt.SetParameterValue("UserPosition", (hmp.labelCurrentUserRole.Text == "Admin"? "Manager" : hmp.labelCurrentUserRole.Text));
            LoadReport(rpt);
        }
        public void SetReceivedSlip(ReportDocument rpt, List<ReceivedSlip> lst, int width)
        {
            rpt.SetDataSource(lst);
            Width = width;
            rpt.SetParameterValue("txtManager", hmp.labelCurrentUserName.Text);
            LoadReport(rpt);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
