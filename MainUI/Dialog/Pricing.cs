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
    public partial class Pricing : Form
    {
        public int Price_Id { get; set; }

        Homepage hmp;

        List<Validator> PriceValidator = new List<Validator>();
        public Pricing(Homepage hmpg)
        {
            InitializeComponent();
            hmp = hmpg;
            PriceValidator.Add(new Validator(txtPriceCode, errPriceCode, "price code", "required|max:8|unique:rd_saims.tbl_price, Price_Code") { unique_ignore = txtPriceCode.Text });
            PriceValidator.Add(new Validator(txtPriceValue, errPriceValue, "price value", "required"));
        }
        public void TransactionType(int price_Id)
        {
            labelTransaction.Text = price_Id == 0 ? "New Price" : "Update Price";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            validateEntry();
        }
        private async void validateEntry()
        {
            try
            {
                if (PriceValidator.Count((validator) => validator.IsValid()) == PriceValidator.Count)
                {
                    var priceAction = new PriceMapper();
                    var price = new PriceObject()
                    {
                        Price_Id = Price_Id == 0 ? default : Price_Id,
                        Price_Code = txtPriceCode.Text,
                        Price_Value = Decimal.Parse(txtPriceValue.Text)
                    };
                    priceAction.InsertOrUpdate(price, "RD_Price_InsertUpdate");
                    Alert_Dialog.ShowAlertMessage($"Price has been {(Price_Id == 0 ? "Added" : "Updated")} successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(hmp.current_user_Id, $"{(Price_Id == 0 ? "Created" : "Updated")} Pricing[{txtPriceCode.Text}], Value[{txtPriceValue.Text}]", "Data Entry");
                    btnCancel_Click(null, null);
                    await hmp.LoadPricingList();
                }
            }
            catch
            {
                throw;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtPriceCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validate = new InputRemoverAndValidation();
            validate.allowTextAndDigitOnly(sender, e);
        }

        private void txtPriceValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validate = new InputRemoverAndValidation();
            validate.numAndDotOnly(sender, e);
        }
    }
}
