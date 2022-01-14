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
    public partial class FeedsType : Form
    {
        public int FeedsType_Id { get; set; }

        Homepage hmp;

        List<Validator> FTypeValidator = new List<Validator>();
        public FeedsType(Homepage hmpg)
        {
            InitializeComponent();
            hmp = hmpg;
            FTypeValidator.Add(new Validator(txtFeedsTypeCode, errFeedsTypeCode, "feeds type", "required|max:8|unique:rd_saims.tbl_feedstype, FeedsType_Code") { unique_ignore = txtFeedsTypeCode.Text });
            FTypeValidator.Add(new Validator(txtDescription, errDescription, "description", "required|max:99"));
        }
        public void TransactionType(int ftype_Id)
        {
            labelTransaction.Text = ftype_Id == 0 ? "New Feeds Type" : "Update Feeds Type";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            validateEntry();
        }
        private async void validateEntry()
        {
            try
            {
                if (FTypeValidator.Count((validator) => validator.IsValid()) == FTypeValidator.Count)
                {
                    var ftypeAction = new FeedsTypeMapper();
                    var ftype = new FeedsTypeObject()
                    {
                        FeedsType_Id = FeedsType_Id == 0 ? default : FeedsType_Id,
                        FeedsType_Code = txtFeedsTypeCode.Text,
                        Description = string.IsNullOrEmpty(txtDescription.Text) ? "No feeds type description" : txtDescription.Text
                    };
                    ftypeAction.InsertOrUpdate(ftype, "RD_FeedsType_InsertUpdate");
                    Alert_Dialog.ShowAlertMessage($"FeedsType has been {(FeedsType_Id == 0 ? "Added" : "Updated")} successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(hmp.current_user_Id, $"{(FeedsType_Id == 0 ? "Created" : "Updated")} Feeds type: Type Code[{txtFeedsTypeCode.Text}], Description[{txtDescription.Text}]", "Data Entry");
                    btnCancel_Click(null, null);
                    await hmp.LoadFeedsTypeList();
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

        private void txtFeedsTypeCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validate = new InputRemoverAndValidation();
            validate.allowTextAndDigitOnly(sender, e);
        }
    }
}
