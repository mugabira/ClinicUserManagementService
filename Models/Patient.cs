using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicUserManagementService.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FName { get; set; }

        [Required]
        public string  LName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PassportNumber { get; set; }
        public string NIN { get; set; }

        [Required]
        public string UserType { get; set; }
    }
}
