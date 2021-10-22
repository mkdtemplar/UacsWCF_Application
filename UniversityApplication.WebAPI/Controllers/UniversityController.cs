using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UniversityApplication.Data;
using UniversityApplication.Data.DataTransferObjects;
using UniversityApplication.Services;

namespace UniversityApplication.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversityController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public UniversityController(IRepositoryManager repositoryManager, IMapper mapper, ILoggerManager logger)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = _repositoryManager.Student.GetallStudents(trackChanges: false);
                
            var studentsDTO = _mapper.Map<IEnumerable<StudentDTO>>(students);
            return Ok(studentsDTO);
        }

        [HttpGet("{studentid}")]
        public IActionResult GetStudentById(int studentid)
        {
            var student = _repositoryManager.Student.GetStudent(studentid, trackChanges: false);
            if (student == null)
            {
                _logger.LogInfo($"Student with id: {studentid} not exist.");
                return NotFound();
            }

            else
            {
                var studentDto = _mapper.Map<StudentDTO>(student);
                return Ok(studentDto);
            }
        }

        [HttpGet("{studentid},{addressId}")]
        public IActionResult GetStudent(int studentid, int addressId)
        {
            var student = _repositoryManager.Student.GetStudentByAddress(studentid, addressId, trackChanges: false);
            if (student == null)
            {
                _logger.LogInfo($"Student with id: {studentid} not exist in database.");
                return NotFound();
            }
            else
            {
                var studentDTO = _mapper.Map<StudentDTO>(student);
                return Ok(studentDTO);
            }
        }
    }
}
