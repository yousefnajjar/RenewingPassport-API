using RenewingPassport.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Core.Repository
{
    public interface IPr_About_UsRepository
    {
        List<Pr_About_Us> GetALLAboutus();
        bool CreateAboutUs(Pr_About_Us pr_About_Us);
        bool UpdateAboutUs(Pr_About_Us pr_About_Us);
        bool DeleteAboutUs(int id);

    }
}
