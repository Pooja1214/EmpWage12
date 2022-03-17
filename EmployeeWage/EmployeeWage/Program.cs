﻿// See https://aka.ms/new-console-template for more information
namespace EmployeeWage1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PRESENT = 0;
            const int PARTIAL_PRESENT = 1;
            const int WAGE_PER_HOUR = 20;
            const int FULL_TIME_WORKING_HOUR = 8;
            int PART_TIME_WORKING_HOUR = 4;

            int TOTAL_WORKING_HOURS_IN_MONTH = 100;
            int NO_OF_WORKING_DAY_IN_MONTH = 20;

            //initialize variable
            int day = 0;
            int totalWorkingHr = 0;
            while (day != NO_OF_WORKING_DAY_IN_MONTH && totalWorkingHr != TOTAL_WORKING_HOURS_IN_MONTH)
            {
                int wage = 0;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case PRESENT:
                        Console.WriteLine("Employee is present");
                        wage = FULL_TIME_WORKING_HOUR * WAGE_PER_HOUR;
                        totalWorkingHr = totalWorkingHr + FULL_TIME_WORKING_HOUR;
                        Console.WriteLine($"WAGE:{wage}");
                        break;

                    case PARTIAL_PRESENT:
                        Console.WriteLine("Employee is partial present");
                        wage = PART_TIME_WORKING_HOUR * WAGE_PER_HOUR;
                        totalWorkingHr = totalWorkingHr + PART_TIME_WORKING_HOUR;
                        Console.WriteLine($"WAGE:{wage}");
                        break;

                    default:
                        Console.WriteLine("Employee is absent");
                        Console.WriteLine($"WAGE:{wage}");
                        break;

                }
                day++;

            }
            Console.WriteLine($"No of working day:{day} and Total working hr:{totalWorkingHr}");
        }
    }
}
