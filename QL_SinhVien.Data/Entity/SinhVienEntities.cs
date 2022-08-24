using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QL_SinhVien.Data.Entity
{
    public class SinhVienEntities: BaseEntities
    {
       
        public int Mssv { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Username { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Password { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Fullname { get; set; }
        public int Age { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        public string Phone { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; }
    }
}
