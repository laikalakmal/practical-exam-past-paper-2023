using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_exam_last_year
{
    internal interface IDecorator : ISalary
    {
        ISalary Salary { get; set; }
    }
}
