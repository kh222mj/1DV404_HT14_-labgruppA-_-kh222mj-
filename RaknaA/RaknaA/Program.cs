using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Mata in en textrad: ");
            string text = Console.ReadLine();

            char[] test = new char[2]{'A', 'a'};
            int A = 0;
            int a = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == test[0]) 
                {
                    A++;
                }
                if (text[i] == test[1])
                {
                    a++;
                }
            }
            Console.WriteLine(string.Format("Antal A: {0}", A));
            Console.WriteLine(string.Format("Antal a: {0}", a));
        }
    }
}
