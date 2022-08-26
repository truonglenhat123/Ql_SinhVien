using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using QL_SinhVien.Service.DTOs;
using QL_SinhVien.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ql_SinhVien.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // GET: api/<StudentController>


        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        //private readonly ILogger<StudentController> _logger;
        public StudentController(IStudentService studentService, IMapper mapper)
        {
            //_logger = logger;
            _studentService = studentService;
            _mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<StudentDTO> Get()
        {
            return _studentService.GetAll();
        }

        [HttpGet("{id}")]
        //[Route("{id}")]
        public StudentDTO GetById(int Id)
        {
            var result = _studentService.GetById(Id);
            return result;
        }

        [HttpPost]
        public IActionResult Create([FromBody] StudentDTO student)
        {
            var result = _studentService.AddStudent(student);
            return Ok(result);
        }
        [HttpPut]
        public IActionResult Update([FromBody]  StudentDTO student)
        {
            var result = _studentService.UpdateStudent(student);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _studentService.DeleteStudent(id);
            return Ok(result);
        }

    }
}
