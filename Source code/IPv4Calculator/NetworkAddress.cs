/// IPv4 Calculator - A simple tool to subnetting IPv4 address
/// Copyright (c) 2015 - Nguyen Tuan
/// Email: nguyentuanit96@gmail.com
/// 
/// This is free software and I hope it will be useful.

namespace IPv4Calculator
{
    /// <summary>
    /// Represents base class for address.
    /// </summary>
    public abstract class NetworkAddress
    {
        protected Octet[] _octet = new Octet[4];

        /// <summary>
        /// Gets or sets array of octets.
        /// </summary>
        public Octet[] Octet
        {
            get { return _octet; }
            set { _octet = value; }
        }

        /// <summary>
        /// Initialize address with default value.
        /// </summary>
        public NetworkAddress()
        {
            for (int i = 0; i < _octet.Length; i++)
                _octet[i] = new Octet();
        }

        /// <summary>
        /// Initialize address with decimal value of octets.
        /// </summary>
        /// <param name="octet1">The first octet.</param>
        /// <param name="octet2">The second octet.</param>
        /// <param name="octet3">The third octet.</param>
        /// <param name="octet4">The fourth octet.</param>
        public NetworkAddress(int octet1, int octet2, int octet3, int octet4)
        {
            Octet = ToOctet(octet1, octet2, octet3, octet4);
        }

        /// <summary>
        /// Initialize address with string of address.
        /// </summary>
        /// <param name="addr">A string of address looks like 192.168.0.1 or 255.255.255.0</param>
        public NetworkAddress(string addr)
        {
            Octet = ToOctet(addr);
        }

        /// <summary>
        /// Converts a string of address to octet array.
        /// </summary>
        /// <param name="addr">A string of address look like 192.168.0.192</param>
        /// <returns></returns>
        public static Octet[] ToOctet(string addr)
        {
            Octet[] octet = new Octet[4];

            for (int i = 0; i < octet.Length; i++)
            {
                int index = addr.IndexOf('.');
                if (index != -1)
                {
                    octet[i] = new Octet(int.Parse(addr.Substring(0, index)));
                    addr = addr.Substring(index + 1);
                }
                else
                {
                    octet[i] = new Octet(int.Parse(addr));
                    addr = null;
                }
            }

            return octet;
        }

        /// <summary>
        /// Converts a 32-bit binary string to octet array
        /// </summary>
        /// <param name="binaryString">32-bit binary string.</param>
        /// <returns></returns>
        public static Octet[] ToOctetFromBinaryString(string binaryString)
        {
            Octet[] octet = new Octet[4];
            int i = 0;
            for (int index = 0; index < octet.Length; index++)
            {
                octet[index] = new Octet(binaryString.Substring(i, 8));
                i += 8;
            }

            return octet;
        }

        /// <summary>
        /// Converts decimal values of octets to octet array.
        /// </summary>
        /// <param name="octet1">The first octet.</param>
        /// <param name="octet2">The second octet.</param>
        /// <param name="octet3">The third octet.</param>
        /// <param name="octet4">The fourth octet.</param>
        /// <returns></returns>
        public static Octet[] ToOctet(int octet1, int octet2, int octet3, int octet4)
        {
            Octet[] octet = new Octet[4];

            octet[0] = new Octet(octet1);
            octet[1] = new Octet(octet2);
            octet[2] = new Octet(octet3);
            octet[3] = new Octet(octet4);

            return octet;
        }

        /// <summary>
        /// Sets address with decimal value of octets.
        /// </summary>
        /// <param name="octet1">The first octet.</param>
        /// <param name="octet2">The second octet.</param>
        /// <param name="octet3">The third octet.</param>
        /// <param name="octet4">The fourth octet.</param>
        public virtual void SetAddress(int octet1, int octet2, int octet3, int octet4)
        {
            _octet[0].Decimal = octet1;
            _octet[1].Decimal = octet2;
            _octet[2].Decimal = octet3;
            _octet[3].Decimal = octet4;
        }

        /// <summary>
        /// Gets 32-bit binary string of current instance of network address.
        /// </summary>
        /// <returns></returns>
        public string ToBinaryString()
        {
            string binary = "";
            foreach (Octet i in _octet)
                binary += i.Binary;

            return binary;
        }

        /// <summary>
        /// Gets string of network address. It looks like 192.168.0.1.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string addr = "";
            foreach (Octet i in _octet)
                addr += i.Decimal.ToString() + ".";

            return addr.Substring(0, addr.Length - 1);
        }

        /// <summary>
        /// Check if current network address is valid.
        /// </summary>
        /// <returns></returns>
        public virtual bool IsValid()
        {
            foreach (var item in _octet)
            {
                if (!item.IsValid())
                    return false;
            }

            return true;
        }
    }
}
