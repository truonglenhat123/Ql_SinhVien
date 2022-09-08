using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using QL_SinhVien.Data.Repositories;
using QL_SinhVien.Service.DTOs;
using QL_SinhVien.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace StudentTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void GetAllListTest()
        {
            Mock<IStudentService> studentService = new Mock<IStudentService>();
            studentService.Setup(x => x.GetAll()).Returns(new List<StudentDTO> { 
            new StudentDTO
            {
                Id =1
            }
            });

         Assert.AreEqual(studentService.Object.GetAll().ToList().Count(), 1);

        }
    }
}