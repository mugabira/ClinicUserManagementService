using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicUserManagementService.Dtos
{
    public class PatientReadDto
    {
        public int Id { get; set; }
        
        public string FName { get; set; }

        public string LName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PassportNumber { get; set; }
        public string NIN { get; set; }

        public string UserType { get; set; }
    }
}
