﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSE.FrontEnd
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        public void emailLabel_Click(object sender, EventArgs e)
        {

        }
        private void logInButton_Click(object sender, EventArgs e)
        {
            var email = emailBox.Text;
            var password = passwordBox.Text;
            var csv = new CSV();

            if (csv.ParsingRegistration(email, password))
            {
                this.Hide();
                // Form1 frm = new Form1();
                //frm.Show();
                InsertReceiptForm insertReceiptForm = new InsertReceiptForm();
                insertReceiptForm.Show();
            }
            else
            {
                var error = "Email or password is incorrect.";
                FormsToolkit.DisplayMessageBox(error);
            }
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            Hide();
            UploadDataForm uploadDataForm = new UploadDataForm();
            uploadDataForm.Show();
        }

        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
