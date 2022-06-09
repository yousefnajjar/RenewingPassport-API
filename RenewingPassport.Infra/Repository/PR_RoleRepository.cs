using Dapper;
using RenewingPassport.Core.Common;
using RenewingPassport.Core.Data;
using RenewingPassport.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace RenewingPassport.Infra.Repository
{
    public class PR_RoleRepository : IPR_RoleRepository
    {
        private readonly IDbContext DbContext;
        public PR_RoleRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public bool CreateRole(Pr_Role pr_Role)
        {
            var p = new DynamicParameters();
            p.Add("ROLENAME_", pr_Role.Rolename, dbType: DbType.String, direction: ParameterDirection.Input);           
            var result = DbContext.Connection.ExecuteAsync("PR_ROLE_PACKAGE.CREATEROLE", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteRole(int id)
        {
            var p = new DynamicParameters();
            p.Add("ROLE_ID_", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DbContext.Connection.ExecuteAsync("PR_ROLE_PACKAGE.DELETEROLE", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Pr_Role> GetAllRole()
        {
            IEnumerable<Pr_Role> result = DbContext.Connection.Query<Pr_Role>("PR_ROLE_PACKAGE.GETALLROLE", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdatRole(Pr_Role pr_Role)
        {
            var p = new DynamicParameters();
            p.Add("ROLE_ID_", pr_Role.Role_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ROLENAME_", pr_Role.Rolename, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("PR_ROLE_PACKAGE.UPDATROLE", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
