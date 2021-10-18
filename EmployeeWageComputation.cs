using System;

namespace EmployeeWageComputation
{
    class EmpWageBuilderArray
    {
        //constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private int numOfCompanies = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray ()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void addCompanyEmpWage(string companyName, int maxWorkingDay, int maxWorkingHrs, int empRate)
        {
            companyEmpWageArray[this.numOfCompanies] = new CompanyEmpWage(companyName, maxWorkingDay, maxWorkingHrs, empRate);
            numOfCompanies++;
        }
        public void computeEmpWage()
        {
            for (int i=0; i<numOfCompanies; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empWage = 0;
            int totalWorkingDay = 0;
            int totalWorkingHrs = 0;
            int empHr = 0;

            //while loop programming construct
            while (totalWorkingDay < companyEmpWage.maxWorkingDay && totalWorkingHrs <= companyEmpWage.maxWorkingHrs)
            {
                //used predefined Random class
                Random attendance = new Random();
                int empInput = attendance.Next(0, 3);

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

                // Formula for calculating employe wage
                empWage = companyEmpWage.empRate * empHr;
                //formula for calculating total emloyee wage
                companyEmpWage.totalEmpWage = companyEmpWage.totalEmpWage + empWage;
                //incrementation
                totalWorkingDay++;
                totalWorkingHrs = totalWorkingHrs + empHr;
                
            }
                
            Console.WriteLine("Total Working Days: {0}, Total Working Hrs: {1}", totalWorkingDay, totalWorkingHrs);
            return companyEmpWage.totalEmpWage;
         
        }
       
       

    }
}
 
