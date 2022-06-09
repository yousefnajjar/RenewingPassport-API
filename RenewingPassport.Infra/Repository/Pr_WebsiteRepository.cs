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
    public class Pr_WebsiteRepository : IPr_WebsiteRepository
    {
        private readonly IDbContext DbContext;

        public Pr_WebsiteRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public bool CreateWebsite(Pr_Website pr_Website)
        {
            var p = new DynamicParameters();
            p.Add("Website_Name_", pr_Website.Website_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Logo_", pr_Website.Logo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Location_", pr_Website.Location, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Phonenumber_", pr_Website.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Email_", pr_Website.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Descrption_", pr_Website.Descrption, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("PR_WEBSITE_Package.CreateWebsite", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Pr_Website> GetAllWebsite()
        {
            IEnumerable<Pr_Website> result = DbContext.Connection.Query<Pr_Website>("PR_WEBSITE_Package.GetAllWebsite", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateWebsite(Pr_Website pr_Website)
        {
            var p = new DynamicParameters();
            p.Add("Website_Id_", pr_Website.Website_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Website_Name_", pr_Website.Website_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Logo_", pr_Website.Logo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Location_", pr_Website.Location, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Phonenumber_", pr_Website.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Email_", pr_Website.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Descrption_", pr_Website.Descrption, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("PR_WEBSITE_Package.UpdateWebsite", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
