using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (count <= 100)
            {

                if (count % 3 == 0 && count % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (count % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (count % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(count);
                }
                count++;
                
            }
            Console.ReadKey();
            

        }
        

        
    }
}
