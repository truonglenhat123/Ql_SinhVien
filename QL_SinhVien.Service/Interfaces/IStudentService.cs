using QL_SinhVien.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_SinhVien.Service.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<StudentDTO> GetAll();
       
    }
}
