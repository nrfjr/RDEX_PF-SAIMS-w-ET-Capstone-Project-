using Guna.UI2.WinForms;
using LiveCharts;
using LiveCharts.Wpf;
using MainUI.Datasets;
using MainUI.Dialog;
using RDEX.Reports;
using MapperLibrary.Controller;
using MapperLibrary.Helper;
using ObjectLibrary;
using OfficeOpenXml;
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
using System.Xml;
using UtilitiesLibrary;
using RDEX.Properties;

namespace MainUI.Forms.Admin_Forms
{
    public partial class Homepage : Form
    {
        public int rowIndex { get; set; }
        public int Selected_Id { get; set; }
        public int current_user_Id { get; set; }
        public int current_user_role_Id { get; set; }
        public DataGridView Selected_DGV { get; set; }

        Timer fadeIn = new Timer();

        Login login; 

        string[] EntryStatus = { "Added", "Updated", "Deleted" };
        public Homepage(Login logins)
        {
            InitializeComponent();
            login = logins;
            SetNotification();
            SetDashboard();
            tabHomepage.SelectedTab = pgDashboard;
        }

        #region PRIVILEGE SETTING
        public void CheckRole(string role)
        {

            if(role == "Admin")
            {
                btnPrivilege.Visible = true;
            }
            labelCurrentUserRole.Text = role;
        }

        public void SetVisibilityByRole(bool val)
        {
            // deletion features and some other features are not limited to encoder.
            datagridMR.Columns[11].Visible = val;
            btnDeleteMR.Visible = val;
            datagridReceive.Columns[12].Visible = val;
            datagridReceive.Columns[2].Visible = val;
            btnDeleteReceive.Visible = val;
            btnDeleteWdraw.Visible = val;
            btnPrintWithdrawal.Enabled = val;
            btnPrintMR.Enabled = val;
            btnPrintReceive.Enabled = val;
            btnDeleteReceive.Visible = val;
            datagridPending.Columns[13].Visible = val;
            datagridFinished.Columns[12].Visible = val;
            btnCreateHarvest.Visible = val;
            btnWithdrawalHistory.Enabled = val;
            btnPrintPondPlan.Enabled = val;
            btnPrintSampling.Enabled = val;
            btnWithdrawalHistory.Enabled = val;
            btnAvailableReport.Enabled = val;
            datagridExpense.Columns[8].Visible = val;
            datagridCustomer.Columns[11].Visible = val;
            btnDeleteCustomer.Visible = val;
            btnClearCustomer.Enabled = val;
            datagridSupplier.Columns[11].Visible = val;
            btnClearSupplier.Enabled = val;
            datagridItems.Columns[7].Visible = val;
            btnDeleteItem.Visible = val;
            btnClearItems.Enabled = val;
            btnClearFType.Enabled = val;
            btnDeleteFType.Visible = val;
            datagridFeedsType.Columns[5].Visible = val;
            datagridExpenseType.Columns[5].Visible = val;
            btnClearExpType.Enabled = val;
            btnDeleteXType.Visible = val;
            btnClearPrices.Enabled = val;
            datagridPrice.Columns[5].Visible = val;
            btnDeletePrice.Visible = val;
            datagridPond.Columns[6].Visible = val;
            btnDeletePond.Visible = val;
            btnClearExpenses.Enabled = val;
            btnClearOccupied.Visible = val;
            btnSettings.Enabled = val;
            btnSetting.Visible = val;
            btnBackupRestore.Visible = val;
            btnDeleteOrder.Visible = val;
            btnCritDelete.Visible = val;
            
        }

        public void SetModulesByPrivilege(int role_Id)
        {
            try
            {
                var privilegeAction = new PrivilegeMapper();
                var role = new PrivilegeObject()
                {
                    Role_Id = role_Id
                };
                var privileges = privilegeAction.dynamicsListWithParam(role, "RD_Privilege_GetPrivilegeListByRole");
                var dt = new DataTable();
                var dgvworker = new ListToDataTableWorker();
                dt = dgvworker.ConvertToDataTable(privileges);

                if (dt.Rows[0][0].ToString() == "Disabled")
                {
                    tabHomepage.TabPages.Remove(pgDashboard);
                }
                if (dt.Rows[0][1].ToString() == "Disabled")
                {
                    tabDataEntry.TabPages.Remove(pgCustomer);
                }
                if (dt.Rows[0][2].ToString() == "Disabled") 
                {
                    tabDataEntry.TabPages.Remove(pgSupplier);
                }
                if(dt.Rows[0][3].ToString() == "Disabled")
                {
                    tabMiscellaneous.TabPages.Remove(pgItems);
                }
                if(dt.Rows[0][4].ToString() == "Disabled")
                {
                    tabMiscellaneous.TabPages.Remove(pgFeedsType);
                }
                if(dt.Rows[0][5].ToString() == "Disabled")
                {
                    tabMiscellaneous.TabPages.Remove(pgExpenseType);
                }
                if(dt.Rows[0][6].ToString() == "Disabled")
                {
                    tabMiscellaneous.TabPages.Remove(pgPricing);
                }
                if (dt.Rows[0][7].ToString() == "Disabled")
                {
                    tabMiscellaneous.TabPages.Remove(pgPond);
                }
                if(dt.Rows[0][3].ToString() == "Disabled" && dt.Rows[0][4].ToString() == "Disabled" && dt.Rows[0][5].ToString() == "Disabled" && dt.Rows[0][6].ToString() == "Disabled" && dt.Rows[0][7].ToString() == "Disabled")
                {
                    tabDataEntry.TabPages.Remove(pgMiscellaneous);
                }
                if(dt.Rows[0][8].ToString() == "Disabled")
                {
                    tabPondPlan.TabPages.Remove(pgPondPlan);
                }
                if(dt.Rows[0][9].ToString() == "Disabled")
                {
                    tabPondPlan.TabPages.Remove(pgWeeklyUpdate);
                }
                if(dt.Rows[0][10].ToString() == "Disabled")
                {
                    tabPondPlan.TabPages.Remove(pgPondResult);
                }
                if(dt.Rows[0][8].ToString() == "Disabled" && dt.Rows[0][9].ToString() == "Disabled" && dt.Rows[0][10].ToString() == "Disabled")
                {
                    tabTransaction.TabPages.Remove(pgPondPlan);
                }
                if(dt.Rows[0][11].ToString() == "Disabled")
                {
                    tabInventory.TabPages.Remove(pgAvailableStock);
                }
                if(dt.Rows[0][12].ToString() == "Disabled")
                {
                    tabInventory.TabPages.Remove(pgCriticalStock);
                }
                if(dt.Rows[0][13].ToString() == "Disabled")
                {
                    tabInventory.TabPages.Remove(pgMaterialRequest);
                }
                if(dt.Rows[0][14].ToString() == "Disabled")
                {
                    tabInventory.TabPages.Remove(pgReceiving);
                }
                if(dt.Rows[0][15].ToString() == "Disabled")
                {
                    tabInventory.TabPages.Remove(pgWithdrawal);
                }
                if(dt.Rows[0][11].ToString() == "Disabled" && dt.Rows[0][12].ToString() == "Disabled" && dt.Rows[0][13].ToString() == "Disabled" && dt.Rows[0][14].ToString() == "Disabled" && dt.Rows[0][15].ToString() == "Disabled")
                {
                    tabTransaction.TabPages.Remove(pgInventory);
                }
                if(dt.Rows[0][16].ToString() == "Disabled")
                {
                    tabTransaction.TabPages.Remove(pgSales);
                }
                if (dt.Rows[0][17].ToString() == "Disabled")
                {
                    tabTransaction.TabPages.Remove(pgExpenses);
                }
                if(dt.Rows[0][18].ToString() == "Disabled")
                {
                    tabHomepage.TabPages.Remove(pgMaintenance);
                }

            }
            catch
            { }
        }
        #endregion

        #region HOMEPAGE BUTTONS
        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (About fb = new About())
            {
                fb.ShowDialog();
            }
        }
        private void Homepage_Load(object sender, EventArgs e)
        {
            fadeIn.Tick += fadeIn_Tick;
            fadeIn.Interval = 40;
            fadeIn.Start();
        }
        private void fadeIn_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
                fadeIn.Stop();
            Opacity += .1;
        }

        private void btnPrivilege_Click(object sender, EventArgs e)
        {
            using(var privilege = new Privileges())
            {
                privilege.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            new AuditTrailMapper().InsertActivity(current_user_Id, $"Exited from the system.", "System");
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnMaximize.Visible = true;
            btnRestore.Visible = false;
        }
        private void pbxCurrentUserProfile_MouseHover(object sender, EventArgs e)
        {
            panelUserMenu.Size = new Size(panelUserMenu.Width, 55);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            var splashscrn = new SplashScreen();
            new AuditTrailMapper().InsertActivity(current_user_Id, $"Logged out from the system.", "System");
            splashscrn.Show();
            splashscrn.runtime = 1;
            Dispose();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (Setting fs = new Setting(this))
            {
                var rsrcmgr = new ResourceManager();
                fs.tabSettings.SelectedTab = fs.pgProfile;
                fs.pbxProfile.Image = pbxCurrentUserProfile.Image;
                fs.ShowDialog();
            }
        }

        private void panelUserMenu_MouseLeave(object sender, EventArgs e)
        {
            panelUserMenu.Size = new Size(panelUserMenu.Width, 0);
        }

        private void MouseClickContextProvider(object sender, ContextMenuStrip cms, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != -1 && e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                    clickedCell.Selected = true;
                    (sender as DataGridView).CurrentCell = clickedCell;
                    rowIndex = (sender as DataGridView).CurrentCell.RowIndex;
                    var relativeMousePosition = (sender as DataGridView).PointToClient(Cursor.Position);
                    cms.Show((sender as DataGridView), relativeMousePosition);
                    Selected_DGV = (sender as DataGridView);
                }
            }
            catch { }
        }
        private void btnNotif_Click(object sender, EventArgs e)
        {
            if ((((Guna2Button)sender).Checked) == true)
            {
                panelNotification.Size = new Size(panelNotification.Size.Width, 220);

            }
            else
            {
                panelNotification.Size = new Size(panelNotification.Size.Width, 0);
            }
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            tabHomepage.SelectedTab = pgDashboard;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            tabHomepage.SelectedTab = pgDataEntry;
            tabDataEntry.SelectedTab = pgCustomer;
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            tabHomepage.SelectedTab = pgDataEntry;
            tabDataEntry.SelectedTab = pgSupplier;
        }

        private void btnMiscellaneous_Click(object sender, EventArgs e)
        {
            tabHomepage.SelectedTab = pgDataEntry;
            tabDataEntry.SelectedTab = pgMiscellaneous;
        }

        private void btnPondEntry_Click(object sender, EventArgs e)
        {
            tabHomepage.SelectedTab = pgTransaction;
            tabTransaction.SelectedTab = pgPondPlan;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            tabHomepage.SelectedTab = pgTransaction;
            tabTransaction.SelectedTab = pgInventory;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            tabHomepage.SelectedTab = pgTransaction;
            tabTransaction.SelectedTab = pgSales;
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            tabHomepage.SelectedTab = pgTransaction;
            tabTransaction.SelectedTab = pgExpenses;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            tabHomepage.SelectedTab = pgMaintenance;
            tabMaintenance.SelectedTab = pgReports;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            tabHomepage.SelectedTab = pgMaintenance;
            tabMaintenance.SelectedTab = pgUsers;
        }

        private void btnAudit_Click(object sender, EventArgs e)
        {
            tabHomepage.SelectedTab = pgMaintenance;
            tabMaintenance.SelectedTab = pgAudit;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            using (Setting fs = new Setting(this))
            {
                fs.GetProfileDetails();
                fs.ShowDialog();
            }
        }
        

        private void btnBackupRestore_Click(object sender, EventArgs e)
        {
            using (Backup_and_Restore br = new Backup_and_Restore())
            {
                br.ShowDialog();
            }
        }
        #endregion

        #region HOMEPAGE TABCONTROLS
        private void tabHomepage_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPage == pgTransaction)
            {
                tabTransaction.SelectedTab = null;
            }
            else if(e.TabPage == pgDashboard)
            {
                SetDashboard();
            }
        }
        private async void tabMaintenance_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == pgUsers)
            {
                FillUserRoles();
                await LoadUserList(txtSearchUser.Text);
            }
            else if(e.TabPage == pgAudit)
            {
                fillAuditCombo();
            }

        }
        private async void tabTransaction_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == pgInventory)
            {
                fillStockCategory();
                await LoadAvailableList();

            }
            else if(e.TabPage == pgSales)
            {

            }
            else if (e.TabPage == pgExpenses)
            {
                FillExpenseType();
                await LoadExpensesChart();
            }
        }
        private async void tabInventory_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPage == pgWithdrawal)
            {
                fillWCategory();
                await LoadAvailableWithdrawList();
            }
        }
        private void tabPondPlan_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == pgPondPlan)
            {

            }
            else if (e.TabPage == pgWeeklyUpdate)
            {
                fillWeeklyProduction();
            }
        }
        private void tabReports_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPage == pgSalesReport)
            {
                LoadSalesReportPond();
            }
        }
        #endregion

        #region DASHBOARD
        private void SetDashboard()
        {
            try
            {
                var invAction = new InventoryMapper();
                var details = invAction.dynamicsList("RD_Dashboard_GetSummary");
                var dgvworker = new ListToDataTableWorker();
                var dt = new DataTable();
                dt = dgvworker.ConvertToDataTable(details);

                lblAvailableFeeds.Text = dt.Rows[0][0].ToString();
                labelSales.Text = $"₱ {(string.IsNullOrEmpty(dt.Rows[0][1].ToString())? "0" :KFormat(Double.Parse(dt.Rows[0][1].ToString())))}";
                lblCritical.Text = dt.Rows[0][2].ToString();
                lblExpenses.Text = $"₱ {(string.IsNullOrEmpty(dt.Rows[0][3].ToString()) ? "0" : KFormat(Double.Parse(dt.Rows[0][3].ToString())))}";
            }
            catch { }

        }
        private string KFormat(double num)
        {
            if(num >= 100000000)
            {
                return (num / 1000000).ToString("#,0M");
            }
            if(num >= 10000000)
            {
                return $"{(num / 1000000).ToString("0.#")}M";
            }
            if (num >= 1000000)
            {
                return $"{(num / 1000000).ToString("0.#")}M";
            }
            if (num >= 100000)
            {
                return (num / 100000).ToString("#.0K");
            }
            if (num >= 10000)
            {
                return $"{(num / 1000).ToString("0.#")}K";
            }
            if (num >= 1000)
            {
                return $"{(num / 1000).ToString("0.#")}K";
            }
            return num.ToString("#,0");

        }
        #endregion

        #region CUSTOMER

        private async void btnRefreshCustomer_Click(object sender, EventArgs e)
        {
            await LoadCustomerList();
        }
        public async Task LoadCustomerList()
        {
            try
            {
                var relationshipAction = new RelationshipMapper();
                var relationshipType = new RelationshipObject()
                {
                    Relationship_Type = "Customer"
                };
                await Task.Delay(1000);
                var customers = relationshipAction.dynamicsListWithParam(relationshipType, "RD_Relationship_GetListByType");
                var dgvworker = new ListToDataTableWorker();
                var dt = new DataTable();
                dt = dgvworker.ConvertToDataTable(customers);
                datagridCustomer.AutoGenerateColumns = false;
                for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                {
                    datagridCustomer.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                }
                datagridCustomer.DataSource = dt;

                if (dt.Rows.Count == 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Customer has been found.", Alert_Dialog.AlertType.INFO);
                }
                else if (dt.Rows.Count > 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Customers has been found.", Alert_Dialog.AlertType.INFO);
                }
            }
            catch
            {
                Alert_Dialog.ShowAlertMessage("No Customer has been found.", Alert_Dialog.AlertType.WARNING);
                datagridCustomer.DataSource = null;
            }
        }
        private void datagridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = datagridCustomer.Columns[e.ColumnIndex].Name;
            if (column == "customer_Edit")
            {
                CustomerListOption(datagridCustomer, e.RowIndex, "Edit");
            }
            else if (column == "customer_Delete")
            {
                CustomerListOption(datagridCustomer, e.RowIndex, "Delete");
            }
        }
        private async void CustomerListOption(DataGridView customer, int rowIndex, string option)
        {
            var inputrv = new InputRemoverAndValidation();
            string[] buyerType = customer.Rows[rowIndex].Cells[8].Value.ToString().Split(' ');
            if (option == "Edit")
            {
                using (var customerForm = new Customers(this))
                {
                    customerForm.Person_Id = Int32.Parse(customer.Rows[rowIndex].Cells[0].Value.ToString());
                    customerForm.Company_Id = Int32.Parse(customer.Rows[rowIndex].Cells[1].Value.ToString());
                    customerForm.txtCompanyName.Text = customer.Rows[rowIndex].Cells[3].Value.ToString();
                    customerForm.txtCompanyAddress.Text = customer.Rows[rowIndex].Cells[5].Value.ToString();
                    inputrv.getFirstAndLastName(customerForm.txtCustomerFirstname, customerForm.txtCustomerLastname, customer.Rows[rowIndex].Cells[6].Value.ToString());
                    customerForm.txtPosition.Text = customer.Rows[rowIndex].Cells[7].Value.ToString();
                    if(buyerType[0] == "Big") { customerForm.rbtnBig.Checked = true; } else { customerForm.rbtnSmall.Checked = true; }
                    customerForm.txtContact.Text = customer.Rows[rowIndex].Cells[9].Value.ToString();
                    customerForm.txtAddress.Text = customer.Rows[rowIndex].Cells[10].Value.ToString();
                    customerForm.TransactionType(Int32.Parse(customer.Rows[rowIndex].Cells[0].Value.ToString()));
                    customerForm.ShowDialog();
                }
            }
            else if(option == "Delete")
            {
                DialogResult result = Confirmation.ShowDialog($"Are you sure to delete {customer.Rows[rowIndex].Cells[3].Value.ToString()} ?");
                if (result == DialogResult.Yes)
                {
                    var relationshipAction = new RelationshipMapper();
                    var person = new PersonObject()
                    {
                        Id = Int32.Parse(customer.Rows[rowIndex].Cells[0].Value.ToString())
                    };
                    var company = new CompanyObject()
                    {
                        Company_Id = Int32.Parse(customer.Rows[rowIndex].Cells[1].Value.ToString())
                    };
                    relationshipAction.Delete(person, company, "RD_Relationship_DeleteById");
                    Alert_Dialog.ShowAlertMessage("Customer has been removed successfully", Alert_Dialog.AlertType.SUCCESS);
                    await LoadCustomerList();
                }
            }
        }
        private void datagridCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseClickContextProvider(sender, dgvCustomerContext, e);
        }

        private async void btnClearCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = Confirmation.ShowDialog("Are you sure to clear all customer records.");
                if (result == DialogResult.Yes)
                {
                    QueryWorker deleteWorker = new QueryWorker();
                    deleteWorker.DeleteAll("DELETE FROM rd_saims.tbl_relationship WHERE Relationship_Type = 'Customer'");
                    Alert_Dialog.ShowAlertMessage("All customer records has been cleared.", Alert_Dialog.AlertType.INFO);
                    await LoadCustomerList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            using (var customerForm = new Customers(this))
            {
                customerForm.ShowDialog();
            }
        }
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            CustomerListOption(datagridCustomer, rowIndex, "Edit");
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            CustomerListOption(datagridCustomer, rowIndex, "Delete");
        }
        #endregion

        #region SUPPLIER
        private async void btnRefreshSupplier_Click(object sender, EventArgs e)
        {
            await LoadSupplierList();
        }
        public async Task LoadSupplierList()
        {
            try
            {
                var relationshipAction = new RelationshipMapper();
                var relationshipType = new RelationshipObject()
                {
                    Relationship_Type = "Supplier"
                };
                await Task.Delay(1000);
                var supplier = relationshipAction.dynamicsListWithParam(relationshipType, "RD_Relationship_GetListByType");
                var dgvworker = new ListToDataTableWorker();
                var dt = new DataTable();
                dt = dgvworker.ConvertToDataTable(supplier);
                datagridSupplier.AutoGenerateColumns = false;
                for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                {
                    datagridSupplier.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                }
                datagridSupplier.DataSource = dt;

                if (dt.Rows.Count == 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Supplier has been found.", Alert_Dialog.AlertType.INFO);
                }
                else if (dt.Rows.Count > 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Supplier has been found.", Alert_Dialog.AlertType.INFO);
                }
            }
            catch
            {
                Alert_Dialog.ShowAlertMessage("No supplier has been found.", Alert_Dialog.AlertType.WARNING);
                datagridSupplier.DataSource = null;
            }
        }
        private void datagridSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = datagridSupplier.Columns[e.ColumnIndex].Name;
            if (column == "supplier_Edit")
            {
                SupplierListOption(datagridSupplier, e.RowIndex, "Edit");
            }
            else if (column == "supplier_Delete")
            {
                SupplierListOption(datagridSupplier, e.RowIndex, "Delete");
            }
        }
        private async void SupplierListOption(DataGridView supplier, int rowIndex, string option)
        {
            var inputrv = new InputRemoverAndValidation();
            if (option == "Edit")
            {
                using (var supplierForm = new Supplier(this))
                {
                    supplierForm.Person_Id = Int32.Parse(supplier.Rows[rowIndex].Cells[0].Value.ToString());
                    supplierForm.Company_Id = Int32.Parse(supplier.Rows[rowIndex].Cells[1].Value.ToString());
                    supplierForm.txtCompanyName.Text = supplier.Rows[rowIndex].Cells[3].Value.ToString();
                    supplierForm.txtLeadTime.Text = supplier.Rows[rowIndex].Cells[4].Value.ToString();
                    supplierForm.txtCompanyAddress.Text = supplier.Rows[rowIndex].Cells[5].Value.ToString();
                    inputrv.getFirstAndLastName(supplierForm.txtSupplierFirstname, supplierForm.txtSupplierLastname, supplier.Rows[rowIndex].Cells[6].Value.ToString());
                    supplierForm.txtPosition.Text = supplier.Rows[rowIndex].Cells[7].Value.ToString();
                    supplierForm.txtContact.Text = supplier.Rows[rowIndex].Cells[9].Value.ToString();
                    supplierForm.txtAddress.Text = supplier.Rows[rowIndex].Cells[10].Value.ToString();
                    supplierForm.TransactionType(Int32.Parse(supplier.Rows[rowIndex].Cells[0].Value.ToString()));
                    supplierForm.ShowDialog();
                }
            }
            else if (option == "Delete")
            {
                DialogResult result = Confirmation.ShowDialog($"Are you sure to delete {supplier.Rows[rowIndex].Cells[3].Value.ToString()} ?");
                if (result == DialogResult.Yes)
                {
                    var relationshipAction = new RelationshipMapper();
                    var person = new PersonObject()
                    {
                        Id = Int32.Parse(supplier.Rows[rowIndex].Cells[0].Value.ToString())
                    };
                    var company = new CompanyObject()
                    {
                        Company_Id = Int32.Parse(supplier.Rows[rowIndex].Cells[1].Value.ToString())
                    };
                    relationshipAction.Delete(person, company, "RD_Relationship_DeleteById");
                    Alert_Dialog.ShowAlertMessage("Supplier has been removed successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(current_user_Id, $"Deleted customer from [{supplier.Rows[rowIndex].Cells[3].Value.ToString()}], Contact Person[{supplier.Rows[rowIndex].Cells[6].Value.ToString()}]", "Data Entry");
                    await LoadSupplierList();
                }
            }
        }
        private void datagridSupplier_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseClickContextProvider(sender, dgvSupplierContext, e);
        }
        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            SupplierListOption(datagridSupplier, rowIndex, "Edit");
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            SupplierListOption(datagridSupplier, rowIndex, "Delete");
        }
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            using(var supplierForm = new Supplier(this))
            {
                supplierForm.ShowDialog();
            }
        }
        private async void btnClearSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = Confirmation.ShowDialog("Are you sure to clear all supplier records?");
                if (result == DialogResult.Yes)
                {
                    QueryWorker deleteWorker = new QueryWorker();
                    deleteWorker.DeleteAll("DELETE FROM rd_saims.tbl_relationship WHERE Relationship_Type = 'Supplier'");
                    Alert_Dialog.ShowAlertMessage("All supplier records has been cleared.", Alert_Dialog.AlertType.INFO);
                    await LoadSupplierList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }



        #endregion

        #region ITEM
        private async void btnRefreshItems_Click(object sender, EventArgs e)
        {
            await LoadItemList();
        }

        public async Task LoadItemList()
        {
            try
            {
                var itemAction = new ItemMapper();
                await Task.Delay(1000);
                var items = itemAction.dynamicsList("RD_Item_GetList");
                var dgvworker = new ListToDataTableWorker();
                var dt = new DataTable();
                dt = dgvworker.ConvertToDataTable(items);
                datagridItems.AutoGenerateColumns = false;
                for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                {
                    datagridItems.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                }
                datagridItems.DataSource = dt;

                if (dt.Rows.Count == 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Item has been found.", Alert_Dialog.AlertType.INFO);
                }
                else if (dt.Rows.Count > 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Items has been found.", Alert_Dialog.AlertType.INFO);
                }
            }
            catch
            {
                Alert_Dialog.ShowAlertMessage("No item has been found.", Alert_Dialog.AlertType.WARNING);
                datagridItems.DataSource = null;
            }
        }

        private void datagridItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = datagridItems.Columns[e.ColumnIndex].Name;
            if (column == "item_Edit")
            {
                ItemListOption(datagridItems, e.RowIndex, "Edit");
            }
            else if (column == "item_Delete")
            {
                ItemListOption(datagridItems, e.RowIndex, "Delete");
            }
        }
        private async void ItemListOption(DataGridView item, int rowIndex, string option)
        {
            if (option == "Edit")
            {
                using (var itemForm = new Item(this))
                {
                    itemForm.Item_Id = Int32.Parse(item.Rows[rowIndex].Cells[0].Value.ToString());
                    itemForm.txtItemCode.Text = item.Rows[rowIndex].Cells[2].Value.ToString();
                    itemForm.txtItemName.Text = item.Rows[rowIndex].Cells[3].Value.ToString();
                    itemForm.cmbCategory.Text = item.Rows[rowIndex].Cells[4].Value.ToString();
                    itemForm.txtDescription.Text = item.Rows[rowIndex].Cells[5].Value.ToString();
                    itemForm.TransactionType(Int32.Parse(item.Rows[rowIndex].Cells[0].Value.ToString()));
                    itemForm.ShowDialog();
                }
            }
            else if (option == "Delete")
            {
                DialogResult result = Confirmation.ShowDialog($"Deleting items might cause anomaly to stock records, Are you sure to delete {item.Rows[rowIndex].Cells[3].Value.ToString()} ?");
                if (result == DialogResult.Yes)
                {
                    var itemAction = new ItemMapper();
                    var items = new ItemObject()
                    {
                        Item_Id = Int32.Parse(item.Rows[rowIndex].Cells[0].Value.ToString())
                    };
                    itemAction.Delete(items, "RD_Item_DeleteById");
                    Alert_Dialog.ShowAlertMessage("Item has been removed successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(current_user_Id, $"Deleted Item:[{item.Rows[rowIndex].Cells[3].Value.ToString()}]", "Data Entry");
                    await LoadItemList();
                }
            }
        }
        private void datagridItems_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseClickContextProvider(sender, dgvItemContext, e);
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            ItemListOption(datagridItems, rowIndex, "Edit");
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            ItemListOption(datagridItems, rowIndex, "Delete");
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            using(var itemForm = new Item(this))
            {
                itemForm.ShowDialog();
            }
        }

        private async void btnClearItems_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = Confirmation.ShowDialog("Are you sure to clear all item records?");
                if (result == DialogResult.Yes)
                {
                    QueryWorker deleteWorker = new QueryWorker();
                    deleteWorker.DeleteAll("DELETE FROM rd_saims.tbl_item");
                    Alert_Dialog.ShowAlertMessage("All item records has been cleared.", Alert_Dialog.AlertType.INFO);
                    await LoadItemList ();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region FEEDS TYPE
        private async void btnRefreshFType_Click(object sender, EventArgs e)
        {
            await LoadFeedsTypeList();
        }
        public async Task LoadFeedsTypeList()
        {
            try
            {
                var ftypeAction = new FeedsTypeMapper();
                await Task.Delay(1000);
                var feedsType = ftypeAction.dynamicsList("RD_FeedsType_GetList");
                var dgvworker = new ListToDataTableWorker();
                var dt = new DataTable();
                dt = dgvworker.ConvertToDataTable(feedsType);
                datagridFeedsType.AutoGenerateColumns = false;
                for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                {
                    datagridFeedsType.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                }
                datagridFeedsType.DataSource = dt;

                if (dt.Rows.Count == 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Feeds type has been found.", Alert_Dialog.AlertType.INFO);
                }
                else if (dt.Rows.Count > 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Feeds type are found.", Alert_Dialog.AlertType.INFO);
                }
            }
            catch
            {
                Alert_Dialog.ShowAlertMessage("No feeds type has been found.", Alert_Dialog.AlertType.WARNING);
                datagridFeedsType.DataSource = null;
            }
        }


        private void datagridFeedsType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = datagridFeedsType.Columns[e.ColumnIndex].Name;
            if (column == "ftype_Edit")
            {
                FeedsTypeListOption(datagridFeedsType, e.RowIndex, "Edit");
            }
            else if (column == "ftype_Delete")
            {
                FeedsTypeListOption(datagridFeedsType, e.RowIndex, "Delete");
            }
        }

        private async void FeedsTypeListOption(DataGridView ftype, int rowIndex, string option)
        {
            if (option == "Edit")
            {
                using (var ftypeForm = new FeedsType(this))
                {
                    ftypeForm.FeedsType_Id = Int32.Parse(ftype.Rows[rowIndex].Cells[0].Value.ToString());
                    ftypeForm.txtFeedsTypeCode.Text = ftype.Rows[rowIndex].Cells[2].Value.ToString();
                    ftypeForm.txtDescription.Text = ftype.Rows[rowIndex].Cells[3].Value.ToString();
                    ftypeForm.TransactionType(Int32.Parse(ftype.Rows[rowIndex].Cells[0].Value.ToString()));
                    ftypeForm.ShowDialog();
                }
            }
            else if (option == "Delete")
            {
                DialogResult result = Confirmation.ShowDialog($"Are you sure to delete {ftype.Rows[rowIndex].Cells[2].Value.ToString()} ?");
                if (result == DialogResult.Yes)
                {
                    var ftypeAction = new FeedsTypeMapper();
                    var ftype_Id = new FeedsTypeObject()
                    {
                        FeedsType_Id = Int32.Parse(ftype.Rows[rowIndex].Cells[0].Value.ToString())
                    };
                    ftypeAction.Delete(ftype_Id, "RD_FeedsType_DeleteById");
                    Alert_Dialog.ShowAlertMessage("Feeds type has been removed successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(current_user_Id, $"Deleted Feed Type:[{ftype.Rows[rowIndex].Cells[2].Value.ToString()}]", "Data Entry");
                    await LoadFeedsTypeList();
                }
            }
        }

        private void datagridFeedsType_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseClickContextProvider(sender, dgvFTypeContext, e);
        }

        private void btnEditFType_Click(object sender, EventArgs e)
        {
            FeedsTypeListOption(datagridFeedsType, rowIndex, "Edit");
        }

        private void btnDeleteFType_Click(object sender, EventArgs e)
        {
            FeedsTypeListOption(datagridFeedsType, rowIndex, "Delete");
        }

        private void btnAddFType_Click(object sender, EventArgs e)
        {
            using(var ftypeForm = new FeedsType(this))
            {
                ftypeForm.ShowDialog();
            }
        }

        private async void btnClearFType_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = Confirmation.ShowDialog("Are you sure to clear all feeds type records?");
                if (result == DialogResult.Yes)
                {
                    QueryWorker deleteWorker = new QueryWorker();
                    deleteWorker.DeleteAll("DELETE FROM rd_saims.tbl_feedstype");
                    Alert_Dialog.ShowAlertMessage("All feeds type records has been cleared.", Alert_Dialog.AlertType.INFO);
                    await LoadFeedsTypeList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        #endregion

        #region EXPENSE TYPE


        private async void btnRefreshExpType_Click(object sender, EventArgs e)
        {
            await LoadExpenseTypeList();
        }
        public async Task LoadExpenseTypeList()
        {
            try
            {
                var ftypeAction = new FeedsTypeMapper();
                await Task.Delay(1000);
                var feedsType = ftypeAction.dynamicsList("RD_ExpenseType_GetList");
                var dgvworker = new ListToDataTableWorker();
                var dt = new DataTable();
                dt = dgvworker.ConvertToDataTable(feedsType);
                datagridExpenseType.AutoGenerateColumns = false;
                for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                {
                    datagridExpenseType.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                }
                datagridExpenseType.DataSource = dt;

                if (dt.Rows.Count == 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Expense type has been found.", Alert_Dialog.AlertType.INFO);
                }
                else if (dt.Rows.Count > 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Expense types has been found.", Alert_Dialog.AlertType.INFO);
                }
            }
            catch
            {
                Alert_Dialog.ShowAlertMessage("No expense type has been found.", Alert_Dialog.AlertType.WARNING);
                datagridExpenseType.DataSource = null;
            }
        }
        private void btnAddExpType_Click(object sender, EventArgs e)
        {
            using (var xtypeForm = new ExpenseType(this))
            {
                xtypeForm.ShowDialog();
            }
        }

        private async void btnClearExpType_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = Confirmation.ShowDialog("Are you sure to clear all expense type records?");
                if (result == DialogResult.Yes)
                {
                    QueryWorker deleteWorker = new QueryWorker();
                    deleteWorker.DeleteAll("DELETE FROM rd_saims.tbl_expensetype");
                    Alert_Dialog.ShowAlertMessage("All expense type records has been cleared.", Alert_Dialog.AlertType.INFO);
                    await LoadExpenseTypeList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void datagridExpenseType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = datagridExpenseType.Columns[e.ColumnIndex].Name;
            if (column == "xtype_Edit")
            {
                ExpenseTypeListOption(datagridExpenseType, e.RowIndex, "Edit");
            }
            else if (column == "xtype_Delete")
            {
                ExpenseTypeListOption(datagridExpenseType, e.RowIndex, "Delete");
            }
        }
        private async void ExpenseTypeListOption(DataGridView xtype, int rowIndex, string option)
        {
            if (option == "Edit")
            {
                using (var xtypeForm = new ExpenseType(this))
                {
                    xtypeForm.ExpenseType_Id = Int32.Parse(xtype.Rows[rowIndex].Cells[0].Value.ToString());
                    xtypeForm.txtExpenseType.Text = xtype.Rows[rowIndex].Cells[2].Value.ToString();
                    xtypeForm.txtDescription.Text = xtype.Rows[rowIndex].Cells[3].Value.ToString();
                    xtypeForm.TransactionType(Int32.Parse(xtype.Rows[rowIndex].Cells[0].Value.ToString()));
                    xtypeForm.ShowDialog();
                }
            }
            else if (option == "Delete")
            {
                DialogResult result = Confirmation.ShowDialog($"Are you sure to delete {xtype.Rows[rowIndex].Cells[2].Value.ToString()} ?");
                if (result == DialogResult.Yes)
                {
                    var xtypeAction = new ExpenseTypeMapper();
                    var xtype_Id = new ExpenseTypeObject()
                    {
                        ExpenseType_Id = Int32.Parse(xtype.Rows[rowIndex].Cells[0].Value.ToString())
                    };
                    xtypeAction.Delete(xtype_Id, "RD_ExpenseType_DeleteById");
                    Alert_Dialog.ShowAlertMessage("Expense type has been removed successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(current_user_Id, $"Deleted an Expense Type[{xtype.Rows[rowIndex].Cells[2].Value.ToString()}]", "Data Entry");
                    await LoadExpenseTypeList ();
                }
            }
        }

        private void datagridExpenseType_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseClickContextProvider(sender, dgvXTypeContext, e);
        }

        private void btnEditXType_Click(object sender, EventArgs e)
        {
            ExpenseTypeListOption(datagridExpenseType, rowIndex, "Edit");
        }

        private void btnDeleteXType_Click(object sender, EventArgs e)
        {
            ExpenseTypeListOption(datagridExpenseType, rowIndex, "Delete");
        }
        #endregion

        #region PRICING

        private async void btnRefreshPrices_Click(object sender, EventArgs e)
        {
            await LoadPricingList();
        }

        public async Task LoadPricingList()
        {
            try
            {
                var priceAction = new PriceMapper();
                await Task.Delay(1000);
                var prices = priceAction.dynamicsList("RD_Price_GetList");
                var dgvworker = new ListToDataTableWorker();
                var dt = new DataTable();
                dt = dgvworker.ConvertToDataTable(prices);
                datagridPrice.AutoGenerateColumns = false;
                for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                {
                    datagridPrice.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                }
                datagridPrice.DataSource = dt;

                if (dt.Rows.Count == 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Price has been found.", Alert_Dialog.AlertType.INFO);
                }
                else if (dt.Rows.Count > 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Prices are found.", Alert_Dialog.AlertType.INFO);
                }
            }
            catch
            {
                Alert_Dialog.ShowAlertMessage("No price has been found.", Alert_Dialog.AlertType.WARNING);
                datagridPrice.DataSource = null;
            }
        }
        private void btnAddPrice_Click(object sender, EventArgs e)
        {
            using (Pricing formPricing = new Pricing(this))
            {
                formPricing.ShowDialog();
            }
        }

        private async void btnClearPrices_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = Confirmation.ShowDialog("Are you sure to clear all price records ?");
                if (result == DialogResult.Yes)
                {
                    QueryWorker deleteWorker = new QueryWorker();
                    deleteWorker.DeleteAll("DELETE FROM rd_saims.tbl_price");
                    Alert_Dialog.ShowAlertMessage("All price records has been cleared.", Alert_Dialog.AlertType.INFO);
                    await LoadPricingList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }



        private void datagridPrice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = datagridPrice.Columns[e.ColumnIndex].Name;
            if (column == "price_Edit")
            {
                PriceListOption(datagridPrice, e.RowIndex, "Edit");
            }
            else if (column == "price_Delete")
            {
                PriceListOption(datagridPrice, e.RowIndex, "Delete");
            }
        }
        private async void PriceListOption(DataGridView price, int rowIndex, string option)
        {
            if (option == "Edit")
            {
                using (var priceForm = new Pricing(this))
                {
                    priceForm.Price_Id = Int32.Parse(price.Rows[rowIndex].Cells[0].Value.ToString());
                    priceForm.txtPriceCode.Text = price.Rows[rowIndex].Cells[2].Value.ToString();
                    priceForm.txtPriceValue.Text = price.Rows[rowIndex].Cells[3].Value.ToString();
                    priceForm.TransactionType(Int32.Parse(price.Rows[rowIndex].Cells[0].Value.ToString()));
                    priceForm.ShowDialog();
                }
            }
            else if (option == "Delete")
            {
                DialogResult result = Confirmation.ShowDialog($"Are you sure to delete {price.Rows[rowIndex].Cells[2].Value.ToString()} ?");
                if (result == DialogResult.Yes)
                {
                    var priceAction = new PriceMapper();
                    var price_Id = new PriceObject()
                    {
                        Price_Id = Int32.Parse(price.Rows[rowIndex].Cells[0].Value.ToString())
                    };
                    priceAction.Delete(price_Id, "RD_Price_DeleteById");
                    Alert_Dialog.ShowAlertMessage("Price has been removed successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(current_user_Id, $"Deleted Pricing[{price.Rows[rowIndex].Cells[2].Value.ToString()}]", "Data Entry");
                    await LoadPricingList();
                }
            }
        }

        private void datagridPrice_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseClickContextProvider(sender, dgvPriceContext, e);
        }
        private void btnEditPrice_Click(object sender, EventArgs e)
        {
            PriceListOption(datagridPrice, rowIndex, "Edit");
        }

        private void btnDeletePrice_Click(object sender, EventArgs e)
        {
            PriceListOption(datagridPrice, rowIndex, "Delete");
        }
        #endregion

        #region POND
        private async  void btnRefreshPonds_Click(object sender, EventArgs e)
        {
           await LoadPondList();
        }
        public async Task LoadPondList()
        {
            try
            {
                var pondAction = new PondMapper();
                await Task.Delay(1000);
                var ponds = pondAction.dynamicsList("RD_Pond_GetList");
                var dgvworker = new ListToDataTableWorker();
                var dt = new DataTable();
                dt = dgvworker.ConvertToDataTable(ponds);
                datagridPond.AutoGenerateColumns = false;
                for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                {
                    datagridPond.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                }
                datagridPond.DataSource = dt;

                if (dt.Rows.Count == 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Pond has been found.", Alert_Dialog.AlertType.INFO);
                }
                else if (dt.Rows.Count > 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Ponds has been found.", Alert_Dialog.AlertType.INFO);
                }
            }
            catch
            {
                Alert_Dialog.ShowAlertMessage("No Pond record has been found.", Alert_Dialog.AlertType.WARNING);
                datagridPond.DataSource = null;
            }
        }
        private void btnAddPond_Click(object sender, EventArgs e)
        {
            using (var pondForm = new Pond(this))
            {
                pondForm.TransactionType(0);
                pondForm.ShowDialog();
            }
        }
        private void datagridPond_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = datagridPond.Columns[e.ColumnIndex].Name;
            if (column == "pond_Edit")
            {
                PondListOption(datagridPond, e.RowIndex, "Edit");
            }
            else if (column == "pond_Delete")
            {
                PondListOption(datagridPond, e.RowIndex, "Delete");
            }
        }

        private async void PondListOption(DataGridView pond, int rowIndex, string option)
        {
            var rsrcmgr = new ResourceManager();
            if (option == "Edit")
            {
                using (var pondForm = new Pond(this))
                {
                    pondForm.Pond_Id = Int32.Parse(pond.Rows[rowIndex].Cells[0].Value.ToString());
                    pondForm.txtPondCode.Text = pond.Rows[rowIndex].Cells[2].Value.ToString();
                    pondForm.txtPondArea.Text = pond.Rows[rowIndex].Cells[3].Value.ToString();
                    pondForm.pbxPondImage.Image = rsrcmgr.ByteArrayToImage(File.ReadAllBytes(SystemPath.PondPath + pond.Rows[rowIndex].Cells[4].Value.ToString()));
                    pondForm.TransactionType(Int32.Parse(pond.Rows[rowIndex].Cells[0].Value.ToString()));
                    pondForm.ShowDialog();
                }
            }
            else if (option == "Delete")
            {
                DialogResult result = Confirmation.ShowDialog($"Are you sure to delete {pond.Rows[rowIndex].Cells[2].Value.ToString()} ?");
                if (result == DialogResult.Yes)
                {
                    var pondAction = new PondMapper();
                    var pond_Id = new PondObject()
                    {
                        Pond_Id = Int32.Parse(pond.Rows[rowIndex].Cells[0].Value.ToString())
                    };
                    pondAction.Delete(pond_Id, "RD_Pond_DeleteById");
                    File.Delete(SystemPath.PondPath + pond.Rows[rowIndex].Cells[4].Value.ToString());
                    Alert_Dialog.ShowAlertMessage("Pond has been removed successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(current_user_Id, $"Deleted Pond[{pond.Rows[rowIndex].Cells[2].Value.ToString()}]", "Data Entry");
                    await LoadPondList();
                }
            }
        }

        private void datagridPond_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseClickContextProvider(sender, dgvPondContext, e);
        }

        private void btnEditPond_Click(object sender, EventArgs e)
        {
            PondListOption(datagridPond, rowIndex, "Edit");
        }

        private void btnDeletePond_Click(object sender, EventArgs e)
        {
            PondListOption(datagridPond, rowIndex, "Delete");
        }
        #endregion

        #region POND ENTRY

        private void btnRefreshPondEntry_Click(object sender, EventArgs e)
        {
            LoadPondEntryList();
        }

        public async void LoadPondEntryList()
        {
            await GetOccupiedPondList();
            await GetIdlePondList();
        }
        public async Task GetOccupiedPondList()
        {
            try
            {
                var prodAction = new ProductionMapper();
                var prod = new ProductionObject()
                {
                    Farm_Name = GetCurrentFarmName()
                };
                await Task.Delay(1000);
                var ponds = prodAction.dynamicsListWithParam(prod, "RD_Production_GetOccupiedList");
                var dgvworker = new ListToDataTableWorker();
                var dt = new DataTable();
                dt = dgvworker.ConvertToDataTable(ponds);
                datagridOccupied.AutoGenerateColumns = false;
                for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                {
                    datagridOccupied.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                }
                datagridOccupied.DataSource = dt;

                if (dt.Rows.Count == 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Occupied pond has been found.", Alert_Dialog.AlertType.INFO);
                }
                else if (dt.Rows.Count > 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Occupied ponds has been found.", Alert_Dialog.AlertType.INFO);
                }
            }
            catch
            {
                Alert_Dialog.ShowAlertMessage("No occupied pond record has been found.", Alert_Dialog.AlertType.WARNING);
                datagridOccupied.DataSource = null;
            }
        }
        public async Task GetIdlePondList()
        {
            try
            {
                var prodAction = new ProductionMapper();
                var prod = new ProductionObject()
                {
                    Farm_Name = GetCurrentFarmName()
                };
                await Task.Delay(1000);
                var idle = prodAction.dynamicsListWithParam(prod, "RD_Production_GetIdleList");
                var dgvworker = new ListToDataTableWorker();
                var dt = new DataTable();
                dt = dgvworker.ConvertToDataTable(idle);
                datagridIdle.AutoGenerateColumns = false;
                for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                {
                    datagridIdle.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                }
                datagridIdle.DataSource = dt;

                if (dt.Rows.Count == 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Idle pond has been found.", Alert_Dialog.AlertType.INFO);
                }
                else if (dt.Rows.Count > 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Idle ponds has been found.", Alert_Dialog.AlertType.INFO);
                }
            }
            catch
            {
                Alert_Dialog.ShowAlertMessage("No idle pond record has been found.", Alert_Dialog.AlertType.WARNING);
                datagridIdle.DataSource = null;
            }
        }
        private void btnNewPondByEntry_Click(object sender, EventArgs e)
        {
            btnAddPond_Click(null, null);
        }

        private void btnPrintPondPlan_Click(object sender, EventArgs e)
        {
            using (Printer fp = new Printer(this))
            {
                fp.setTitle("Print Pond Status");
                fp.SetPondStatusReport(new rptPlan());
                fp.ShowDialog();
            }
        }
        private void datagridIdle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = datagridIdle.Columns[e.ColumnIndex].Name;
            if (column == "idle_Edit")
            {
                PondEntryList(datagridIdle, e.RowIndex, "Create");
            }
        }

        private void PondEntryList(DataGridView dgv, int rowIndex, string option)
        {
            if (option == "Edit")
            {
                using (Plan_Entry pe = new Plan_Entry(this))
                {
                    pe.fillCombo();
                    pe.TransactionType("Update");

                    pe.Production_Id = Int32.Parse(dgv.Rows[rowIndex].Cells[0].Value.ToString());
                    pe.txtProductionNumber.Text = dgv.Rows[rowIndex].Cells[2].Value.ToString();
                    pe.txtCropNumber.Value = Int32.Parse(dgv.Rows[rowIndex].Cells[3].Value.ToString());
                    pe.cmbPond.Text = dgv.Rows[rowIndex].Cells[4].Value.ToString();
                    pe.lblArea.Text = $"Area: {dgv.Rows[rowIndex].Cells[5].Value.ToString()}";
                    if (!string.IsNullOrEmpty(dgv.Rows[rowIndex].Cells[5].Value.ToString())) { pe.Area = Int32.Parse(dgv.Rows[rowIndex].Cells[5].Value.ToString().Replace(",", "")); }
                    if (!string.IsNullOrEmpty(dgv.Rows[rowIndex].Cells[7].Value.ToString())) pe.dtpDateStocked.Value = Convert.ToDateTime(dgv.Rows[rowIndex].Cells[7].Value.ToString());
                    if (!string.IsNullOrEmpty(dgv.Rows[rowIndex].Cells[8].Value.ToString())) pe.dtpHarvest.Value = Convert.ToDateTime(dgv.Rows[rowIndex].Cells[8].Value.ToString());
                    pe.lblDOC.Text = string.IsNullOrEmpty(dgv.Rows[rowIndex].Cells[9].Value.ToString()) ? "0" : dgv.Rows[rowIndex].Cells[9].Value.ToString();
                    pe.txtFryStocked.Text = string.IsNullOrEmpty(dgv.Rows[rowIndex].Cells[10].Value.ToString()) ? "" : dgv.Rows[rowIndex].Cells[10].Value.ToString();
                    pe.lblSD.Text = string.IsNullOrEmpty(dgv.Rows[rowIndex].Cells[11].Value.ToString()) ? "0" : dgv.Rows[rowIndex].Cells[11].Value.ToString();
                    pe.lblBiomass.Text = string.IsNullOrEmpty(dgv.Rows[rowIndex].Cells[14].Value.ToString()) ? "0" : dgv.Rows[rowIndex].Cells[14].Value.ToString();
                    pe.lblFeedsRequired.Text = string.IsNullOrEmpty(dgv.Rows[rowIndex].Cells[15].Value.ToString()) ? "0" : dgv.Rows[rowIndex].Cells[15].Value.ToString();
                    if (!string.IsNullOrEmpty(dgv.Rows[rowIndex].Cells[17].Value.ToString())) { pe.cmbSupplier.Text = dgv.Rows[rowIndex].Cells[17].Value.ToString(); }

                    pe.ShowDialog();
                }
            }
            else if (option == "Clear")
            {
                DialogResult result = Confirmation.ShowDialog($"Are you sure to clear {dgv.Rows[rowIndex].Cells[2].Value.ToString()} data?");
                if (result == DialogResult.Yes)
                {
                    var prodAction = new ProductionMapper();
                    var pn = new ProductionObject()
                    {
                        Production_Id = Int32.Parse(dgv.Rows[rowIndex].Cells[0].Value.ToString()),
                        Production_Number = Int32.Parse(dgv.Rows[rowIndex].Cells[2].Value.ToString())
                    };
                    prodAction.Clear(pn, "RD_Production_ClearEntry");
                    Alert_Dialog.ShowAlertMessage("Pond data has been cleared successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(current_user_Id, $" Cleared [{dgv.Rows[rowIndex].Cells[2].Value.ToString()}] data", "Pond Entry");
                    LoadPondEntryList();
                }
            }
            else if (option == "Create")
            {
                using(Plan_Entry pe = new Plan_Entry(this))
                {
                    pe.fillCombo();
                    pe.TransactionType("Create");

                    pe.Production_Id = Int32.Parse(dgv.Rows[rowIndex].Cells[0].Value.ToString());
                    pe.txtProductionNumber.Text = dgv.Rows[rowIndex].Cells[2].Value.ToString();
                    pe.cmbPond.Text = dgv.Rows[rowIndex].Cells[3].Value.ToString();
                    pe.lblArea.Text = $"Area: {dgv.Rows[rowIndex].Cells[4].Value.ToString()}";
                    if (!string.IsNullOrEmpty(dgv.Rows[rowIndex].Cells[4].Value.ToString())) { pe.Area = Int32.Parse(dgv.Rows[rowIndex].Cells[4].Value.ToString().Replace(",", "")); }
                    if (!string.IsNullOrEmpty(dgv.Rows[rowIndex].Cells[6].Value.ToString())) { pe.dtpDateStocked.Value = Convert.ToDateTime(dgv.Rows[rowIndex].Cells[6].Value.ToString()); };
                    if (!string.IsNullOrEmpty(dgv.Rows[rowIndex].Cells[7].Value.ToString())) { pe.dtpHarvest.Value = Convert.ToDateTime(dgv.Rows[rowIndex].Cells[7].Value.ToString()).AddDays(7);  };
                    pe.lblDOC.Text = string.IsNullOrEmpty(dgv.Rows[rowIndex].Cells[8].Value.ToString()) ? "0" : dgv.Rows[rowIndex].Cells[8].Value.ToString();
                    pe.txtFryStocked.Text = string.IsNullOrEmpty(dgv.Rows[rowIndex].Cells[9].Value.ToString()) ? "" : dgv.Rows[rowIndex].Cells[9].Value.ToString();
                    pe.lblSD.Text = string.IsNullOrEmpty(dgv.Rows[rowIndex].Cells[10].Value.ToString()) ? "0" : dgv.Rows[rowIndex].Cells[10].Value.ToString();
                    pe.lblBiomass.Text = string.IsNullOrEmpty(dgv.Rows[rowIndex].Cells[13].Value.ToString()) ? "0" : dgv.Rows[rowIndex].Cells[13].Value.ToString();
                    pe.lblFeedsRequired.Text = string.IsNullOrEmpty(dgv.Rows[rowIndex].Cells[14].Value.ToString()) ? "0" : dgv.Rows[rowIndex].Cells[14].Value.ToString();
                    if (!string.IsNullOrEmpty(dgv.Rows[rowIndex].Cells[16].Value.ToString())) { pe.cmbSupplier.Text = dgv.Rows[rowIndex].Cells[16].Value.ToString(); }

                    pe.ShowDialog();
                }
            }
            else if (option == "Sampling")
            {
                using (Weekly_Status wk = new Weekly_Status(this))
                {
                    wk.fillProduction();
                    wk.cmbPond.Text = dgv.Rows[rowIndex].Cells[4].Value.ToString();
                    wk.ShowDialog();

                }
            }

        }

        private void datagridIdle_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseClickContextProvider(sender, dgvIdleContext, e);
        }

        private void btnCreatePondEntry_Click(object sender, EventArgs e)
        {
            PondEntryList(datagridIdle, rowIndex, "Create");
        }

        private void datagridOccupied_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = datagridIdle.Columns[e.ColumnIndex].Name;
            if (column == "idle_Edit")
            {
                PondEntryList(datagridIdle, e.RowIndex, "Create");
            }
        }

        private void datagridOccupied_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseClickContextProvider(sender, dgvOccupiedContext, e);
        }

        private void btnEditOccupied_Click(object sender, EventArgs e)
        {
            PondEntryList(datagridOccupied, rowIndex, "Edit");
        }

        private void btnDeleteOccupied_Click(object sender, EventArgs e)
        {
            PondEntryList(datagridOccupied, rowIndex, "Clear");
        }

        private void btnOccupiedCreate_Click(object sender, EventArgs e)
        {
            PondEntryList(datagridOccupied, rowIndex, "Sampling");
        }

        #endregion

        #region WEEKLY STATUS
        private async void btnRefreshSampling_Click(object sender, EventArgs e)
        {
            if (cmbWeeklyProduction.DataSource != null && !string.IsNullOrEmpty(cmbWeeklyProduction.Text))
            {
                await LoadWeekyUpdateList(Int64.Parse(cmbWeeklyProduction.Text));
            }
        }
        public void fillWeeklyProduction()
        {
            try
            {
                var prodAction = new ProductionMapper();
                var farmName = new ProductionObject()
                {
                    Farm_Name = GetCurrentFarmName()
                };
                var ponds = prodAction.dynamicsListWithParam(farmName, "RD_Production_GetOccupiedList");
                cmbWeeklyProduction.DataSource = ponds;
                cmbWeeklyProduction.DisplayMember = "Production_Number";
                cmbWeeklyProduction.ValueMember = "Production_Id";
            }
            catch { }
        }
        public string GetCurrentFarmName()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(SystemPath.FarmPath);
            string farmOwner = xmlDoc.SelectSingleNode("/ Farm / Name").InnerText;
            return farmOwner;
        }

        public async Task LoadWeekyUpdateList(long number)
        {
            try
            {
                var prodAction = new ProductionMapper();
                var prod = new ProductionObject()
                {
                    Production_Number = number,
                    Farm_Name = GetCurrentFarmName()
                };
                await Task.Delay(1000);
                var ponds = prodAction.dynamicsListWithParam(prod, "RD_Production_GetSamplingList");
                var dgvworker = new ListToDataTableWorker();
                var dt = new DataTable();
                dt = dgvworker.ConvertToDataTable(ponds);
                datagridSampling.AutoGenerateColumns = false;
                for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                {
                    datagridSampling.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                }
                datagridSampling.DataSource = dt;

                if (dt.Rows.Count == 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Sampling has been found.", Alert_Dialog.AlertType.INFO);
                }
                else if (dt.Rows.Count > 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Samplings are found.", Alert_Dialog.AlertType.INFO);
                }
            }
            catch
            {
                Alert_Dialog.ShowAlertMessage("No sampling record has been found.", Alert_Dialog.AlertType.WARNING);
                datagridSampling.DataSource = null;
            }
        }
        private void datagridSampling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = datagridSampling.Columns[e.ColumnIndex].Name;
            if (column == "sm_Edit")
            {
                SamplingListOption(datagridSampling, e.RowIndex, "Edit");
            }
            else if (column == "sm_Delete")
            {
                SamplingListOption(datagridSampling, e.RowIndex, "Delete");
            }
        }

        private async void SamplingListOption(DataGridView sm, int rowIndex, string option)
        {
            if(option == "Edit")
            {
                using(Weekly_Status wkform = new Weekly_Status(this))
                {
                    wkform.txtWN.Enabled = true;
                    wkform.cmbPond.Text = sm.Rows[rowIndex].Cells[5].Value.ToString();
                    wkform.txtWN.Value = Int32.Parse(sm.Rows[rowIndex].Cells[4].Value.ToString());
                    wkform.fillProduction();
                    wkform.ShowDialog();
                }
            }
            else if(option == "Delete")
            {
                DialogResult result = Confirmation.ShowDialog($"Are you sure to delete Production No. {sm.Rows[rowIndex].Cells[2].Value.ToString()} sampling?");
                if (result == DialogResult.Yes)
                {
                    var prodAction = new ProductionMapper();
                    var pn = new ProductionObject()
                    {
                        Production_Id = Int32.Parse(sm.Rows[rowIndex].Cells[0].Value.ToString()),
                        Week_Number = Int32.Parse(sm.Rows[rowIndex].Cells[4].Value.ToString())
                    };
                    prodAction.Clear(pn, "RD_Production_DeleteSampling");
                    Alert_Dialog.ShowAlertMessage("Sampling has been deleted successfully.", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(current_user_Id, $"Deleted Sampling for Week [{sm.Rows[rowIndex].Cells[4].Value.ToString()}] on Production[{cmbWeeklyProduction.Text}]", "Pond Entry");
                    await LoadWeekyUpdateList(Int64.Parse(cmbWeeklyProduction.Text));
                }
            }
            else if(option == "Harvest")
            {
                using (Create_Harvest ch = new Create_Harvest(this))
                {
                    ch.Production_Id = Int32.Parse(sm.Rows[rowIndex].Cells[0].Value.ToString());
                    ch.lblCropNo.Text = sm.Rows[rowIndex].Cells[3].Value.ToString();
                    ch.SetProductionNo(sm.Rows[rowIndex].Cells[2].Value.ToString());
                    ch.lblPond.Text = sm.Rows[rowIndex].Cells[5].Value.ToString();
                    ch.lblTotalStocked.Text = sm.Rows[rowIndex].Cells[8].Value.ToString();
                    if (!string.IsNullOrEmpty(sm.Rows[rowIndex].Cells[8].Value.ToString())) { ch.Qty = Int64.Parse(sm.Rows[rowIndex].Cells[8].Value.ToString().Replace(",","")); }
                    ch.lblABW.Text = string.IsNullOrEmpty(sm.Rows[rowIndex].Cells[13].Value.ToString())? "00.00" : sm.Rows[rowIndex].Cells[13].Value.ToString();
                    if (!string.IsNullOrEmpty(sm.Rows[rowIndex].Cells[13].Value.ToString())) { ch.Abw = Double.Parse(sm.Rows[rowIndex].Cells[13].Value.ToString()); }
                    ch.lblDOC.Text = (sm.Rows[rowIndex].Cells[11].Value.ToString());
                    ch.lblSR.Text = string.IsNullOrEmpty(sm.Rows[rowIndex].Cells[18].Value.ToString()) ? "00.00" : sm.Rows[rowIndex].Cells[18].Value.ToString();
                    ch.ShowDialog();
                }
            }
        }

        private void datagridSampling_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseClickContextProvider(sender, dgvSamplingContext, e);
        }
        private void btnNewSampling_Click(object sender, EventArgs e)
        {
            using (Weekly_Status wk = new Weekly_Status(this))
            {
                wk.fillProduction();
                wk.ShowDialog();
            }
        }

        private async void cmbWeeklyProduction_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbWeeklyProduction.DataSource != null)
            {
                await LoadWeekyUpdateList(Int64.Parse(cmbWeeklyProduction.Text));
            }
        }

        private void btnEditSampling_Click(object sender, EventArgs e)
        {
            SamplingListOption(datagridSampling, rowIndex, "Edit");
        }

        private void btnDeleteSampling_Click(object sender, EventArgs e)
        {
            SamplingListOption(datagridSampling, rowIndex, "Delete");
        }
        private void btnCreateHarvest_Click(object sender, EventArgs e)
        {
            SamplingListOption(datagridSampling, rowIndex, "Harvest");
        }
        private void btnPrintSampling_Click(object sender, EventArgs e)
        {
            DialogResult result = Confirmation.ShowDialog($"Add remarks/note to sampling report on Production No. {cmbWeeklyProduction.Text} ?");
            if (result == DialogResult.Yes)
            {
                using (Remarks fr = new Remarks(this))
                {
                    fr.ShowDialog();
                }
            }
            else
            {
                using (Printer fp = new Printer(this))
                {
                    fp.setTitle("Print Sampling Report");
                    fp.SetProductionSampling(new rptSampling());
                    fp.ShowDialog();
                }
            }
            
        }
        #endregion

        #region POND RESULT
        private async void btnRefreshResult_Click(object sender, EventArgs e)
        {
            await LoadResultList();
        }
        private async Task LoadResultList()
        {
            try
            {
                var prodAction = new ProductionMapper();
                var prod = new ProductionObject()
                {
                    Farm_Name = GetCurrentFarmName()
                };
                await Task.Delay(1000);
                var ponds = prodAction.dynamicsListWithParam(prod, "RD_Production_GetResultList");
                var dgvworker = new ListToDataTableWorker();
                var dt = new DataTable();
                dt = dgvworker.ConvertToDataTable(ponds);
                datagridResult.AutoGenerateColumns = false;
                for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                {
                    datagridResult.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                }
                datagridResult.DataSource = dt;

                if (dt.Rows.Count == 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Pond result has been found.", Alert_Dialog.AlertType.INFO);
                }
                else if (dt.Rows.Count > 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Pond result are found.", Alert_Dialog.AlertType.INFO);
                }
            }
            catch
            {
                Alert_Dialog.ShowAlertMessage("No pond result record has been found.", Alert_Dialog.AlertType.WARNING);
                datagridResult.DataSource = null;
            }
        }
        private void btnPrintResults_Click(object sender, EventArgs e)
        {
            using(Result_Parameters frp = new Result_Parameters(this))
            {
                frp.ShowDialog();
            }
        }
        #endregion

        #region MR
        List<Validator> MRValidator = new List<Validator>();
        public string Previous_Unit { get; set; }
        public double DefaultStockQty { get; set; }
        private async void btnRefreshMR_Click(object sender, EventArgs e)
        {
            await LoadMRList();
        }

        private void fillMRCombo()
        {
            try
            {
                var categoryAction = new CategoryMapper();
                var category = categoryAction.dynamicsList("RD_Category_GetList");
                cmbRequestCategory.DataSource = category;
                cmbRequestCategory.DisplayMember = "Category_Name";
                cmbRequestCategory.ValueMember = "Category_Id";

                var ftypeAction = new FeedsTypeMapper();
                var ftypes = ftypeAction.dynamicsList("RD_FeedsType_GetList");
                cmbRequestFType.DataSource = ftypes;
                cmbRequestFType.DisplayMember = "FeedsType_Code";
                cmbRequestFType.ValueMember = "FeedsType_Id";

                var unitAction = new UnitMapper();
                var units = unitAction.dynamicsList("RD_Unit_GetList");
                cmbRequestUnit.DataSource = units;
                cmbRequestUnit.DisplayMember = "Expression";
                cmbRequestUnit.ValueMember = "Unit_Id";
                }
            catch{

            }
        }

        public async Task LoadMRList()
        {
            try
            {
                var invAction = new InventoryMapper();
                await Task.Delay(1000);
                var requests = invAction.dynamicsList("RD_Stock_GetRequestList");
                var dgvworker = new ListToDataTableWorker();
                var dt = new DataTable();
                dt = dgvworker.ConvertToDataTable(requests);
                datagridMR.AutoGenerateColumns = false;
                for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                {
                    datagridMR.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                }
                datagridMR.DataSource = dt;

                if (dt.Rows.Count == 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Request has been found.", Alert_Dialog.AlertType.INFO);
                }
                else if (dt.Rows.Count > 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Requests are found.", Alert_Dialog.AlertType.INFO);
                }
            }
            catch
            {
                Alert_Dialog.ShowAlertMessage("No request record has been found.", Alert_Dialog.AlertType.WARNING);
                datagridMR.DataSource = null;
            }
        }

        private void btnCreateMR_Click(object sender, EventArgs e)
        {
            if (panelMREntry.Size.Width == 0)
            {
                panelMREntry.Size = new Size(350, panelMREntry.Size.Height);
            }
            MRValidator.Add(new Validator(txtRequestQty, errRequestQty, "quantity", "required|nozero"));
            fillMRCombo();
        }

        private void btnSaveMR_Click(object sender, EventArgs e)
        {
            validateMREntry();
        }
        private async void validateMREntry()
        {
            if (MRValidator.Count((validator) => validator.IsValid()) == MRValidator.Count)
            {
                var invAction = new InventoryMapper();
                var inv = new InventoryStockObject()
                {
                    Inventory_Id = Selected_Id,
                    Item_Id = Int32.Parse(cmbRequestItem.SelectedValue.ToString()),
                    FType_Id = cmbRequestFType.Visible == false ? default :  Int32.Parse(cmbRequestFType.SelectedValue.ToString()),
                    Quantity = Double.Parse(txtRequestQty.Text.Replace(",", "")),
                    Entry_Date = Convert.ToDateTime(dtpRequest.Value.ToString("yyyy-MM-dd")),
                    Unit_Id = Int32.Parse(cmbRequestUnit.SelectedValue.ToString())
                };
                invAction.InsertOrUpdate(inv, "RD_Stock_InsertUpdateRequest");
                Alert_Dialog.ShowAlertMessage($"Request has been {(rowIndex == 0 ? "Added" : "Updated")} successfully", Alert_Dialog.AlertType.SUCCESS);
                new AuditTrailMapper().InsertActivity(current_user_Id, $"{(Selected_Id == 0? "Created": "Updated")} Request for Item:[{cmbRequestItem.Text}], Item Type:[{(cmbRequestFType.Visible == true? cmbRequestFType.Text: "")}], Quantity:[{txtRequestQty.Text}] Unit:[{cmbRequestUnit.Text}]", "Inventory");
                btnCancelMR_Click(null, null);
                await LoadMRList();
            }
        }
        private void btnCancelMR_Click(object sender, EventArgs e)
        {
            panelMREntry.Size = new Size(0, panelMREntry.Size.Height);
            MRValidator.ForEach(validator => validator.Reset());
            var inprv = new InputRemoverAndValidation();
            inprv.ClearText(panelMREntry);
            Selected_Id = 0;
            Previous_Unit = "";
            DefaultStockQty = 0;
        }

        private void datagridMR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = datagridMR.Columns[e.ColumnIndex].Name;
            if (column == "mr_Edit")
            {
                MRListOption(datagridMR, e.RowIndex, "Edit");
            }
            else if (column == "mr_Delete")
            {
                MRListOption(datagridMR, e.RowIndex, "Delete");
            }
        }

        private async void MRListOption(DataGridView mr, int rowIndex, string option)
        {
            if(option == "Edit")
            {
                btnCreateMR_Click(null, null);

                Selected_Id = Int32.Parse(mr.Rows[rowIndex].Cells[0].Value.ToString());
                cmbRequestCategory.Text = mr.Rows[rowIndex].Cells[4].Value.ToString();
                cmbRequestItem.Text = mr.Rows[rowIndex].Cells[3].Value.ToString();
                Previous_Unit = mr.Rows[rowIndex].Cells[9].Value.ToString();
                txtRequestQty.Text = mr.Rows[rowIndex].Cells[7].Value.ToString();
                DefaultStockQty = Double.Parse(mr.Rows[rowIndex].Cells[7].Value.ToString().Replace(",",""));
                if (!string.IsNullOrEmpty(mr.Rows[rowIndex].Cells[5].Value.ToString())) { cmbRequestFType.Text = mr.Rows[rowIndex].Cells[5].Value.ToString(); }
                dtpRequest.Value = Convert.ToDateTime(mr.Rows[rowIndex].Cells[8].Value.ToString());
                cmbRequestUnit.Text = mr.Rows[rowIndex].Cells[9].Value.ToString();

            }
            else if(option == "Delete")
            {
                DialogResult result = Confirmation.ShowDialog($"Are you sure to delete request for: {(string.IsNullOrEmpty(mr.Rows[rowIndex].Cells[6].Value.ToString())?mr.Rows[rowIndex].Cells[3].Value.ToString(): $"{mr.Rows[rowIndex].Cells[3].Value.ToString()} {mr.Rows[rowIndex].Cells[6].Value.ToString()}" )} ?");
                if (result == DialogResult.Yes)
                {
                    var invAction = new InventoryMapper();
                    var inv_Id = new InventoryStockObject()
                    {
                        Inventory_Id = Int32.Parse(mr.Rows[rowIndex].Cells[0].Value.ToString())
                    };
                    invAction.Delete(inv_Id, "RD_Stock_DeleteById");
                    Alert_Dialog.ShowAlertMessage("Request has been removed successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(current_user_Id, $"Deleted Request for:[{(string.IsNullOrEmpty(mr.Rows[rowIndex].Cells[6].Value.ToString()) ? mr.Rows[rowIndex].Cells[3].Value.ToString() : $"{mr.Rows[rowIndex].Cells[3].Value.ToString()} {mr.Rows[rowIndex].Cells[6].Value.ToString()}")}]", "Inventory");
                    await LoadMRList();
                }
            }
        }

        private void datagridMR_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseClickContextProvider(sender, dgvMRContext, e);
        }

        private void btnPrintMR_Click(object sender, EventArgs e)
        {
            using(Printer fp = new Printer(this))
            {
                fp.setTitle("Material Request Slip");
                fp.SetMaterialRequestSlip(new rptMR());
                fp.ShowDialog();
            }
        }

        private void btnEditMR_Click(object sender, EventArgs e)
        {
            MRListOption(datagridMR, rowIndex, "Edit");
        }

        private void btnDeleteMR_Click(object sender, EventArgs e)
        {
            MRListOption(datagridMR, rowIndex, "Delete");
        }


        private void cmbRequestCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbRequestCategory.DataSource != null)
            {
                if (cmbRequestCategory.Text == "Goods")
                {
                    lblRequestFType.Visible = false;
                    cmbRequestFType.Visible = false;
                }
                else
                {
                    lblRequestFType.Visible = true;
                    cmbRequestFType.Visible = true;
                }
                LoadMRItems();
            }
        }

        private void LoadMRItems()
        {
            try
            {
                var itemAction = new ItemMapper();
                var category_Id = new ItemObject()
                {
                    Category_Id = Int32.Parse(cmbRequestCategory.SelectedValue.ToString())
                };
                var items = itemAction.dynamicsListWithParam(category_Id, "RD_Item_GetListByCategory");
                cmbRequestItem.DataSource = items;
                cmbRequestItem.DisplayMember = "Item_Name";
                cmbRequestItem.ValueMember = "Item_Id";
            }
            catch { }
        }
        private void txtRequestQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            var inprv = new InputRemoverAndValidation();
            inprv.numAndDotOnly(sender, e);
        }
        private void cmbRequestCategory_TextChanged(object sender, EventArgs e)
        {
            cmbRequestCategory.SelectedItem = cmbRequestCategory.Text;
        }

        private void cmbRequestItem_TextChanged(object sender, EventArgs e)
        {
            cmbRequestItem.SelectedItem = cmbRequestItem.Text;
        }

        private void cmbRequestFType_TextChanged(object sender, EventArgs e)
        {
            cmbRequestFType.SelectedItem = cmbRequestFType.Text;
        }

        private void cmbRequestUnit_TextChanged(object sender, EventArgs e)
        {
            cmbRequestUnit.SelectedItem = cmbRequestUnit.Text;
        }
        private void cmbRequestUnit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var uc = new UnitConverter();
            if (DefaultStockQty != 0 && !string.IsNullOrEmpty(Previous_Unit))
            {
                txtRequestQty.Text = uc.ConvertUnit(DefaultStockQty, Previous_Unit, cmbRequestUnit.Text).ToString();
            }
        }
        #endregion

        #region RECEIVING
        List<Validator> ReceiveValidator = new List<Validator>();
        List<ReceivedSlip> ReceivedDetails = new List<ReceivedSlip>();
        private void fillReceiveCombo()
        {
            var categoryAction = new CategoryMapper();
            var category = categoryAction.dynamicsList("RD_Category_GetList");
            cmbReceiveCategory.DataSource = category;
            cmbReceiveCategory.DisplayMember = "Category_Name";
            cmbReceiveCategory.ValueMember = "Category_Id";

            var ftypeAction = new FeedsTypeMapper();
            var ftypes = ftypeAction.dynamicsList("RD_FeedsType_GetList");
            cmbReceiveFType.DataSource = ftypes;
            cmbReceiveFType.DisplayMember = "FeedsType_Code";
            cmbReceiveFType.ValueMember = "FeedsType_Id";

            var supplierAction = new RelationshipMapper();
            var relationship = new RelationshipObject()
            {
                Relationship_Type = "Supplier"
            };
            var supplier = supplierAction.dynamicsListWithParam(relationship, "RD_Relationship_GetListByType");
            cmbReceiveSupplier.DataSource = supplier;
            cmbReceiveSupplier.DisplayMember = "Company_Name";
            cmbReceiveSupplier.ValueMember = "Person_Id";

            var unitAction = new UnitMapper();
            var units = unitAction.dynamicsList("RD_Unit_GetList");
            cmbReceiveUnit.DataSource = units;
            cmbReceiveUnit.DisplayMember = "Expression";
            cmbReceiveUnit.ValueMember = "Unit_Id";
        }

        private async Task LoadReceivedList()
        {
            try
            {
                var invAction = new InventoryMapper();
                var status = new InventoryStockObject()
                {
                    Status = labelCurrentUserRole.Text == "Encoder"? "Pending" : "Received"
                };

                await Task.Delay(1000);
                var stocks = invAction.dynamicsListWithParam(status, "RD_Stock_GetReceivedList");
                var dgvworker = new ListToDataTableWorker();
                var dt = new DataTable();
                dt = dgvworker.ConvertToDataTable(stocks);
                datagridReceive.AutoGenerateColumns = false;
                for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                {
                    datagridReceive.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                }
                datagridReceive.DataSource = dt;

                if (dt.Rows.Count == 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Pending request has been found.", Alert_Dialog.AlertType.INFO);
                }
                else if (dt.Rows.Count > 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Pending requests are found.", Alert_Dialog.AlertType.INFO);
                }
            }
            catch
            {
                Alert_Dialog.ShowAlertMessage("No records has been found.", Alert_Dialog.AlertType.WARNING);
                datagridReceive.DataSource = null;
            }
        }

        private async void btnRefreshReceive_Click(object sender, EventArgs e)
        {
            await LoadReceivedList();
        }

        private void btnSaveReceive_Click(object sender, EventArgs e)
        {
            validateReceivedEntry();
        }
        private async void validateReceivedEntry()
        {
            if (ReceiveValidator.Count((validator) => validator.IsValid()) == ReceiveValidator.Count)
            {
                try
                {
                    var invAction = new InventoryMapper();
                    var inv = new InventoryStockObject()
                    {
                        Inventory_Id = Selected_Id,
                        Reference_Number = txtReceiveRefNum.Text,
                        Supplier_Id = Int32.Parse(cmbReceiveSupplier.SelectedValue.ToString()),
                        Item_Id = Int32.Parse(cmbReceiveItem.SelectedValue.ToString()),
                        FType_Id = cmbReceiveFType.Visible == false ? default : Int32.Parse(cmbReceiveFType.SelectedValue.ToString()),
                        Quantity = Double.Parse(txtReceiveQty.Text.Replace(",", "")),
                        Unit_Id = Int32.Parse(cmbReceiveUnit.SelectedValue.ToString()),
                        Status = labelCurrentUserRole.Text == "Encoder" ? "Received" : "Available"
                    };
                    invAction.InsertOrUpdate(inv, "RD_Stock_InsertUpdateReceived");
                    Alert_Dialog.ShowAlertMessage($"Request has been confirmed successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(current_user_Id, $"{(Selected_Id == 0? "Created": "Updated")} Request for Item:[{cmbReceiveItem.Text}], Reference Number:[{txtReceiveRefNum.Text}], Item Type:[{(cmbReceiveFType.Visible == true? cmbReceiveFType.Text: "")}], Quantity:[{txtReceiveQty.Text}], Unit:[{cmbReceiveUnit.Text}], Supplier[{cmbReceiveSupplier.Text}]", "Inventory");
                    var received = new ReceivedSlip(txtReceiveRefNum.Text, cmbReceiveItem.Text, cmbReceiveCategory.Text, cmbReceiveFType.Text, txtReceiveQty.Text, cmbReceiveUnit.Text);
                    ReceivedDetails.Add(received);
                    btnCancelReceive_Click(null, null);
                    await LoadReceivedList();
                }
                catch {}
            }
        }

        private void btnCancelReceive_Click(object sender, EventArgs e)
        {
            panelReceivingEntry.Size = new Size(0, panelReceivingEntry.Size.Height);
            ReceiveValidator.ForEach(validator => validator.Reset());
            var inprv = new InputRemoverAndValidation();
            inprv.ClearText(panelReceivingEntry);
            Selected_Id = 0;
            Previous_Unit = "";
            DefaultStockQty = 0;
        }

        private void datagridReceive_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = datagridReceive.Columns[e.ColumnIndex].Name;
            if (column == "rv_Edit")
            {
                ReceivedListOption(datagridReceive, e.RowIndex, "Edit");
            }
            else if (column == "rv_Delete")
            {
                ReceivedListOption(datagridReceive, e.RowIndex, "Delete");
            }
        }

        private async void ReceivedListOption(DataGridView rv, int rowIndex, string option)
        {
            if (option == "Edit")
            {
                ReceiveValidator.Add(new Validator(txtReceiveRefNum, errReceiveRefNum, "reference number", "required"));
                ReceiveValidator.Add(new Validator(txtReceiveQty, errReceiveQty, "quantity", "required|nozero"));

                fillReceiveCombo();
                Selected_Id = Int32.Parse(rv.Rows[rowIndex].Cells[0].Value.ToString());
                txtReceiveRefNum.Text = rv.Rows[rowIndex].Cells[2].Value.ToString();
                cmbReceiveCategory.Text = rv.Rows[rowIndex].Cells[5].Value.ToString();
                cmbReceiveItem.Text = rv.Rows[rowIndex].Cells[4].Value.ToString();
                if (!string.IsNullOrEmpty(rv.Rows[rowIndex].Cells[6].Value.ToString())) { cmbReceiveFType.Text = rv.Rows[rowIndex].Cells[6].Value.ToString(); }
                if (!string.IsNullOrEmpty(rv.Rows[rowIndex].Cells[10].Value.ToString())) { cmbReceiveSupplier.Text = rv.Rows[rowIndex].Cells[10].Value.ToString(); }
                cmbReceiveUnit.Text = rv.Rows[rowIndex].Cells[8].Value.ToString();
                txtReceiveQty.Text = rv.Rows[rowIndex].Cells[7].Value.ToString();
                Previous_Unit = rv.Rows[rowIndex].Cells[8].Value.ToString();
                DefaultStockQty = Double.Parse(rv.Rows[rowIndex].Cells[7].Value.ToString());

                panelReceivingEntry.Size = new Size(350, panelReceivingEntry.Size.Height);

            }
            else if (option == "Delete")
            {
                DialogResult result = Confirmation.ShowDialog($"Are you sure to delete {(string.IsNullOrEmpty(rv.Rows[rowIndex].Cells[6].Value.ToString()) ? rv.Rows[rowIndex].Cells[3].Value.ToString() : $"{rv.Rows[rowIndex].Cells[3].Value.ToString()} {rv.Rows[rowIndex].Cells[6].Value.ToString()}")} request?");
                if (result == DialogResult.Yes)
                {
                    var invAction = new InventoryMapper();
                    var inv_Id = new InventoryStockObject()
                    {
                        Inventory_Id = Int32.Parse(rv.Rows[rowIndex].Cells[0].Value.ToString())
                    };
                    invAction.Delete(inv_Id, "RD_Stock_DeleteById");
                    Alert_Dialog.ShowAlertMessage("Request has been removed successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(current_user_Id, $"Deleted Request for {(string.IsNullOrEmpty(rv.Rows[rowIndex].Cells[6].Value.ToString()) ? rv.Rows[rowIndex].Cells[3].Value.ToString() : $"{rv.Rows[rowIndex].Cells[3].Value.ToString()} {rv.Rows[rowIndex].Cells[6].Value.ToString()}")}]", $"Inventory");
                    await LoadReceivedList();
                }
            }
        }

        private void datagridReceive_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseClickContextProvider(sender, dgvReceiveContext, e);
        }

        private void btnConfirmReceive_Click(object sender, EventArgs e)
        {
            ReceivedListOption(datagridReceive, rowIndex, "Edit");
        }

        private void btnDeleteReceive_Click(object sender, EventArgs e)
        {
            ReceivedListOption(datagridReceive, rowIndex, "Delete");
        }

        private void cmbReceiveCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbReceiveCategory.DataSource != null)
            {
                if (cmbReceiveCategory.Text == "Goods")
                {
                    lblReceiveFType.Visible = false;
                    cmbReceiveFType.Visible = false;
                }
                else
                {
                    lblReceiveFType.Visible = true;
                    cmbReceiveFType.Visible = true;
                }
                LoadReceiveItems();
            }
        }
        private void LoadReceiveItems()
        {
            try
            {
                var itemAction = new ItemMapper();
                var category_Id = new ItemObject()
                {
                    Category_Id = Int32.Parse(cmbReceiveCategory.SelectedValue.ToString())
                };
                var items = itemAction.dynamicsListWithParam(category_Id, "RD_Item_GetListByCategory");
                cmbReceiveItem.DataSource = items;
                cmbReceiveItem.DisplayMember = "Item_Name";
                cmbReceiveItem.ValueMember = "Item_Id";
            }
            catch { }
        }

        private void cmbReceiveUnit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var uc = new UnitConverter();
            if (DefaultStockQty != 0 && !string.IsNullOrEmpty(Previous_Unit))
            {
                txtReceiveQty.Text = uc.ConvertUnit(DefaultStockQty, Previous_Unit, cmbReceiveUnit.Text).ToString();
            }
        }
        private void cmbReceiveSupplier_TextChanged(object sender, EventArgs e)
        {
            cmbReceiveSupplier.SelectedItem = cmbReceiveSupplier.Text;
        }

        private void cmbReceiveCategory_TextChanged(object sender, EventArgs e)
        {
            cmbReceiveCategory.SelectedItem = cmbReceiveCategory.Text;
        }

        private void cmbReceiveItem_TextChanged(object sender, EventArgs e)
        {
            cmbReceiveItem.SelectedItem = cmbReceiveItem.Text;
        }

        private void cmbReceiveFType_TextChanged(object sender, EventArgs e)
        {
            cmbReceiveFType.SelectedItem = cmbReceiveFType.Text;
        }

        private void cmbReceiveUnit_TextChanged(object sender, EventArgs e)
        {
            cmbReceiveUnit.SelectedItem = cmbReceiveUnit.Text;
        }
        private void btnPrintReceive_Click(object sender, EventArgs e)
        {
            using (Printer fp = new Printer(this))
            {
                fp.setTitle("Receiving Slip");
                fp.SetReceivedSlip(new rptReceiveSlip(), ReceivedDetails, 700);
                fp.ShowDialog();
            }
        }
        #endregion

        #region AVAILABLE

        private void fillStockCategory()
        {
            var categoryAction = new CategoryMapper();
            var category = categoryAction.dynamicsList("RD_Category_GetList");
            cmbStockCategory.DataSource = category;
            cmbStockCategory.DisplayMember = "Category_Name";
            cmbStockCategory.ValueMember = "Category_Id";
        }

        private async void btnRefreshAvailable_Click(object sender, EventArgs e)
        {
            await LoadAvailableList();
        }

        public async Task LoadAvailableList()
        {
            try
            {
                var invAction = new InventoryMapper();
                var category = new InventoryStockObject()
                {
                    Status = cmbStockCategory.Text
                };

                await Task.Delay(1000);

                    var stock = invAction.dynamicsListWithParam(category, "RD_Stock_GetAvailableListByCategory");
                    var dgvworker = new ListToDataTableWorker();
                    var dt = new DataTable();
                    dt = dgvworker.ConvertToDataTable(stock);
                    datagridAvailable.AutoGenerateColumns = false;
                    for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                    {
                        datagridAvailable.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                    }
                    datagridAvailable.DataSource = dt;

                    if (dt.Rows.Count == 1)
                    {
                        Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Available {cmbStockCategory.Text} stock has been found.", Alert_Dialog.AlertType.INFO);
                    }
                    else if (dt.Rows.Count > 1)
                    {
                        Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Available {cmbStockCategory.Text} stocks are found.", Alert_Dialog.AlertType.INFO);
                    }
                
            }
            catch
            {
                Alert_Dialog.ShowAlertMessage("No request record has been found.", Alert_Dialog.AlertType.WARNING);
                datagridAvailable.DataSource = null;
            }
        }

        private void datagridAvailable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = datagridAvailable.Columns[e.ColumnIndex].Name;
            if (column == "av_Manage")
            {
                AvailableListOption(datagridAvailable, e.RowIndex, "Edit");
            }
        }

        private async void AvailableListOption(DataGridView av, int rowIndex, string option)
        {
            if(option == "Edit")
            {
                using(Stock_Management sm = new Stock_Management(this))
                {
                    
                    sm.TransactionType(cmbStockCategory.Text);
                    sm.fillCombo();

                    sm.Stock_Id = Int32.Parse(av.Rows[rowIndex].Cells[0].Value.ToString());
                    sm.txtRefNum.Text = av.Rows[rowIndex].Cells[2].Value.ToString();
                    sm.cmbItem.Text = av.Rows[rowIndex].Cells[4].Value.ToString();
                    sm.txtQty.Text = av.Rows[rowIndex].Cells[5].Value.ToString();
                    sm.DefaultQty = Double.Parse(av.Rows[rowIndex].Cells[5].Value.ToString());
                    sm.txtRestock.Text = av.Rows[rowIndex].Cells[6].Value.ToString();
                    sm.cmbUnit.Text = av.Rows[rowIndex].Cells[7].Value.ToString();
                    sm.Previous_Unit = av.Rows[rowIndex].Cells[7].Value.ToString();
                    sm.cmbCategory.Text = av.Rows[rowIndex].Cells[8].Value.ToString();
                    sm.cmbFType.Text = av.Rows[rowIndex].Cells[9].Value.ToString();
                    sm.cmbSupplier.Text = av.Rows[rowIndex].Cells[11].Value.ToString();

                    sm.ShowDialog(this);

                }

            }
            else if (option == "Delete")
            {
                DialogResult result = Confirmation.ShowDialog($"Are you sure to delete {av.Rows[rowIndex].Cells[3].Value.ToString()} {av.Rows[rowIndex].Cells[4].Value.ToString()} stock?");
                if (result == DialogResult.Yes)
                {
                    var invAction = new InventoryMapper();
                    var inv_Id = new InventoryStockObject()
                    {
                        Inventory_Id = Int32.Parse(av.Rows[rowIndex].Cells[0].Value.ToString())
                    };
                    invAction.Delete(inv_Id, "RD_Stock_DeleteById");
                    Alert_Dialog.ShowAlertMessage("Stock has been removed successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(current_user_Id, $"Deleted {av.Rows[rowIndex].Cells[3].Value.ToString()} {av.Rows[rowIndex].Cells[4].Value.ToString()} stock.", "Inventory");
                    await LoadAvailableList();
                }
            }
            else if(option == "Request")
            {
                DialogResult result = Confirmation.ShowDialog($"Create Material Request for {(string.IsNullOrEmpty(av.Rows[rowIndex].Cells[9].Value.ToString())? $"{av.Rows[rowIndex].Cells[4].Value.ToString()}": $"{av.Rows[rowIndex].Cells[4].Value.ToString()} {av.Rows[rowIndex].Cells[9].Value.ToString()}" )} ?");
                if(result == DialogResult.Yes)
                {
                    btnCreateMR_Click(null, null);

                    cmbRequestCategory.Text = av.Rows[rowIndex].Cells[8].Value.ToString();
                    cmbRequestItem.Text = av.Rows[rowIndex].Cells[4].Value.ToString();
                    txtRequestQty.Text = av.Rows[rowIndex].Cells[5].Value.ToString();
                    if (!string.IsNullOrEmpty(av.Rows[rowIndex].Cells[9].Value.ToString())) { cmbRequestFType.Text = av.Rows[rowIndex].Cells[9].Value.ToString(); }
                    cmbRequestUnit.Text = av.Rows[rowIndex].Cells[7].Value.ToString();

                    tabInventory.SelectedTab = pgMaterialRequest;

                }
            }


        }

        private void datagridAvailable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseClickContextProvider(sender, dgvAvailableContext, e);
        }
        private void btnAvailableReport_Click(object sender, EventArgs e)
        {
            tabHomepage.SelectedTab = pgMaintenance;
            tabMaintenance.SelectedTab = pgReports;
            txtSearchInvReport.Text = cmbStockCategory.Text;
            cmbInvReport.SelectedItem = "Available";
            btnLoadInvReport_Click(null, null);
        }
        private void btnManageAvailable_Click(object sender, EventArgs e)
        {
            AvailableListOption(datagridAvailable, rowIndex, "Edit");
        }
        private void btnRequestAvailable_Click(object sender, EventArgs e)
        {
            AvailableListOption(datagridAvailable, rowIndex, "Request");
        }
        private async void cmbStockCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbStockCategory.DataSource != null)
            {
                await LoadAvailableList();
            }
        }
        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            AvailableListOption(datagridAvailable, rowIndex, "Delete");
        }

        #endregion

        #region CRITICAL

        private async void btnRefreshCrit_Click(object sender, EventArgs e)
        {
            await LoadCriticalList();
        }
        public async Task LoadCriticalList()
        {
            try
            {
                var invAction = new InventoryMapper();
                await Task.Delay(1000);
                var stock = invAction.dynamicsList("RD_Stock_GetCriticalList");
                var dgvworker = new ListToDataTableWorker();
                var dt = new DataTable();
                dt = dgvworker.ConvertToDataTable(stock);
                datagridCrit.AutoGenerateColumns = false;
                for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                {
                    datagridCrit.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                }
                datagridCrit.DataSource = dt;

                if (dt.Rows.Count == 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Critical stock has been found.", Alert_Dialog.AlertType.INFO);
                }
                else if (dt.Rows.Count > 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Critical stocks are found.", Alert_Dialog.AlertType.INFO);
                }

            }
            catch
            {
                Alert_Dialog.ShowAlertMessage("No critical stock has been found.", Alert_Dialog.AlertType.WARNING);
                datagridCrit.DataSource = null;
            }
        }
        private void datagridCrit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = datagridCrit.Columns[e.ColumnIndex].Name;
            if (column == "cr_Request")
            {
                CriticalListOption(datagridCrit, e.RowIndex, "Request");
            }
        }
        private async void CriticalListOption(DataGridView cr, int rowIndex, string option)
        {
            if(option == "Request")
            {
                DialogResult result = Confirmation.ShowDialog($"Create Material Request for {(string.IsNullOrEmpty(cr.Rows[rowIndex].Cells[9].Value.ToString()) ? $"{cr.Rows[rowIndex].Cells[4].Value.ToString()}" : $"{cr.Rows[rowIndex].Cells[4].Value.ToString()} {cr.Rows[rowIndex].Cells[9].Value.ToString()}")} ?");
                if (result == DialogResult.Yes)
                {
                    btnCreateMR_Click(null, null);

                    cmbRequestCategory.Text = cr.Rows[rowIndex].Cells[8].Value.ToString();
                    cmbRequestItem.Text = cr.Rows[rowIndex].Cells[4].Value.ToString();
                    txtRequestQty.Text = cr.Rows[rowIndex].Cells[5].Value.ToString();
                    if (!string.IsNullOrEmpty(cr.Rows[rowIndex].Cells[9].Value.ToString())) { cmbRequestFType.Text = cr.Rows[rowIndex].Cells[9].Value.ToString(); }
                    cmbRequestUnit.Text = cr.Rows[rowIndex].Cells[7].Value.ToString();

                    tabInventory.SelectedTab = pgMaterialRequest;

                }
            }
            else if(option == "Delete")
            {
                DialogResult result = Confirmation.ShowDialog($"Are you sure to delete {cr.Rows[rowIndex].Cells[3].Value.ToString()} {cr.Rows[rowIndex].Cells[4].Value.ToString()} stock?");
                if (result == DialogResult.Yes)
                {
                    var invAction = new InventoryMapper();
                    var inv_Id = new InventoryStockObject()
                    {
                        Inventory_Id = Int32.Parse(cr.Rows[rowIndex].Cells[0].Value.ToString())
                    };
                    invAction.Delete(inv_Id, "RD_Stock_DeleteById");
                    Alert_Dialog.ShowAlertMessage("Stock has been removed successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(current_user_Id, $"Deleted {cr.Rows[rowIndex].Cells[3].Value.ToString()} {cr.Rows[rowIndex].Cells[4].Value.ToString()} from critical list. ", "Imventory");
                    SetNotification();
                    await LoadCriticalList();
                }
            }

        }

        private void datagridCrit_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseClickContextProvider(sender, dgvCritContext, e);
        }
        private void SetNotification()
        {
            try
            {
                var stockAction = new InventoryMapper();
                var result = stockAction.dynamicsList("RD_Stock_GetCriticalList");
                var dt = new DataTable();
                var dgvworker = new ListToDataTableWorker();
                dt = dgvworker.ConvertToDataTable(result);
                panelNotification.Controls.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var notif = new Critical_Notification();
                    notif.lblRefNum.Text = $"Reference No.: {dt.Rows[i][2].ToString()}";
                    notif.lblItemName.Text = $"Item : {dt.Rows[i][4].ToString()} {(string.IsNullOrEmpty(dt.Rows[i][9].ToString())?"": dt.Rows[i][9].ToString())}";
                    notif.lblQty.Text = $"Quantity Left : {dt.Rows[i][5].ToString()}";

                    panelNotification.Controls.Add(notif);
                    notif.Dock = DockStyle.Top;
                    panelNotification.Padding = new Padding(5);
                }
                btnNotif.Image = Resources._notification;
                if (dt.Rows.Count == 1)
                {
                    Alert_Dialog.ShowAlertMessage($"There is {dt.Rows.Count} stock below restocking level.", Alert_Dialog.AlertType.WARNING);
                }
                else if (dt.Rows.Count > 1)
                {
                    Alert_Dialog.ShowAlertMessage($"There are {dt.Rows.Count} stock below restocking level.", Alert_Dialog.AlertType.WARNING);
                }

            }
            catch
            {
                Alert_Dialog.ShowAlertMessage($"There are no stock below restocking level.", Alert_Dialog.AlertType.INFO);
                btnNotif.Image = Resources.notification;
            }
        }
        private void btnCritReq_Click(object sender, EventArgs e)
        {
            CriticalListOption(datagridCrit, rowIndex, "Request");
        }

        private void btnCritDelete_Click(object sender, EventArgs e)
        {
            CriticalListOption(datagridCrit, rowIndex, "Delete");
        }
        #endregion

        #region WITHDRAW
        private void fillWCategory()
        {
            var categoryAction = new CategoryMapper();
            var category = categoryAction.dynamicsList("RD_Category_GetList");
            cmbWithdrawCategory.DataSource = category;
            cmbWithdrawCategory.DisplayMember = "Category_Name";
            cmbStockCategory.ValueMember = "Category_Id";
        }
        private async void btnRefreshWithdraw_Click(object sender, EventArgs e)
        {
            await LoadAvailableWithdrawList();
        }
        public async Task LoadAvailableWithdrawList()
        {
            try
            {
                var invAction = new InventoryMapper();
                var category = new InventoryStockObject()
                {
                    Status = cmbWithdrawCategory.Text
                };

                await Task.Delay(1000);

                var stock = invAction.dynamicsListWithParam(category, "RD_Stock_GetAvailableListByCategory");
                var dgvworker = new ListToDataTableWorker();
                var dt = new DataTable();
                dt = dgvworker.ConvertToDataTable(stock);
                datagridWithdraw.AutoGenerateColumns = false;
                for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                {
                    datagridWithdraw.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                }
                datagridWithdraw.DataSource = dt;

                if (dt.Rows.Count == 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Available {cmbWithdrawCategory.Text} stock has been found.", Alert_Dialog.AlertType.INFO);
                }
                else if (dt.Rows.Count > 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Available {cmbWithdrawCategory.Text} stocks are found.", Alert_Dialog.AlertType.INFO);
                }

            }
            catch
            {
                Alert_Dialog.ShowAlertMessage("No request record has been found.", Alert_Dialog.AlertType.WARNING);
                datagridWithdraw.DataSource = null;
            }
        }

        private void datagridWithdraw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = datagridWithdraw.Columns[e.ColumnIndex].Name;
            if (column == "w_Select")
            {
                WithdrawListOption(datagridWithdraw, e.RowIndex, "Withdraw");
            }
        }
        private async void WithdrawListOption(DataGridView w, int rowIndex, string option)
        {
            if(option == "Withdraw")
            {
                using(Withdrawal wform = new Withdrawal(this))
                {
                    wform.TransactionType(cmbWithdrawCategory.Text);

                    wform.Stock_Id = Int32.Parse(w.Rows[rowIndex].Cells[0].Value.ToString());
                    wform.labelItem.Text = w.Rows[rowIndex].Cells[4].Value.ToString();
                    wform.labelQty.Text = w.Rows[rowIndex].Cells[5].Value.ToString();
                    wform.AvailableQty = Double.Parse(w.Rows[rowIndex].Cells[5].Value.ToString());
                    wform.labelUnits.Text = w.Rows[rowIndex].Cells[7].Value.ToString();
                    wform.labelType.Text = string.IsNullOrEmpty(w.Rows[rowIndex].Cells[9].Value.ToString())? "None": w.Rows[rowIndex].Cells[9].Value.ToString();
                    wform.Category = w.Rows[rowIndex].Cells[8].Value.ToString();
                    wform.ShowDialog();
                }
            }
            else if (option == "Delete")
            {
                DialogResult result = Confirmation.ShowDialog($"Are you sure to delete {w.Rows[rowIndex].Cells[3].Value.ToString()} {w.Rows[rowIndex].Cells[4].Value.ToString()} stock?");
                if (result == DialogResult.Yes)
                {
                    var invAction = new InventoryMapper();
                    var inv_Id = new InventoryStockObject()
                    {
                        Inventory_Id = Int32.Parse(w.Rows[rowIndex].Cells[0].Value.ToString())
                    };
                    invAction.Delete(inv_Id, "RD_Stock_DeleteById");
                    Alert_Dialog.ShowAlertMessage("Stock has been removed successfully.", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(current_user_Id, $"Deleted {w.Rows[rowIndex].Cells[3].Value.ToString()} {w.Rows[rowIndex].Cells[4].Value.ToString()} stock", "Inventory");
                    await LoadAvailableWithdrawList();
                }
            }
        }

        private void datagridWithdraw_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseClickContextProvider(sender, dgvWithdrawContext, e);
        }
        public List<WithdrawSlip> WdrawDetails = new List<WithdrawSlip>();
        private void btnPrintWithdrawal_Click(object sender, EventArgs e)
        {
            using(Printer fp = new Printer(this))
            {
                fp.setTitle("Withdrawal Slip");
                fp.SetWithdrawalSlip(new rptWithdrawSlip(), WdrawDetails, 500);
                fp.ShowDialog();
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawListOption(datagridWithdraw, rowIndex, "Withdraw");
        }

        private void btnDeleteWdraw_Click(object sender, EventArgs e)
        {
            WithdrawListOption(datagridWithdraw, rowIndex, "Delete");
        }

        private async void cmbWithdrawCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbWithdrawCategory.DataSource != null)
            {
                await LoadAvailableWithdrawList();
            }
        }
        private void btnWithdrawalHistory_Click(object sender, EventArgs e)
        {
            using (Withdrawal_History fwh = new Withdrawal_History(this))
            {
                fwh.ShowDialog();
            }
        }
        #endregion

        #region SALES
        public long DefaultHarvQty { get; set; }
        public string Order_Status { get; set; }
        public int Order_PId { get; set; }
        List<Validator> OrderValidator = new List<Validator>();
        private void fillSalesCombo()
        {
            try
            {
                var relationshipAction = new RelationshipMapper();
                var relationshipType = new RelationshipObject()
                {
                    Relationship_Type = "Customer"
                };
                var customers = relationshipAction.dynamicsListWithParam(relationshipType, "RD_Relationship_GetListByType");
                cmbSalesCustomer.DataSource = customers;
                cmbSalesCustomer.DisplayMember = "Company_Name";
                cmbSalesCustomer.ValueMember = "Person_Id";
                cmbSalesCustomer.SelectedItem = null;

                var prodAction = new ProductionMapper();
                var farmName = new ProductionObject()
                {
                    Farm_Name = GetCurrentFarmName()
                };
                var ponds = prodAction.dynamicsListWithParam(farmName, "RD_Production_GetHarvestedList");
                cmbSalesProduction.DataSource = ponds;
                cmbSalesProduction.DisplayMember = "Pond_Code";
                cmbSalesProduction.ValueMember = "Production_Id";
                cmbSalesProduction.SelectedItem = null;
                

                var priceAction = new PriceMapper();
                var price = priceAction.dynamicsList("RD_Price_GetList");
                cmbSalesPrice.DataSource = price;
                cmbSalesPrice.DisplayMember = "Price_Code";
                cmbSalesPrice.ValueMember = "Price_Value";

            }
            catch { }
        }
        private void btnNewSales_Click(object sender, EventArgs e)
        {
            fillSalesCombo();

            panelSalesEntry.Size = new Size(350, panelSalesEntry.Size.Height);
            GetLastOrderSlipNo();

            OrderValidator.Add(new Validator(txtSalesOS, errSalesOs, "order slip", "required|min:5")); 
            OrderValidator.Add(new Validator(txtSalesQty, errSalesQty, "order quantity", "required|nozero"));

        }

        private void btnCancelSales_Click(object sender, EventArgs e)
        {
            OrderValidator.ForEach(validator => validator.Reset());
            panelSalesEntry.Size = new Size(0, panelSalesEntry.Size.Height);
            Selected_Id = 0;
            lblSalesHQty.Text = string.Empty;
            new InputRemoverAndValidation().ClearText(panelSalesEntry);
        }
        private async void btnRefreshOrders_Click(object sender, EventArgs e)
        {
            await LoadOrderList(datagridPending, "Pending", 1000);
            await LoadOrderList(datagridFinished, "Finished", 2000);
        }
        private async Task LoadOrderList(DataGridView dgv, string status, int wait_val)
        {
            try
            {
                var orderAction = new SalesAndOrderMapper();
                var search = new SalesAndOrdersObject()
                {
                    Search = txtSearchOrders.Text,
                    Order_Status = status
                };

                await Task.Delay(wait_val);

                var orders = orderAction.dynamicsListWithParam(search, "RD_Order_GetOrderList");
                var dgvworker = new ListToDataTableWorker();
                var dt = new DataTable();
                dt = dgvworker.ConvertToDataTable(orders);
                dgv.AutoGenerateColumns = false;
                for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                {
                   dgv.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                }
                dgv.DataSource = dt;

                if (dt.Rows.Count == 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} {status} Order has been found.", Alert_Dialog.AlertType.INFO);
                }
                else if (dt.Rows.Count > 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} {status} Orders are found.", Alert_Dialog.AlertType.INFO);
                }

            }
            catch
            {
                Alert_Dialog.ShowAlertMessage($"No {status} order has been found.", Alert_Dialog.AlertType.WARNING);
                dgv.DataSource = null;
            }
        }

        private void datagridOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = (sender as DataGridView).Columns[e.ColumnIndex].Name;
            if (column == "pn_Edit")
            {
                OrderListOption((sender as DataGridView), e.RowIndex, "Edit");
            }
            else if(column == "pn_Delete")
            {
                OrderListOption((sender as DataGridView), e.RowIndex, "Delete");
            }
            else if (column == "fn_Edit")
            {
                OrderListOption((sender as DataGridView), e.RowIndex, "Edit");
            }
            else if (column == "fn_Delete")
            {
                OrderListOption((sender as DataGridView), e.RowIndex, "Delete");
            }
        }
        private void OrderListOption(DataGridView ord, int rowIndex, string option)
        {
            if (option == "Edit")
            {
                btnNewSales_Click(null, null);

                Selected_Id = Int32.Parse(ord.Rows[rowIndex].Cells[0].Value.ToString());
                Order_PId = Int32.Parse(ord.Rows[rowIndex].Cells[1].Value.ToString());
                cmbSalesProduction.Text = ord.Rows[rowIndex].Cells[5].Value.ToString();
                txtSalesOS.Text = ord.Rows[rowIndex].Cells[3].Value.ToString();
                cmbSalesCustomer.Text = ord.Rows[rowIndex].Cells[6].Value.ToString();
                txtSalesQty.Text = ord.Rows[rowIndex].Cells[7].Value.ToString();
                cmbSalesPrice.SelectedItem = ord.Rows[rowIndex].Cells[9].Value.ToString();
                dtpSales.Value = Convert.ToDateTime(ord.Rows[rowIndex].Cells[11].Value.ToString());

            }
            else if (option == "Delete")
            {
                DialogResult result = Confirmation.ShowDialog($"Are you sure to delete OS#{ord.Rows[rowIndex].Cells[3].Value.ToString()} order?");
                if (result == DialogResult.Yes)
                {
                    var ordAction = new SalesAndOrderMapper();
                    var ord_Id = new SalesAndOrdersObject()
                    {
                        Order_Id = Int32.Parse(ord.Rows[rowIndex].Cells[0].Value.ToString())
                    };
                    ordAction.Delete(ord_Id, "RD_Order_DeleteById");
                    Alert_Dialog.ShowAlertMessage("Order has been removed successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(current_user_Id, $"Deleted Order No.[{ord.Rows[rowIndex].Cells[2].Value.ToString()}] order.", "Sales");
                    btnRefreshOrders_Click(null, null);
                }
            }

        }
        private void btnSaveSales_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSalesQty.Text))
            {
                if (Int64.Parse(txtSalesQty.Text) > DefaultHarvQty)
                {
                    Alert_Dialog.ShowAlertMessage("Order amount must be less or Equal to harvested amount.", Alert_Dialog.AlertType.WARNING);
                }
                else
                {
                    var OSDetails = new OrderSlip(cmbSalesCustomer.Text, GetCustomerAddress(), txtSalesQty.Text, "Kg/s", lblSalesABW.Text, String.Format("{0:n}", (Double.Parse(txtSalesQty.Text) * Double.Parse(cmbSalesPrice.SelectedValue.ToString()))), txtSalesOS.Text, cmbSalesPrice.SelectedValue.ToString());
                    GetSlipDetails.Add(OSDetails);
                    PrintOrderSlip(Selected_Id, Int64.Parse(txtSalesQty.Text));
                }
            }
        }
        public List<OrderSlip> GetSlipDetails = new List<OrderSlip>();
        public void validateSalesEntry(string status)
        {
            if (OrderValidator.Count((validator) => validator.IsValid()) == OrderValidator.Count)
            {
                var orderAction = new SalesAndOrderMapper();
                var order = new SalesAndOrdersObject()
                {
                    Order_Id = Selected_Id == 0 ? default : Selected_Id,
                    Order_Qty = Int64.Parse(txtSalesQty.Text),
                    Order_Slip_Number = Int64.Parse(txtSalesOS.Text),
                    Order_Status = status,
                    Price_Code = cmbSalesPrice.Text,
                    Production_Id = Selected_Id == 0 ? Int32.Parse(cmbSalesProduction.SelectedValue.ToString()): Order_PId,
                    Entry_Date = Convert.ToDateTime(dtpSales.Value.ToString("yyyy-MM-dd")),
                    Customer_Id = Int32.Parse(cmbSalesCustomer.SelectedValue.ToString()),
                    Order_Remarks = Selected_Id == 0 ? null : $"Updated On {DateTime.Now} by {labelCurrentUserName.Text}"
                };
                orderAction.InsertOrUpdate(order, "RD_Order_InsertUpdateOrders");
                //Alert_Dialog.ShowAlertMessage($"Order has been created successfully", Alert_Dialog.AlertType.SUCCESS);
                new AuditTrailMapper().InsertActivity(current_user_Id, $"{(Selected_Id == 0? "Created": "Updated")} Order No.[{txtSalesOS.Text}] from [{cmbSalesProduction.Text}], Quantity[{txtSalesQty.Text}], Price[{cmbSalesPrice.SelectedValue.ToString()}], Total[{ String.Format("{0:n0}", Double.Parse(txtSalesQty.Text) * Double.Parse(cmbSalesPrice.SelectedValue.ToString()))}]", "Sales");
                GetSlipDetails.Clear();
                btnCancelSales_Click(null, null);
                btnRefreshOrders_Click(null, null);
            }
        }
        private string GetCustomerAddress()
        {
            return new QueryWorker().returnScalarText($"SELECT Address FROM rd_saims.tbl_company WHERE Company_Name = '{cmbSalesCustomer.Text}' LIMIT 1");
        }
        private void datagridOrders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if((sender as DataGridView) == datagridFinished)
            {
                btnEditOrder.Visible = false;
            }
            else
            {
                btnEditOrder.Visible = true;
            }
            MouseClickContextProvider(sender, dgvOrderContext, e);
            
        }

        private void GetLastOrderSlipNo()
        {
            long LastOrderSlipNumber = 30000;
            var os = new QueryWorker().returnScalarText($"SELECT (CASE WHEN Order_Slip_Number IS NULL THEN 0 WHEN Order_Slip_Number IS NOT NULL THEN Order_Slip_Number + 1 END) AS Order_Slip_Number FROM rd_saims.tbl_orders Order By Order_Id DESC LIMIT 1; ");
            if (!string.IsNullOrEmpty(os)) { LastOrderSlipNumber = Convert.ToInt64(os); }
            if(LastOrderSlipNumber != 0)
            {
                txtSalesOS.Text = Convert.ToString(LastOrderSlipNumber);
            }
            else
            {
                txtSalesOS.Text = Convert.ToString(LastOrderSlipNumber);
            }
           
        }
        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            OrderListOption(Selected_DGV, rowIndex, "Edit");
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            OrderListOption(Selected_DGV, rowIndex, "Delete");
        }
        private async void cmbSalesPrice_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSalesQty.Text))
            {
                await GetTotalSales(Double.Parse(txtSalesQty.Text), Double.Parse(cmbSalesPrice.SelectedValue.ToString()));
            }
        }
        private async Task GetTotalSales(Double qty, double price)
        {
            lblSalesHQty.Text = String.Format("{0:n0}", (qty - DefaultHarvQty)).Replace("-","");
            lblTotalSales.Text = "Calculating ...";
            await Task.Delay(500);
            lblTotalSales.Text = String.Format("₱ {0:n0}", (qty * price));
            if (string.IsNullOrEmpty(txtSalesQty.Text)) { lblTotalSales.Text = "₱ 000,000,000.00"; lblSalesHQty.Text = DefaultHarvQty.ToString(); }
        }

        private void txtSalesQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            new InputRemoverAndValidation().numOnly(sender, e);
        }

        private void txtSalesQty_TextChanged(object sender, EventArgs e)
        {
            txtSalesQty_Validated(sender, e);
        }

        private async void txtSalesQty_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Guna2TextBox).Text))
            {
                lblTotalSales.Text = "₱ 000,000,000.00";
                lblSalesHQty.Text = String.Format("{0:n}", DefaultHarvQty.ToString());
            }
            else
            {
                await GetTotalSales(Double.Parse(txtSalesQty.Text), Double.Parse(cmbSalesPrice.SelectedValue.ToString()));

            }
        }
        private void cmbSalesProduction_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetHarvestDetails();
        }
        private void GetHarvestDetails()
        {
            var prodAction = new ProductionMapper();
            var prod = new ProductionObject()
            {
                Entry_Status = cmbSalesProduction.Text
            };
            var harv = prodAction.dynamicsListWithParam(prod, "RD_Production_GetHarvestForSales");
            var dt = new ListToDataTableWorker().ConvertToDataTable(harv);
            lblSalesHQty.Text = dt.Rows[0][2].ToString();
            lblSalesABW.Text = dt.Rows[0][3].ToString();
            lblpcskg.Text = dt.Rows[0][4].ToString();
            DefaultHarvQty = Int64.Parse(dt.Rows[0][2].ToString().Replace(",", ""));
        }
        private void cmbSalesPrice_TextChanged(object sender, EventArgs e)
        {
            cmbSalesPrice.SelectedItem = cmbSalesPrice.Text;
        }
        private void cmbSalesCustomer_TextChanged(object sender, EventArgs e)
        {
            cmbSalesCustomer.SelectedItem = cmbSalesCustomer.Text;
        }
        private void PrintOrderSlip(int order_id, long order_qty)
        {
            using(Invoice_Printer fp = new Invoice_Printer(this))
            {
                fp.invoice = new Order_Slip();
                fp.Order_Id = order_id;
                fp.Order_Qty = order_qty;
                if(txtSalesQty.Enabled == false) { fp.rbtnNo.Enabled = false; }
                fp.GetSlipDetails = GetSlipDetails;
                fp._width = 500;
                fp.rbtnYes_CheckedChanged(fp.rbtnYes, null);
                fp.ShowDialog();
            }
        }
        private void cmbSalesCustomer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbSalesCustomer.Text))
            {
                GetCustomerType();
            }
        }
        private void GetCustomerType()
        {
            var buyerType = new QueryWorker().returnScalarText($"SELECT r.Buyer_Status FROM rd_saims.tbl_relationship AS r LEFT JOIN tbl_Company AS c ON r.Company_Id = c.Company_Id WHERE c.Company_Name = '{cmbSalesCustomer.Text}' LIMIT 1");
            if (cmbSalesProduction.SelectedItem == null)
            {
                Alert_Dialog.ShowAlertMessage("Please select pond for sales first", Alert_Dialog.AlertType.INFO);
                cmbSalesCustomer.SelectedItem = null;

            }
            else
            {
                if (buyerType == "Big")
                {
                    txtSalesQty.Text = DefaultHarvQty.ToString();
                    txtSalesQty.Enabled = false;
                    lblSalesCustomerType.Text = "Big Buyer Details";
                }
                else
                {
                    txtSalesQty.Text = string.Empty;
                    txtSalesQty.Enabled = true;
                    lblSalesCustomerType.Text = "Small Buyer Details";
                }
            }
        }
       #endregion

        #region EXPENSE

        private void FillExpenseType()
        {
            var expenseTypeAction = new ExpenseTypeMapper();
            var expType = expenseTypeAction.dynamicsList("RD_ExpenseType_GetList");
            cmbExpenseType.DataSource = expType;
            cmbExpenseType.DisplayMember = "ExpenseType_Title";
            cmbExpenseType.ValueMember = "ExpenseType_Id";
        }
        public int Expense_Id { get; set; }

        List<Validator> ExpenseValidator = new List<Validator>();
        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            panelExpenseEntry.Size = new Size(350, panelExpenseEntry.Size.Height);
            ExpenseValidator.Add(new Validator(txtExpenseOR, errExpenseOR, "official receipt number", "required"));
            ExpenseValidator.Add(new Validator(txtExpenseAmount, errExpenseAmount, "expense amount", "required"));
            ExpenseValidator.Add(new Validator(txtExpenseNote, errExpenseNote, "expense note", "max:99"));
        }

        private async void btnImportExpense_Click(object sender, EventArgs e)
        {
            await ImportFromExcel();
        }
        
        private async Task ImportFromExcel()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
            string file = @"";
            var excelOpener = new ResourceManager();
            try
            {
                await Task.Delay(1000);
                FileInfo excel = new FileInfo(excelOpener.ExcelFileOpener("(*.xlsx;) | *.xlsx; ", file));

                using (var package = new ExcelPackage(excel))
                {
                    var wb = package.Workbook;
                    var ws = wb.Worksheets.First();
                    int tr = ws.Dimension.End.Row;
                    try
                    {

                        for (int i = 1; i <= tr; i++)
                        {
                            cmbExpenseType.Text = ws.Cells[i, 3].Text.ToString();
                            var expenseAction = new ExpensesMapper();
                            var importDate = new ExpensesObject() 
                            {
                            Expense_Id = default,
                            OR_Number = ws.Cells[i, 1].Text.ToString(),
                            Amount = Double.Parse(ws.Cells[i, 2].Text.ToString()),
                            ExpenseType_Id = Int32.Parse(cmbExpenseType.SelectedValue.ToString()),
                            Entry_Date = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),
                            Expense_Note = string.IsNullOrEmpty(ws.Cells[i, 4].Text.ToString()) ? "No expense note" : ws.Cells[i, 4].Text.ToString()
                            };

                            expenseAction.InsertOrUpdate(importDate, "RD_Expense_InsertUpdate");
                        }
                        Alert_Dialog.ShowAlertMessage("Expenses has been imported successfully", Alert_Dialog.AlertType.SUCCESS);
                        new AuditTrailMapper().InsertActivity(current_user_Id, $"Imported {tr} total expenses record form excel.", "Expenses");
                        await LoadExpensesChart();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("No file has been selected", "Expense Import", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (FormatException)
            {
                MessageBox.Show("Rows and Columns value does not match.", "Expense Import", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private async void btnRefreshExpense_Click(object sender, EventArgs e)
        {
            if (dtpFromExpense.Value > dtpToExpense.Value)
            {
                Alert_Dialog.ShowAlertMessage($"Date(From) should be less than Date(To).", Alert_Dialog.AlertType.INFO);
            }
            else
            {
                await LoadExpensesChart();
            }
        }
        readonly List<decimal> currentYearValues = new List<decimal>();
        readonly List<decimal> prevYearValues = new List<decimal>();
        internal static int currentYear = DateTime.Now.Year;
        internal static int previousYear = currentYear - 1;
        private async Task LoadExpensesChart()
        {
                chartExpenses.Update();
                chartExpenses.AxisX.Clear();
                chartExpenses.AxisY.Clear();
                chartExpenses.AxisX.Add(new Axis
                {
                    Title = "Month",
                    Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                });
                chartExpenses.AxisY.Add(new Axis
                {
                    Title = "Expense History",
                    LabelFormatter = value => value.ToString("C").Replace("$", "₱")
                });


                await Task.Delay(1000);

            try
                {
                    SeriesCollection series = new SeriesCollection();
                    decimal value = 0;
                    for (int month = 1; month <= 12; month++)
                    {
                        var expenseAction = new ExpensesMapper();
                        var expenseDate = new ExpensesObject()
                        {
                            Year = currentYear,
                            Month = month
                        };
                        var scalar = expenseAction.GetScalar(expenseDate, "RD_Expense_GetChartData");

                        if (scalar != null)
                        {
                            value = Convert.ToDecimal(scalar);
                        }
                        else
                        {
                            value = 0;
                        }
                        currentYearValues.Add(value);
                    }
                    for (int month = 1; month <= 12; month++)
                    {
                        var expenseAction = new ExpensesMapper();
                        var expenseDate = new ExpensesObject()
                        {
                            Year = previousYear,
                            Month = month
                        };
                        var scalar = expenseAction.GetScalar(expenseDate, "RD_Expense_GetChartData");

                        if (scalar != null)
                        {
                            value = Convert.ToDecimal(scalar);
                        }
                        else
                        {
                            value = 0;
                        }
                        prevYearValues.Add(value);
                    }
                    series = new SeriesCollection
                    {
                         new LineSeries
                        {

                            Title = previousYear.ToString(),
                            Values = new ChartValues<decimal>(prevYearValues)

                        },
                        new LineSeries
                        {
                            Title = currentYear.ToString(),
                            Values = new ChartValues<decimal>(currentYearValues)
                        }
                    };
                    chartExpenses.LegendLocation = LegendLocation.Bottom;
                    chartExpenses.ForeColor = Color.FromArgb(24, 30, 54);
                    prevYearValues.Clear();
                    currentYearValues.Clear();
                    chartExpenses.Series = series;

                    await LoadExpensesList();

                
            }
            catch
            {
            }
        }
        private async Task LoadExpensesList()
        {
            try
            {
                    var expensesAction = new ExpensesMapper();
                    var expense = new ExpensesObject()
                    {
                        fromDate = DateTime.Parse(dtpFromExpense.Value.ToString("yyyy-MM-dd")),
                        toDate = DateTime.Parse(dtpToExpense.Value.ToString("yyyy-MM-dd")),

                    };
                    await Task.Delay(1000);
                    var expenseList = expensesAction.dynamicsListWithParam(expense, "RD_Expenses_GetListByDate");
                    var dgvworker = new ListToDataTableWorker();
                    var dt = new DataTable();
                    dt = dgvworker.ConvertToDataTable(expenseList);
                    datagridExpense.AutoGenerateColumns = false;
                    for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                    {
                        datagridExpense.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                    }
                    datagridExpense.DataSource = dt;

                    if (dt.Rows.Count == 1)
                    {
                        Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Expense has been found.", Alert_Dialog.AlertType.INFO);
                    }
                    else if (dt.Rows.Count > 1)
                    {
                        Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Expenses has been found.", Alert_Dialog.AlertType.INFO);
                    }
                
            }
            catch
            {
                Alert_Dialog.ShowAlertMessage("No expense record has been found.", Alert_Dialog.AlertType.WARNING);
                datagridExpense.DataSource = null;
            }
        }
        private void btnSaveExpense_Click(object sender, EventArgs e)
        {
            validateExpenseEntry();
        }
        private async void validateExpenseEntry()
        {
            try
            {
                if (ExpenseValidator.Count((validator) => validator.IsValid()) == ExpenseValidator.Count)
                {
                    var expenseAction = new ExpensesMapper();
                    var expense = new ExpensesObject()
                    {
                        Expense_Id = Expense_Id == 0 ? default : Expense_Id,
                        Amount = Double.Parse(txtExpenseAmount.Text),
                        OR_Number = txtExpenseOR.Text,
                        ExpenseType_Id = Int32.Parse(cmbExpenseType.SelectedValue.ToString()),
                        Entry_Date = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")),
                        Expense_Note = string.IsNullOrEmpty(txtExpenseNote.Text)? Expense_Id == 0 ?"No expense note." : "No expense note.(Updated)" : Expense_Id == 0 ? txtExpenseNote.Text : $"{txtExpenseNote.Text} (Updated)"
                    };
                    expenseAction.InsertOrUpdate(expense, "RD_Expense_InsertUpdate");
                    Alert_Dialog.ShowAlertMessage($"Expense has been {(string.IsNullOrEmpty(user_ID.Text) ? EntryStatus[0] : EntryStatus[1])} successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(current_user_Id, $"{(Expense_Id == 0 ? "Created" : "Updated")} Expense: Official Receipt No.[{txtExpenseOR.Text}], Amount[{txtExpenseAmount.Text}], Expense type[{cmbExpenseType.Text}]", "Expenses");
                    btnCancelExpense_Click(null, null);
                    await LoadExpensesChart();
                }
            }
            catch
            {
            }
        }
        private void btnCancelExpense_Click(object sender, EventArgs e)
        {
            var clear = new InputRemoverAndValidation();
            panelExpenseEntry.Size = new Size(0, panelExpenseEntry.Size.Height);
            ExpenseValidator.ForEach(validator => validator.Reset());
            clear.ClearText(panelExpenseEntry);
            Expense_Id = 0;
        }
        private void txtExpenseAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validate = new InputRemoverAndValidation();
            validate.numAndDotOnly(sender, e);
        }

        private void txtExpenseNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validate = new InputRemoverAndValidation();
            validate.allowTextAndDigitOnly(sender, e);
        }

        private void txtExpenseOR_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validate = new InputRemoverAndValidation();
            validate.allowTextAndDigitOnly(sender, e);
        }
        private void datagridExpense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = datagridExpense.Columns[e.ColumnIndex].Name;
            if (column == "xpense_Edit")
            {
                ExpensesListOption(datagridExpense, e.RowIndex, "Edit");
            }
            else if (column == "xpense_Delete")
            {
                ExpensesListOption(datagridExpense, e.RowIndex, "Delete");
            }
        }
        private async void ExpensesListOption(DataGridView expense, int rowIndex, string option)
        {
            if (option == "Edit")
            {
                Expense_Id = Int32.Parse(expense.Rows[rowIndex].Cells[0].Value.ToString());
                txtExpenseOR.Text = expense.Rows[rowIndex].Cells[2].Value.ToString();
                cmbExpenseType.Text = expense.Rows[rowIndex].Cells[3].Value.ToString();
                txtExpenseAmount.Text = expense.Rows[rowIndex].Cells[4].Value.ToString();
                txtExpenseNote.Text = expense.Rows[rowIndex].Cells[6].Value.ToString();

                btnAddExpense_Click(null, null);
            }
            else if (option == "Delete")
            {
                DialogResult result = Confirmation.ShowDialog($"Are you sure this record {expense.Rows[rowIndex].Cells[2].Value.ToString()} ?");
                if (result == DialogResult.Yes)
                {
                    var expenseAction = new ExpensesMapper();
                    var expense_Id = new ExpensesObject()
                    {
                        Expense_Id = Int32.Parse(expense.Rows[rowIndex].Cells[0].Value.ToString())
                    };
                    expenseAction.Delete(expense_Id, "RD_Expense_DeleteById");
                    Alert_Dialog.ShowAlertMessage("Expense has been removed successfully", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(current_user_Id, $"Deleted expense record with Official Receipt No.[{expense.Rows[rowIndex].Cells[2].Value.ToString()}]", "Expenses");
                    await LoadExpensesChart();
                }
            }
        }
        private void datagridExpense_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseClickContextProvider(sender, dgvExpenseContext, e);
        }

        private void btnEditExpense_Click(object sender, EventArgs e)
        {
            ExpensesListOption(datagridExpense, rowIndex, "Edit");
        }

        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            ExpensesListOption(datagridExpense, rowIndex, "Delete");
        }
        private void cmbExpenseType_TextChanged(object sender, EventArgs e)
        {
            cmbExpenseType.SelectedItem = cmbExpenseType.Text;
        }
        private async  void btnClearExpenses_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = Confirmation.ShowDialog("Are you sure to clear all expense records ?");
                if (result == DialogResult.Yes)
                {
                    QueryWorker deleteWorker = new QueryWorker();
                    deleteWorker.DeleteAll("DELETE FROM rd_saims.tbl_expenses");
                    Alert_Dialog.ShowAlertMessage("All expense records has been cleared.", Alert_Dialog.AlertType.INFO);
                    await LoadPricingList();
                }
            }
            catch (Exception)
            {
               
            }
        }
        #endregion

        #region USERS
        List<Validator> UserValidator = new List<Validator>();

        private void FillUserRoles()
        {
            var userAction = new UserMapper();
            var roles = userAction.dynamicsList("RD_Role_GetRoleTitle");
            cmbUserRole.DataSource = roles;
            cmbUserRole.DisplayMember = "Role_Title";
            cmbUserRole.ValueMember = "Role_Id";
        }

        private async Task LoadUserList(string search)
        {
            try
            {
                var userAction = new UserMapper();
                var user = new UserObject()
                {
                    User_Search = search
                };
                await Task.Delay(1000);
                var users = userAction.dynamicsListWithParam(user, "RD_User_GetListBySearch");
                var dgvworker = new ListToDataTableWorker();
                var dt = new DataTable();
                dt = dgvworker.ConvertToDataTable(users);
                datagridUserList.AutoGenerateColumns = false;
                for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                {
                    datagridUserList.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                }
                datagridUserList.DataSource = dt;

                if (dt.Rows.Count == 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} User has been found.", Alert_Dialog.AlertType.INFO);
                }
                else if (dt.Rows.Count > 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Users has been found.", Alert_Dialog.AlertType.INFO);
                }
            }
            catch
            {
                Alert_Dialog.ShowAlertMessage("No User record has been found.", Alert_Dialog.AlertType.WARNING);
                datagridUserList.DataSource = null;
            }
        }
        private async void txtSearchUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                await LoadUserList(txtSearchUser.Text);
            }
        }

        private async void btnRefreshUser_Click(object sender, EventArgs e)
        {
            await LoadUserList(txtSearchUser.Text);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            panelUserEntry.Size = new Size(358, panelUserEntry.Size.Height);
            UserValidator.Add(new Validator(txtUserFname, errFirstname, "firstname", "required|name"));
            UserValidator.Add(new Validator(txtUserLname, errLastname, "lastname", "required|name"));
            UserValidator.Add(new Validator(txtUserContact, errContact, "contact number", "required"));
            UserValidator.Add(new Validator(txtUserAddress, errAddress, "address", "required"));
            UserValidator.Add(new Validator(txtUserUname, errUsername, "username", "required|max:10|unique:rd_saims.tbl_user, Username") { unique_ignore = txtUserUname.Text });
            UserValidator.Add(new Validator(txtUserPassword, errPassword, "password", "required|min:8"));
        }

        private void datagridUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = datagridUserList.Columns[e.ColumnIndex].Name;
            if (column == "user_Edit")
            {
                UserListOption(datagridUserList, e.RowIndex, "Edit");
            }
            else if (column == "user_Delete")
            {
                UserListOption(datagridUserList, e.RowIndex, "Delete");
            }
        }
        private async void UserListOption(DataGridView dgv_user, int rowIndex, string option)
        {
            var rsrcmgr = new ResourceManager();
            var inputrv = new InputRemoverAndValidation();
            if (option == "Edit")
            {
                user_ID.Text = dgv_user.Rows[rowIndex].Cells[0].Value.ToString();
                inputrv.getFirstAndLastName(txtUserFname, txtUserLname, dgv_user.Rows[rowIndex].Cells[2].Value.ToString());
                txtUserContact.Text = dgv_user.Rows[rowIndex].Cells[3].Value.ToString();
                txtUserAddress.Text = dgv_user.Rows[rowIndex].Cells[4].Value.ToString();
                cmbUserRole.Text = dgv_user.Rows[rowIndex].Cells[7].Value.ToString();
                txtUserUname.Text = dgv_user.Rows[rowIndex].Cells[5].Value.ToString();
                txtUserPassword.Text = HashWorker.Decrypt(dgv_user.Rows[rowIndex].Cells[6].Value.ToString());
                tglUserStatus.Checked = dgv_user.Rows[rowIndex].Cells[8].Value.ToString().Equals("Active") ? true : false;
                try { pbxUserProfile.Image = rsrcmgr.ByteArrayToImage(File.ReadAllBytes(SystemPath.ProfilesPath + dgv_user.Rows[rowIndex].Cells[9].Value.ToString())); } catch { pbxUserProfile.Image = Resources.user; }
                labelImagePath.Text = SystemPath.ProfilesPath + dgv_user.Rows[rowIndex].Cells[9].Value.ToString();

                btnAddUser_Click(null, null);
            }
            else if (option == "Delete")
            {
                btnCancelUser_Click(null, null);
                DialogResult result = Confirmation.ShowDialog($"Are you sure to delete {dgv_user.Rows[rowIndex].Cells[2].Value.ToString()} account?");
                if (result == DialogResult.Yes)
                {
                    var userAction = new UserMapper();
                    var person = new PersonObject()
                    {
                        Id = Int32.Parse(dgv_user.Rows[rowIndex].Cells[0].Value.ToString())
                    };
                    labelImagePath.Text = dgv_user.Rows[rowIndex].Cells[9].Value.ToString();
                    userAction.Delete(person, "RD_User_DeleteById");
                    File.Delete(SystemPath.ProfilesPath + labelImagePath.Text);
                    Alert_Dialog.ShowAlertMessage("Account has been removed successfully", Alert_Dialog.AlertType.SUCCESS);
                    await LoadUserList(txtSearchUser.Text);
                }
            }
            else if (option == "View")
            {
                tabMaintenance.SelectedTab = pgAudit;
                cmbUsers.Text = dgv_user.Rows[rowIndex].Cells[2].Value.ToString();
            }
        }
        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            validateUserEntry();
        }
        private async void validateUserEntry()
        {
            try
            {
                if (UserValidator.Count((validator) => validator.IsValid()) == UserValidator.Count)
                {
                    var rsrcmgr = new ResourceManager();
                    var filename = $"{txtUserFname.Text}.jpg";
                    var userAction = new UserMapper();
                    var user = new UserObject()
                    {
                        Role_Id = Int32.Parse(cmbUserRole.SelectedValue.ToString()),
                        UserName = txtUserUname.Text,
                        Password = HashWorker.Encrypt(txtUserPassword.Text),
                        Status = tglUserStatus.Checked.Equals(true) ? "Active" : "Inactive",
                        ImagePath = filename
                    };
                    var person = new PersonObject()
                    {
                        Id = string.IsNullOrEmpty(user_ID.Text) ? default : Int32.Parse(user_ID.Text),
                        FirstName = txtUserFname.Text,
                        LastName = txtUserLname.Text,
                        Contact_Number = txtUserContact.Text,
                        Address = txtUserAddress.Text
                    };
                    userAction.InsertOrUpdate(user, person, "RD_User_InsertUpdate");
                    if (string.IsNullOrEmpty(user_ID.Text))
                    {
                        File.Copy(labelImagePath.Text, rsrcmgr.getUniqueFilename(SystemPath.ProfilesPath + filename));
                    }
                    else
                    {
                        File.Copy(labelImagePath.Text, SystemPath.ProfilesPath + filename, true);
                    }
                    Alert_Dialog.ShowAlertMessage($"Account has been {(string.IsNullOrEmpty(user_ID.Text) ? EntryStatus[0] : EntryStatus[1])} successfully", Alert_Dialog.AlertType.SUCCESS);
                    btnCancelUser_Click(null, null);
                    await LoadUserList(txtSearchUser.Text);
                }
            }
            catch
            {
            }
        }

        private void btnCancelUser_Click(object sender, EventArgs e)
        {
            panelUserEntry.Size = new Size(0, panelUserEntry.Size.Height);
            var inputrv = new InputRemoverAndValidation();
            btnSaveUser.Visible = true;
            pbxUserProfile.Image.Dispose();
            pbxUserProfile.Image = Resources.user;
            tglUserStatus.Checked = false;
            inputrv.ClearText(panelUserEntry);
            labelImagePath.Text = string.Empty;
            user_ID.Text = string.Empty;
            UserValidator.ForEach(validator => validator.Reset());
        }

        private void tglVisibility_Click(object sender, EventArgs e)
        {
            if ((((Guna2Button)sender).Checked) == true)
            {
                txtUserPassword.PasswordChar = '\0';
            }
            else
            {
                txtUserPassword.PasswordChar = '•';
            }
        }
        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            BrowseImage();
        }
        private void BrowseImage()
        {
            var imgOpener = new ResourceManager();
            imgOpener.ImageFileOpener("(*.jpg; *.jpeg; *.bmp; *.png;) | *.jpg; *.jpeg; *.bmp; *.png;", labelImagePath, pbxUserProfile);
        }
        private void datagridUserList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MouseClickContextProvider(sender, dgvUserContext, e);
        }
        private void cmEditUser_Click(object sender, EventArgs e)
        {
            UserListOption(datagridUserList, rowIndex, "Edit");
        }
        private void cmDeleteUser_Click(object sender, EventArgs e)
        {
            UserListOption(datagridUserList, rowIndex, "Delete");
        }
        private void cmViewActivity_Click(object sender, EventArgs e)
        {
            UserListOption(datagridUserList, rowIndex, "View");
        }

        private void txtUserFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validate = new InputRemoverAndValidation();
            validate.textOnly(sender, e);
        }

        private void txtUserContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validate = new InputRemoverAndValidation();
            validate.numOnly(sender, e);
        }

        private void txtUserUname_KeyPress(object sender, KeyPressEventArgs e)
        {
            var validate = new InputRemoverAndValidation();
            validate.allowTextAndDigitOnly(sender, e);
        }



        #endregion

        #region REPORTS
        private void btnLoadInvReport_Click(object sender, EventArgs e)
        {
            if (dtpFromInventory.Value >= dtpToInventory.Value)
            {
                Alert_Dialog.ShowAlertMessage("Date 'To' should be less than Date 'From'.", Alert_Dialog.AlertType.WARNING);
            }
            else
            {
                GetInventoryReport();
                new AuditTrailMapper().InsertActivity(current_user_Id, $"Generated {cmbInvReport.Text} inventory report.", "Reports");
            }
        }
        private void GetInventoryReport()
        {
            var invReport = new rptInventory();
            invReport.SetParameterValue("fromDate", DateTime.Parse(dtpFromInventory.Value.ToString("dd/MM/yyyy")));
            invReport.SetParameterValue("toDate", DateTime.Parse(dtpToInventory.Value.ToString("dd/MM/yyyy")));
            invReport.SetParameterValue("preparedBy", labelCurrentUserName.Text);
            invReport.SetParameterValue("invSearch", txtSearchInvReport.Text);
            invReport.SetParameterValue("invStatus", cmbInvReport.Text);
            cvInventory.ReportSource = invReport;
            cvInventory.Refresh();
        }
        private void btnLoadSalesReport_Click(object sender, EventArgs e)
        {
            if (dtpFromSalesReport.Value > dtpToSalesReport.Value)
            {
                Alert_Dialog.ShowAlertMessage("Date 'From' must be less than Date 'To' ", Alert_Dialog.AlertType.WARNING);
            }
            else
            {
                GetSalesReport();
                new AuditTrailMapper().InsertActivity(current_user_Id, $"Generated {cmbPondSalesReport.Text} sales report.", "Reports");
            }
        }
        private void GetSalesReport()
        {
            var salesReport = new rptSales();
            salesReport.SetParameterValue("fromDate", DateTime.Parse(dtpFromSalesReport.Value.ToString("dd/MM/yyyy")));
            salesReport.SetParameterValue("toDate", DateTime.Parse(dtpToSalesReport.Value.ToString("dd/MM/yyyy")));
            salesReport.SetParameterValue("txtPond", cmbPondSalesReport.Text);
            salesReport.SetParameterValue("txtManager", labelCurrentUserName.Text);
            cvSales.ReportSource = salesReport;
            cvSales.Refresh();
        }
        private void LoadSalesReportPond()
        {
            try
            {
                var prodAction = new ProductionMapper();
                var farmName = new ProductionObject()
                {
                    Farm_Name = GetCurrentFarmName()
                };
                var ponds = prodAction.dynamicsListWithParam(farmName, "RD_Production_GetResultList");
                cmbPondSalesReport.DataSource = ponds;
                cmbPondSalesReport.DisplayMember = "Pond_Code";
                cmbPondSalesReport.ValueMember = "Production_Id";
            }
            catch { }
        }

        private void btnLoadExpReport_Click(object sender, EventArgs e)
        {
            if (dtpFromExpReport.Value > dtpToExpReport.Value)
            {
                Alert_Dialog.ShowAlertMessage("Date 'From' must be less than Date 'To' ", Alert_Dialog.AlertType.WARNING);
            }
            else
            {
                GetExpenseReport();
                new AuditTrailMapper().InsertActivity(current_user_Id, $"Generated expenses report.", "Reports");
            }
        }
        private void GetExpenseReport()
        {
            var expReport = new rptExpenses();
            expReport.SetParameterValue("fromDate", DateTime.Parse(dtpFromExpReport.Value.ToString("dd/MM/yyyy")));
            expReport.SetParameterValue("toDate", DateTime.Parse(dtpToExpReport.Value.ToString("dd/MM/yyyy")));
            expReport.SetParameterValue("txtManager", labelCurrentUserName.Text);
            cvExpenses.ReportSource = expReport;
            cvExpenses.Refresh();
        }
        #endregion

        #region AUDIT TRAIL

        private void fillAuditCombo()
        {
            try
            {
                var auditAction = new AuditTrailMapper();
                var users = auditAction.dynamicsList("RD_Audit_GetPersonList");
                cmbUsers.DataSource = users;
                cmbUsers.DisplayMember = "Fullnames";
                cmbUsers.ValueMember = "Person_Id";

                var typeAction = new AuditTrailMapper();
                var types = auditAction.dynamicsList("RD_Audit_GetActivityType");
                cmbActivityType.DataSource = types;
                cmbActivityType.DisplayMember = "Activity_Type";
                cmbActivityType.ValueMember = "Person_Id";
            }
            catch { }
        }

        private async void LoadAuditTrailList()
        {
            try
            {
                await Task.Delay(1000);
                var users = new AuditTrailMapper().dynamicsListWithParam(Int32.Parse(cmbUsers.SelectedValue.ToString()), cmbActivityType.Text, DateTime.Parse(dtpFromAudit.Value.ToString("yyyy-MM-dd")), DateTime.Parse(dtpToAudit.Value.ToString("yyyy-MM-dd")), "RD_Audit_GetAuditList");
                var dgvworker = new ListToDataTableWorker();
                var dt = new DataTable();
                dt = dgvworker.ConvertToDataTable(users);
                datagridAudit.AutoGenerateColumns = false;
                for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                {
                    datagridAudit.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                }
                datagridAudit.DataSource = dt;

                if (dt.Rows.Count == 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Acitivity has been found.", Alert_Dialog.AlertType.INFO);
                }
                else if (dt.Rows.Count > 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Activities has been found.", Alert_Dialog.AlertType.INFO);
                }
            }
            catch
            {
                Alert_Dialog.ShowAlertMessage("No Activities has been found.", Alert_Dialog.AlertType.WARNING);
                datagridAudit.DataSource = null;
            }
        }
        private void btnLoadActivity_Click(object sender, EventArgs e)
        {
            if (dtpFromAudit.Value > dtpToAudit.Value && cmbUsers.DataSource != null)
            {
                Alert_Dialog.ShowAlertMessage("Date(From) should be less than Date(To)", Alert_Dialog.AlertType.WARNING);
            }
            else
            {
                LoadAuditTrailList();
            }
        }



        #endregion


    }
}
