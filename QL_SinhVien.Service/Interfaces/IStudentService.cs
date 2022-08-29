using QL_SinhVien.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_SinhVien.Service.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<StudentDTO> GetAll();
        StudentDTO GetById(int Id);

        StudentDTO AddStudent(StudentDTO student);

        StudentDTO UpdateStudent(int Id, RequestUpdate student);

        bool DeleteStudent(int id);

    }
}
