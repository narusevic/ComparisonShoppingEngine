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
    public partial class GetDataForm : Form
    {
        public GetDataForm()
        {
            InitializeComponent();
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }
    }
}
