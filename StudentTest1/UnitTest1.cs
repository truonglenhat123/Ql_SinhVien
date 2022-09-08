using Moq;
using NUnit.Framework;
using QL_SinhVien.Service.DTOs;
using QL_SinhVien.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace StudentTest1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAllListTest()
        {
            Mock<IStudentService> studentService = new Mock<IStudentService>();
            studentService.Setup(x => x.GetAll()).Returns(new List<StudentDTO> {
            new StudentDTO
            {
                Id =100
            }
            });

            Assert.AreEqual(studentService.Object.GetAll().ToList().Count(), 1);
            Assert.AreEqual(studentService.Object.GetAll().FirstOrDefault().Id, 100);
        }

        [Test]
        public void DeleteServiceTest()
        {
            Mock<IStudentService> studentService = new Mock<IStudentService>();
            studentService.Setup(x => x.DeleteStudent(1)).Returns(true);
            studentService.Setup(x => x.DeleteStudent(2)).Returns(false);

            Assert.AreEqual(studentService.Object.DeleteStudent(1), true);
            Assert.AreEqual(studentService.Object.DeleteStudent(2), false);
        }

        [Test]
        public void AddServiceTest()
        {
            StudentDTO createStd = new StudentDTO
            {
                Id = 100
            };

            Mock<IStudentService> studentService = new Mock<IStudentService>();
            studentService.Setup(x => x.AddStudent(createStd)).Returns(createStd);

            Assert.AreEqual(studentService.Object.AddStudent(createStd).Id, 100);
            Assert.AreNotEqual(studentService.Object.AddStudent(createStd).Id, 101);
        }

        [Test]
        public void UpdateServiceTest()
        {
            StudentDTO updateStudentDTO = new StudentDTO();
            RequestUpdate update = new RequestUpdate()
            {
                Fullname = "truong",
                Age = 22,
                Username = "truongtest1111",
                Password = "truongtess",
                Address = "phan huy ích, phường 12",
                Email = "kieubbo123@gmail.com",
                Mssv = 2111,
                Phone = "0964437046"

            };

            Mock<IStudentService> studentService = new Mock<IStudentService>();
            studentService.Setup(x => x.UpdateStudent(0, update)).Returns(updateStudentDTO);

            Assert.AreEqual(studentService.Object.UpdateStudent(0, update).Id, 0);
            //Assert.AreNotEqual(studentService.Object.UpdateStudent(1, update).Id, 2);
        }

    }
}