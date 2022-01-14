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
    public partial class Supplier : Form
    {
        public int Person_Id { get; set; }
        public int Company_Id { get; set; }
        List<Validator> SupplierValidator = new List<Validator>();
        Homepage hmp;

        public Supplier(Homepage hmpg)
        {
            InitializeComponent();
            hmp = hmpg;
            SupplierValidator.Add(new Validator(txtCompanyName, errCompanyName, "company name", "required"));
            SupplierValidator.Add(new Validator(txtCompanyAddress, errCompanyAddress, "company address", "required"));
            SupplierValidator.Add(new Validator(txtSupplierFirstname, errFirstname, "firstname", "required|name"));
            SupplierValidator.Add(new Validator(txtSupplierLastname, errLastname, "lastname", "required|name"));
            SupplierValidator.Add(new Validator(txtPosition, errPosition, "designation / position", "name"));
            SupplierValidator.Add(new Validator(txtContact, errContact, "contact number", "required|min:11|max:11"));
            SupplierValidator.Add(new Validator(txtAddress, errAddress, "address", "required"));
            SupplierValidator.Add(new Validator(txtLeadTime, errLeadTime, "lead time", "required|max:3"));
        }

        public void TransactionType(int supplier_Id)
        {
            labelTransaction.Text = Person_Id == 0 ? "New Supplier" : "Update Supplier";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int LeadTime = string.IsNullOrEmpty(txtLeadTime.Text) ? 0 : Int32.Parse(txtLeadTime.Text);
            if (LeadTime <= 0)
            {
                Alert_Dialog.ShowAlertMessage($"Lead Time should not be less or equal to zero.", Alert_Dialog.AlertType.ERROR);
            }
            else
            {
                validateEntry();
            }
        }
        private async void validateEntry()
        {
            try
            {
                if (SupplierValidator.Count((validator) => validator.IsValid()) == SupplierValidator.Count)
                {
                    var relationshipAction = new RelationshipMapper();
                    var company = new CompanyObject()
                    {
                        Company_Id = Company_Id == 0 ? default : Company_Id,
                        Company_Name = txtCompanyName.Text,
                        Company_Address = txtCompanyAddress.Text
                    };
                    var person = new PersonObject()
                    {
                        Id = Person_Id == 0 ? default : Person_Id,
                        FirstName = txtSupplierFirstname.Text,
                        LastName = txtSupplierLastname.Text,
                        Designation = string.IsNullOrEmpty(txtPosition.Text) ? "N/A" : txtPosition.Text,
                        Contact_Number = txtContact.Text,
                        Address = txtAddress.Text
                    };
                    var relationship = new RelationshipObject()
                    {
                        Relationship_Type = "Supplier",
                        Lead_Time = Int32.Parse(txtLeadTime.Text),
                        Buyer_Status = null
                    };
                    relationshipAction.InsertOrUpdate(person, company, relationship, "RD_Relationship_InsertUpdate");
                    Alert_Dialog.ShowAlertMessage($"Supplier has been {(Person_Id == 0 ? "Added" : "Updated")} successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(hmp.current_user_Id, $"{(Person_Id == 0 ? "Created" : "Updated")} Supplier: Company Name[{txtCompanyName.Text}] with Contact Person[{txtSupplierFirstname.Text} {txtSupplierLastname.Text}], Contact No.[{txtContact.Text}]", "Data Entry");
                    btnCancel_Click(null, null);
                    await hmp.LoadSupplierList();
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

        private void txtSupplierLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validate = new InputRemoverAndValidation();
            validate.textOnlyWithSpaces(sender, e);
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validate = new InputRemoverAndValidation();
            validate.numOnly(sender, e);
        }

        private void txtLeadTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validate = new InputRemoverAndValidation();
            validate.numOnly(sender, e);
        }
    }
}
