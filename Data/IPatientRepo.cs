using ClinicUserManagementService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicUserManagementService.Data
{
    public interface IPatientRepo
    {
        bool SaveChanges();
        IEnumerable<Patient> GetAllPatients();
        Patient GetPatientById(int id);

        void CreatePatient(Patient patient);

    }
}
