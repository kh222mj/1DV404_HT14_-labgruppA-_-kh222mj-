using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastStorsta
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("Ange nummer 1: ");
                    int nummer1 = int.Parse(Console.ReadLine());
                    Console.Write("Ange nummer 2: ");
                    int nummer2 = int.Parse(Console.ReadLine());

                    int storst;
                    int nastStorst;
                    if (nummer1 < nummer2)
                    {
                        storst = nummer2;
                        nastStorst = nummer1;
                    }
                    else
                    {
                        storst = nummer1;
                        nastStorst = nummer2;
                    }

                    for (int i = 3; i < 11; i++)
                    {
                        Console.Write("Ange nummer {0}: ", i);
                        int nummer3 = int.Parse(Console.ReadLine());

                        if (nummer3 > nastStorst && nummer3 < storst)
                        {
                            nastStorst = nummer3;
                        }
                        if (nummer3 > storst)
                        {
                            storst = nummer3;
                        }
                    }
                    Console.WriteLine(string.Format("Det näst största talet är: {0}", nastStorst));
                    break;
                }
                catch (Exception)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL! Mata in ett nummer!");
                    Console.ResetColor();
                } 
            } while (true);
        }
    }
}
