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
using MainUI.Dialog;
using Squirrel;
using System.Net;
using MainUI.Forms.Admin_Forms;
using MainUI.Forms;
using System.Reflection;

namespace MainUI
{
    public partial class SplashScreen : Form
    {
        Timer fadeIn = new Timer();
        UpdateManager updateManager;
        public int runtime { get; set; }
        public string farmOwner { get; set; }
        public SplashScreen()
        {
            CheckFarmUser();
            CheckUpdate();
            startTimer.Start();
        }
        private void CheckFarmUser()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(SystemPath.FarmPath);
            farmOwner = xmlDoc.SelectSingleNode("/ Farm / Name").InnerText;

            if (string.IsNullOrEmpty(farmOwner))
            {
                Setting formSet = new Setting(null);
                formSet.ShowDialog();
                InitializeComponent();
            }
            else
            {
                InitializeComponent();
                labelOwner.Text = $"{farmOwner} Sales and Inventory Management System with Expense Tracker";
            }
        }
        private async void CheckUpdate()
        {
            try
            {
                using (var update = await UpdateManager.GitHubUpdateManager(@"https://github.com/pritongsabaw/RD_SAIMS-Version-Repo"))
                {
                    updateManager = update;
                    var releaseUpdate = await update.UpdateApp();
                }
            }
            catch 
            {
                if (runtime <= 0)
                {
                    Alert_Dialog.ShowAlertMessage("No updates detected.", Alert_Dialog.AlertType.INFO);
                }
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
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

        private void startTimer_Tick(object sender, EventArgs e)
        {
            startLoadingBar.Maximum = 100;
            startLoadingBar.Increment(2);

            if (startLoadingBar.Value == 100)
            {
                startTimer.Enabled = false;
                var ft = new FormTransition();
                var login = new Login();
                login.Text = $"{farmOwner} Sales and Inventory Management System with Expense Tracker v{Assembly.GetExecutingAssembly().GetName().Version}";
                ft.FadeOutHide(this, 30);
                login.ShowDialog();
                startTimer.Stop();

            }
        }
    }
}
