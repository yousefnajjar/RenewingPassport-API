using RenewingPassport.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Core.Repository
{
    public interface IPr_WebsiteRepository
    {
        //Read
        List<Pr_Website> GetAllWebsite();
        //Create
        bool CreateWebsite(Pr_Website pr_Website);

        //Update
        bool UpdateWebsite(Pr_Website pr_Website);

    }
}
