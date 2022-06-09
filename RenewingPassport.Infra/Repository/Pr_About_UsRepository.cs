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
    public class Pr_About_UsRepository : IPr_About_UsRepository
    {
        private readonly IDbContext DbContext;
        public Pr_About_UsRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public List<Pr_About_Us> GetALLAboutus()
        {

            IEnumerable<Pr_About_Us> result = DbContext.Connection.Query<Pr_About_Us>("Pr_about_us_package.GetALLAboutus", commandType: CommandType.StoredProcedure);
            return result.ToList();

        }


        public bool CreateAboutUs(Pr_About_Us pr_About_Us)
        {
            var p = new DynamicParameters();
            p.Add("Mission_", pr_About_Us.Mission, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Workinghour_", pr_About_Us.Workinghour, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Website_Id_", pr_About_Us.Website_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Vision_", pr_About_Us.Vision, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Goals_", pr_About_Us.Goals, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Pr_about_us_package.CreateAboutus", p, commandType: CommandType.StoredProcedure);
            return true;                                               
        }


        public bool UpdateAboutUs(Pr_About_Us pr_About_Us)
        {
            var p = new DynamicParameters();

            p.Add("About_Us_Id_", pr_About_Us.About_Us_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Mission_", pr_About_Us.Mission, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Workinghour_", pr_About_Us.Workinghour, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Website_Id_", pr_About_Us.Website_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Vision_", pr_About_Us.Vision, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Goals_", pr_About_Us.Goals, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Pr_about_us_package.UpdateAboutus", p, commandType: CommandType.StoredProcedure);
            return true;

        }

        public bool DeleteAboutUs(int id)
        {
            var p = new DynamicParameters();
            p.Add("About_Us_Id_", id, dbType: DbType.Int32, direction: ParameterDirection.Input); 
            var result = DbContext.Connection.ExecuteAsync("Pr_about_us_package.DeleteAboutus", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
