using Guna.UI2.WinForms;
using MainUI.Forms.Admin_Forms;
using MapperLibrary.Controller;
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
    public partial class Create_Harvest : Form
    {
        public int Production_Id {get; set;}
        public string Production_Number { get; set; }
        public double Abw { get; set; }
        public long Qty { get; set; }
        List<Validator> HValidator = new List<Validator>();
        Homepage hmp;
        public Create_Harvest(Homepage hmpg)
        {
            InitializeComponent();
            HValidator.Add(new Validator(txtHarvestedQty, errHarvestedQty, "harvest quantity", "required"));
            hmp = hmpg;
        }
        public void SetProductionNo(string prodNum)
        {
            lblProdnum.Text = $"Set Production No. {prodNum} sampling as:";
            Production_Number = prodNum;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            validateEntry();
        }

        private void validateEntry()
        {
            if (HValidator.Count((validator) => validator.IsValid()) == HValidator.Count)
            {
                var result = Confirmation.ShowDialog($"Are you sure to set {(rbtnFull.Checked == true ? "Full" : "Partial")} harvest for Production No. {Production_Number}");
                if (result == DialogResult.Yes) {
                    var prodAction = new ProductionMapper();
                    var entry = new ProductionObject()
                    {
                        Production_Id = Production_Id,
                        Harvest_Quantity = Int64.Parse(lblKGS.Text.Replace(",","")),
                        Date_Of_Harvest = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")),
                        Harvest_Status = GetHarvestStatus(),
                        Crop_Number = rbtnFull.Checked == true ? default : Int32.Parse(lblCropNo.Text)
                    };
                    prodAction.Update(entry, "RD_Production_InsertUpdateHarvest");
                    Alert_Dialog.ShowAlertMessage($"Entry has been created successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(hmp.current_user_Id, $"Created {(rbtnFull.Checked == true ? "Full" : "Partial")} Harvest for Production No.[{lblProdnum.Text}]", "Pond Entry");
                    btnCancel_Click(null, null);
                    hmp.LoadPondEntryList();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private string GetHarvestStatus()
        {
            string status = "";

            if(rbtnFull.Checked == true)
            {
                status = "Full";
            }
            else if(rbtnPartial.Checked == true)
            {
                status = "Partial";
            }

            return status;
        }

        private void txtHarvestedQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            new InputRemoverAndValidation().numOnly(sender, e);
        }

        private void txtHarvestedQty_TextChanged(object sender, EventArgs e)
        {
            
            txtHarvestedQty_Validated(sender, e);
        }

        private void txtHarvestedQty_Validated(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty((sender as Guna2TextBox).Text)) 
            {
                if (Double.Parse(txtHarvestedQty.Text) > Qty)
                {
                    rbtnFull.Checked = true;
                }

                ConvertPCStoKGs(Double.Parse(txtHarvestedQty.Text), Abw);
            }
            else
            {
                lblKGS.Text = "0"; lblPCS.Text = "0";
            }
        }
        private void ConvertPCStoKGs(double qty, double abw)
        {
            var kgs = ((abw / 1000) * qty);
            lblKGS.Text = String.Format("{0:n0}", kgs);
            var pcs = (qty / ((abw / 1000) * Qty));
            lblPCS.Text = String.Format("{0:n0}", pcs);
        }

        private void rbtnFull_CheckedChanged(object sender, EventArgs e)
        {
            if((sender as Guna2RadioButton).Name == rbtnFull.Name)
            {
                lblHarvest.Text = "Harvested Quantity (≈ pcs)";
                txtHarvestedQty.Text = Qty.ToString();
            }
            else if((sender as Guna2RadioButton).Name == rbtnPartial.Name)
            {
                lblHarvest.Text = "Partial Harvest Quantity (≈ pcs)";
                txtHarvestedQty.Text = string.Empty;

            }
        }
    }
}
