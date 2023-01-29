using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fullday = 8;
            int halfday = 4;
            int perWages = 20;
            int isPresent = 20;
            int WageforMonth = 0;
            int workingDaysPerMonth = 20;
            int TotalHours = 100;

            Random random = new Random();
            int number = random.Next(0, 3);


            for (int i = 0; i < workingDaysPerMonth && i <= TotalHours; i++) ;
            {

                switch (number)
                {
                    case 0:
                        Console.WriteLine("Employee Hour is 8");
                        Console.WriteLine("Wage is fullday");
                        WageforMonth = WageforMonth + (fullday * perWages);

                        break;

                    case 1:
                        Console.WriteLine("Employee Hour is 4");
                        Console.WriteLine("Wage is halfday");
                        WageforMonth = WageforMonth + (halfday * perWages);

                        break;

                    default:
                        Console.WriteLine("Employee Hour is 0");
                        break;

                }
            }
            Console.WriteLine("Number of Days Present: " + isPresent);
            Console.WriteLine("wages for the month is: " + WageforMonth); 
            Console.WriteLine("Employee worked Hours: " + TotalHours);
            Console.ReadLine();
        }
    }
}
