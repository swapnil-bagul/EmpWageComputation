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
            int userInput = Attendance.Next(0, 3);

            //if else if programming construct
            if(userInput == IS_FULL_TIME  )
            {
                empHr = 8;
                Console.WriteLine("Employee is Full time");
            }
            else if (userInput == IS_PART_TIME )
            {
                Console.WriteLine("Employee is Part time");
                empHr = 4;
            }
            else 
            {
                Console.WriteLine("Employee is Absent");
                empHr = 0;
            }
            // Formula for finding employe wage
            empWage = EMP_RATE_PER_HR * empHr;
            Console.WriteLine("Employee Daily Wage is " + empWage);
            Console.ReadLine();

        }
    }
}
