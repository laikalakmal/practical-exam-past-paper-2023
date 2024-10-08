using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_exam_last_year
{
    internal class IncomeTaxDecorator : IDecorator
    {
        public ISalary Salary { get; set; }
        public decimal BasicSalary { get; set; }
        public IncomeTaxDecorator(ISalary salary)
        {
            Salary = salary;
            BasicSalary = salary.BasicSalary;
        }

        public decimal CalNetSalary()
        {
            decimal incomeTax = BasicSalary * (decimal)0.1;
            return Salary.CalNetSalary()- incomeTax;
        }
    }
}
