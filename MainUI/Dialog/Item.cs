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
    public partial class Item : Form
    {
        public int Item_Id { get; set; }

        Homepage hmp;

        List<Validator> ItemValidator = new List<Validator>();
        public Item(Homepage hmpg)
        {
            InitializeComponent();
            hmp = hmpg;
            LoadCategoryList();
            ItemValidator.Add(new Validator(txtItemCode, errItemCode, "item code", "required|max:8|unique:rd_saims.tbl_item, Item_Code") { unique_ignore = txtItemCode.Text });
            ItemValidator.Add(new Validator(txtItemName, errItemName, "item name", "required|max:20|unique:rd_saims.tbl_item, Item_Name") { unique_ignore = txtItemName.Text });
            ItemValidator.Add(new Validator(txtDescription, errDescription, "description", "max:99"));

        }
        public void TransactionType(int item_Id)
        {
            labelTransaction.Text = item_Id == 0 ? "New Item" : "Update Item";
        }
        private void LoadCategoryList()
        {
            var categoryAction = new CategoryMapper();
            var categories = categoryAction.dynamicsList("RD_Category_GetList");
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Category_Name";
            cmbCategory.ValueMember = "Category_Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            validateEntry();
        }
        private async void validateEntry()
        {
            try
            {
                if (ItemValidator.Count((validator) => validator.IsValid()) == ItemValidator.Count)
                {
                    var itemAction = new ItemMapper();
                    var item = new ItemObject()
                    {
                        Item_Id = Item_Id == 0? default : Item_Id,
                        Item_Code = txtItemCode.Text,
                        Item_Name = txtItemName.Text,
                        Category_Id = Int32.Parse(cmbCategory.SelectedValue.ToString()),
                        Description = string.IsNullOrEmpty(txtDescription.Text)? "No item description" : txtDescription.Text
                    };
                    itemAction.InsertOrUpdate(item, "RD_Item_InsertUpdate");
                    Alert_Dialog.ShowAlertMessage($"Item has been {(Item_Id == 0 ? "Added" : "Updated")} successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(hmp.current_user_Id, $"{(Item_Id == 0 ? "Created" : "Updated")} an Item: Item Code[{txtItemCode.Text}], Item Name[{txtItemName.Text}]", "Data Entry");
                    btnCancel_Click(null, null);
                    await hmp.LoadItemList();
                }
            }
            catch
            {
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

        private void txtItemCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validate = new InputRemoverAndValidation();
            validate.allowTextAndDigitOnly(sender, e);
        }

        private void txtItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validate = new InputRemoverAndValidation();
            validate.allowTextAndDigitOnly(sender, e);
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validate = new InputRemoverAndValidation();
            validate.allowTextAndDigitOnly(sender, e);
        }
    }
}
