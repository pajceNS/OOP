using System;
namespace StudentOffice
{
    public class Exam
    {
        private Professor _professor;
        private Student _student;
        private Subject _subject;

        public Exam(Professor professor, Student student, Subject subject)
        {
            _professor = professor;
            _student = student;
            _subject = subject;
        }

        public string ExamName()
        {
            return _subject.Name;
        }

        public string StudentName()
        {
            return _student.GetFullName();
        }

        public int Grade()
        {
            return new Random().Next(5, 11);
        }
    }
}
