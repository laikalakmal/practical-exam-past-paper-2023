using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_exam_last_year
{
    internal class TransportAllowanceDecorator : IDecorator
    {
        public ISalary Salary { get; set; }
        public decimal BasicSalary { get; set; }
        public TransportAllowanceDecorator(ISalary salary)
        {
            Salary = salary;
            BasicSalary=salary.BasicSalary;
        }

        public decimal CalNetSalary()
        {
            return Salary.CalNetSalary()+10000;
        }
    }
}
