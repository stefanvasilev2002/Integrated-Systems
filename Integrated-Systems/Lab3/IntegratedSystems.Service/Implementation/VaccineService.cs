using IntegratedSystems.Domain.Domain_Models;
using IntegratedSystems.Domain.DTO;
using IntegratedSystems.Repository.Interface;
using IntegratedSystems.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratedSystems.Service.Implementation
{
    public class VaccineService : IVaccineService
    {
        private readonly IRepository<Vaccine> _vaccineRepository;
        private readonly IRepository<VaccinationCenter> _vaccinationCenterRepository;
        private readonly IRepository<Patient> _patientRepository;

        public VaccineService(IRepository<Vaccine> vaccineRepository, IRepository<VaccinationCenter> vaccinationCenterRepository, IRepository<Patient> patientRepository)
        {
            _vaccineRepository = vaccineRepository;
            _vaccinationCenterRepository = vaccinationCenterRepository;
            _patientRepository = patientRepository;
        }

        public Vaccine AddVaccineToVaccinationCenter(VaccineDTO vaccine)
        {
            var center = _vaccinationCenterRepository.Get(vaccine.VaccinationCenter);
            if (center.MaxCapacity <= 0)
            {
                return null;
            }
            Vaccine model = new Vaccine()
            {
                Id = Guid.NewGuid(),
                Manufacturer = vaccine.Manufacturer,
                Certificate = Guid.NewGuid(),
                DateTaken = DateTime.Now,
                PatientId = (Guid)vaccine.PatientId,
                PatientFor = _patientRepository.Get(vaccine.PatientId),
                VaccinationCenter = (Guid)vaccine.VaccinationCenter,
                Center = center
            };
            _vaccineRepository.Insert(model);
            
            center.MaxCapacity = center.MaxCapacity - 1;
            _vaccinationCenterRepository.Update(center);

            return model;
        }

        public List<Vaccine> GetVaccines()
        {
            return _vaccineRepository.GetAll().ToList();
        }

        public List<Vaccine> GetVaccinesInVaccinationCenter(Guid center)
        {
            return _vaccineRepository.GetAll().Where(v => v.VaccinationCenter == center).ToList();
        }
    }
}
