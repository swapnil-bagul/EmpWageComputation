using System;

namespace EmployeeWageComputation
{
    class Employee
    {
        //constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int NUM_OF_WORKING_HRS = 100;

        //static variable
        static int empHr = 0;
        public static int Check(int empInput)
        {
            
            //switch case programming construct
            switch (empInput)
            {
                case IS_FULL_TIME:
                    return empHr = 8;


                case IS_PART_TIME:
                    return empHr = 4;


                default:
                    return empHr = 0;

            }
        }
        public static void Wage()
        {
            //local variable
            int empWage = 0;
            int totalEmpWage = 0;
            int day = 0;
            int totalHrs = 0;

            //while loop programming construct
            while (day < NUM_OF_WORKING_DAYS && totalHrs <= NUM_OF_WORKING_HRS)
            {
                Random attendance = new Random();
                int empInput = attendance.Next(0, 3);

                //call static method
                Employee .Check (empInput);

                // Formula for finding employe wage
                empWage = EMP_RATE_PER_HR * empHr;
                //formula for finding total emloyee wage
                totalEmpWage = totalEmpWage + empWage;
                //incrementation
                day++;
                totalHrs = totalHrs + empHr;

            }
            Console.WriteLine("Total Employee Wage for {0} Days & {1} Hrs is {2} ", day, totalHrs, totalEmpWage);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
           Employee.Wage ();
        }

    }
}
 
