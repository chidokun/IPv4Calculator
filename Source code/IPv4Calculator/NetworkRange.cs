/// IPv4 Calculator - A simple tool to subnetting IPv4 address
/// Copyright (c) 2015 - Nguyen Tuan
/// Email: nguyentuanit96@gmail.com
/// 
/// This is free software and I hope it will be useful.

using System.Text;

namespace IPv4Calculator
{
    /// <summary>
    /// Represents a range of IPv4 addresses.
    /// </summary>
    public class NetworkRange
    {
        private IPv4Address _networkIDAddress;

        private int _prefix;

        private int _subnetBit;

        private IPv4Class _class;

        #region Properties
        /// <summary>
        /// Gets or sets network address as known as Network ID.
        /// </summary>
        public IPv4Address NetworkIDAddress
        {
            get { return _networkIDAddress; }
            set { _networkIDAddress = value; }
        }

        /// <summary>
        /// Gets broadcast address.
        /// </summary>
        public IPv4Address BroadcastAddress
        {
            get { return ToBroadcastAddress(); }
        }

        /// <summary>
        /// Gets or sets prefix number of original address.
        /// </summary>
        public int Prefix
        {
            get { return _prefix; }
            set { _prefix = value; }
        }

        /// <summary>
        /// Gets or sets borrowed bits.
        /// </summary>
        public int SubnetBit
        {
            get { return _subnetBit; }
            set { _subnetBit = value; }
        }

        /// <summary>
        /// Gets or sets class of network range
        /// </summary>
        public IPv4Class Class
        {
            get { return _class; }
            set { _class = value; }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Initialize network range.
        /// </summary>
        /// <param name="networkAddr">Network address.</param>
        /// <param name="broadcastAddr">Broadcast address.</param>
        /// <param name="prefix">Prefix number is less than 32.</param>
        /// <param name="subnetBit">Borrowed bits.</param>
        /// <param name="ipClass">Class of IPv4 address.</param>
        public NetworkRange(IPv4Address networkAddr, IPv4Address broadcastAddr, int prefix, int subnetBit, IPv4Class ipClass)
        {
            NetworkIDAddress = networkAddr;
            Prefix = prefix;
            SubnetBit = subnetBit;
            Class = ipClass;
        }

        /// <summary>
        /// Initialize network range.
        /// </summary>
        /// <param name="networkAddr">Network address.</param>
        /// <param name="prefix">Prefix number is less than 32.</param>
        /// <param name="subnetBit">Class of IPv4 address.</param>
        public NetworkRange(IPv4Address networkAddr, int prefix, int subnetBit)
        {
            NetworkIDAddress = networkAddr;
            Prefix = prefix;
            SubnetBit = subnetBit;
            Class = NetworkIDAddress.Class;
        }

        #endregion
        /// <summary>
        /// Returns broadcast address of current network range.
        /// </summary>
        /// <returns></returns>
        private IPv4Address ToBroadcastAddress()
        {
            StringBuilder binNetworkAddr = new StringBuilder(_networkIDAddress.ToBinaryString());

            for (int i = _prefix + _subnetBit; i < 32; i++)
                binNetworkAddr[i] = '1';

            IPv4Address broadcast = new IPv4Address(IPv4Address.ToOctetFromBinaryString(binNetworkAddr.ToString()),
                                                        new SubnetMask(_prefix + _subnetBit), _class);

            return broadcast;
        }
    }
}
