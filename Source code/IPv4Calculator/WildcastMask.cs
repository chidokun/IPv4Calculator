/// IPv4 Calculator - A simple tool to subnetting IPv4 address
/// Copyright (c) 2015 - Nguyen Tuan
/// Email: nguyentuanit96@gmail.com
/// 
/// This is free software and I hope it will be useful.

namespace IPv4Calculator
{
    /// <summary>
    /// Represents wildcast mask of IPv4 addresses.
    /// </summary>
    public class WildcastMask : NetworkAddress
    {
        public WildcastMask() { }

        public WildcastMask(string addr) : base(addr) { }

        public SubnetMask ToSubnetMask()
        {
            SubnetMask subnet = new SubnetMask();

            for (int i = 0; i < _octet.Length; i++)
                subnet.Octet[i].Decimal = 255 - _octet[i].Decimal;

            return subnet;
        }
       
        public override bool IsValid()
        {
            byte[] temp = { 255, 254, 252, 248, 240, 224, 192, 128, 0 };
            bool isValid = true;
            foreach (Octet i in _octet)
            {
                bool octetValid = false;
                for (int j = 0; j < temp.Length; j++)
                {
                    if (i.Decimal == 255 - temp[j])
                        octetValid = true;
                }
                isValid &= octetValid;
            }

            return isValid;
        }
    }
}
