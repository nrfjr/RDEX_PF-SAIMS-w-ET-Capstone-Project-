using Guna.UI2.WinForms;
using MainUI.Datasets;
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
    public partial class Withdrawal : Form
    {
        Homepage hmp;
        public int Stock_Id { get; set; }
        public string Category { get; set; }
        public double AvailableQty { get; set; }
        List<Validator> WDrawValidator = new List<Validator>();
        public Withdrawal(Homepage hmpg)
        {
            InitializeComponent();
            hmp = hmpg;
            WDrawValidator.Add(new Validator(txtWQty, errWQty, "quantity", "required|nozero"));
        }
        public void TransactionType(string type)
        {
            labelTransaction.Text = type.Equals("Feeds") ? "Feeds Withdrawal" : "Goods Withdrawal" ;
            if(type == "Feeds")
            {
                labelProduction.Visible = true;
                cmbProduction.Visible = true;
                fillProduction();
            } 
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
                cmbProduction.DataSource = ponds;
                cmbProduction.DisplayMember = "Production_Number";
                cmbProduction.ValueMember = "Production_Id";
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double wdraw = string.IsNullOrEmpty(txtWQty.Text) ? 0 : Double.Parse(txtWQty.Text);
            if ( wdraw > AvailableQty)
            {
                Alert_Dialog.ShowAlertMessage($"Withdrawal quantity must be less than or equal to Available quantity.", Alert_Dialog.AlertType.WARNING);
            }
            else if ((wdraw - AvailableQty) == 0)
            {
                DialogResult result = Confirmation.ShowDialog($"Withdrawal causes stock to be empty, Are you sure to continue?");
                if (result == DialogResult.Yes)
                {
                    validateWithdrawal();
                }

            }
            else
            {
                validateWithdrawal();
            }

        }

        private async void validateWithdrawal()
        {

            if (WDrawValidator.Count((validator) => validator.IsValid()) == WDrawValidator.Count)
            {
                var invAction = new InventoryMapper();
                var withdraw = new InventoryStockObject()
                {
                    Production_Id = (cmbProduction.Visible == false) ? default : Int32.Parse(cmbProduction.SelectedValue.ToString()),
                    Quantity = Double.Parse(txtWQty.Text),
                    Inventory_Id = Stock_Id,
                };
                invAction.InsertOrUpdate(withdraw, "RD_Stock_InsertUpdateWithdraw");
                Alert_Dialog.ShowAlertMessage("Withdraw successfully", Alert_Dialog.AlertType.SUCCESS);
                new AuditTrailMapper().InsertActivity(hmp.current_user_Id, $"Withdraw {labelItem.Text}{(labelType.Text == "None" ? "" : labelType.Text)}, Quantity[{txtWQty.Text}], Unit[{labelUnits.Text}]", "Inventory");
                var WdrawDetails = new WithdrawSlip(txtWQty.Text, labelItem.Text, labelType.Text, labelUnits.Text, cmbProduction.Text, Category);
                hmp.WdrawDetails.Add(WdrawDetails);
                btnCancel_Click(null, null);
                await hmp.LoadAvailableWithdrawList();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtWQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            new InputRemoverAndValidation().numAndDotOnly(sender, e);

        }
        private void SetDeduction(double wqty)
        {
            double newqty = AvailableQty - wqty;

            if(newqty == 0)
            {
                labelQty.Text = String.Format("{0:n}", AvailableQty);
            }
            else
            {
                labelQty.Text = String.Format("{0:n}", newqty);
            }

        }

        private void txtWQty_TextChanged(object sender, EventArgs e)
        {
            txtWQty_Validated(sender, e);
        }

        private void txtWQty_Validated(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty((sender as Guna2TextBox).Text))
            {
                labelQty.Text = String.Format("{0:n}", AvailableQty);
            }
            else
            {
                SetDeduction(Double.Parse(txtWQty.Text));
            }
        }
    }
}
