using System;
using System.Collections.Generic;

namespace StudentOffice
{
    public class Professor : Employee
    {
        private List<Subject> _subjects;

        public Professor(string name, float salary,
            List<Subject> subjects) : base(name, salary)
        {
            Subjects = subjects;
        }

        public List<Subject> Subjects
        {
            get => _subjects;
            set => _subjects = value;
        }
    }
}
