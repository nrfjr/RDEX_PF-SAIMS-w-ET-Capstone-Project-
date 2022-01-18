using Guna.UI2.WinForms;
using MainUI.Forms.Admin_Forms;
using MapperLibrary.Controller;
using MapperLibrary.Helper;
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
using UtilitiesLibrary;

namespace MainUI.Dialog
{
    public partial class Weekly_Status : Form
    {
        public int tries { get; set; }
        Homepage hmp;
        List<Validator> SamplingValidator = new List<Validator>();
        public Weekly_Status(Homepage hmpg)
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(txtSampRefNo.Text)) { GetReferenceNumber(); }
            SamplingValidator.Add(new Validator(txtLABW, errLABW, "latest body weight", "required"));
            SamplingValidator.Add(new Validator(txtLSR, errLSR, "latest survival rate", "required"));
            SamplingValidator.Add(new Validator(txtLabTech, errLabtech, "laboratory technician", "required|name"));
            SamplingValidator.Add(new Validator(txtSampRefNo, errSampRefNo, "sampling reference", "required"));
            hmp = hmpg;
        }
        public void fillProduction()
        {
            try
            {
                var prodAction = new ProductionMapper();
                var farmName = new ProductionObject()
                {
                    Farm_Name = hmp.GetCurrentFarmName()
                };
                var ponds = prodAction.dynamicsListWithParam(farmName, "RD_Production_GetOccupiedList");
                cmbPond.DataSource = ponds;
                cmbPond.DisplayMember = "Pond_Code";
                cmbPond.ValueMember = "Production_Id";
            }
            catch { }
        }
        private void RetrieveProductionDetailsByPond(string code, int week)
        {
            try
            {
                var prodAction = new ProductionMapper();
                var pond = new ProductionObject()
                {
                    Entry_Status = code,
                    Week_Number = week
                };
                var details = prodAction.dynamicsListWithParam(pond, "RD_Production_GetSamplingListByPond");
                var dt = new DataTable();
                var dgvworker = new ListToDataTableWorker();
                dt = dgvworker.ConvertToDataTable(details);

                lblProductionNo.Text = dt.Rows[0][1].ToString();
                lblCN.Text = dt.Rows[0][2].ToString();
                txtWN.Value = Int32.Parse(dt.Rows[0][3].ToString());
                lblArea.Text = $"Area: {dt.Rows[0][5].ToString()}";
                lblDateStock.Text = dt.Rows[0][7].ToString();
                lblDOC.Text = string.IsNullOrEmpty(dt.Rows[0][9].ToString()) ? "0" : dt.Rows[0][9].ToString();
                lblTotalFryStock.Text = dt.Rows[0][10].ToString();
                lblSD.Text = dt.Rows[0][11].ToString();
                lblABW.Text = dt.Rows[0][12].ToString();
                lblSR.Text = dt.Rows[0][13].ToString();
                lblBiomass.Text = dt.Rows[0][14].ToString();
                lblFCR.Text = dt.Rows[0][16].ToString();
                lblWeekly.Text = string.IsNullOrEmpty(dt.Rows[0][17].ToString()) ? "0" : dt.Rows[0][17].ToString().Replace("-","");
                lblCummu.Text = string.IsNullOrEmpty(dt.Rows[0][18].ToString()) ? "0" : dt.Rows[0][18].ToString();
                lblDay.Text = GetDailyFeeds(Double.Parse(dt.Rows[0][17].ToString())).Replace("-","");
            }
            catch
            {}
        }

        private string GetDailyFeeds(double weekly_feeds)
        {
            var daily = weekly_feeds / 7;
            return String.Format("{0:n}", (daily == 0)? 0: daily);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            validateEntry();
        }
        private async void validateEntry()
        {
            if (SamplingValidator.Count((validator) => validator.IsValid()) == SamplingValidator.Count)
            {
                DialogResult result = Confirmation.ShowDialog("Are you sure to save this sampling?");
                if (result == DialogResult.Yes)
                {
                    var prodAction = new ProductionMapper();
                    var entry = new ProductionObject()
                    {
                        Production_Id = Int32.Parse(cmbPond.SelectedValue.ToString()),
                        Sampling_Date = Convert.ToDateTime(dtpSampling.Value.ToString("yyyy-MM-dd")),
                        Actual_Body_Weight = Double.Parse(txtLABW.Text),
                        Weekly_Cummulative = Double.Parse(lblWeekly.Text.Replace("-", "")),
                        Week_Number = Int32.Parse(txtWN.Value.ToString()),
                        Survival_Rate = Double.Parse(txtLSR.Text),
                        Lab_Technician = txtLabTech.Text,
                        Sampling_Reference = Int64.Parse(txtSampRefNo.Text)
                    };
                    prodAction.Update(entry, "RD_Production_InsertUpdateSampling");
                    Alert_Dialog.ShowAlertMessage($"Week {txtWN.Value.ToString()} sampling has been created successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(hmp.current_user_Id, $"Created Week[{txtWN.Value.ToString()}] Sampling for Production No.[{lblProductionNo.Text}]", "Pond Entry");
                    btnCancel_Click(null, null);
                    await hmp.LoadWeekyUpdateList(Int32.Parse(lblProductionNo.Text));
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dtpSampling_ValueChanged(object sender, EventArgs e)
        {
            SetDOC(lblDateStock, dtpSampling);
        }
        private void SetDOC(Label stocking, Guna2DateTimePicker sampling)
        {
            TimeSpan tm = Convert.ToDateTime(stocking.Text) - sampling.Value;
            if (sampling.Value < Convert.ToDateTime(stocking.Text))
            {
                Alert_Dialog.ShowAlertMessage("Date Stocked must be less than Sampling Date", Alert_Dialog.AlertType.ERROR);
            }
            else
            {
                lblDOC.Text = tm.Days.ToString().Replace("-", "");
            }
        }

        private void cmbPond_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RetrieveProductionDetailsByPond(cmbPond.Text, Int32.Parse(txtWN.Value.ToString()));
        }

        private void cmbPond_TextChanged(object sender, EventArgs e)
        {
            cmbPond.SelectedItem = cmbPond.Text;
        }

        private void txtLABW_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLABW.Text))
            {
                SetIncDecAndGPD(Double.Parse(lblABW.Text), Double.Parse(txtLABW.Text));
            }
            else
            {
                lblIncDec.Text = "0";
                lblGPD.Text = "0";
            }
        }

        private void SetIncDecAndGPD(double abw, double labw) 
        {
            var incdec = labw - abw;
            lblIncDec.Text = String.Format("{0:n}", incdec);
            var gpd = incdec / 7;
            lblGPD.Text = String.Format("{0:n}", gpd);
        }

        private void txtLABW_KeyPress(object sender, KeyPressEventArgs e)
        {
            new InputRemoverAndValidation().numAndDotOnly(sender, e);
        }

        private void txtLSR_KeyPress(object sender, KeyPressEventArgs e)
        {
            new InputRemoverAndValidation().numOnly(sender, e);
        }

        private void txtLSR_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtLABW.Text) && !string.IsNullOrEmpty(txtLSR.Text) && !string.IsNullOrEmpty(lblTotalFryStock.Text) && !string.IsNullOrEmpty(lblWeekly.Text))
            {
                SetBiomassAndFCR(Int32.Parse(lblTotalFryStock.Text.Replace(",", "")), Double.Parse(txtLABW.Text), Int32.Parse(txtLSR.Text), Double.Parse(lblWeekly.Text.Replace(",","")));
            }
            else
            {
                RetrieveProductionDetailsByPond(cmbPond.Text, Int32.Parse(txtWN.Value.ToString()));
            }
        }
        private void SetBiomassAndFCR(int totalstock, double labw, double lsr, double wfeeds)
        {
            double biomass = 0, fcr = 0;
            biomass = ((((totalstock * labw) * lsr) / 100) / 1000);
            lblBiomass.Text = String.Format("{0:n0}", biomass);
            fcr = wfeeds / biomass;
            lblFCR.Text = String.Format("{0:n}", fcr);
        }
        private void GetReferenceNumber()
        {
            long LastSamplingReferenceNumber = 100000;
            var os = new QueryWorker().returnScalarText($"SELECT (CASE WHEN Sampling_Reference IS NULL THEN 0 WHEN Sampling_Reference IS NOT NULL THEN Sampling_Reference + 1 END) AS Sampling_Reference FROM rd_saims.tbl_weeklyupdate Order By Production_Id DESC LIMIT 1; ");
            if (!string.IsNullOrEmpty(os) && os != "0") { LastSamplingReferenceNumber = Convert.ToInt64(os); }
            if (LastSamplingReferenceNumber != 0)
            {
                txtSampRefNo.Text = Convert.ToString(LastSamplingReferenceNumber);
            }
            else
            {
                txtSampRefNo.Text = Convert.ToString(LastSamplingReferenceNumber);
            }
        }

        private void txtSampRefNo_Click(object sender, EventArgs e)
        {
            if (tries <= 0)
            {
                DialogResult result = Confirmation.ShowDialog("Are you sure to modify Sampling Reference Number?");
                if (result == DialogResult.Yes)
                {
                    tries++;
                }
            }
 
        }
    }
}
