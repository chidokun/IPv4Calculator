using System;
using System.Text;

namespace IPv4Calculator
{
    /// <summary>
    /// Represents mask of network addresses.
    /// </summary>
    public class NetworkMask
    {
        private SubnetMask _subnetMask;

        private WildcastMask _wildcastMask;

        /// <summary>
        /// Gets or sets subnet mask.
        /// </summary>
        public SubnetMask SubnetMask
        {
            get { return _subnetMask; }
            set
            {
                _subnetMask = value;
                _wildcastMask = _subnetMask.ToWildcastMask();
            }
        }

        /// <summary>
        /// Gets wildcast mask.
        /// </summary>
        public WildcastMask WildcastMask
        {
            get { return _wildcastMask; }
        }

        /// <summary>
        /// Gets of sets prefix number. Prefix is a positive integer number less than 32.
        /// </summary>
        public int Prefix
        {
            get { return SubnetMask.Prefix; }
            set
            {
                _subnetMask = new SubnetMask(value);
                _wildcastMask = _subnetMask.ToWildcastMask();
            }
        }

        /// <summary>
        /// Initialize instance with network prefix.
        /// </summary>
        /// <param name="prefix">Prefix number less than 32.</param>
        public NetworkMask(int prefix = 0)
        {
            Prefix = prefix;
        }

        /// <summary>
        /// Initialize instance with subnet mask.
        /// </summary>
        /// <param name="subnetMask">A string of subnet mask. It looks like 255.255.255.192.</param>
        public NetworkMask(string subnetMask)
        {
            _subnetMask.Octet = NetworkAddress.ToOctet(subnetMask);
        }

        /// <summary>
        /// Initialize instance with array of octets of IP Address.
        /// </summary>
        /// <param name="ipAddress">Array of octets of IP Address.</param>
        public NetworkMask(Octet[] ipAddress)
        {
            int n = ipAddress[0].Decimal;
            if (n < 128)
                Prefix = 8;
            else if (n < 192)
                Prefix = 16;
            else if (n < 224)
                Prefix = 24;
            else
                Prefix = 32;
        }

        /// <summary>
        /// Initialize instance with subnet mask object.
        /// </summary>
        /// <param name="subnetMask"></param>
        public NetworkMask(SubnetMask subnetMask)
        {
            SubnetMask = subnetMask;
        }
    }
}
