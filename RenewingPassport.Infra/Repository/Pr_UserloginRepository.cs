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
    public class Pr_UserloginRepository : IPr_UserloginRepository
    {

        private readonly IDbContext DbContext;
        public Pr_UserloginRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public bool CreateUser(Pr_Userlogin pr_Userlogin)
        {
            var p = new DynamicParameters();
            p.Add("FIRSTNAME_", pr_Userlogin.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LASTNAME_", pr_Userlogin.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PASSWORD_", pr_Userlogin.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PHONENUMBER_", pr_Userlogin.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("EMAIL_", pr_Userlogin.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMAGE_", pr_Userlogin.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("REGISTRATIONTIME_", pr_Userlogin.Registrationtime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ROLE_ID_", pr_Userlogin.Role_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("passportType_", pr_Userlogin.Passport_Type, dbType: DbType.String, direction: ParameterDirection.Input);


            var result = DbContext.Connection.ExecuteAsync("PR_USERLOGIN_PACKAGE.CREATEUSER", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteUser(int id)
        {
            var p = new DynamicParameters();
            p.Add("USER_ID_", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DbContext.Connection.ExecuteAsync("PR_USERLOGIN_PACKAGE.DELETEUSER", p, commandType: CommandType.StoredProcedure);
            return true;
        }


        public List<Pr_Userlogin> GetAllUser()
        {
            IEnumerable<Pr_Userlogin> result = DbContext.Connection.Query<Pr_Userlogin>("PR_USERLOGIN_PACKAGE.GETALLUSER", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Pr_Userlogin GetByEmail(GetByEmail email)
        {
            var p = new DynamicParameters();
            p.Add("email_", email.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Pr_Userlogin> result = DbContext.Connection.Query<Pr_Userlogin>("PR_USERLOGIN_PACKAGE.getbyemail", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }

        public bool UpdatePassword(UpdatePassword updatePassword)
        {
            var p = new DynamicParameters();
            p.Add("USER_ID_", updatePassword.User_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("NewPASSWORD_", updatePassword.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("PR_USERLOGIN_PACKAGE.Updatpassword", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdatUser(Pr_Userlogin pr_Userlogin)
        {
            var p = new DynamicParameters();

            p.Add("USER_ID_", pr_Userlogin.User_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("FIRSTNAME_", pr_Userlogin.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LASTNAME_", pr_Userlogin.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PASSWORD_", pr_Userlogin.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PHONENUMBER_", pr_Userlogin.Phonenumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("EMAIL_", pr_Userlogin.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMAGE_", pr_Userlogin.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("REGISTRATIONTIME_", pr_Userlogin.Registrationtime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ROLE_ID_", pr_Userlogin.Role_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("passportType_", pr_Userlogin.Passport_Type, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("PR_USERLOGIN_PACKAGE.UPDATUSER", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
