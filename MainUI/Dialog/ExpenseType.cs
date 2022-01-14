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
    public partial class ExpenseType : Form
    {
        public int ExpenseType_Id { get; set; }

        Homepage hmp;

        List<Validator> XTypeValidator = new List<Validator>();
        public ExpenseType(Homepage hmpg)
        {
            InitializeComponent();
            hmp = hmpg;
            XTypeValidator.Add(new Validator(txtExpenseType, errExpenseType, "expense type", "required|unique:rd_saims.tbl_expensetype, ExpenseType_Title") { unique_ignore = txtExpenseType.Text });
            XTypeValidator.Add(new Validator(txtDescription, errDescription, "description", "required|max:99"));
        }
        public void TransactionType(int xtype_Id)
        {
            labelTransaction.Text = xtype_Id == 0 ? "New Expense Type" : "Update Expense Type";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            validateEntry();
        }
        private async void validateEntry()
        {
            try
            {
                if (XTypeValidator.Count((validator) => validator.IsValid()) == XTypeValidator.Count)
                {
                    var xtypeAction = new ExpenseTypeMapper();
                    var xtype = new ExpenseTypeObject()
                    {
                        ExpenseType_Id = ExpenseType_Id == 0 ? default : ExpenseType_Id,
                        Expense_Type = txtExpenseType.Text,
                        Description = string.IsNullOrEmpty(txtDescription.Text) ? "No expense description" : txtDescription.Text
                    };
                    xtypeAction.InsertOrUpdate(xtype, "RD_ExpenseType_InsertUpdate");
                    Alert_Dialog.ShowAlertMessage($"ExpenseType has been {(ExpenseType_Id == 0 ? "Added" : "Updated")} successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(hmp.current_user_Id, $"{(ExpenseType_Id == 0 ? "Created" : "Updated")} Expense Type: Expense Type Name[{txtExpenseType.Text}], Description[{txtDescription.Text}]", "Data Entry");
                    btnCancel_Click(null, null);
                    await hmp.LoadExpenseTypeList();
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

        private void txtExpenseType_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validate = new InputRemoverAndValidation();
            validate.allowTextAndDigitOnly(sender, e);
        }
    }
}
