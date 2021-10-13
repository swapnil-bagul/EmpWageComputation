using System;

namespace EmployeeWageComputation
{
    class Employee
    {
        //constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        //static variable
        int empRate;
        int maxWorkingDay;
        int maxWorkingHrs;
        string companyName;
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
        public static void Wage(string companyName,int maxWorkingDay,int maxWorkingHrs,int empRate )
        {
            //local variable
            int empWage = 0;
            int totalEmpWage = 0;
            int day = 0;
            int totalHrs = 0;

            //while loop programming construct
            while (day < maxWorkingDay && totalHrs <= maxWorkingHrs)
            {
                Random attendance = new Random();
                int empInput = attendance.Next(0, 3);

                //call static method
                Employee .Check (empInput);

                // Formula for finding employe wage
                empWage = empRate  * empHr;
                //formula for finding total emloyee wage
                totalEmpWage = totalEmpWage + empWage;
                //incrementation
                day++;
                totalHrs = totalHrs + empHr;

            }
            Console.WriteLine("{0} : Total Employee Wage for {1} Days & {2} Hrs is {3} ",companyName, day, totalHrs, totalEmpWage);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
           Employee.Wage ("Tata Motors", 24, 120, 30);
           Employee.Wage("Maruti Suzuki", 25, 110, 35);
        }

    }
}
 
