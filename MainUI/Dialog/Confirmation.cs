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
    public partial class Confirmation : Form
    {
        public Confirmation(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Dispose();
        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Dispose();
        }
        public static DialogResult ShowDialog(string message)
        {
            return (new Confirmation(message)).ShowDialog();
        }
    }
}
