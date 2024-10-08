using System.Collections.Generic;

namespace practical_exam_last_year
{
    internal class Employee
    {
        private string name;
        private string position;
        private decimal basicSalary;
        private decimal allowanceRate;
        private bool transportUsed;

        decimal netSalary;

        public string Name { get => name; set => name = value; }
        public string Position { get => position; set => position = value; }
        public decimal BasicSalary { get => basicSalary; set => basicSalary = value; }
        public decimal AllowanceRate { get => allowanceRate; set => allowanceRate = value; }
        public bool TransportUsed { get => transportUsed; set => transportUsed = value; }
        public decimal NetSalary { get => netSalary; set => netSalary = value; }

        public static List<Employee> Employee_List = new List<Employee>();

        public Employee(string name, string position, int basicSalary, decimal allowanceRate, bool transportUsed)
        {
            this.name = name;
            this.position = position;
            this.basicSalary = basicSalary;
            this.allowanceRate = allowanceRate;
            this.transportUsed = transportUsed;

            ISalary Salary = new Salary(basicSalary);
            Salary = new IncomeTaxDecorator(Salary);
            Salary = new EPFDecorator(Salary);
            Salary = new AllowanceDecorator(Salary, allowanceRate);
            if (!TransportUsed)
            {
                Salary = new TransportAllowanceDecorator(Salary);
            }

            NetSalary = Salary.CalNetSalary();

        }
    }
}
