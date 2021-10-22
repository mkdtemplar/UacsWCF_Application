using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityApplication.Data.DataTransferObjects;
using UniversityApplication.Services;

namespace UniversityApplication.WebAPI.Controllers
{
    [Route("api/university/{studentId}/address")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AddressController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetStudentsAddress(int studentId,int addressId)
        {
            var student = _repository.Student.GetStudentByAddress(studentId, addressId, trackChanges: false);
            if (student == null)
            {
                _logger.LogInfo($"Student with id {addressId} not exist in database.");
                return NotFound();
            }

            var addressFromDb = _repository.Address.GetAddresses(addressId, trackChanges: false);

            var addressDto = _mapper.Map<IEnumerable<AddressDTO>>(addressFromDb);

            return Ok(addressDto);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudentByAddress(int studentId, int id)
        {
            var student = _repository.Student.GetStudent(studentId, trackChanges: false);
            if (student == null)
            {
                _logger.LogInfo($"Student with id {studentId} not exists");
                return NotFound();
            }

            var addressDb = _repository.Address.GetStudentAddress(studentId, id, trackChanges: false);
            if (addressDb == null)
            {
                _logger.LogInfo($"Address with id {id} not exists");
                return NotFound();
            }

            var address = _mapper.Map<AddressDTO>(addressDb);

            return Ok(address);
        }
    }
}