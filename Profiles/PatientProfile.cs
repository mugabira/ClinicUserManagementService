using AutoMapper;
using ClinicUserManagementService.Dtos;
using ClinicUserManagementService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicUserManagementService.Profiles
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            //source -> target
            CreateMap<Patient, PatientReadDto>();
            CreateMap<PatientCreateDto, Patient>();
        }
    }
}
