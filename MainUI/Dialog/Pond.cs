using MainUI.Forms.Admin_Forms;
using MapperLibrary.Controller;
using ObjectLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilitiesLibrary;

namespace MainUI.Dialog
{
    public partial class Pond : Form
    {
        public int Pond_Id { get; set; }

        Homepage hmp;

        List<Validator> PondValidator = new List<Validator>();
        public Pond(Homepage hmpg)
        {
            InitializeComponent();
            hmp = hmpg;
        }
        public void TransactionType(int pond_Id)
        {
            labelTransaction.Text = pond_Id == 0 ? "New Pond" : "Update Pond";
            if (pond_Id == 0)
            {
                PondValidator.Add(new Validator(txtPondCode, errPondCode, "pond code", "required|max:8|unique:rd_saims.tbl_pond, Pond_Code") { unique_ignore = txtPondCode.Text });
            }
            else
            {
                PondValidator.Add(new Validator(txtPondCode, errPondCode, "pond code", "required|max:8"));
            }
            PondValidator.Add(new Validator(txtPondArea, errPondArea, "pond area", "required"));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(labelImagePath.Text))
            {
                Alert_Dialog.ShowAlertMessage($"Please select a pond image", Alert_Dialog.AlertType.INFO);
            }
            else if(!string.IsNullOrEmpty(labelImagePath.Text))
            {
                validateEntry();
            }
        }
        private async void validateEntry()
        {
            try
            {
                if (PondValidator.Count((validator) => validator.IsValid()) == PondValidator.Count)
                {
                    var rsrcmgr = new ResourceManager();
                    var file = $"{txtPondCode.Text}.jpg";
                    var pondAction = new PondMapper();
                    var pond = new PondObject()
                    {
                        Pond_Id = Pond_Id == 0 ? default : Pond_Id,
                        Pond_Code = txtPondCode.Text,
                        Pond_Area = Int32.Parse(txtPondArea.Text.Replace(",","")),
                        Pond_Image = file
                    };
                    pondAction.InsertOrUpdate(pond, "RD_Pond_InsertUpdate");
                    if(Pond_Id == 0)
                    {
                        File.Copy(labelImagePath.Text, rsrcmgr.getUniqueFilename(SystemPath.PondPath + file));
                    }
                    else if (Pond_Id != 0)
                    {
                        File.Copy(labelImagePath.Text, SystemPath.PondPath + file, true);
                    }
                    Alert_Dialog.ShowAlertMessage($"Pond has been {(Pond_Id == 0 ? "Added" : "Updated")} successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(hmp.current_user_Id, $"{(Pond_Id == 0 ? "Created" : "Updated")} Pond: Code[{txtPondCode.Text}], Area[{txtPondArea.Text}]", "Data Entry");
                    btnCancel_Click(null, null);
                    await hmp.LoadPondList();
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

        private void btnEditImage_Click(object sender, EventArgs e)
        {
            BrowseImage();
        }
        private void BrowseImage()
        {
            var imgOpener = new ResourceManager();
            imgOpener.ImageFileOpener("(*.jpg; *.jpeg; *.bmp; *.png;) | *.jpg; *.jpeg; *.bmp; *.png;", labelImagePath, pbxPondImage);
        }

        private void txtPondArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validate = new InputRemoverAndValidation();
            validate.numAndDotOnly(sender, e);
        }

        private void txtPondCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validate = new InputRemoverAndValidation();
            validate.allowTextAndDigitOnly(sender, e);
        }
    }
}
