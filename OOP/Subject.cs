using System;
namespace StudentOffice
{
    public class Subject
    {
        private int _id;
        private string _name;
        private int _points;

        public Subject(int id, string name, int points)
        {
            Id = id;
            Name = name;
            Points = points;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Points
        {
            get => _points;
            set => _points = value;
        }
    }
}
