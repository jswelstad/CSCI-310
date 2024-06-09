using System;
using System.Runtime.CompilerServices;

namespace HW8OpOverloading
{
    public class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public int Numerator
        {
            get { return this.numerator; }
            set { this.numerator = value; }
        }

        public int Denominator
        {
            get { return this.denominator; }
            set { this.denominator = value; }
        }

        public void PrintFraction()
        {
            Console.WriteLine($"{this.Numerator}/{this.Denominator}");
        }

        public override string ToString()
        {
            return $"{this.Numerator}/{this.Denominator}";
        }

        public static Fraction operator +(Fraction left, Fraction right)
        {
            int product1;
            int product2;
            int newNumerator;
            int newDenominator;
            
            if (left.Denominator == right.Denominator)
            {
                newNumerator = left.Numerator + right.Numerator;
                return new Fraction(newNumerator, right.Denominator);
            }

            product1 = left.Numerator * right.Denominator;
            product2 = left.Denominator * right.Numerator;

            newNumerator = product1 + product2;
            newDenominator = left.Denominator * right.Denominator;
            
            return new Fraction(newNumerator, newDenominator);
            
        }

        public static Fraction Simplify(Fraction inputFraction)
        {
            int greatestCommonDivisor;

            greatestCommonDivisor = GCD(inputFraction.Numerator, inputFraction.Denominator);

            return new Fraction(inputFraction.Numerator / greatestCommonDivisor,
                inputFraction.Denominator / greatestCommonDivisor);
        }

        private static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return GCD(b, a % b);
        }

        public static bool operator ==(Fraction left, Fraction right)
        {
            if (left.Numerator == right.Numerator && left.Denominator == right.Denominator)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Fraction left, Fraction right)
        {
            return !(left == right);
        }
        
        public static Fraction operator *(Fraction left, Fraction right)
        {
            int newNumer = left.Numerator * right.Numerator;
            int newDenom = left.Denominator * right.Denominator;
            return new Fraction(newNumer, newDenom);
        }

        public static Fraction operator /(Fraction left, Fraction right)
        {
            int newNumer = left.Numerator * right.Denominator;
            int newDenom = left.Denominator * right.Numerator;
            return new Fraction(newNumer, newDenom);
        }
    }
    
    
    public class HW8OpOverloading
    {
        static void Main(string[] args)
        {
            Fraction frac1 = new Fraction(1, 2);
            Fraction frac2 = new Fraction(1, 4);
            Console.Write("Fraction 1: ");
            frac1.PrintFraction();
            Console.Write("Fraction 2: ");
            frac2.PrintFraction();
            
            Console.Write("Adding them together: ");
            Fraction frac3 = frac1 + frac2;
            
            Console.WriteLine(frac3);
            
            Console.Write("Simplifying: ");
            Console.WriteLine(Fraction.Simplify(frac3));

            Console.WriteLine($"{frac1} == {frac2} = {frac1 == frac2}");

            Fraction frac4 = new Fraction(7, 9);
            
            Console.WriteLine("Multiplication:");
            Console.WriteLine($"{frac1} * {frac2} = {Fraction.Simplify(frac1 * frac2)}");
            Console.WriteLine($"{frac3} * {frac4} = {Fraction.Simplify(frac3 * frac4)}");
            
            Console.WriteLine("Division");
            Console.WriteLine($"{frac1} / {frac2} = {Fraction.Simplify(frac1 / frac2)}");
            Console.WriteLine($"{frac3} / {frac4} = {Fraction.Simplify(frac3 / frac4)}");
            
        }
    }
}

