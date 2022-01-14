using Guna.UI2.WinForms;
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

namespace MainUI.Dialog
{
    public partial class Privileges : Form
    {
        public Privileges()
        {
            InitializeComponent();
            LoadRoles();
        }
        private void LoadRoles()
        {
            var userAction = new UserMapper();
            var roles = userAction.dynamicsList("RD_Role_GetRoleTitle");
            cmbRole.DataSource = roles;
            cmbRole.DisplayMember = "Role_Title";
            cmbRole.ValueMember = "Role_Id";
        }
        private void validateEntry()
        {
            try
            {
                var result = Confirmation.ShowDialog($"Are you sure to save changes for {cmbRole.Text}?");
                if (result == DialogResult.Yes)
                {
                    var privilegeAction = new PrivilegeMapper();
                    var userPrivilege = new PrivilegeObject()
                    {
                        Role_Id = Int32.Parse(cmbRole.SelectedValue.ToString()),
                        Dashboard = tglDashboard.Checked == true ? "Enabled" : "Disabled",
                        Customer = tglCustomer.Checked == true ? "Enabled" : "Disabled",
                        Supplier = tglSupplier.Checked == true ? "Enabled" : "Disabled",
                        Items = tglItems.Checked == true ? "Enabled" : "Disabled",
                        Feeds_Type = tglFeedsType.Checked == true ? "Enabled" : "Disabled",
                        Expense_Type = tglExpenseType.Checked == true ? "Enabled" : "Disabled",
                        Pricing = tglPricing.Checked == true ? "Enabled" : "Disabled",
                        Ponds = tglPond.Checked == true ? "Enabled" : "Disabled",
                        Pond_Plan_Entry = tglPondPlanEntry.Checked == true ? "Enabled" : "Disabled",
                        Pond_Weekly_Updates = tglWeeklyUpdates.Checked == true ? "Enabled" : "Disabled",
                        Pond_Results = tglPondResult.Checked == true ? "Enabled" : "Disabled",
                        Available_Stock = tglAvailableStock.Checked == true ? "Enabled" : "Disabled",
                        Critical_Stock = tglCriticalStock.Checked == true ? "Enabled" : "Disabled",
                        Material_Request = tglMaterialRequest.Checked == true ? "Enabled" : "Disabled",
                        Stock_Receiving = tglStockReceiving.Checked == true ? "Enabled" : "Disabled",
                        Stock_Withdrawal = tglStockWithdrawal.Checked == true ? "Enabled" : "Disabled",
                        Sales_Entry = tglSalesEntry.Checked == true ? "Enabled" : "Disabled",
                        Expenses = tglExpenses.Checked == true ? "Enabled" : "Disabled",
                        Maintenance = tglMaintenance.Checked == true ? "Enabled" : "Disabled",
                    };
                    privilegeAction.InsertOrUpdate(userPrivilege, "RD_Privilege_InsertUpdate");
                    Alert_Dialog.ShowAlertMessage($"Privilege for {cmbRole.Text} has been saved successfully.", Alert_Dialog.AlertType.SUCCESS);
                    btnDiscardPrivilege_Click(null, null);
                }
            }
            catch
            { }
        }
        private void cmbRole_SelectedValueChanged(object sender, EventArgs e)
        {
            AssignChecked();
        }
        private void AssignChecked()
        {
            try
            {
                var privilegeAction = new PrivilegeMapper();
                var role = new PrivilegeObject()
                {
                    Role_Id = Int32.Parse(cmbRole.SelectedValue.ToString())
                };
                var privileges = privilegeAction.dynamicsListWithParam(role, "RD_Privilege_GetPrivilegeListByRole");
                var dt = new DataTable();
                var dgvworker = new ListToDataTableWorker();
                dt = dgvworker.ConvertToDataTable(privileges);

                tglDashboard.Checked = dt.Rows[0][0].ToString() == "Enabled" ? true : false;
                tglCustomer.Checked = dt.Rows[0][1].ToString() == "Enabled" ? true : false;
                tglSupplier.Checked = dt.Rows[0][2].ToString() == "Enabled" ? true : false;
                tglItems.Checked = dt.Rows[0][3].ToString() == "Enabled" ? true : false;
                tglFeedsType.Checked = dt.Rows[0][4].ToString() == "Enabled" ? true : false;
                tglExpenseType.Checked = dt.Rows[0][5].ToString() == "Enabled" ? true : false;
                tglPricing.Checked = dt.Rows[0][6].ToString() == "Enabled" ? true : false;
                tglPond.Checked = dt.Rows[0][7].ToString() == "Enabled" ? true : false;
                tglPondPlanEntry.Checked = dt.Rows[0][8].ToString() == "Enabled" ? true : false;
                tglWeeklyUpdates.Checked = dt.Rows[0][9].ToString() == "Enabled" ? true : false;
                tglPondResult.Checked = dt.Rows[0][10].ToString() == "Enabled" ? true : false;
                tglAvailableStock.Checked = dt.Rows[0][11].ToString() == "Enabled" ? true : false;
                tglCriticalStock.Checked = dt.Rows[0][12].ToString() == "Enabled" ? true : false;
                tglMaterialRequest.Checked = dt.Rows[0][13].ToString() == "Enabled" ? true : false;
                tglStockReceiving.Checked = dt.Rows[0][14].ToString() == "Enabled" ? true : false;
                tglStockWithdrawal.Checked = dt.Rows[0][15].ToString() == "Enabled" ? true : false;
                tglSalesEntry.Checked = dt.Rows[0][16].ToString() == "Enabled" ? true : false;
                tglExpenses.Checked = dt.Rows[0][17].ToString() == "Enabled" ? true : false;
                tglMaintenance.Checked = dt.Rows[0][18].ToString() == "Enabled" ? true : false;
            }
            catch
            {}
        }
        private void btnSavePrivilege_Click(object sender, EventArgs e)
        {
            validateEntry();
        }
        private void btnDiscardPrivilege_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void btnCheckToggle_Click(object sender, EventArgs e)
        {
            CheckButtons(panel1);
        }
        private void CheckButtons(Control con)
        {
            foreach(Control c in con.Controls)
            {
                if (c is Guna2ToggleSwitch)
                    ((Guna2ToggleSwitch)c).Checked = true;
                CheckButtons(c);
            }
        }
        private void btnUncheckToggle_Click(object sender, EventArgs e)
        {
            UnCheckButtons(panel1);
        }
        private void UnCheckButtons(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is Guna2ToggleSwitch)
                    ((Guna2ToggleSwitch)c).Checked = false;
                UnCheckButtons(c);
            }
        }
    }
}
