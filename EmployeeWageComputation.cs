using System;

namespace EmployeeWageComputation
{
    class Attendance
    {
        //constants
        public const int IS_PRESENT = 1;
        public const int EMP_RATE_PER_HR = 20;

        static void Main(string[] args)
        {
            //local variable
            int empWage = 0;
            int empHr = 0;

            //creating object 
            Random Attendance = new Random();
            int userInput = Attendance.Next(0, 2);

            //if else programming construct
            if(userInput == IS_PRESENT)
            {
                empHr = 8;
               
            }
            else
            {
                empHr = 0;

            }
            // Formula for finding employe wage
            empWage = EMP_RATE_PER_HR * empHr;
            Console.WriteLine("Employee Daily Wage is " + empWage);
            Console.ReadLine();

        }
    }
}
