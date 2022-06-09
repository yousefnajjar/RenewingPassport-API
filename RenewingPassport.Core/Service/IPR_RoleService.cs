using RenewingPassport.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Core.Service
{
    public interface IPR_RoleService
    {
        List<Pr_Role> GetAllRole();
        bool CreateRole(Pr_Role pr_Role);
        bool UpdatRole(Pr_Role pr_Role);
        bool DeleteRole(int id);
    }
}
