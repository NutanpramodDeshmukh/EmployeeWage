using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fullday = 8;
            int halfday = 4;
            int perWages = 20;
            Random random = new Random();
            int number = random.Next(0, 3);


            switch (number)
            {
                case 0:
                Console.WriteLine("Employee Hour is 8");
                Console.WriteLine("Wage is" + perWages * fullday);
                break;

                case 1:
                Console.WriteLine("Employee Hour is 4");
                Console.WriteLine("Wage is" + perWages * halfday);
                break;

                default:
                Console.WriteLine("Employee Hour is 0");
                break;

            }
            Console.ReadLine();

        }
    }
}
