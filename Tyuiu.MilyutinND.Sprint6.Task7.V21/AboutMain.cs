﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.MilyutinND.Sprint6.Task7.V21
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void buttonAccept_KDR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
