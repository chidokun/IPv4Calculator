/// IPv4 Calculator - A simple tool to subnetting IPv4 address
/// Copyright (c) 2015 - Nguyen Tuan
/// Email: nguyentuanit96@gmail.com
/// 
/// This is free software and I hope it will be useful.

using System;

namespace IPv4Calculator
{
    /// <summary>
    /// Represents subnet mask of IPv4 addresses.
    /// </summary>
    public class SubnetMask : NetworkAddress
    {
        private int _prefix;

        /// <summary>
        /// Gets or sets prefix number. Prefix is a positive integer number less than 32.
        /// </summary>
        public int Prefix
        {
            get { return _prefix; }
            set
            {
                if (!IsValid(value))
                    throw new ArgumentOutOfRangeException("Prefix number must be between 0 and 32.");
                else
                {
                    _prefix = value;
                    Octet = ToOctet(_prefix);
                }
            }
        }

        /// <summary>
        /// Initialize subnet mask with IPv4 class.
        /// </summary>
        /// <param name="ipClass">IPv4 class.</param>
        public SubnetMask(IPv4Class ipClass = IPv4Class.A)
        {
            switch (ipClass)
            {
                case IPv4Class.A:
                    Prefix = 8;
                    break;
                case IPv4Class.B:
                    Prefix = 16;
                    break;
                case IPv4Class.C:
                    Prefix = 24;
                    break;
                default:
                    Prefix = 32;
                    break;
            }
        }

        /// <summary>
        /// Initialize subnet mask with string of IPv4 address.
        /// </summary>
        /// <param name="addr">A string of IPv4 address</param>
        public SubnetMask(string addr) : base(addr)
        {
            if (IsValid())
                Prefix = ToPrefix(addr);
        }

        /// <summary>
        /// Initialize subnet mask with prefix number.
        /// </summary>
        /// <param name="prefix">A positive integer number less than 32.</param>
        public SubnetMask(int prefix)
        {
            Prefix = prefix;
        }

        /// <summary>
        /// Converts current instance to wildcast mask.
        /// </summary>
        /// <returns></returns>
        public WildcastMask ToWildcastMask()
        {
            WildcastMask wildcast = new WildcastMask();

            for (int i = 0; i < _octet.Length; i++)
                wildcast.Octet[i].Decimal = 255 - _octet[i].Decimal;

            return wildcast;
        }

        /// <summary>
        /// Convert prefix number to octets array.
        /// </summary>
        /// <param name="prefix">Prefix number is less than 32.</param>
        /// <returns></returns>
        public static Octet[] ToOctet(int prefix)
        {
            Octet[] subnetOctet = new Octet[4];
            byte[] temp = { 0, 128, 192, 224, 240, 248, 252, 254, 255 };

            for (int i = 0; i < subnetOctet.Length; i++)
            {
                if (prefix > 8)
                {
                    subnetOctet[i] = new Octet(255);
                    prefix -= 8;
                }
                else
                {
                    subnetOctet[i] = new Octet(temp[prefix]);
                    prefix = 0;
                }
            }

            return subnetOctet;
        }

        /// <summary>
        /// Converts from string of subnet mask to prefix
        /// </summary>
        /// <param name="subnet">A string of subnet mask looks like 255.255.0.0</param>
        /// <returns></returns>
        public static int ToPrefix(string subnet)
        {
            Octet[] subnetOctet = new Octet[4];
            subnetOctet = ToOctet(subnet);

            int prefix = 0;
            byte[] temp = { 0, 128, 192, 224, 240, 248, 252, 254, 255 };

            foreach (Octet i in subnetOctet)
                for (int j = 0; j < temp.Length; j++)
                    if (i.Decimal == temp[j])
                        prefix += j;

            return prefix;
        }

        /// <summary>
        /// Convert IPv4Class to default prefix number.
        /// </summary>
        /// <param name="ipClass">IPv4 class.</param>
        /// <returns></returns>
        public static int ToPrefix(IPv4Class ipClass)
        {
            switch (ipClass)
            {
                case IPv4Class.A:
                    return 8;
                case IPv4Class.B:
                    return 16;
                case IPv4Class.C:
                    return 24;
                case IPv4Class.D:
                    return 32;
                case IPv4Class.E:
                    return 32;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Checks if prefix number is valid.
        /// </summary>
        /// <param name="prefix">Prefix number.</param>
        /// <returns></returns>
        public static bool IsValid(int prefix)
        {
            return !(prefix < 0 || prefix > 32);
        }

        /// <summary>
        /// Checks if current instance of subnet mask is valid.
        /// </summary>
        /// <returns></returns>
        public override bool IsValid()
        {
            byte[] temp = { 255, 254, 252, 248, 240, 224, 192, 128, 0 };
            bool isValid = true;
            for (int  i=0;i<_octet.Length;i++)
            {
                bool octetValid = false;
                for (int j = 0; j < temp.Length; j++)
                {
                    if (_octet[i].Decimal == temp[j])
                        octetValid = true;
                }
                isValid &= octetValid;
            }

            return isValid;
        }
    }
}
