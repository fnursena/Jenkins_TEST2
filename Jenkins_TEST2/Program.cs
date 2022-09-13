using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenkins_TEST2
{
    class Program
    {
        static void Main(string[] args)
        {
            Islemler islemler = new Islemler();
        }
    }
    public class Islemler
    {
        public double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Extraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Division(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
