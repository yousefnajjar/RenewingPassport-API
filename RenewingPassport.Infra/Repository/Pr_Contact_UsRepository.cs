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
    public class Pr_Contact_UsRepository : IPr_Contact_UsRepository
    {

        private readonly IDbContext DbContext;
        public Pr_Contact_UsRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }


        public List<Pr_Contact_Us> GetAllContact_Us() 
            {
            IEnumerable<Pr_Contact_Us> result = DbContext.Connection.Query<Pr_Contact_Us>("Pr_Contact_Us_Package.GetAllContact_Us", commandType: CommandType.StoredProcedure);
            return result.ToList();
        } 
        public bool CreateContact_Us(Pr_Contact_Us pr_Contact_Us)
        {
            var p = new DynamicParameters();
            p.Add("Name_", pr_Contact_Us.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Phone_No_", pr_Contact_Us.Phone_No, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Email_", pr_Contact_Us.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Massege_", pr_Contact_Us.Massege, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Website_Id_", pr_Contact_Us.Website_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Pr_Contact_Us_Package.CreateContact_Us", p, commandType: CommandType.StoredProcedure);
            return true;
        }
       public bool UpdateContact_Us(Pr_Contact_Us pr_Contact_Us)
        {
            var p = new DynamicParameters();
            p.Add("Contact_Us_Id_", pr_Contact_Us.Contact_Us_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Name_", pr_Contact_Us.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Phone_No_", pr_Contact_Us.Phone_No, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Email_", pr_Contact_Us.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Massege_", pr_Contact_Us.Massege, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Website_Id_", pr_Contact_Us.Website_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Pr_Contact_Us_Package.UpdateContact_Us", p, commandType: CommandType.StoredProcedure);
            return true;
        }
       public bool DeleteContact_Us(int id)
        {
            var p = new DynamicParameters();
            p.Add("Contact_Us_Id_", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Pr_Contact_Us_Package.DeleteContact_Us", p, commandType: CommandType.StoredProcedure);
            return true;      
        }

    }
}
