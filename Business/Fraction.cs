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

        public int GetNumerator() => numenator;

        public int GetDenominator() => denominator;

        public override string ToString()
        {
            int num;

            var gcd = new int[] { numenator, denominator }.Aggregate(GreatestCommonDivisor);

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

        static int GreatestCommonDivisor(int a, int b) => b == 0 ? a : GreatestCommonDivisor(b, a % b);

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            var num1 = fraction1.GetNumerator();
            var den1 = fraction1.GetDenominator();

            var num2 = fraction2.GetNumerator();
            var den2 = fraction2.GetDenominator();

            var num = num1 * den2 + num2 * den1;
            var den = den2 * den1;

            return new Fraction(num, den);
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            var num1 = fraction1.GetNumerator();
            var den1 = fraction1.GetDenominator();

            var num2 = fraction2.GetNumerator();
            var den2 = fraction2.GetDenominator();

            var num = num1 * den2 - num2 * den1;
            var den = den2 * den1;

            return new Fraction(num, den);
        }

        public static Fraction operator *(Fraction fraction1, Fraction fraction2)
        {
            var num1 = fraction1.GetNumerator();
            var den1 = fraction1.GetDenominator();

            var num2 = fraction2.GetNumerator();
            var den2 = fraction2.GetDenominator();

            var num = num1 * num2;
            var den = den1 * den2;

            return new Fraction(num, den);
        }

        public static Fraction operator /(Fraction fraction1, Fraction fraction2)
        {
            var num1 = fraction1.GetNumerator();
            var den1 = fraction1.GetDenominator();

            var num2 = fraction2.GetNumerator();
            var den2 = fraction2.GetDenominator();

            var num = num1 * den2;
            var den = den1 * num2;

            return new Fraction(num, den);
        }

        public static bool operator >(Fraction fraction1, Fraction fraction2)
        {
            var num1 = fraction1.GetNumerator();
            var den1 = fraction1.GetDenominator();

            var num2 = fraction2.GetNumerator();
            var den2 = fraction2.GetDenominator();

            var res = num1 * den2 > num2 * den1;

            return res;
        }

        public static bool operator <(Fraction fraction1, Fraction fraction2) => !(fraction1 > fraction2);

        public static bool operator ==(Fraction fraction1, Fraction fraction2)
        {
            var num1 = fraction1.GetNumerator();
            var den1 = fraction1.GetDenominator();

            var num2 = fraction2.GetNumerator();
            var den2 = fraction2.GetDenominator();

            var res = num1 * den2 == num2 * den1;

            return res;
        }

        public static bool operator !=(Fraction fraction1, Fraction fraction2) => !(fraction1 == fraction2);

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return numenator+denominator;
        }
    }
}


