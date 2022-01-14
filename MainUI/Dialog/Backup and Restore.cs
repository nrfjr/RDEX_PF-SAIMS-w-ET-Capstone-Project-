using MySql.Data.MySqlClient;
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
    public partial class Backup_and_Restore : Form
    {
        string datenow = DateTime.Now.ToString("yyyy-MM-dd");
        List<Validator> bkpValidator = new List<Validator>();
        List<Validator> rstValidator = new List<Validator>();
        public Backup_and_Restore()
        {
            InitializeComponent();
            bkpValidator.Add(new Validator(txtFarmName, errorFarmName, "folder path", "required"));
            rstValidator.Add(new Validator(txtRestorePath, errRestore, "restore path", "required"));
            
        }
        #region BACKUP
        private void txtFarmName_Click(object sender, EventArgs e)
        {
            txtFarmName.Text = new ResourceManager().FolderPathFinder();
        }

        private void btBackup_Click(object sender, EventArgs e)
        {
            bwBackup.RunWorkerAsync();
        }
        private void validateBackup(string filepath)
        {
            if (bkpValidator.Count((validator) => validator.IsValid()) == bkpValidator.Count)
            {

                using (var _connection = new MySqlConnection(MySqlDBConnection.stringCon))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup backup = new MySqlBackup(cmd))
                        {
                            cmd.Connection = _connection;
                            _connection.Open();
                            backup.ExportToFile(Path.Combine(filepath, "RDSAIMS-Backup" + datenow + ".sql"));
                            _connection.Close();
                        }
                    }
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void bwBackup_DoWork(object sender, DoWorkEventArgs e)
        {
            validateBackup(txtFarmName.Text);
        }

        private void bwBackup_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bwBackup_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Alert_Dialog.ShowAlertMessage("Backup operation succeedded", Alert_Dialog.AlertType.SUCCESS);
            txtFarmName.Text = string.Empty;
        }
        #endregion

        #region RESTORE
        

        private void bwRestore_DoWork(object sender, DoWorkEventArgs e)
        {
            validateRestore(txtRestorePath.Text);
        }
        private void validateRestore(string filepath)
        {
            if (bkpValidator.Count((validator) => validator.IsValid()) == bkpValidator.Count)
            {
                using (var _connection = new MySqlConnection(MySqlDBConnection.stringCon))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup restore = new MySqlBackup(cmd))
                        {
                            cmd.Connection = _connection;
                            _connection.Open();
                            restore.ImportFromFile(filepath);
                            _connection.Close();
                        }
                    }
                }
            }
        }
        private void bwRestore_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Alert_Dialog.ShowAlertMessage("Restore operation succeedded", Alert_Dialog.AlertType.SUCCESS);
        }

        private void btnCancelRestore_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        #endregion

        private void txtRestorePath_Click(object sender, EventArgs e)
        {
            txtRestorePath.Text = new ResourceManager().SQLFileFinder();
        }
    }
}
