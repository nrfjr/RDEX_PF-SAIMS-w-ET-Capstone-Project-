using Guna.UI2.WinForms;
using MainUI.Dialog;
using MainUI.Forms.Admin_Forms;
using MapperLibrary.Controller;
using MapperLibrary.Helper;
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
using System.Xml;
using UtilitiesLibrary;

namespace MainUI.Forms
{
    public partial class Login : Form
    {
        Timer fadeIn = new Timer();
        public Login()
        {
            InitializeComponent();
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            await GetLoginDetails();
        }
        private async Task GetLoginDetails()
        {
            try
            {
                await Task.Delay(1000);
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    Alert_Dialog.ShowAlertMessage("Username or Password field is empty, Please try again!.", Alert_Dialog.AlertType.WARNING);
                }
                else
                {
                    var userAction = new UserMapper();
                    var user = new UserObject()
                    {
                        UserName = txtUsername.Text
                    };
                    var details = userAction.dynamicsListWithParam(user, "RD_User_GetLoginDetails");
                    var dt = new DataTable();
                    var dgvworker = new ListToDataTableWorker();
                    dt = dgvworker.ConvertToDataTable(details);

                    verifyLogin(dt, txtUsername.Text, txtPassword.Text);
                }
            }
            catch
            {
                
                Alert_Dialog.ShowAlertMessage("Username does not exist, Please contact your Admin / Manager.", Alert_Dialog.AlertType.WARNING);
            }
        }
        private async void verifyLogin(DataTable dt, string username, string password)
        {

                if (dt.Rows[0][1].ToString() != username)
                {
                    Alert_Dialog.ShowAlertMessage("Invalid username, Please try again!.", Alert_Dialog.AlertType.ERROR);
                }
                else if (HashWorker.Decrypt(dt.Rows[0][2].ToString()) != password)
                {
                    Alert_Dialog.ShowAlertMessage("Invalid password, Please try again!.", Alert_Dialog.AlertType.ERROR);
                }
                else
                {

                    await Task.Delay(1000);
                    var ft = new FormTransition();
                    var rsrcmgr = new ResourceManager();
                    var home = new Homepage(this);
                    ft.FadeOutHide(this, 30);
                    home.SetModulesByPrivilege(Int32.Parse(dt.Rows[0][4].ToString()));
                    home.CheckRole(dt.Rows[0][5].ToString());
                    home.SetVisibilityByRole(dt.Rows[0][5].ToString() == "Admin" ? true : false);
                    home.labelCurrentUserName.Text = dt.Rows[0][3].ToString();
                    home.pbxCurrentUserProfile.Image = rsrcmgr.ByteArrayToImage(File.ReadAllBytes(SystemPath.ProfilesPath + dt.Rows[0][6].ToString()));
                    Alert_Dialog.ShowAlertMessage($"Welcome {dt.Rows[0][5].ToString()} !", Alert_Dialog.AlertType.SUCCESS);
                    home.current_user_Id = Int32.Parse(dt.Rows[0][0].ToString());
                    new AuditTrailMapper().InsertActivity(Convert.ToInt32(dt.Rows[0][0].ToString()), $"Logged in to the system", "System");
                    home.Show();
                }
            
        }

        private void btnVisibility_Click(object sender, EventArgs e)
        {
            if ((((Guna2Button)sender).Checked) == true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnForgot_Click(object sender, EventArgs e)
        {
            //forgot password form
        }

        private void Login_Load(object sender, EventArgs e)
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

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}
