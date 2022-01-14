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
using System.Xml;
using UtilitiesLibrary;

namespace MainUI.Dialog
{
    public partial class Plan_Entry : Form
    {
        //Default Value for Pond Entry (Standard Values)
        const int Actual_Body_Weight = 15, Survival_Rate = 85;
        const double Feeds_Consumed_Ratio = 1.5;
        DateTime DefaultHarvestDate = DateTime.Now.Date.AddDays(120);
        public int Area { get; set; }
        public int Production_Id { get; set; }
        int tries = 0;
        List<Validator> PEValidator = new List<Validator>();
        Homepage hmp;

        public Plan_Entry(Homepage hmpg)
        {
            InitializeComponent();
            lblFarmName.Text = GetCurrentFarmName();
            hmp = hmpg;
            PEValidator.Add(new Validator(txtFryStocked, errFryStock, "total fry stock", "required|nozero"));
            PEValidator.Add(new Validator(txtProductionNumber, errProdNum, "production no.", "required|min:4|nozero"));
            dtpDateStocked.Value = DateTime.Now;
        }
        public void TransactionType(string type)
        {
            labelTransaction.Text = type == "Create" ? "Create Pond Entry" : "Update Pond Entry";
            dtpHarvest.Value = DefaultHarvestDate;
            dtpHarvest_ValueChanged(null, null);
        }
        public void fillCombo()
        {
            try
            {
                var pondAction = new PondMapper();
                var ponds = pondAction.dynamicsList("RD_Pond_GetList");
                cmbPond.DataSource = ponds;
                cmbPond.DisplayMember = "Pond_Code";
                cmbPond.ValueMember = "Pond_Id";

                var supplierAction = new RelationshipMapper();
                var relationship = new RelationshipObject()
                {
                    Relationship_Type = "Supplier"
                };
                var supplier = supplierAction.dynamicsListWithParam(relationship, "RD_Relationship_GetListByType");
                cmbSupplier.DataSource = supplier;
                cmbSupplier.DisplayMember = "Company_Name";
                cmbSupplier.ValueMember = "Person_Id";
            }
            catch { }
        }
        private string GetCurrentFarmName()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(SystemPath.FarmPath);
            string farmOwner = xmlDoc.SelectSingleNode("/ Farm / Name").InnerText;
            return farmOwner;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            validateEntry();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cmbPond_TextChanged(object sender, EventArgs e)
        {
            cmbPond.SelectedItem = cmbPond.Text;
        }

        private void cmbSupplier_TextChanged(object sender, EventArgs e)
        {
            cmbSupplier.SelectedItem = cmbSupplier.Text;
        }

        private void cmbPond_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var area = new QueryWorker().returnScalarText($"SELECT Pond_Area FROM rd_saims.tbl_pond WHERE Pond_Code = '{cmbPond.Text}'");
            Area = Int32.Parse(area);
            lblArea.Text = $"Area: {area}";
        }

        private void txtFryStocked_KeyPress(object sender, KeyPressEventArgs e)
        {
            new InputRemoverAndValidation().numOnly(sender, e);
        }

        private void txtProductionNumber_Click(object sender, EventArgs e)
        {
            if (tries <= 0)
            {
                var result = Confirmation.ShowDialog("Are you sure modify production number?");
                if (result == DialogResult.Yes)
                {
                    tries++;
                }
            }
        }

        private void dtpHarvest_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan tm = dtpDateStocked.Value - dtpHarvest.Value;
            if (dtpDateStocked.Value > dtpHarvest.Value) {
                Alert_Dialog.ShowAlertMessage("Date Stocked must be less than Date of Harvest", Alert_Dialog.AlertType.ERROR);
            }
            else
            {
                lblDOC.Text = tm.Days.ToString().Replace("-", "");
            }
        }

        private void txtFryStocked_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int tfs = Int32.Parse(txtFryStocked.Text);
                lblBiomass.Text = GetBiomass(tfs);
                lblSD.Text = String.Format("{0:n0}", tfs / Area);
            }
            catch 
            {
            }

        }
        private string GetBiomass(int tfs)
        {
            double biomass;
            biomass = ((((tfs * Actual_Body_Weight) * Survival_Rate)/100) / 1000);
            lblFeedsRequired.Text = GetFeedsRequired(biomass);
            return String.Format("{0:n}", biomass);

        }
        private string GetFeedsRequired(double biomass)
        {
            var fr = biomass * Feeds_Consumed_Ratio;
            return String.Format("{0:n0}", fr);
        }

        private void txtFryStocked_Validated(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty((sender as Guna2TextBox).Text))
            {
                lblBiomass.Text = "0";
                lblSD.Text = "0";
                lblFeedsRequired.Text = "0";
            }
        }

        private void validateEntry()
        {
            if (PEValidator.Count((validator) => validator.IsValid()) == PEValidator.Count)
            {
                var prodAction = new ProductionMapper();
                var entry = new ProductionObject()
                {
                    Production_Id = Production_Id,
                    Production_Number = Int64.Parse(txtProductionNumber.Text),
                    Total_Fry_Stocked = Int64.Parse(txtFryStocked.Text.Replace(",","")),
                    Date_Stocked = Convert.ToDateTime(dtpDateStocked.Value.ToString("yyyy-MM-dd")),
                    Date_Of_Harvest = Convert.ToDateTime(dtpHarvest.Value.ToString("yyyy-MM-dd")),
                    Supplier_Id = Int32.Parse(cmbSupplier.SelectedValue.ToString()),
                    Crop_Number = Int32.Parse(txtCropNumber.Value.ToString()),
                    Farm_Name = lblFarmName.Text,
                    Entry_Status = "Plan"
                };
                prodAction.Update(entry, "RD_Production_CreateUpdateEntry");
                Alert_Dialog.ShowAlertMessage($"Entry has been created successfully", Alert_Dialog.AlertType.SUCCESS);
                new AuditTrailMapper().InsertActivity(hmp.current_user_Id, $"{(Production_Id == 0? "Created": "Updated")} Pond Entry with Production No.:[{txtProductionNumber.Text}] for Pond[{cmbPond.Text}]", "Pond Entry");
                btnCancel_Click(null, null);
                hmp.LoadPondEntryList();
            }
        }

    }
}
