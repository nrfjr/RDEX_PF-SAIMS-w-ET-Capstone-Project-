﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilitiesLibrary
{
    public class InputRemoverAndValidation
    {
        public void getFirstAndLastName(Guna2TextBox firstname, Guna2TextBox lastname, String fullname)
        {
            string[] fnames = fullname.Split(' ');
            string first_name = "", last_name = "";

            for (int i = 0; i != fnames.Length; i++)
            {
                if (i != fnames.Length - 1)
                {
                    if (i == 0)
                    {
                        first_name = first_name + fnames[i];
                    }
                    else
                    {
                        first_name = first_name + " " + fnames[i];
                    }
                }
            }

            string[] lnames = fullname.Split(' ');
            last_name = lnames[lnames.Length - 1].ToString();

            firstname.Text = first_name; lastname.Text = last_name;

        }
        public void ClearText(Control con)
        {

            foreach (Control c in con.Controls)
            {
                if (c is Guna2TextBox)
                    ((Guna2TextBox)c).Clear();
                ClearText(c);
            }
        }
        public void ClearComboBoxes(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is ComboBox)
                    ((ComboBox)c).Text = null;
                ClearComboBoxes(c);
            }
        }
        public void ClearTextAndCombo(Control con)
        {
            ClearText(con);
            ClearComboBoxes(con);
        }
        public void isTextButtonComboEnabled(Control con, bool status)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Enabled = status;
                if (c is ComboBox)
                    ((ComboBox)c).Enabled = status;
                if (c is Button)
                    ((Button)c).Enabled = status;
                isTextButtonComboEnabled(c, status);
            }
        }
        public void textOnly(Object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        public void textOnlyWithSpaces(Object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        public void allowTextAndDigitOnly(Object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.Back);/*IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || (e.KeyChar < 48) || (e.KeyChar > 57)*/
        }
        public void numOnly(Object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                e.Handled = true;
            }
        }
        public void numAndDotOnly(Object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar)&&e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if(e.KeyChar == '.' && (sender as Guna2TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        public void Pond_numOnly(Object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
            }
            else if (e.KeyChar == 46)
            {
            }
            else if (e.KeyChar == 80)
            {

            }
            else if ((e.KeyChar < 48) || (e.KeyChar > 57))
            {
                e.Handled = true;
            }
        }
    }
}