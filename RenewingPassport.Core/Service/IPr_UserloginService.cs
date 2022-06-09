using RenewingPassport.Core.Data;
using RenewingPassport.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Core.Service
{
    public interface IPr_UserloginService
    {
        List<Pr_Userlogin> GetAllUser();
        bool CreateUser(Pr_Userlogin pr_Userlogin);
        bool UpdatUser(Pr_Userlogin pr_Passport);
        bool DeleteUser(int id);
        Pr_Userlogin GetByEmail(GetByEmail email);
        bool UpdatePassword(UpdatePassword updatePassword);

    }
}
