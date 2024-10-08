using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_exam_last_year
{
    internal class EPFDecorator : IDecorator
    {
        public EPFDecorator(ISalary salary)
        {
            Salary = salary;
            BasicSalary = salary.BasicSalary;
        }
        public ISalary Salary { get; set; }
        public decimal BasicSalary { get; set; }

        public decimal CalNetSalary()
        {
            decimal epf = BasicSalary * (decimal)0.05;
            return Salary.CalNetSalary()-epf;
        }
    }
}
