using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Xml.Serialization.Configuration;

namespace Lab7
{
    public class Complex
    {
        public double re { get; private set; }
        public double im { get; private set; }

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        
        public static explicit operator double(Complex complex)
        {
            return complex.re;
        }

        public static implicit operator Complex(double value)
        {
            return new Complex(value, 0);
        }

        public override string ToString()
        {
            return re + " + " + im + " * i";
        }

        public static Complex operator+(Complex left, Complex right)
        {
            return new Complex(left.re + right.re, left.im + right.im);
        }

        public static Complex operator-(Complex left, Complex right)
        {
            return new Complex(left.re - right.re, left.im - right.im);
        }
        
        public static Complex operator*(Complex left, Complex right)
        {
            return new Complex(left.re * right.re - left.im * right.im, left.re * right.im + left.im * right.re);
        }
        
        public static Complex operator/(Complex left, Complex right)
        {
            return new Complex((left.re * right.re + left.im * right.im) / (Math.Pow(left.im, 2) + Math.Pow(right.im, 2)),
                (left.im * right.re - left.re * right.im) / (Math.Pow(left.im, 2) + Math.Pow(right.im, 2)));
        }

        public static Complex operator ++(Complex complex)
        {
            return complex + new Complex(1, 1);
        }
        
        public static Complex operator --(Complex complex)
        {
            return complex - new Complex(1, 1);
        }
        
        
        
        public static bool operator true(Complex complex)
        {
            return complex.re != 0 || complex.im != 0;
        }
        
        public static bool operator false(Complex complex)
        {
            return complex.re == 0 && complex.im == 0;
        }


        public static bool operator==(Complex left, Complex right)
        {
            return (left.re == right.re) && (left.im == right.re);
        }
        
        public static bool operator!=(Complex left, Complex right)
        {
            return (left.re != right.re) || (left.im != right.re);
        }

        private static double Module(Complex complex)
        {
            return Math.Pow(complex.re, 2) + Math.Pow(complex.im, 2);
        }

        public static bool operator>(Complex left, Complex right)
        {
            return Module(left) > Module(right);
        }

        public static bool operator<(Complex left, Complex right)
        {
            return Module(left) < Module(right);
        }
    }
}