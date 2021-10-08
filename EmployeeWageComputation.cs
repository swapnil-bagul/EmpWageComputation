using System;

namespace EmployeeWageComputation
{
    class Attendance
    {
        static void Main(string[] args)
        {
            int IS_PRESENT = 1;
            Random Attendance = new Random();
            int userInput = Attendance.Next(0, 2);

            if(userInput == IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine();
            }

        }
    }
}
