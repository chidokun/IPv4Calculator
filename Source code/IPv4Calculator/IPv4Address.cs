/// IPv4 Calculator - A simple tool to subnetting IPv4 address
/// Copyright (c) 2015 - Nguyen Tuan
/// Email: nguyentuanit96@gmail.com
/// 
/// This is free software and I hope it will be useful.

using System.Text;

namespace IPv4Calculator
{
    /// <summary>
    /// Represents class of IPv4 addresses.
    /// </summary>
    public enum IPv4Class { A, B, C, D, E }

    public class IPv4Address : NetworkAddress
    {
        private NetworkMask _mask = new NetworkMask();

        private IPv4Class _class;

        #region Properties

        /// <summary>
        /// Gets or sets a string of IPv4 address. It looks like 192.168.0.0.
        /// </summary>
        public string Address
        {
            get { return ToString(); }
            set
            {
                Octet = ToOctet(value);
                _mask = new NetworkMask(_octet);
                _class = ToNetworkClass(_octet);
            }
        }

        /// <summary>
        /// Gets class of current instance of IPv4 address.
        /// </summary>
        public IPv4Class Class
        {
            get { return _class; }          
        }

        /// <summary>
        /// Gets or sets subnet mask of current instance of IPv4 address.
        /// </summary>
        public SubnetMask SubnetMask
        {
            get { return _mask.SubnetMask; }
            set { _mask.SubnetMask = value; }
        }

        /// <summary>
        /// Gets wildcast mask of current instance of IPv4 address.
        /// </summary>
        public WildcastMask WildcastMask
        {
            get { return _mask.WildcastMask; }
        }
        #endregion

        #region Constructor

        /// <summary>
        /// Initialize IPv4 address
        /// </summary>
        /// <param name="addr">A string of IPv4 address. It looks like 192.168.0.0.</param>
        public IPv4Address(string addr) : base(addr)
        {
            _mask = new NetworkMask(_octet);
            _class = ToNetworkClass(_octet);
        }

        /// <summary>
        /// Initialize IPv4 address
        /// </summary>
        /// <param name="addr">A string of IPv4 address. It looks like 192.168.0.0.</param>
        /// <param name="subnetMask">A string of subnet mask of IPv4 address. It looks like 255.255.255.0.</param>
        public IPv4Address(string addr, string subnetMask) : base(addr)
        {
            _mask = new NetworkMask(subnetMask);
            _class = ToNetworkClass(_octet);
        }

        /// <summary>
        /// Initialize IPv4 address
        /// </summary>
        /// <param name="addr">A string of IPv4 address. It looks like 192.168.0.0.</param>
        /// <param name="subnetMask">A string of subnet mask of IPv4 address. It looks like 255.255.255.0.</param>
        /// <param name="ipClass">Class of IPv4 address.</param>
        public IPv4Address(string addr, string subnetMask, IPv4Class ipClass) : base(addr)
        {
            _mask = new NetworkMask(subnetMask);
            _class = ipClass;
        }

        /// <summary>
        /// Initialize IPv4 address
        /// </summary>
        /// <param name="addr">A string of IPv4 address. It looks like 192.168.0.0.</param>
        /// <param name="prefix">An integer number less than 32.</param>
        public IPv4Address(string addr, int prefix) : base(addr)
        {
            _mask = new NetworkMask(prefix);
            _class = ToNetworkClass(_octet);
        }

        /// <summary>
        /// Initialize IPv4 address
        /// </summary>
        /// <param name="addr">A string of IPv4 address. It looks like 192.168.0.0.</param>
        /// <param name="prefix">An integer number less than 32.</param>
        /// <param name="ipClass">Class of IPv4 address.</param>
        public IPv4Address(string addr, int prefix, IPv4Class ipClass) : base(addr)
        {
            _mask = new NetworkMask(prefix);
            _class = ipClass;
        }

        /// <summary>
        /// Initialize IPv4 address
        /// </summary>
        /// <param name="octet1">The first octet.</param>
        /// <param name="octet2">The second octet.</param>
        /// <param name="octet3">The third octet.</param>
        /// <param name="octet4">The fourth octet.</param>
        public IPv4Address(int octet1, int octet2, int octet3, int octet4) : base(octet1, octet2, octet3, octet4)
        {
            _mask = new NetworkMask(_octet);
            _class = ToNetworkClass(_octet);
        }

        /// <summary>
        /// Initialize IPv4 address
        /// </summary>
        /// <param name="addr">An array of octet of IPv4 address.</param>
        /// <param name="subnetMask">Subnet mask of IPv4 address.</param>
        /// <param name="ipClass">Class of IPv4 address.</param>
        public IPv4Address(Octet[] addr, SubnetMask subnetMask, IPv4Class ipClass)
        {
            Octet = addr;
            _mask = new NetworkMask(subnetMask);
            _class = ipClass;
        }

        /// <summary>
        /// Initialize IPv4 address with IPv4 class.
        /// </summary>
        /// <param name="ipClass">Class of IPv4 address.</param>
        public IPv4Address(IPv4Class ipClass)
        {
            _class = ipClass;
            switch (_class)
            {
                case IPv4Class.A:
                    Octet = ToOctet(1, 0, 0, 0);
                    _mask = new NetworkMask(8);
                    break;
                case IPv4Class.B:
                    Octet = ToOctet(128, 0, 0, 0);
                    _mask = new NetworkMask(16);
                    break;
                case IPv4Class.C:
                    Octet = ToOctet(192, 0, 0, 0);
                    _mask = new NetworkMask(24);
                    break;
                case IPv4Class.D:
                    Octet = ToOctet(224, 0, 0, 0);
                    _mask = new NetworkMask(32);
                    break;
                case IPv4Class.E:
                    Octet = ToOctet(240, 0, 0, 0);
                    _mask = new NetworkMask(32);
                    break;
                default:
                    break;
            }
        }

        #endregion

        /// <summary>
        /// Determines IPv4 class of an array of octets.
        /// </summary>
        /// <param name="ipAddr">An array of octets of IPv4 address.</param>
        /// <returns></returns>
        public static IPv4Class ToNetworkClass(Octet[] ipAddr)
        {
            int n = ipAddr[0].Decimal;
            if (n < 128)
                return IPv4Class.A;
            else if (n < 192)
                return IPv4Class.B;
            else if (n < 224)
                return IPv4Class.C;
            else if (n < 240)
                return IPv4Class.D;
            else
                return IPv4Class.E;
        }

        /// <summary>
        /// Sets address with decimal value of octets.
        /// </summary>
        /// <param name="octet1">The first octet.</param>
        /// <param name="octet2">The second octet.</param>
        /// <param name="octet3">The third octet.</param>
        /// <param name="octet4">The fourth octet.</param>
        public override void SetAddress(int octet1, int octet2, int octet3, int octet4)
        {
            base.SetAddress(octet1, octet2, octet3, octet4);

            _mask = new NetworkMask(_octet);
            _class = ToNetworkClass(_octet);
        }

        /// <summary>
        /// Gets string of hexadecimal value of IPv4 address.
        /// </summary>
        /// <returns></returns>
        public string GetHexAddress()
        {
            string hex = "";
            foreach (Octet item in _octet)
                hex += string.Format("{0:X2}.", item.Decimal);

            return hex.Substring(0, hex.Length - 1);
        }

        /// <summary>
        /// Find the next address of current IPv4 address.
        /// </summary>
        /// <returns></returns>
        public IPv4Address NextAddress()
        {
            IPv4Address nextAddr;
            nextAddr = new IPv4Address(Octet[0].Decimal, Octet[1].Decimal, Octet[2].Decimal, Octet[3].Decimal);

            for (int i = nextAddr.Octet.Length - 1; i >= 0; i--)
            {
                if (nextAddr.Octet[i].Decimal < 255)
                {
                    nextAddr.Octet[i].Decimal++;
                    break;
                }                 
                else
                    nextAddr.Octet[i].Decimal = 0;
            }

            return nextAddr;
        }

        /// <summary>
        /// Find the previous address of current IPv4 address.
        /// </summary>
        /// <returns></returns>
        public IPv4Address PreviousAddress()
        {
            IPv4Address nextAddr;
            nextAddr = new IPv4Address(Octet[0].Decimal, Octet[1].Decimal, Octet[2].Decimal, Octet[3].Decimal);

            for (int i = nextAddr.Octet.Length - 1; i >= 0; i--)
            {
                if (nextAddr.Octet[i].Decimal > 0)
                {
                    nextAddr.Octet[i].Decimal--;
                    break;
                }                    
                else
                    nextAddr.Octet[i].Decimal = 255;
            }

            return nextAddr;
        }

        public IPv4Address NetworkIDAddress()
        {
            StringBuilder binNetworkIDAddr = new StringBuilder(ToBinaryString());

            for (int i = SubnetMask.Prefix; i < 32; i++)
                binNetworkIDAddr[i] = '0';

            IPv4Address networkIDAddr = new IPv4Address(IPv4Address.ToOctetFromBinaryString(binNetworkIDAddr.ToString()),
                                                        SubnetMask, _class);

            return networkIDAddr;
        }
    }
}
