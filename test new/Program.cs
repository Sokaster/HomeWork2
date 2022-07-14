using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press number of factorial, which you need");
            int x = int.Parse(Console.ReadLine());
            int n = x;
            if (x > 0)
            {
               
                          for (int i = n - 1; i > 0; i--)
                           {
                              n *= i;
                           }
                            Console.WriteLine($"factorial chisla {x} ! = {n}");
             }
             if (x == 0)
            {
                Console.WriteLine($"factorial {x} ! = 1");
            }
             if (x < 0)
            {
                Console.Write("VVedite polozhitelnoe chislo");
            } 
                
                
        }

                
                
            
            
           
        }
    }
