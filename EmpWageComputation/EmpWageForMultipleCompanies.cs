using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComputation
{
    class EmpWageForMultipleCompanies
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private static readonly int numOfWorkingDays;

        public static int ComputeEmpWage(string comapny, int empRatePerHour, int maxHoursPerMonth)
        {
            //Variables
            int empHrs = 0, totalEmpHrs = 0, totalworkingDays = 0;
            //computation
            while (totalEmpHrs <= maxHoursPerMonth && totalworkingDays < numOfWorkingDays)
            {
                totalworkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalworkingDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            string company = null;
            Console.WriteLine("Total Emp Wage for company : " + company + " is:" + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage("Dmart", 20, 2, 10);
            ComputeEmpWage("Reliance", 10, 4, 20);
        }

        private static void ComputeEmpWage(string v1, int v2, int v3, int v4)
        {
            throw new NotImplementedException();
        }
    }
}
