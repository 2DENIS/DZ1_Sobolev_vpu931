using System;
using System.Collections.Generic;
using System.Text;

namespace DZ1_Sobolev_vpu931
{
    class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber()
        {
            Real = 0.0;
            Imaginary = 0.0;
        }
        public ComplexNumber(double re, double im)
        {
            Real = re;
            Imaginary = im;
        }
        public static ComplexNumber operator +(ComplexNumber num1,ComplexNumber num2)
        { 
            return new ComplexNumber(num1.Real + num2.Real, num1.Imaginary + num2.Imaginary);
        }
        public static ComplexNumber operator -(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.Real - num2.Real, num1.Imaginary - num2.Imaginary);
        }
        public static ComplexNumber operator *(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.Real * num2.Real - num1.Imaginary * num2.Imaginary, num1.Real * num2.Imaginary + num1.Imaginary * num2.Real);
        }
        public static ComplexNumber operator /(ComplexNumber num1, ComplexNumber num2) 
        {           
            double r = num2.Real * num2.Real + num2.Imaginary * num2.Imaginary;
            return new ComplexNumber((num1.Real * num2.Real+ num1.Imaginary * num2.Imaginary)/r, (num2.Real*num1.Imaginary - num2.Imaginary * num1.Real)/r);

        }

    }
}
