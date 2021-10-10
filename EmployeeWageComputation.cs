using System;

namespace EmployeeWageComputation
{
    class Attendance
    {
        //constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;

        static void Main(string[] args)
        {
            //local variable
            int empWage = 0;
            int empHr = 0;
            int totalEmpWage = 0;


            //creating object 
            Random Attendance = new Random();

            //for loop programming construct
            for (int day=1; day <= NUM_OF_WORKING_DAYS; day ++)
            {
                int empInput = Attendance.Next(0, 3);

                //switch case programming construct
                switch (empInput)
                {
                    case IS_FULL_TIME:
                        empHr = 8;
                        break;

                    case IS_PART_TIME:
                        empHr = 4;
                        break;

                    default:
                        empHr = 0;                    
                        break;
                }
                // Formula for finding employe wage
                empWage = EMP_RATE_PER_HR * empHr;
                //formula for finding total emloyee wage
                totalEmpWage = totalEmpWage + empWage;

            }

            Console.WriteLine("Employee Wage for a Month " +totalEmpWage );
            Console.ReadLine();

        }
    }
}
