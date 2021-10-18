using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder .addCompanyEmpWage("Tata Motors", 24, 120, 30);
            empWageBuilder .addCompanyEmpWage("Maruti Suzuki", 25, 110, 35);
            empWageBuilder .addCompanyEmpWage ("Mahindra",23,100,40);
            empWageBuilder.computeEmpWage();
        }
    }
}
