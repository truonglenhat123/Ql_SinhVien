using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using FluentMigrator.Runner.Processors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NuGet.Protocol.Core.Types;
using QL_SinhVien.Data.Repositories;
using QL_SinhVien.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagermentTest.RepositoryTest
{
    [TestClass]
   public class StudentRepositoryTest
    {
        [TestMethod]
       public void GetAllStudent_ShouldReturnAllProducts()
        {
            var testStudent = getAll();
            var controller = new SimpleProductController(testProducts);

            var result = controller.GetAllProducts() as List<Product>;
            Assert.AreEqual(testProducts.Count, result.Count);
        }
        private List<StudentDTO> GetTestStudent()
        {
            var testStudent = new List<StudentDTO>();
            testStudent.Add(new StudentDTO { Id = 1, Name = "Demo1", Price = 1 });
            testStudent.Add(new StudentDTO { Id = 2, Name = "Demo2", Price = 3.75M });
            testStudent.Add(new StudentDTO { Id = 3, Name = "Demo3", Price = 16.99M });
            testStudent.Add(new Product { Id = 4, Name = "Demo4", Price = 11.00M });

            return testProducts;
        }
    }
}
