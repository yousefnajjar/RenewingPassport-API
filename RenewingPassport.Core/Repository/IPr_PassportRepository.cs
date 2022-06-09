using RenewingPassport.Core.Data;
using RenewingPassport.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Core.Repository
{
    public interface IPr_PassportRepository
    {
        List<Pr_Passport> GetAllPassport();
        bool CreatePassport(Pr_Passport pr_Passport);
        bool UpdatPassport(Pr_Passport pr_Passport);
        bool DeletePassport(int id);
        List<Pr_Passport> GetAllStatusNull();
        List<Pr_Passport> AdminSearch(AdminSearchPassportDTO adminSearch);
        bool GenarateNewPassport( int id);

        bool RejectPassport(int id);
        Pr_Passport GetPasspoetByUserid(GetPassportById getPassportById);

        List<Pr_Passport> GetByDate(SearchByDate searchByDate);
        bool UudateStatus(UpdatePassportStatus passportStatus);
    }

}
