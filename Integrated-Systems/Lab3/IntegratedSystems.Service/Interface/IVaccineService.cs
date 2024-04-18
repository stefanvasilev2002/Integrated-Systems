using IntegratedSystems.Domain.Domain_Models;
using IntegratedSystems.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratedSystems.Service.Interface
{
    public interface IVaccineService
    {
        public List<Vaccine> GetVaccinesInVaccinationCenter(Guid center);
        public List<Vaccine> GetVaccines();
        public Vaccine AddVaccineToVaccinationCenter(VaccineDTO vaccine);
    }
}
