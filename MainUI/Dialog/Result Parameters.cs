using MainUI.Forms.Admin_Forms;
using RDEX.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using UtilitiesLibrary;

namespace MainUI.Dialog
{
    public partial class Result_Parameters : Form
    {
        Homepage hmp;
        public Result_Parameters(Homepage hmpg)
        {
            InitializeComponent();
            hmp = hmpg;
            txtFarmName.Text = GetFarmName();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Value > dtpTo.Value)
            {
                Alert_Dialog.ShowAlertMessage("Date 'From' should be lesser than Date 'To'", Alert_Dialog.AlertType.WARNING);
            }
            else
            {
                using (Printer fp = new Printer(hmp))
                {
                    fp.setTitle("Pond Result Report");
                    fp.SetProductionResult(this, new rptResult());
                    fp.ShowDialog();
                    Dispose();
                }
            }
        }
        private string GetFarmName()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(SystemPath.FarmPath);
            return xmlDoc.SelectSingleNode("/ Farm / Name").InnerText;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
