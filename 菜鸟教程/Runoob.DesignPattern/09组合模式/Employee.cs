#region

using System.Collections.Generic;
using Common;

#endregion

namespace _09组合模式
{
    internal class Employee
    {
        public Employee(string name, string dept, int salary)
        {
            Name = name;
            Dept = dept;
            Salary = salary;
            Subordinates = new List<Employee>();
        }

        public string Name { get; }

        public string Dept { get; }

        public int Salary { get; }

        public IList<Employee> Subordinates { get; }

        public void Add(Employee employee)
        {
            Subordinates.Add(employee);
        }

        public void Remove(Employee employee)
        {
            Subordinates.Remove(employee);
        }


        public override string ToString()
        {
            return $"{nameof(Employee)}: {this.ToJson()}";
        }
    }
}