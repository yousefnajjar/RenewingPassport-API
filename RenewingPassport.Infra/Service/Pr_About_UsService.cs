using RenewingPassport.Core.Data;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Infra.Service
{
    public class Pr_About_UsService : IPr_About_UsService
    {
        private readonly IPr_About_UsRepository _pr_About_UsRepository;

        public Pr_About_UsService(IPr_About_UsRepository pr_About_UsRepository)
        {
            _pr_About_UsRepository = pr_About_UsRepository;
        }
        public List<Pr_About_Us> GetALLAboutus()
        {
            return _pr_About_UsRepository.GetALLAboutus();
        }
        public bool CreateAboutUs(Pr_About_Us pr_About_Us)
        {
            return _pr_About_UsRepository.CreateAboutUs(pr_About_Us);
        }
        public bool UpdateAboutUs(Pr_About_Us pr_About_Us)
        {
            return _pr_About_UsRepository.UpdateAboutUs(pr_About_Us);   
        }
        public bool DeleteAboutUs(int id)
        {
            return _pr_About_UsRepository.DeleteAboutUs(id);
        }

    }
}
