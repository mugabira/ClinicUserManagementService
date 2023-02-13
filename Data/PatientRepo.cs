using ClinicUserManagementService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicUserManagementService.Data
{
    public class PatientRepo : IPatientRepo
    {
        private readonly AppDBContext _context;

        public PatientRepo(AppDBContext context)
        {
            _context = context;
        }
        public void CreatePatient(Patient patient)
        {
            if(patient == null)
            {
                throw new ArgumentNullException(nameof(patient));
            }
            _context.Patients.Add(patient);
        }

        public IEnumerable<Patient> GetAllPatients()
        {
            return _context.Patients.ToList();
        }

        public Patient GetPatientById(int id)
        {
            return _context.Patients.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }
    }
}
