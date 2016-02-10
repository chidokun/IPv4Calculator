/// IPv4 Calculator - A simple tool to subnetting IPv4 address
/// Copyright (c) 2015 - Nguyen Tuan
/// Email: nguyentuanit96@gmail.com
/// 
/// This is free software and I hope it will be useful.

using System;
using System.Windows.Forms;
using IPv4Calculator.Properties;

namespace IPv4Calculator
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void lnkNewVersion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/chidokun/IPv4Calculator/releases");
        }

        private void lnkJoinUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/chidokun/IPv4Calculator");
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            lblInformation.Text = "Version: " + Resources.Version
                            + "\nRelease Date: " + Resources.ReleaseDate
                            + "\nCopyright © 2015 Nguyễn Tuấn.";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
