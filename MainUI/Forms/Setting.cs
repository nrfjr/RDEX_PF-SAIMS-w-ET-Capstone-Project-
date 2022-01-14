using MainUI.Dialog;
using MainUI.Forms.Admin_Forms;
using MapperLibrary.Controller;
using MapperLibrary.Helper;
using MySql.Data.MySqlClient;
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
using System.Xml;
using UtilitiesLibrary;

namespace MainUI
{
    public partial class Setting : Form
    {
        List<Validator> Cvalidator = new List<Validator>();
        List<Validator> Fvalidator = new List<Validator>();
        List<Validator> Pvalidator = new List<Validator>();
        Homepage hmp;
        public Setting(Homepage hmpg)
        {
            InitializeComponent();
            hmp = hmpg;
            SetValidators();
            GetConnectionDetails();
            GetFarmDetails();
        }
        private void SetValidators()
        {
            Fvalidator.Add(new Validator(txtFarmName, errorFarmName, "farm name", "required"));
            Cvalidator.Add(new Validator(txtServer, errServer, "server", "required"));
            Cvalidator.Add(new Validator(txtDatabase, errDatabase, "database", "required"));
            Cvalidator.Add(new Validator(txtUsername, errUsername, "username", "required"));
            Cvalidator.Add(new Validator(txtPassword, errPassword, "password", "required"));
            Cvalidator.Add(new Validator(txtPort, errPort, "port", "required"));
            Pvalidator.Add(new Validator(txtFullname, errFullname, "fullname", "required|name"));
            Pvalidator.Add(new Validator(txtContact, errContact, "contact no.", "required"));
            Pvalidator.Add(new Validator(txtAddress, errAddr, "address", "required"));
            Pvalidator.Add(new Validator(txtUserUname, errUserUname, "username", "required|max:10|min:8"));
            Pvalidator.Add(new Validator(txtUserPass, errUserPass, "password", "required|max:10|min:8"));
        }

        #region Farm
        private void GetFarmDetails()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(SystemPath.FarmPath);
            txtFarmName.Text = xmlDoc.SelectSingleNode("/ Farm / Name").InnerText;
        }
        private void btnSaveFarm_Click(object sender, EventArgs e)
        {
            try
            {
                if (Fvalidator.Count((validator) => validator.IsValid()) == Fvalidator.Count)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(SystemPath.FarmPath);
                    xmlDoc.SelectSingleNode("/ Farm / Name ").InnerText = txtFarmName.Text;
                    xmlDoc.Save(SystemPath.FarmPath);
                    Alert_Dialog.ShowAlertMessage("Farm name has been updated successfully.", Alert_Dialog.AlertType.SUCCESS);
                    GetFarmDetails();
                }
            }
            catch { }
        }

        private void btnFarmCancel_Click(object sender, EventArgs e)
        {
            Fvalidator.ForEach(validator => validator.Reset());
            GetFarmDetails();
        }

        #endregion

        #region Profile
        public void GetProfileDetails()
        {
            try {
            string[] name = hmp.labelCurrentUserName.Text.Split(' ');
            var userAction = new UserMapper();
            var user = new UserObject()
            {
                UserName = name[0]
            };
            var users = userAction.dynamicsListWithParam(user, "RD_User_GetProfileData");
            var dgvworker = new ListToDataTableWorker();
            var dt = new DataTable();
            dt = dgvworker.ConvertToDataTable(users);

            txtContact.Text = dt.Rows[0][0].ToString();
            txtAddress.Text = dt.Rows[0][1].ToString();
            txtUserUname.Text = dt.Rows[0][2].ToString();
            txtUserPass.Text = HashWorker.Decrypt(dt.Rows[0][3].ToString());
            }catch{ }
        }
        private void btnUserSave_Click(object sender, EventArgs e)
        {

        }

        private void btnUserCancel_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Connectivity
        private void GetConnectionDetails()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(SystemPath.ConnectionPath);
            txtServer.Text = xmlDoc.SelectSingleNode("/ Table / Connection / Server").InnerText;
            txtDatabase.Text = xmlDoc.SelectSingleNode("/ Table / Connection / Database").InnerText;
            txtUsername.Text = xmlDoc.SelectSingleNode("/ Table / Connection / User").InnerText;
            txtPassword.Text = xmlDoc.SelectSingleNode("/ Table / Connection / Password").InnerText;
            txtPort.Text = xmlDoc.SelectSingleNode("/ Table / Connection / Port").InnerText;
            tglSecurity.Checked = xmlDoc.SelectSingleNode("/ Table / Connection / Security").InnerText == "true" ? true : false;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cvalidator.Count((validator) => validator.IsValid()) == Cvalidator.Count)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(SystemPath.ConnectionPath);
                    xmlDoc.SelectSingleNode("/ Table / Connection / Server").InnerText = txtServer.Text;
                    xmlDoc.SelectSingleNode("/ Table / Connection / Database").InnerText = txtDatabase.Text;
                    xmlDoc.SelectSingleNode("/ Table / Connection / User").InnerText = txtUsername.Text;
                    xmlDoc.SelectSingleNode("/ Table / Connection / Password").InnerText = txtPassword.Text;
                    xmlDoc.SelectSingleNode("/ Table / Connection / Port").InnerText = txtPort.Text;
                    xmlDoc.SelectSingleNode("/ Table / Connection / Security").InnerText = tglSecurity.Checked == true ? "true" : "false";
                    xmlDoc.Save(SystemPath.ConnectionPath);
                    Alert_Dialog.ShowAlertMessage("Connection has been updated successfully.", Alert_Dialog.AlertType.SUCCESS);
                    GetConnectionDetails();

                }
            }
            catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cvalidator.ForEach(validator => validator.Reset());
            GetConnectionDetails();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var result = Confirmation.ShowDialog("Are you sure to Edit Connection Settings?");
            if(result == DialogResult.Yes)
            {
                guna2GroupBox1.Enabled = true;
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            TestConn();
        }
        private void TestConn()
        {
            using (var connection = new MySqlConnection(MySqlDBConnection.stringCon))
            {
                try
                {
                    connection.Open();
                    connection.Close();
                    Alert_Dialog.ShowAlertMessage("Test Connection Successful.", Alert_Dialog.AlertType.SUCCESS);
                }
                catch
                {
                    Alert_Dialog.ShowAlertMessage("Test Connection Failed.", Alert_Dialog.AlertType.WARNING);
                }
            }
        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }


    }
}
