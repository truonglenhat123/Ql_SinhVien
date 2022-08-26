using AutoMapper;
using QL_SinhVien.Data.Entity;
using QL_SinhVien.Data.Interface;
using QL_SinhVien.Service.DTOs;
using QL_SinhVien.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QL_SinhVien.Service.Services
{
    public class StudentService : IStudentService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<SinhVienEntities> _repository;

        public StudentService(IMapper mapper, IRepository<SinhVienEntities> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public IEnumerable<StudentDTO> GetAll()
        {
            var students = _repository.GetAll().ToList();
            return _mapper.Map<List<StudentDTO>>(students);
        }

        
    }
}
