using RenewingPassport.Core.Data;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Infra.Service
{
    public class Pr_Contact_UsService : IPr_Contact_UsService
    {
        private readonly IPr_Contact_UsRepository _pr_Contact_UsRepository;

        public Pr_Contact_UsService(IPr_Contact_UsRepository pr_Contact_UsRepository)
        {
            _pr_Contact_UsRepository = pr_Contact_UsRepository;
        }
       public List<Pr_Contact_Us> GetAllContact_Us()
        {
            return _pr_Contact_UsRepository.GetAllContact_Us();
        }
        public bool CreateContact_Us(Pr_Contact_Us pr_Contact_Us)
        {
            return _pr_Contact_UsRepository.CreateContact_Us(pr_Contact_Us);    
        }
        public bool UpdateContact_Us(Pr_Contact_Us pr_Contact_Us)
        {
            return _pr_Contact_UsRepository.UpdateContact_Us(pr_Contact_Us);
        }
        public bool DeleteContact_Us(int id)
        {
            return _pr_Contact_UsRepository.DeleteContact_Us(id);
        }
    }
}
