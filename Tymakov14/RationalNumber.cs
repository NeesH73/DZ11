using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov14
{
    [DeveloperInfo1("Игнат", "05.12.2023")]
    internal class RationalNumber
    {
        private int numerator;
        private int denominator;

        public RationalNumber(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0)
                    throw new ArgumentException("Знаменатель не может быть равен нулю");
                denominator = value;
            }
        }
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
        public static bool operator <(RationalNumber num1, RationalNumber num2)
        {
            return num1.numerator * num2.denominator < num2.numerator * num1.denominator;
        }

        public static bool operator >(RationalNumber num1, RationalNumber num2)
        {
            return num1.numerator * num2.denominator > num2.numerator * num1.denominator;
        }

        public static bool operator <=(RationalNumber num1, RationalNumber num2)
        {
            return num1.numerator * num2.denominator <= num2.numerator * num1.denominator;
        }

        public static bool operator >=(RationalNumber num1, RationalNumber num2)
        {
            return num1.numerator * num2.denominator >= num2.numerator * num1.denominator;
        }

        public static RationalNumber operator +(RationalNumber num1, RationalNumber num2)
        {
            int newNumerator = num1.numerator * num2.denominator + num2.numerator * num1.denominator;
            int newDenominator = num1.denominator * num2.denominator;
            return new RationalNumber(newNumerator, newDenominator);
        }

        public static RationalNumber operator -(RationalNumber num1, RationalNumber num2)
        {
            int newNumerator = num1.numerator * num2.denominator - num2.numerator * num1.denominator;
            int newDenominator = num1.denominator * num2.denominator;
            return new RationalNumber(newNumerator, newDenominator);
        }
        public static RationalNumber operator ++(RationalNumber num)
        {
            return new RationalNumber(num.numerator + num.denominator, num.denominator);
        }
        public static RationalNumber operator --(RationalNumber num)
        {
            return new RationalNumber(num.numerator - num.denominator, num.denominator);
        }
        public static explicit operator float(RationalNumber num)
        {
            return (float)num.numerator / num.denominator;
        }

        public static explicit operator int(RationalNumber num)
        {
            return num.numerator / num.denominator;
        }

        public static RationalNumber operator *(RationalNumber num1, RationalNumber num2)
        {
            int newNumerator = num1.numerator * num2.numerator;
            int newDenominator = num1.denominator * num2.denominator;
            return new RationalNumber(newNumerator, newDenominator);
        }

        public static RationalNumber operator /(RationalNumber num1, RationalNumber num2)
        {
            int newNumerator = num1.numerator * num2.denominator;
            int newDenominator = num1.denominator * num2.numerator;
            return new RationalNumber(newNumerator, newDenominator);
        }

        public static int operator %(RationalNumber num1, RationalNumber num2)
        {
            RationalNumber rationalNumber = num1 / num2;

            return (rationalNumber.numerator % rationalNumber.denominator);
        }
    }
}
