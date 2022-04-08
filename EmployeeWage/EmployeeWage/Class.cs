using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeWage
{
    class Program
    {

        const int FULL_TIME = 1;
        const int PART_TIME = 2;
        const int WAGE_PER_HOUR = 20;
        const int WORKINGMAX_PER_MONTH = 20;
        const int WORKINGMAX_PER_DAYS = 100;

        private static int maxHourPerMonth;

        public static void ComputeWage(string company, int WAGE_PER_HOUR, int WORKINGMAX_PER_DAYS, int WORKINGMAX_PER_MONTHh)
        {

            int empHrs = 0;
            int empDailyWage = 0;

            int workingHrs = 0;
            int totalwage = 0;
            int WorkingDays = 1;

            Random random = new Random();

            while (WorkingDays <= WORKINGMAX_PER_DAYS && workingHrs <= maxHourPerMonth)
            {


                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case FULL_TIME:

                        empHrs = 8;
                        break;

                    case PART_TIME:

                        empHrs = 4;
                        break;

                    default:

                        break;

                }
                empDailyWage = empHrs * WAGE_PER_HOUR;
                workingHrs += empHrs;
                totalwage += empDailyWage;

                if (empCheck != 0)
                {
                    WorkingDays++;
                }

            }
            Console.WriteLine("CompanyName: " + company);

            Console.WriteLine("Working Hours :" + workingHrs);
            Console.WriteLine("Employee Wage Per day :" + empDailyWage);
            Console.WriteLine("Working days in a month :" + WorkingDays);
            Console.WriteLine("Employee Wage for 20 working days :" + totalwage);



        }

        static void main(string[] args)
        {
            ComputeWage("Dmart", 50, 30, 10);
            ComputeWage("Reliance", 20, 10, 80);
            ComputeWage("KP mall", 50, 30, 10);


        }
    }
}