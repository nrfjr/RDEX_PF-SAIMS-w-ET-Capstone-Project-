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
    public partial class Stock_Management : Form
    {
        Homepage hmp;
        public int Stock_Id { get; set; }
        public string Previous_Unit { get; set; }
        public double DefaultQty { get; set; }
        public int Lead_Time { get; set; }

        List<Validator> StockValidator = new List<Validator>();

        public Stock_Management(Homepage hmpg)
        {
            InitializeComponent();
            hmp = hmpg;
            StockValidator.Add(new Validator(txtRefNum, errRefNum, "reference number", "required"));
            StockValidator.Add(new Validator(txtQty, errQty, "quantity", "required|nozero"));
            StockValidator.Add(new Validator(txtConsume, errConsume, "consumption", "nozero"));
        }

        public void TransactionType(string type)
        {
            labelTransaction.Text = $"Manage {type} Stock";
        }
        public void fillCombo()
        {
            try
            {
                var categoryAction = new CategoryMapper();
                var category = categoryAction.dynamicsList("RD_Category_GetList");
                cmbCategory.DataSource = category;
                cmbCategory.DisplayMember = "Category_Name";
                cmbCategory.ValueMember = "Category_Id";

                var ftypeAction = new FeedsTypeMapper();
                var ftypes = ftypeAction.dynamicsList("RD_FeedsType_GetList");
                cmbFType.DataSource = ftypes;
                cmbFType.DisplayMember = "FeedsType_Code";
                cmbFType.ValueMember = "FeedsType_Id";

                var supplierAction = new RelationshipMapper();
                var relationship = new RelationshipObject()
                {
                    Relationship_Type = "Supplier"
                };
                var supplier = supplierAction.dynamicsListWithParam(relationship, "RD_Relationship_GetListByType");
                cmbSupplier.DataSource = supplier;
                cmbSupplier.DisplayMember = "Company_Name";
                cmbSupplier.ValueMember = "Person_Id";

                var unitAction = new UnitMapper();
                var units = unitAction.dynamicsList("RD_Unit_GetList");
                cmbUnit.DataSource = units;
                cmbUnit.DisplayMember = "Expression";
                cmbUnit.ValueMember = "Unit_Id";
            }
            catch { throw; }
        }
        private void LoadItems()
        {
            try
            {
                var itemAction = new ItemMapper();
                var category_Id = new ItemObject()
                {
                    Category_Id = Int32.Parse(cmbCategory.SelectedValue.ToString())
                };
                var items = itemAction.dynamicsListWithParam(category_Id, "RD_Item_GetListByCategory");
                cmbItem.DataSource = items;
                cmbItem.DisplayMember = "Item_Name";
                cmbItem.ValueMember = "Item_Id";
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            validateManagement();
        }
        private async void validateManagement()
        {
            if (StockValidator.Count((validator) => validator.IsValid()) == StockValidator.Count)
            {
                try
                {
                    var invAction = new InventoryMapper();
                    var inv = new InventoryStockObject()
                    {
                        Inventory_Id = Stock_Id,
                        Reference_Number = txtRefNum.Text,
                        Supplier_Id = Int32.Parse(cmbSupplier.SelectedValue.ToString()),
                        Item_Id = Int32.Parse(cmbItem.SelectedValue.ToString()),
                        FType_Id = cmbFType.Visible == false ? default : Int32.Parse(cmbFType.SelectedValue.ToString()),
                        Quantity = Double.Parse(txtQty.Text.Replace(",", "")),
                        Restock_Point = Int32.Parse(txtRestock.Text),
                        Unit_Id = Int32.Parse(cmbUnit.SelectedValue.ToString())
                    };
                    invAction.InsertOrUpdate(inv, "RD_Stock_UpdateAvailable");
                    Alert_Dialog.ShowAlertMessage($"Changes has been applied successfully.", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(hmp.current_user_Id, $"{(Stock_Id == 0? "Created": "Updated")} Item:[{cmbItem.Text}], Item Type:[{(cmbFType.Visible == true? cmbFType.Text: "")}], Quantity:[{txtQty.Text}] Unit:[{cmbUnit.Text}]", "Inventory");
                    btnCancel_Click(null, null);
                    await hmp.LoadAvailableList();
                }
                catch { }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cmbCategory_TextChanged(object sender, EventArgs e)
        {
            cmbCategory.SelectedItem = cmbCategory.Text;
        }

        private void cmbFType_TextChanged(object sender, EventArgs e)
        {
            cmbFType.SelectedItem = cmbFType.Text;
        }

        private void cmbItem_TextChanged(object sender, EventArgs e)
        {
            cmbItem.SelectedItem = cmbItem.Text;
        }

        private void cmbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbCategory.DataSource != null)
            {
                if(cmbCategory.Text == "Goods")
                {
                    labelFType.Visible = false;
                    cmbFType.Visible = false;
                }
                LoadItems();
            }

        }

        private void cmbUnit_TextChanged(object sender, EventArgs e)
        {
            cmbUnit.SelectedItem = cmbUnit.Text;
        }
        private void cmbUnit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var uc = new UnitConverter();
            txtQty.Text = uc.ConvertUnit(DefaultQty, Previous_Unit, cmbUnit.Text);
        }

        private void txtConsume_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtRestock.Text = Convert.ToString(Double.Parse(txtConsume.Text) * Lead_Time);
                txtConsume_Validated(sender, e);
            }
            catch { }
        }

        private void cmbSupplier_TextChanged(object sender, EventArgs e)
        {
            cmbSupplier.SelectedItem = cmbSupplier.Text;
        }

        private async void cmbSupplier_SelectedValueChanged(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            var LeadTime = new QueryWorker().returnScalarText($"SELECT Lead_Time FROM rd_saims.tbl_relationship WHERE Person_Id = {Int32.Parse(cmbSupplier.SelectedValue.ToString())}");
            Lead_Time = Int32.Parse(LeadTime);
        }

        private void txtRefNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            new InputRemoverAndValidation().allowTextAndDigitOnly(sender, e);
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            new InputRemoverAndValidation().numAndDotOnly(sender, e);
        }

        private void txtConsume_Validated(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty((sender as Guna2TextBox).Text))
            {
                txtRestock.Text = string.Empty;
            }
        }
    }
}
