using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp
{
    public class StudentService
    {
        private readonly IStudentRepository studentRepository;
        public StudentService(IStudentRepository repo)
        {
            studentRepository = repo;
        }
        public bool PrepareStudentForTest(int id, int hours)
        {
            Student student = studentRepository.GetStudentById(id);

            if (student == null) return false;

            student.Learn(hours);

            if (student.IsTestPassed())
            {
                studentRepository.Save(student);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
