using System;
namespace Question3
{
    public class Complex
    {
        public int Real { get; set; }
        public string Imaginary { get; set; }
        public Complex(){}
        public Complex(int real,string imaginary)
        {
            Real=real;
            Imaginary=imaginary;
        }
        public static Complex operator +(Complex complex1,Complex complex2)
        {
            Complex tempComplex=new Complex();
            tempComplex.Real=complex1.Real+complex2.Real;
            int temp=int.Parse(complex1.Imaginary.Remove(complex1.Imaginary.Length-1))+int.Parse(complex2.Imaginary.Remove(complex1.Imaginary.Length-1));
            tempComplex.Imaginary=temp+Convert.ToString(complex1.Imaginary[complex1.Imaginary.Length-1]);
            return tempComplex;
        }
        public static Complex operator -(Complex complex1,Complex complex2)
        {
            Complex tempComplex=new Complex();
            tempComplex.Real=complex1.Real+complex2.Real;
            int temp=int.Parse(complex1.Imaginary.Remove(complex1.Imaginary.Length-1))-int.Parse(complex2.Imaginary.Remove(complex1.Imaginary.Length-1));
            tempComplex.Imaginary=temp+Convert.ToString(complex1.Imaginary[complex1.Imaginary.Length-1]);
            return tempComplex;
        }
    }
}