using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_exam_last_year
{
    internal class AllowanceDecorator : IDecorator
    {
        public ISalary Salary { get; set; }
        public decimal Rate { get; }
        public decimal BasicSalary { get; set; }
        public AllowanceDecorator(ISalary salary,decimal rate)
        {
            Salary = salary;
            Rate = rate;
            BasicSalary = salary.BasicSalary;   
        }
        public decimal CalNetSalary()
        {
            decimal allowance = BasicSalary*Rate;
            return Salary.CalNetSalary()+allowance;
        }
    }
}
