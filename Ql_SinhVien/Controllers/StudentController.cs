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
    [Route("api/[controller]")]
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
    }
}
