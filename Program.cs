using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter Percentage");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 75)
            {
                Console.WriteLine($"(n) A Grade");
            }
            else if (n >= 61 && n <= 75)
                {
                    Console.WriteLine($"(n) B Grade");
                }

                 else if (n >= 40 && n <= 60)
                    {
                        Console.WriteLine($"(n) C Grade");

                    }
                    else
                    {
                        Console.WriteLine($"(n) Fail");
                    }
                
            
        }

    }

}
