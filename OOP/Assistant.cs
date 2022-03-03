using System;
namespace StudentOffice
{
    public class Assistant : Employee
    {
        private Professor _professor;

        public Assistant(string name, float salary, Professor professor) :
            base(name, salary)
        {
            Professor = professor;
        }

        public Professor Professor
        {
            get => _professor;
            set => _professor = value;
        }
    }
}
