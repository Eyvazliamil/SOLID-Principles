using Open_Closed_Principle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    public class SalaryCalculator
    {
        public static decimal EmpSalaryCalculator(decimal salary, ISalaryCalculator SalaryCalculator)
        {
            return SalaryCalculator.EmployeeSalaryCalculator(salary);
        }
    }
}
