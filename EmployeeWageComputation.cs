using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmpWageBuilder:IComputeEmpWage 
    {
        //constants variable 
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        //Used LinkedList And Dictionary
        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        //EmpWageBuilder constructor
        public EmpWageBuilder ()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
           
        }
        public void addCompanyEmpWage(string companyName, int maxWorkingDay, int maxWorkingHrs, int empRate)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(companyName, maxWorkingDay, maxWorkingHrs, empRate);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(companyName, companyEmpWage);
            
        }
        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList )
            {
                companyEmpWage.setTotalEmpWage(this.ComputeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());

            }
            
        }
        private int ComputeEmpWage(CompanyEmpWage Company)
        {
            int empWage = 0;
            int totalWorkingDay = 0;
            int totalWorkingHrs = 0;
            int empHr = 0;

            //while loop programming construct
            while (totalWorkingDay < Company.maxWorkingDay && totalWorkingHrs <= Company.maxWorkingHrs)
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
                empWage = Company.empRate * empHr;
                //formula for calculating total emloyee wage
                Company.totalEmpWage = Company.totalEmpWage + empWage;
                //incrementation
                totalWorkingDay++;
                totalWorkingHrs = totalWorkingHrs + empHr;
                
            }
                
            Console.WriteLine("Total Working Days: {0}, Total Working Hrs: {1}", totalWorkingDay, totalWorkingHrs);
            return Company.totalEmpWage;
         
        }

        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }
       
       

    }
}
 
