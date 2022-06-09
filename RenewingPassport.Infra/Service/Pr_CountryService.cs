using RenewingPassport.Core.Data;
using RenewingPassport.Core.DTO;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Infra.Service
{
    public class Pr_CountryService : IPr_CountryService
    {
        private readonly IPr_CountryRepository _pr_CountryRepository;
        public Pr_CountryService(IPr_CountryRepository pr_CountryRepository)
        {
            _pr_CountryRepository = pr_CountryRepository;
        }
        public bool Createcountry(Pr_country pr_Country)
        {
            return _pr_CountryRepository.Createcountry(pr_Country);
        }

        public bool Deletecountry(int id)
        {
            return _pr_CountryRepository.Deletecountry(id);
        }

        public List<Pr_country> GetAllcountry()
        {
           return _pr_CountryRepository.GetAllcountry();
        }

        public List<Pr_country> GetByType(CountryType countryType)
        {
            return _pr_CountryRepository.GetByType(countryType);
        }

        public bool Updatecountry(Pr_country pr_Country)
        {
            return _pr_CountryRepository.Updatecountry(pr_Country);
        }
    }
}
