﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourFmNew
{
    public partial class Show : UserControl
    {
        Main super = null;
        public Show(Main s)
        {
            this.super = s;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            super.openShowManage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            super.openAddEpisode();
        }
    }
}
