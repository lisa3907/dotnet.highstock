using System;
using System.Globalization;

namespace DotNet.Highstock.Helpers
{
    public struct Number : IComparable
    {
        double? _DoubleNumber;
        int? _IntNumber;

        Number(double value)
        {
            _DoubleNumber = value;
            _IntNumber = null;
        }

        Number(int value)
        {
            _IntNumber = value;
            _DoubleNumber = null;
        }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            if (_DoubleNumber == null && _IntNumber == null)
                throw new ArgumentException("The number is not correct.");

            if (obj == null) return 1;

            IComparable comparer = _DoubleNumber ?? _IntNumber;
            Number objectNumber = (Number)obj;
            return comparer.CompareTo(objectNumber._DoubleNumber ?? objectNumber._IntNumber);
        }

        #endregion

        public static implicit operator Number(double value) { return new Number(value); }
        public static implicit operator Number(int value) { return new Number(value); }

        public static Number? GetNumber(object o)
        {
            if (o is int)
                return new Number((int)o);
            if (o is double)
                return new Number((double)o);
            return null;
        }

        public static implicit operator int?(Number a)
        {
            if (a._IntNumber.HasValue)
                return a._IntNumber.Value;
            if (a._DoubleNumber.HasValue)
                return Convert.ToInt32(a._DoubleNumber.Value);
            return null;
        }

        public static implicit operator double?(Number a)
        {
            if (a._DoubleNumber.HasValue)
                return a._DoubleNumber;
            if (a._IntNumber.HasValue)
                return Convert.ToDouble(a._IntNumber.Value);
            return null;
        }

        public override string ToString()
        {
            if (_DoubleNumber.HasValue)
                return _DoubleNumber.Value.ToString(CultureInfo.InvariantCulture);
            if (_IntNumber.HasValue)
                return _IntNumber.Value.ToString(CultureInfo.InvariantCulture);
            return String.Empty;
        }
    }
}