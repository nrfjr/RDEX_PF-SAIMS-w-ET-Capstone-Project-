using FontAwesome.Sharp;
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
    public partial class Alert_Dialog : Form
    {
        private static List<Alert_Dialog> openforms = new List<Alert_Dialog>();
        Action action;

        public enum AlertType
        {
            SUCCESS,
            WARNING,
            ERROR,
            INFO
        }
        enum Action
        {
            WAIT,
            START,
            CLOSE
        }
        int x, y;
        public Alert_Dialog(string message, AlertType type)
        {
            InitializeComponent();
            string fname;
            Opacity = 0;
            StartPosition = FormStartPosition.Manual;

            for (int i = 1; i <= 10; i++)
            {
                fname = "alert" + i;
                var alert = openforms.FirstOrDefault((forms) => forms.Name == fname);
                if (alert == null)
                {
                    Name = fname;
                    x = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                    y = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
                    Location = new Point(x, y);
                    openforms.Add(this);
                    break;
                }

            }
            x = Screen.PrimaryScreen.WorkingArea.Width - Width - 5;

            switch (type)
            {
                case AlertType.SUCCESS:
                    pbxAlertIcon.IconChar = IconChar.Check;
                    panelAlert.FillColor = Color.FromArgb(126, 148, 44);
                    break;
                case AlertType.WARNING:
                    pbxAlertIcon.IconChar = IconChar.ExclamationTriangle;
                    panelAlert.FillColor = Color.FromArgb(255, 187, 0);
                    break;
                case AlertType.ERROR:
                    pbxAlertIcon.IconChar = IconChar.Times;
                    panelAlert.FillColor = Color.Red;
                    break;
                case AlertType.INFO:
                    pbxAlertIcon.IconChar = IconChar.Info;
                    panelAlert.FillColor = Color.White;
                    break;
            }
            labelMessage.Text = message;
        }

        public void showAlert()
        {
            action = Action.START;
            TopMost = true;
            Show();
            tmAlert.Start();
        }
        public static void ShowAlertMessage(string message, AlertType type)
        {
            var alert = (new Alert_Dialog(message, type));
            alert.showAlert();
        }
        private void tmAlert_Tick(object sender, EventArgs e)
        {
            switch (action)
            {
                case Action.START:
                    tmAlert.Interval = 1;
                    Opacity += 0.1;
                    if (x < Location.X)
                    {
                        Left -= 1;
                    }
                    else
                    {
                        if (Opacity == 1)
                        {
                            action = Action.WAIT;
                        }
                    }
                    break;
                case Action.WAIT:
                    tmAlert.Interval = 3000;
                    action = Action.CLOSE;
                    break;
                case Action.CLOSE:
                    tmAlert.Interval = 1;
                    Opacity -= 0.1;
                    Left += 1;
                    if (Opacity == 0)
                    {
                        openforms.Remove(this);
                        Close();
                    }
                    break;
            }
        }
    }
}
