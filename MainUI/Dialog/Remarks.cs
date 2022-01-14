using MainUI.Forms.Admin_Forms;
using MainUI.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilitiesLibrary;

namespace MainUI.Dialog
{
    public partial class Remarks : Form
    {
        Homepage hmp;
        List<Validator> rmValidator = new List<Validator>();
        public Remarks(Homepage hmpg)
        {
            InitializeComponent();
            rmValidator.Add(new Validator(txtSampRemarks, errSampRemarks, "remarks/notes", "required"));
            hmp = hmpg;
        }

        private void btnConfirmRemarks_Click(object sender, EventArgs e)
        {
            if(rmValidator.Count((validator) => validator.IsValid()) == rmValidator.Count)
            {
                using (Printer fp = new Printer(hmp))
                {
                    fp.SetProductionSamplingWithRemarks(this, new rptSampling());
                    fp.ShowDialog();
                }
                Dispose();
            }
        }

        private void btnCancelRemarks_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
