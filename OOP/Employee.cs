using System;
namespace StudentOffice
{
    public abstract class Employee
    {
        private string _name;
        private float _salary;

        public Employee(string name, float salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public float Salary
        {
            get => _salary;
            set => _salary = value;
        }
    }
}
