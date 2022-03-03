using System;
using System.Collections.Generic;

namespace StudentOffice
{
    public class StudentOffice
    {
        private List<Exam> passedExams = new List<Exam>();
        private List<Exam> failedExams = new List<Exam>();

        public void SaveExam(Exam exam)
        {
            int grade = exam.Grade();
            Console.WriteLine($"Grade is {grade}");

            if (grade > 5)
            {
                Console.Write("Exam has been added to the database");
                Console.WriteLine($"Student {exam.StudentName()} passed an {exam.ExamName()}");
                passedExams.Add(exam);
            }
            else
            {
                failedExams.Add(exam);
                Console.WriteLine($"Student {exam.StudentName()} did not pass this exam");
            }
        }

        public void PrintExamReport()
        {
            foreach (Exam exam in passedExams)
            {
                Console.WriteLine($"Student {exam.StudentName()} " +
                    $"passed an exam: {exam.ExamName()}");
            }

            foreach (Exam exam1 in failedExams)
            {
                Console.WriteLine($"Student {exam1.StudentName()} " +
                    $"did not pass an exam: {exam1.ExamName()}");
            }
        }
    }
}
