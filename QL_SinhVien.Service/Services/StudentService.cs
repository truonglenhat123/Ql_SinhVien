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

        public StudentDTO GetById(int Id)
        {
            var student = _repository.GetById(Id);
            return _mapper.Map<StudentDTO>(student);
        }

        public StudentDTO AddStudent(StudentDTO student)
        {
            var svEntity = _mapper.Map<SinhVienEntities>(student);
            var sinhVienEntitieResult = _repository.Insert(svEntity);

            return _mapper.Map<StudentDTO>(sinhVienEntitieResult);
        }

        public StudentDTO UpdateStudent(int Id, RequestUpdate student)
        {

            var check = _repository.Find(x => x.Id == Id).FirstOrDefault();
            if (check != null)
            {
                check = _mapper.Map<RequestUpdate, SinhVienEntities>(student);
                check.Id = Id;
                _repository.Update(check);
                return GetById(Id);
            }
            return null;
        }

        public bool DeleteStudent(int id)
        {
            var svEntity = _repository.GetById(id);
            return _repository.Remove(svEntity);
        }

    }
}
