using RenewingPassport.Core.Data;
using RenewingPassport.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Core.Service
{
    public interface IPr_CountryService
    {
        List<Pr_country> GetAllcountry();
        bool Createcountry(Pr_country pr_Country);
        bool Updatecountry(Pr_country pr_Country);
        bool Deletecountry(int id);
        List<Pr_country> GetByType(CountryType countryType);
    }
}
