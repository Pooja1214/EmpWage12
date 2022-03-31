// See https://aka.ms/new-console-template for more information
namespace EmployeeWage1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int FULL_TIME = 0;
            const int PART_TIME = 1;
            const int WAGE_PER_HOUR = 20;
            int NO_OF_WORKING_DAY_IN_MONTH = 20;
            int day = 0;
            int emphrs = 0;
            int totalempWage = 0;
            for (day = 0; day < NO_OF_WORKING_DAY_IN_MONTH; day++)

            {
                int wage = 0;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case FULL_TIME:
                        emphrs = 8;
                        break;

                    case PART_TIME:
                        emphrs = 4;
                        break;

                    default:
                        emphrs = 0;
                        break;
                }

                wage = emphrs * WAGE_PER_HOUR;
                totalempWage += wage;
                Console.WriteLine("Employee Wage:" + wage);
            }
            Console.WriteLine("Total Employee Wage:" + totalempWage);
        }
    }
}