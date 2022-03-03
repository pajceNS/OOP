using System;
using System.Collections.Generic;

namespace StudentOffice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Subject> subjects = new List<Subject>
            {
                new Subject(1, "Genetics", 5),
                new Subject(2, "Embryology", 6),
                new Subject(3, "ART", 4)
            };

            Student Nemanja = new Student(14, "Nemanja", "Pajcin");
            Professor Stefan = new Professor("Stefan", 700, subjects);
            Exam exam = new Exam(Stefan, Nemanja, subjects[0]);
            Exam exam2 = new Exam(Stefan, Nemanja, subjects[1]);
            Exam exam3 = new Exam(Stefan, Nemanja, subjects[2]);
            StudentOffice studentOffice = new StudentOffice();


            studentOffice.SaveExam(exam);
            studentOffice.SaveExam(exam2);
            studentOffice.SaveExam(exam3);

            studentOffice.PrintExamReport();

        }
    }
}
