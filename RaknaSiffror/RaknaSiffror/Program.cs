using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaSiffror
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("Mata in ett heltal: ");
                    int nummer = int.Parse(Console.ReadLine());
                    string langd = nummer.ToString();

                    int nollor = 0;
                    int jamna = 0;
                    int udda = 0;

                    for (int i = 0; i < langd.Length; i++)
                    {
                        if (langd[i] == 0)
                        {
                            nollor++;
                        }
                        if (langd[i] % 2 == 0)
                        {
                            jamna++;
                        }
                        else
                        {
                            udda++;
                        }
                    }

                    Console.WriteLine(string.Format("Antal nollor: {0}", nollor));
                    Console.WriteLine(string.Format("Antal jämna tal: {0}", jamna));
                    Console.WriteLine(string.Format("Antal udda tal: {0}", udda));
                    break;
                }
                catch (Exception)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL! Skriv in ett tal");
                    Console.ResetColor();
                } 
            } while (true);
        }
    }
}
