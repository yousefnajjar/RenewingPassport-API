using RenewingPassport.Core.Data;
using RenewingPassport.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Core.Repository
{
    public interface IJWTRepository
    {
        LoginDTO Auth(Pr_Userlogin login);
    }
}
