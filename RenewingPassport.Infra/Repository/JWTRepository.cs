using Dapper;
using RenewingPassport.Core.Common;
using RenewingPassport.Core.Data;
using RenewingPassport.Core.DTO;
using RenewingPassport.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace RenewingPassport.Infra.Repository
{
    public class JWTRepository : IJWTRepository
    {
        private readonly IDbContext dbContext;
        public JWTRepository(IDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public LoginDTO Auth(Pr_Userlogin login)
        {
            var p = new DynamicParameters();

            p.Add("Email_", login.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("password_", login.Password, dbType: DbType.String, direction: ParameterDirection.Input);

            IEnumerable<LoginDTO> result = dbContext.Connection.Query<LoginDTO>("PR_USERLOGIN_PACKAGE.Login", p, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }
    }
}
