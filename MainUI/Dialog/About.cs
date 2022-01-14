using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI.Dialog
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            labelVersion.Text = $"Version {GetVersion().ToString()}";
        }
        private static Version GetVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version;
        }

        private void labelDev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void labelDev_MouseLeave(object sender, EventArgs e)
        {
            panelDev.Size = new Size(panelDev.Width, 0);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            panelDev.Visible = false;

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            panelDev.Visible = true;
            panelDev.Size = new Size(panelDev.Width, 196);
        }
    }
}
