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
    public partial class Customers : Form
    {
        public int Person_Id { get; set; }
        public int Company_Id { get; set; }
        List<Validator> CustomerValidator = new List<Validator>();
        Homepage hmp;
        public Customers(Homepage hmpg)
        {
            InitializeComponent();
            hmp = hmpg;
            CustomerValidator.Add(new Validator(txtCompanyName, errCompanyName, "Company / Store name", "required"));
            CustomerValidator.Add(new Validator(txtCompanyAddress, errCompanyAddress, "Company / Store address", "required"));
            CustomerValidator.Add(new Validator(txtCustomerFirstname, errFirstname, "firstname", "required|name"));
            CustomerValidator.Add(new Validator(txtCustomerLastname, errLastname, "lastname", "required|name"));
            CustomerValidator.Add(new Validator(txtPosition, errPosition, "deignation / position", "name"));
            CustomerValidator.Add(new Validator(txtContact, errContact, "contact number", "required|min:11|max:11"));
            CustomerValidator.Add(new Validator(txtAddress, errAddress, "address", "required"));
        }
        public void TransactionType(int customer_Id)
        {
            labelTransaction.Text = customer_Id == 0 ? "New Customer" : "Update Customer";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            validateEntry();
        }
        private async  void validateEntry()
        {
            try
            {
                if (CustomerValidator.Count((validator) => validator.IsValid()) == CustomerValidator.Count)
                {
                    var relationshipAction = new RelationshipMapper();
                    var company = new CompanyObject()
                    {
                        Company_Id = Company_Id == 0? default : Company_Id,
                        Company_Name = txtCompanyName.Text,
                        Company_Address = txtCompanyAddress.Text
                    };
                    var person = new PersonObject()
                    {
                        Id = Person_Id == 0 ? default : Person_Id,
                        FirstName = txtCustomerFirstname.Text,
                        LastName = txtCustomerLastname.Text,
                        Designation = string.IsNullOrEmpty(txtPosition.Text)? "N/A" : txtPosition.Text,
                        Contact_Number = txtContact.Text,
                        Address = txtAddress.Text
                    };
                    var relationship = new RelationshipObject()
                    {
                        Relationship_Type = "Customer",
                        Lead_Time = default,
                        Buyer_Status = rbtnBig.Checked == true? "Big": "Small"
                    };
                    relationshipAction.InsertOrUpdate(person, company, relationship, "RD_Relationship_InsertUpdate");
                    Alert_Dialog.ShowAlertMessage($"Account has been {(Person_Id == 0 ? "Added" : "Updated" )} successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(hmp.current_user_Id, $"{(Person_Id == 0 ? "Created" : "Updated")} Customer: Company Name[{txtCompanyName.Text}] with Contact Person[{txtCustomerFirstname.Text} {txtCustomerLastname.Text}], Contact No.[{txtContact.Text}]", "Data Entry");
                    btnCancel_Click(null, null);
                    await hmp.LoadCustomerList();
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

        private void Customers_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validate = new InputRemoverAndValidation();
            validate.textOnlyWithSpaces(sender, e);
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validate = new InputRemoverAndValidation();
            validate.numOnly(sender, e);
        }
    }
}
