using RenewingPassport.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Core.Repository
{
    public interface IPr_Contact_UsRepository
    {
        List<Pr_Contact_Us> GetAllContact_Us();
        bool CreateContact_Us(Pr_Contact_Us pr_Contact_Us);
        bool UpdateContact_Us(Pr_Contact_Us pr_Contact_Us);
        bool DeleteContact_Us(int id);
    }
}
