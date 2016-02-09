/// IPv4 Calculator - A simple tool to subnetting IPv4 address
/// Copyright (c) 2015 - Nguyen Tuan
/// Email: nguyentuanit96@gmail.com
/// 
/// This is free software and I hope it will be useful.

using System;

namespace IPv4Calculator
{
    /// <summary>
    /// Represents octet in IPv4 address.
    /// </summary>
    public class Octet
    {
        private string _binaryValue;
        private int _decimalValue;

        /// <summary>
        /// Represents binary value of octet.
        /// </summary>
        public string Binary
        {
            get { return _binaryValue; }
            set
            {
                if (!IsValid(value))
                    throw new Exception();
                else
                    _binaryValue = value;
                _decimalValue = ToDecimal(_binaryValue);
            }
        }

        /// <summary>
        /// Represent decimal value of octet.
        /// </summary>
        public int Decimal
        {
            get { return _decimalValue; }
            set
            {
                if (!IsValid(value))
                    throw new ArgumentOutOfRangeException("Decimal value must be between 0 and 32.");
                else
                    _decimalValue = value;
                _binaryValue = ToBinary(_decimalValue);
            }
        }

        /// <summary>
        /// Initialize octet.
        /// </summary>
        /// <param name="octet">An integer value less than 256.</param>
        public Octet(int octet = 0)
        {
            Decimal = octet;
        }

        /// <summary>
        /// Initialize octet.
        /// </summary>
        /// <param name="octet">A binary string less than 9 characters.</param>
        public Octet(string octet)
        {
            Binary = octet;
        }

        /// <summary>
        /// Convert an integer value to string of binary value.
        /// </summary>
        /// <param name="n">An integer value less than 256.</param>
        /// <returns></returns>
        private string ToBinary(int n)
        {
            string result = "";
            while (n > 0)
            {
                result = (n % 2).ToString() + result;
                n /= 2;
            }
            while (result.Length < 8)
                result = "0" + result;

            return result;
        }

        /// <summary>
        /// Convert a binary string to decimal value.
        /// </summary>
        /// <param name="binary">A binary string less than 9 characters.</param>
        /// <returns></returns>
        private int ToDecimal(string binary)
        {
            int result = 0, pow = 1;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                result += (binary[i] - '0') * pow;
                pow *= 2;
            }
            return result;
        }

        /// <summary>
        /// Checks if an octet value is valid.
        /// </summary>
        /// <param name="binary">A string of binary value.</param>
        /// <returns></returns>
        public static bool IsValid(string binary)
        {
            if (binary.Length >= 0 && binary.Length <= 8)
            {
                for (int i = 0; i < binary.Length; i++)
                    if (!(binary[i] == '1' || binary[i] == '0'))
                        return false;
            }
            else
                return false;

            return true;
        }

        /// <summary>
        /// Checks if an octet value is valid.
        /// </summary>
        /// <param name="intNumber">Decimal value of octet.</param>
        /// <returns></returns>
        public static bool IsValid(int intNumber)
        {
            return !(intNumber < 0 || intNumber > 255);
        }

        /// <summary>
        /// Checks if current instance is valid.
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            return IsValid(Decimal) && IsValid(Binary);
        }
    }
}
