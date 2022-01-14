using Guna.UI2.WinForms;
using MainUI.Forms.Admin_Forms;
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
    public partial class Withdrawal_History : Form
    {
        public int rowIndex { get; set; }
        Homepage hmp;
        public Withdrawal_History(Homepage hmpg)
        {
            InitializeComponent();
            hmp = hmpg;
            foo();
        }
        private async Task LoadWithdrawalList()
        {
            
            try
            {
                var invAction = new InventoryMapper();
                var search = new InventoryStockObject()
                {
                    Search = txtWdrawSearch.Text,
                    fromDate = Convert.ToDateTime(dtpFromWdraw.Value.ToString("yyyy-MM-dd")),
                    toDate = Convert.ToDateTime(dtpToWdraw.Value.ToString("yyyy-MM-dd"))
                };
                await Task.Delay(1000);
                var stock = invAction.dynamicsListWithParam(search, "RD_Stock_GetWithdrawalList");
                var dgvworker = new ListToDataTableWorker();
                var dt = new DataTable();
                dt = dgvworker.ConvertToDataTable(stock);
                datagridWdraw.AutoGenerateColumns = false;
                for (int i = 0, j = 0; i < dt.Columns.Count; i++)
                {
                    datagridWdraw.Columns[j++].DataPropertyName = dt.Columns[i].ColumnName;
                }
                datagridWdraw.DataSource = dt;

                if (dt.Rows.Count == 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Withdrawal has been found.", Alert_Dialog.AlertType.INFO);
                }
                else if (dt.Rows.Count > 1)
                {
                    Alert_Dialog.ShowAlertMessage($"{dt.Rows.Count} Withdrawals are found.", Alert_Dialog.AlertType.INFO);
                }

            }
            catch
            {
                Alert_Dialog.ShowAlertMessage("No Withdrawal has been found.", Alert_Dialog.AlertType.WARNING);
                datagridWdraw.DataSource = null;
            }
        }
        private async void foo()
        {
            await LoadWithdrawalList();
        }

        private void datagridWdraw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = datagridWdraw.Columns[e.ColumnIndex].Name;
            if (column == "wdraw_revert")
            {
                WithdrawListOption(datagridWdraw, e.RowIndex, "Revert");
            }

        }
        private async void WithdrawListOption(DataGridView w, int rowIndex, string option)
        {
            if(option == "Revert")
            {
                string itemcode, itemname, qty, unit;
                itemcode = w.Rows[rowIndex].Cells[2].Value.ToString(); itemname = w.Rows[rowIndex].Cells[3].Value.ToString(); qty = w.Rows[rowIndex].Cells[6].Value.ToString(); unit = w.Rows[rowIndex].Cells[7].Value.ToString();
                DialogResult result = Confirmation.ShowDialog($"Are you sure to revert withdrawal on {w.Rows[rowIndex].Cells[2].Value.ToString()} { w.Rows[rowIndex].Cells[3].Value.ToString()}?");
                if(result == DialogResult.Yes)
                {
                    var invAction = new InventoryMapper();
                    var withdraw = new InventoryStockObject()
                    {
                        Inventory_Id = Int32.Parse(w.Rows[rowIndex].Cells[0].Value.ToString()),
                    };
                    invAction.Delete(withdraw, "RD_Stock_DeleteWithdrawalById");
                    Alert_Dialog.ShowAlertMessage("Withdrawal Reverted successfully.", Alert_Dialog.AlertType.SUCCESS);
                    new AuditTrailMapper().InsertActivity(hmp.current_user_Id, $"Reverted withdrawal on {itemcode} {itemname}, Quantity[{qty}], Unit[{unit}]", "Inventory");
                    foo();
                    await hmp.LoadAvailableWithdrawList();
                }

            }

        }

        private void datagridWdraw_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex != -1 && e.Button == MouseButtons.Right)
                {
                    DataGridViewCell clickedCell = datagridWdraw.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    clickedCell.Selected = true;
                    datagridWdraw.CurrentCell = clickedCell;
                    rowIndex = datagridWdraw.CurrentCell.RowIndex;
                    var relativeMousePosition = datagridWdraw.PointToClient(Cursor.Position);
                    dgvWdrawContext.Show(datagridWdraw, relativeMousePosition);
                }
            }
            catch { }
        }

        private void btnRevertWdraw_Click(object sender, EventArgs e)
        {
            WithdrawListOption(datagridWdraw, rowIndex, "Revert");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private async void btnLoadWdraw_Click(object sender, EventArgs e)
        {
            await LoadWithdrawalList();
        }
    }
}
