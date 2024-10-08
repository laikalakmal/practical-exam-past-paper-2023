using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_exam_last_year
{
    internal class Salary : ISalary
    {
        public decimal BasicSalary { get; set; }
        public Salary(decimal basicSalary)
        {
            BasicSalary=basicSalary;
        }

        public decimal CalNetSalary()
        {
            return BasicSalary ;
        }
    }
}
