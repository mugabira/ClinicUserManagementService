using AutoMapper;
using ClinicUserManagementService.Data;
using ClinicUserManagementService.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicUserManagementService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientRepo _repository;
        private readonly IMapper _mapper;

        public PatientsController(IPatientRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PatientReadDto>> GetAllPatients()
        {
            var patientItems = _repository.GetAllPatients();
            return Ok(_mapper.Map<IEnumerable<PatientReadDto>>(patientItems));
        }
    }
}
