using System;

namespace EmployeeWageComputation
{
    class Attendance
    {
        //constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;

        static void Main(string[] args)
        {
            //local variable
            int empWage = 0;
            int empHr = 0;

            //creating object 
            Random Attendance = new Random();
            int empInput = Attendance.Next(0, 3);

            //switch case programming construct
            switch (empInput)
            {
                case IS_FULL_TIME: 
                    empHr = 8;
                    Console.WriteLine("Employee is Full time");
                    break;

                case IS_PART_TIME:
                    empHr = 4;
                    Console.WriteLine("Employee is Part time");
                    break;
                default:
                    empHr = 0;
                    Console.WriteLine("Employee is Absent");
                    break;
            }

            // Formula for finding employe wage
            empWage = EMP_RATE_PER_HR * empHr;
            Console.WriteLine("Employee Daily Wage is " + empWage);
            Console.ReadLine();

        }
    }
}
