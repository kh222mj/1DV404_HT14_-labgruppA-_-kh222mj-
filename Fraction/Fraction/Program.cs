using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Fraction fraction = new Fraction(2, 2);               
                Console.WriteLine(fraction.toString());
                fraction.isNegative();
                Console.WriteLine();

                fraction = fraction.add(20, 5);
                Console.WriteLine(fraction.toString());
                fraction.isNegative();
                Console.WriteLine();

                fraction.isEqualTo(fraction, fraction.add(20, 5));
            }
            catch (Exception)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Du har initierat bråktalet fel!");
                Console.ResetColor();
            }

        }
    }
}
