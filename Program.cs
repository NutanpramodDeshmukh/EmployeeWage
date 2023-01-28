using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAttendance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Name");
            string name = Console.ReadLine();
            Random random = new Random();
            int isPresent = random.Next(0,2);
            if (isPresent == 0)
            {
                Console.WriteLine(name + "Absent");
            }
            else 
            {
                Console.WriteLine(name + "Present");

            }


        }
    }
}
