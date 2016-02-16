/// IPv4 Calculator - A simple tool to subnetting IPv4 address
/// Copyright (c) 2015 - Nguyen Tuan
/// Email: nguyentuanit96@gmail.com
/// 
/// This is free software and I hope it will be useful.

using System;
using System.Text;
using System.Windows.Forms;
using IPv4Calculator.Properties;

namespace IPv4Calculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            InitializePropertiesPanel();
            InitializeClass();
        }

        #region IP Panel

        public IPv4Address ipAddress;
        private bool isSelectClass = true; //Determines user is selecting in Class ComboBox or not.
        private bool isValidIPAddress = true; //Determines current IP address user input is valid or not.
        private bool isValidSubnetMask = true; //Determines current Subnet mask user input is valid or not.

        public void InitializeClass()
        {
            cmbClass.Items.Add("A");
            cmbClass.Items.Add("B");
            cmbClass.Items.Add("C");
        }

        public void InitializePropertiesPanel()
        {
            foreach (ListViewItem item in lvwProperties.Items)
                item.SubItems.Add("");
        }

        public void UpdateIPv4Address()
        {
            try
            {
                ipAddress = new IPv4Address(txtIPv4Address.Text);

                isSelectClass = false;
                cmbClass.SelectedIndex = (int)ipAddress.Class;
                isSelectClass = !isSelectClass;

                isValidIPAddress = true;
                ipAddress.SubnetMask = new SubnetMask(cmbSubnetMask.Text);

                picIPAddress.Image = Resources.icon_ok_20;

                UpdatePropertiesPanel();
                UpdateSubnetBitmap();
            }
            catch
            {
                picIPAddress.Image = Resources.icon_warning_20;
                isValidIPAddress = false;
            }
            finally
            {
                UpdateSubnettingButton();
            }
        }

        public void UpdateSubnetMask()
        {
            try
            {
                SubnetMask subnetMask = new SubnetMask(cmbSubnetMask.Text);
                if (subnetMask.IsValid())
                {
                    ipAddress.SubnetMask = subnetMask;
                    numPrefix.Value = subnetMask.Prefix;

                    picSubnetMask.Image = Resources.icon_ok_20;
                    isValidSubnetMask = true;

                    UpdatePropertiesPanel();
                    UpdateSubnetBitmap();
                }
            }
            catch
            {
                picSubnetMask.Image = Resources.icon_warning_20;
                isValidSubnetMask = false;
            }
            finally
            {
                UpdateSubnettingButton();
            }
        }

        public void UpdatePrefix()
        {
            try
            {
                SubnetMask subnetMask = new SubnetMask((int)numPrefix.Value);
                ipAddress.SubnetMask = subnetMask;

                cmbSubnetMask.Text = subnetMask.ToString();
                UpdatePropertiesPanel();

                numSubnetBits.Maximum = 30 - numPrefix.Value;
                numNumberOfSubnets.Maximum = (decimal)Math.Pow(2, 30 - (double)numPrefix.Value);
                numHostPerSubnet.Maximum = (decimal)Math.Pow(2, 32 - (double)numPrefix.Value) - 2;
                UpdateSubnetBit();
                UpdateSubnetBitmap();

                picSubnetMask.Image = Resources.icon_ok_20;
            }
            catch { }
        }

        public void UpdateClass()
        {
            switch (cmbClass.SelectedIndex)
            {
                case 0:
                    ipAddress = isSelectClass ? new IPv4Address(IPv4Class.A) : new IPv4Address(txtIPv4Address.Text);
                    numPrefix.Minimum = 8;
                    break;
                case 1:
                    ipAddress = isSelectClass ? new IPv4Address(IPv4Class.B) : new IPv4Address(txtIPv4Address.Text);
                    numPrefix.Minimum = 16;
                    break;
                case 2:
                    ipAddress = isSelectClass ? new IPv4Address(IPv4Class.C) : new IPv4Address(txtIPv4Address.Text);
                    numPrefix.Minimum = 24;
                    break;
                default:
                    break;
            }
            numPrefix.Value = ipAddress.SubnetMask.Prefix;
            txtIPv4Address.Text = ipAddress.Address;

            UpdatePropertiesPanel();
            UpdateSubnetBitmap();

            //Update Subnetmask combobox items
            cmbSubnetMask.Items.Clear();
            SubnetMask temp = new SubnetMask();

            for (int i = SubnetMask.ToPrefix(ipAddress.Class); i < 31; i++)
            {
                temp.Prefix = i;
                cmbSubnetMask.Items.Add(temp.ToString());
            }
        }

        public void UpdatePropertiesPanel()
        {
            lvwProperties.Items[0].SubItems[1].Text = ipAddress.Address; //IP Address
            lvwProperties.Items[1].SubItems[1].Text = ipAddress.GetHexAddress(); //Hex Address
            lvwProperties.Items[2].SubItems[1].Text = ipAddress.SubnetMask.ToString(); //Subnet Mask
            lvwProperties.Items[3].SubItems[1].Text = ipAddress.WildcastMask.ToString(); //Wildcast Mask
            lvwProperties.Items[4].SubItems[1].Text = ipAddress.SubnetMask.Prefix.ToString(); //Prefix
            lvwProperties.Items[5].SubItems[1].Text = ToClass(ipAddress.Class); //Class
            lvwProperties.Items[6].SubItems[1].Text = ToFirstOctetRange(ipAddress.Class); //First Octet Range
            lvwProperties.Items[7].SubItems[1].Text = ipAddress.NetworkIDAddress().ToString(); //Network ID Address
        }

        private static string ToClass(IPv4Class ipClass)
        {
            switch (ipClass)
            {
                case IPv4Class.A:
                    return "A";
                case IPv4Class.B:
                    return "B";
                case IPv4Class.C:
                    return "C";
                case IPv4Class.D:
                    return "D";
                case IPv4Class.E:
                    return "E";
                default:
                    return null;
            }
        }

        private static string ToFirstOctetRange(IPv4Class ipClass)
        {
            switch (ipClass)
            {
                case IPv4Class.A:
                    return "1 - 127";
                case IPv4Class.B:
                    return "128 - 191";
                case IPv4Class.C:
                    return "192 - 223";
                case IPv4Class.D:
                    return "224 - 239";
                case IPv4Class.E:
                    return "240 - 255";
                default:
                    return null;
            }
        }

        #endregion

        #region Subnetting

        public void UpdateSubnetBit()
        {
            numNumberOfSubnets.Value = (decimal)Math.Pow(2, (double)numSubnetBits.Value);
            numHostPerSubnet.Value = (decimal)Math.Pow(2, 32 - (double)numSubnetBits.Value - (double)numPrefix.Value) - 2;
        }

        public void UpdateNumberOfSubnet()
        { 
            numSubnetBits.Value = (decimal)RoundUp(Math.Log((double)numNumberOfSubnets.Value, 2));
            numHostPerSubnet.Value = (decimal)Math.Pow(2, 32 - (double)numSubnetBits.Value - (double)numPrefix.Value) - 2;
        }

        public void UpdateHostPerSubnet()
        {
            numSubnetBits.Value = 32 - (decimal)Math.Log((double)numHostPerSubnet.Value, 2) - 2 - numPrefix.Value;
            numNumberOfSubnets.Value = (decimal)Math.Pow(2, (double)numSubnetBits.Value);
        }

        public void UpdateSubnettingButton()
        {
            btnSubnetting.Enabled = isValidIPAddress && isValidSubnetMask;
        }

        public static double RoundUp(double x)
        {
            return x - (int)x > 0 ? (int)x + 1 : x;
        }

        public void Subnetting()
        {
            int subnetBit = (int)numSubnetBits.Value;
            int numberSubnet = (int)numNumberOfSubnets.Value;
            int numberHost = (int)numHostPerSubnet.Value;

            NetworkRange subnet;
            IPv4Address networkID = ipAddress.NetworkIDAddress();

            lvwSubnetting.Items.Clear();

            for (int i = 1; i <= numberSubnet; i++)
            {
                lvwSubnetting.Items.Add(i.ToString());

                subnet = new NetworkRange(networkID, ipAddress.SubnetMask.Prefix, subnetBit);

                lvwSubnetting.Items[i - 1].SubItems.Add(subnet.NetworkIDAddress.ToString());
                lvwSubnetting.Items[i - 1].SubItems.Add((subnet.Prefix + subnet.SubnetBit).ToString());
                lvwSubnetting.Items[i - 1].SubItems.Add(subnet.NetworkIDAddress.NextAddress().ToString());
                lvwSubnetting.Items[i - 1].SubItems.Add(subnet.BroadcastAddress.PreviousAddress().ToString());
                lvwSubnetting.Items[i - 1].SubItems.Add(subnet.BroadcastAddress.ToString());

                networkID = subnet.BroadcastAddress.NextAddress();
            }

            UpdateSubnetBitmap();
        }
        #endregion

        #region Subnet Bitmap
        public static string ToSubnetBitmap(string binary, int prefix, int subnetBit, IPv4Class ipClass)
        {
            StringBuilder subnetBitmap = new StringBuilder(binary);

            for (int i = 31; i > 0; i--)
            {
                if (i > prefix + subnetBit - 1)
                    subnetBitmap[i] = 'H';
                else if (i > prefix - 1)
                    subnetBitmap[i] = 'S';
                else if (i > 2
                    || (i == 2 && ipClass < IPv4Class.C)
                    || (i == 1 && ipClass < IPv4Class.B))
                    subnetBitmap[i] = 'N';
            }

            return AddDotSeparator(subnetBitmap.ToString());
        }

        public static string AddDotSeparator(string binary)
        {
            for (int i = 24; i >= 8; i -= 8)
                binary = binary.Insert(i, ".");

            return binary;
        }

        public void UpdateSubnetBitmap()
        {
            if (isValidIPAddress && isValidSubnetMask)
                lblSubnetBitmap.Text = ToSubnetBitmap(ipAddress.ToBinaryString(),
                                ipAddress.SubnetMask.Prefix, (int)numSubnetBits.Value, ipAddress.Class);
        }

        #endregion

        #region Events
        private void txtIPv4Address_TextChanged(object sender, EventArgs e)
        {
            UpdateIPv4Address();
        }

        private void cmbSubnetMask_TextUpdate(object sender, EventArgs e)
        {
            UpdateSubnetMask();
        }

        private void numPrefix_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrefix();
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateClass();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbClass.SelectedIndex = 2;
            numSubnetBits.Value = 0;
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (((NumericUpDown)sender).Focused)
            {
                if (sender == numSubnetBits)
                {
                    UpdateSubnetBit();
                }
                else if (sender == numNumberOfSubnets)
                {
                    UpdateNumberOfSubnet();
                }
                else if (sender == numHostPerSubnet)
                {
                    UpdateHostPerSubnet();
                }
            }
            UpdateSubnetBitmap();
        }

        private void btnSubnetting_Click(object sender, EventArgs e)
        {
            Subnetting();
        }

        private void cmbSubnetMask_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSubnetMask();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Form about = new frmAbout();
            about.ShowDialog();
        }
        #endregion

    }
}
