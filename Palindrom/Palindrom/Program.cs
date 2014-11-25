using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
	        {
	            try
                {
                    Console.Write("Skriv ett ord: ");
                    string text = Console.ReadLine();
                    int x = text.Length - 1;
                    
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text[i] == text[x - i])
                        {                            
                            continue;
                        }
                        else
                        {
                            throw new NotImplementedException();
                        }
                    }
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(string.Format("Ordet {0} är ett Palindrom!", text));
                    Console.ResetColor();
                    break;
                }
                catch (Exception)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ordet är inte ett Palindrom, var vänlig försök igen!");
                    Console.ResetColor();
                }                               
	        }           
        }
    }
}
