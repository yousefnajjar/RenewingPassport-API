using RenewingPassport.Core.Data;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Infra.Service
{
    public class PR_RoleService : IPR_RoleService
    {
        private readonly IPR_RoleRepository _PR_RoleRepository;
        public PR_RoleService(IPR_RoleRepository PR_RoleRepository)
        {
            _PR_RoleRepository = PR_RoleRepository;
        }
        public bool CreateRole(Pr_Role pr_Role)
        {
            return _PR_RoleRepository.CreateRole(pr_Role);
        }

        public bool DeleteRole(int id)
        {
            return _PR_RoleRepository.DeleteRole(id);
        }

        public List<Pr_Role> GetAllRole()
        {
            return _PR_RoleRepository.GetAllRole();
        }

        public bool UpdatRole(Pr_Role pr_Role)
        {
            return _PR_RoleRepository.UpdatRole(pr_Role);
        }
    }
}
