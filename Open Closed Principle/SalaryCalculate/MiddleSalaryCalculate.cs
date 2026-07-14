using Open_Closed_Principle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.SalaryCalculate
{
    public class MiddleSalaryCalculate : ISalaryCalculator
    {
        public decimal EmployeeSalaryCalculator(decimal salary) => salary * 1.6m;
    }
}
