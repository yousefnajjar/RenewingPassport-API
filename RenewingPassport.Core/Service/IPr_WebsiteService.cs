using RenewingPassport.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Core.Service
{
    public interface IPr_WebsiteService
    {
        //Read
        List<Pr_Website> GetAllWebsite();
        //Create
        bool CreateWebsite(Pr_Website pr_Website);

        //Update
        bool UpdateWebsite(Pr_Website pr_Website);

    }
}
