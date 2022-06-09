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
    public class Pr_CountryRepository : IPr_CountryRepository
    {
        private readonly IDbContext DbContext;
        public Pr_CountryRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public List<Pr_country> GetAllcountry()
        {
            IEnumerable<Pr_country> result = DbContext.Connection.Query<Pr_country>("Pr_country_PACKAGE.GetAllcountry", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool Createcountry(Pr_country pr_Country)
        {
            var p = new DynamicParameters();
            p.Add("countryType_", pr_Country.CountryType, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("countryName_", pr_Country.CountryName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("countryImage_", pr_Country.CountryImage, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("countryDescrption_", pr_Country.CountryDescrption, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Pr_country_PACKAGE.Createcountry", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool Updatecountry(Pr_country pr_Country)
        {
            var p = new DynamicParameters();
            p.Add("country_ID_", pr_Country.Country_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("countryType_", pr_Country.CountryType, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("countryName_", pr_Country.CountryName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("countryImage_", pr_Country.CountryImage, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("countryDescrption_", pr_Country.CountryDescrption, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Pr_country_PACKAGE.Updatecountry", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool Deletecountry(int id)
        {
            var p = new DynamicParameters();
            p.Add("country_ID_", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DbContext.Connection.ExecuteAsync("Pr_country_PACKAGE.Deletecountry", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Pr_country> GetByType(CountryType countryType)
        {
            var p = new DynamicParameters();
            p.Add("countryType_", countryType.Type, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Pr_country> result = DbContext.Connection.Query<Pr_country>("Pr_country_PACKAGE.GetByType", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

       
    }
}
