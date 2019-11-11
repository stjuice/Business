using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public struct Fraction
    {
        public int numenator;
        public int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numenator = numerator;
            this.denominator = denominator;
        }
    }
    public class RegularFraction
    {
        public Fraction Fraction { get; set; }

        public RegularFraction(int num, int den)
        {
            if (den == 0)
                throw new ArgumentException("Denominator cannot be a zero");

            Fraction = new Fraction(num, den);
        }

        public int GetNumerator() => Fraction.numenator;

        public int GetDenominator() => Fraction.denominator;

        public string GetFraction()
        {
            var numenator = GetNumerator();
            var denominator = GetDenominator();
            int num;

            var gcd = new int[] { numenator, denominator }.Aggregate(GCD);

            if (numenator > denominator)
            {
                num = numenator / denominator;
                numenator %= denominator;
                return $"{num} {numenator}/{denominator}";
            }

            if (gcd == 1)
                return $"{numenator}/{denominator}";

            numenator /= gcd;
            denominator /= gcd;

            return $"{numenator}/{denominator}";
        }

        static int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);

        public static RegularFraction operator +(RegularFraction fraction1, RegularFraction fraction2)
        {
            var num1 = fraction1.GetNumerator();
            var den1 = fraction1.GetDenominator();

            var num2 = fraction2.GetNumerator();
            var den2 = fraction2.GetDenominator();

            var num = num1 * den2 + num2 * den1;
            var den = den2 * den1;

            return new RegularFraction(num, den);
        }

        public static RegularFraction operator -(RegularFraction fraction1, RegularFraction fraction2)
        {
            var num1 = fraction1.GetNumerator();
            var den1 = fraction1.GetDenominator();

            var num2 = fraction2.GetNumerator();
            var den2 = fraction2.GetDenominator();

            var num = num1 * den2 - num2 * den1;
            var den = den2 * den1;

            return new RegularFraction(num, den);
        }

        public static RegularFraction operator *(RegularFraction fraction1, RegularFraction fraction2)
        {
            var num1 = fraction1.GetNumerator();
            var den1 = fraction1.GetDenominator();

            var num2 = fraction2.GetNumerator();
            var den2 = fraction2.GetDenominator();

            var num = num1 * num2;
            var den = den1 * den2;

            return new RegularFraction(num, den);
        }

        public static RegularFraction operator /(RegularFraction fraction1, RegularFraction fraction2)
        {
            var num1 = fraction1.GetNumerator();
            var den1 = fraction1.GetDenominator();

            var num2 = fraction2.GetNumerator();
            var den2 = fraction2.GetDenominator();

            var num = num1 * den2;
            var den = den1 * num2;

            return new RegularFraction(num, den);
        }

        public static bool operator >(RegularFraction fraction1, RegularFraction fraction2)
        {
            var num1 = fraction1.GetNumerator();
            var den1 = fraction1.GetDenominator();

            var num2 = fraction2.GetNumerator();
            var den2 = fraction2.GetDenominator();

            var res = num1 * den2 > num2 * den1;

            return res;
        }

        public static bool operator <(RegularFraction fraction1, RegularFraction fraction2) => !(fraction1 > fraction2);

        public static bool operator ==(RegularFraction fraction1, RegularFraction fraction2)
        {
            var num1 = fraction1.GetNumerator();
            var den1 = fraction1.GetDenominator();

            var num2 = fraction2.GetNumerator();
            var den2 = fraction2.GetDenominator();

            var res = num1 * den2 == num2 * den1;

            return res;
        }

        public static bool operator !=(RegularFraction fraction1, RegularFraction fraction2) => !(fraction1 == fraction2);
    }
}
