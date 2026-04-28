using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp
{
    public interface IStudentRepository
    {
        Student GetStudentById(int id);
        void Save(Student student);
    }
}
