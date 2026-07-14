using Open_Closed_Principle;
using Open_Closed_Principle.SalaryCalculate;

var low = SalaryCalculator.EmpSalaryCalculator(1500, new LowSalaryCalculate());
var mid = SalaryCalculator.EmpSalaryCalculator(1500, new MiddleSalaryCalculate());
var high = SalaryCalculator.EmpSalaryCalculator(1500, new HighSalaryCalculate());

Console.WriteLine($"Low Salary: {low} AZN");
Console.WriteLine($"Middle Salary: {mid} AZN");
Console.WriteLine($"High Salary: {high} AZN");