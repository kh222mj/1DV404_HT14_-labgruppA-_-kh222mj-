using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Fraction
    {
        private int taljare, namnare;
        public Fraction(int Taljare, int Namnare)
        {
            this.taljare = Taljare;
            this.namnare = Namnare;
        }
        public int getNumerator()
        {
            return taljare;
        }
        public int getDominator()
        {
            return namnare;
        }
        public bool isNegative()
        {
            if (taljare / namnare < 0)
            {
                Console.WriteLine("Talet är negativt!");
                return true;
            }
            Console.WriteLine("Talet är positivt!");
            return false;
        }
        public Fraction add(int num1, int num2)
        {
            Fraction fraction = new Fraction(num1, num2);
            return fraction;
        }
        public int multiply()
        {
            if (taljare == 0 || namnare == 0) 
            {
                throw new Exception();
            }    
            int resultat = taljare / namnare;
            return resultat;            
        }
        public bool isEqualTo(Fraction fraction1, Fraction fraction2)
        {

            if (fraction1.namnare == fraction2.namnare && fraction1.taljare == fraction2.taljare)
            {
                Console.WriteLine("De två Fraction instanserna du jämförde är lika!");
                return true;
            }
            else 
            {
                Console.WriteLine("De två Fraction instanserna du jämförde är inte lika!");
                return false;
            }
        }
        public string toString()
        {
            int resultat = multiply();
            int taljare = getNumerator();
            int namnare = getDominator();
            string str = "Resultat " + taljare + " / " + namnare + " = " + resultat;
            return str;
        }
    }
}
