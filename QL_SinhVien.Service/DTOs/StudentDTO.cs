using QL_SinhVien.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace QL_SinhVien.Service.DTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public int Mssv { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
