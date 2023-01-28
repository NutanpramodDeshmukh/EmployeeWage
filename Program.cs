using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePartTime
{
    internal class Program
    {
        public static void Main()
        {
            int fullday = 8;
            int halfday = 4;
            int perWages = 20;
            Random random = new Random();
            int number = random.Next(0, 3);
           

            if (number == 1)
            {
                Console.WriteLine("Employee Hour is 8");
                Console.WriteLine("Wage is", perWages * fullday);
            }
            else if (number == 0)
            {
                Console.WriteLine("Employee Hour is 4");
                Console.WriteLine("Wage is", perWages * halfday);


            }
            else {
                Console.WriteLine("Employee Hour is 0");

            }
            Console.ReadLine();

        }
    }
}
