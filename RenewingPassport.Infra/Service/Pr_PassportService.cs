using RenewingPassport.Core.Data;
using RenewingPassport.Core.DTO;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Infra.Service
{
    public class Pr_PassportService : IPr_PassportService
    {


        private readonly IPr_PassportRepository _pr_PassportRepository;
        public Pr_PassportService(IPr_PassportRepository pr_PassportRepository)
        {
            _pr_PassportRepository = pr_PassportRepository;
        }
        public List<Pr_Passport> GetAllPassport()
        {
            return _pr_PassportRepository.GetAllPassport();
        }
        public bool CreatePassport(Pr_Passport pr_Passport)
        {
            return _pr_PassportRepository.CreatePassport(pr_Passport);
        }

        public bool UpdatPassport(Pr_Passport pr_Passport)
        {
            return _pr_PassportRepository.UpdatPassport(pr_Passport);
        }
        public bool DeletePassport(int id)
        {
            return _pr_PassportRepository.DeletePassport(id);
        }

        public List<Pr_Passport> GetAllStatusNull()
        {
            return _pr_PassportRepository.GetAllStatusNull();
        }

        public List<Pr_Passport> AdminSearch(AdminSearchPassportDTO adminSearch)
        {
            return _pr_PassportRepository.AdminSearch(adminSearch);
        }

        public bool GenarateNewPassport(int id)
        {
            return _pr_PassportRepository.GenarateNewPassport(id);
        }

        public bool RejectPassport(int id)
        {
            return _pr_PassportRepository.RejectPassport(id);
        }

        public Pr_Passport GetPasspoetByUserid(GetPassportById getPassportById)
        {
            return _pr_PassportRepository.GetPasspoetByUserid(getPassportById);
        }

        public List<Pr_Passport> GetByDate(SearchByDate searchByDate)
        {
            return _pr_PassportRepository.GetByDate(searchByDate);
        }

        public bool UudateStatus(UpdatePassportStatus passportStatus)
        {
            return _pr_PassportRepository.UudateStatus(passportStatus);
        }
    }
}
