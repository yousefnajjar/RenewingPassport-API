using RenewingPassport.Core.Data;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Infra.Service
{
    public class Pr_WebsiteService : IPr_WebsiteService
    {
        private readonly IPr_WebsiteRepository _WebsiteRepository;

        public Pr_WebsiteService(IPr_WebsiteRepository WebsiteRepository)
        {
            _WebsiteRepository = WebsiteRepository;
        }

        public bool CreateWebsite(Pr_Website pr_Website)
        {
            return _WebsiteRepository.CreateWebsite(pr_Website);
        }

        public List<Pr_Website> GetAllWebsite()
        {
            return _WebsiteRepository.GetAllWebsite();
        }

        public bool UpdateWebsite(Pr_Website pr_Website)
        {
            return _WebsiteRepository.UpdateWebsite(pr_Website);
        }
    }
}
