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
    public class Pr_PassportRepository : IPr_PassportRepository
    {
        private readonly IDbContext DbContext;
        public Pr_PassportRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public List<Pr_Passport> GetAllPassport()
        {
            IEnumerable<Pr_Passport> result = DbContext.Connection.Query<Pr_Passport>("PR_PASSPORT_PACKAGE.GETALLPASSPORT", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


        public bool CreatePassport(Pr_Passport pr_Passport)
        {
            var p = new DynamicParameters();
            p.Add("PASSPORTNUMBER_", pr_Passport.Passportnumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("fullNAME_", pr_Passport.Fullname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("National_No_", pr_Passport.National_No, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("gender_", pr_Passport.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMG_CARD_", pr_Passport.Img_Card, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMG_OLDPASSPORT_", pr_Passport.Img_Oldpassport, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("BIRTHDATE_", pr_Passport.Birthdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("PLACEOFBIRTH_", pr_Passport.Placeofbirth, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("EXPIRYDATE_", pr_Passport.Expirydate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("DATEOFISSUE_", pr_Passport.Dateofissue, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("REQUESTTIME_", pr_Passport.Requesttime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("USER_ID_", pr_Passport.User_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("STATUS_", pr_Passport.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Passport_Type_", pr_Passport.Passport_Type, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Mother_Name_", pr_Passport.Mother_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Authority_", pr_Passport.Authority, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("address_", pr_Passport.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Image_", pr_Passport.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Email_", pr_Passport.Email, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("PR_PASSPORT_PACKAGE.CREATEPASSPORT", p, commandType: CommandType.StoredProcedure);
            return true;
        }


        public bool UpdatPassport(Pr_Passport pr_Passport)
        {
            var p = new DynamicParameters();
            p.Add("PASSPORT_ID_", pr_Passport.Passport_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("PASSPORTNUMBER_", pr_Passport.Passportnumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("fullNAME_", pr_Passport.Fullname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("National_No_", pr_Passport.National_No, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("gender_", pr_Passport.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMG_CARD_", pr_Passport.Img_Card, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMG_OLDPASSPORT_", pr_Passport.Img_Oldpassport, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("BIRTHDATE_", pr_Passport.Birthdate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("PLACEOFBIRTH_", pr_Passport.Placeofbirth, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("EXPIRYDATE_", pr_Passport.Expirydate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("DATEOFISSUE_", pr_Passport.Dateofissue, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("REQUESTTIME_", pr_Passport.Requesttime, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("USER_ID_", pr_Passport.User_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("STATUS_", pr_Passport.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Passport_Type_", pr_Passport.Passport_Type, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Mother_Name_", pr_Passport.Mother_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Authority_", pr_Passport.Authority, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("address_", pr_Passport.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Image_", pr_Passport.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Email_", pr_Passport.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("PR_PASSPORT_PACKAGE.UPDATPASSPORT", p, commandType: CommandType.StoredProcedure);
            return true;
        }


        public bool DeletePassport(int id)
        {
            var p = new DynamicParameters();
            p.Add("PASSPORT_ID_", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DbContext.Connection.ExecuteAsync("PR_PASSPORT_PACKAGE.DELETEPASSPORT", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Pr_Passport> GetAllStatusNull()
        {
            IEnumerable<Pr_Passport> result = DbContext.Connection.Query<Pr_Passport>("PR_PASSPORT_PACKAGE.STATUSPending", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Pr_Passport> AdminSearch(AdminSearchPassportDTO adminSearch)
        {
            var p = new DynamicParameters();
           
            p.Add("PASSPORTNUMBER_", adminSearch.Passportnumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("fullNAME_", adminSearch.Fullname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("National_No_", adminSearch.National_No, dbType: DbType.Int64, direction: ParameterDirection.Input);
            p.Add("gender_", adminSearch.Gender, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("address_", adminSearch.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.Query<Pr_Passport>("PR_PASSPORT_PACKAGE.searchPASSPORT",p, commandType: CommandType.StoredProcedure);
            return result.ToList();



            
        }

        public bool GenarateNewPassport(int id)
        {
            var p = new DynamicParameters();

            p.Add("PASSPORT_ID_", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DbContext.Connection.ExecuteAsync("PR_PASSPORT_PACKAGE.GenerateNewPASSPORT", p, commandType: CommandType.StoredProcedure);
            return true;
        }



        public bool RejectPassport(int id)
        {
            var p = new DynamicParameters();
            p.Add("PASSPORT_ID_", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DbContext.Connection.ExecuteAsync("PR_PASSPORT_PACKAGE.RejectPassport", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public Pr_Passport GetPasspoetByUserid(GetPassportById getPassportById)
        {
            var p = new DynamicParameters();
            p.Add("USER_ID_", getPassportById.User_Id, dbType: DbType.Int64, direction: ParameterDirection.Input);
            IEnumerable<Pr_Passport> result = DbContext.Connection.Query<Pr_Passport>("PR_PASSPORT_PACKAGE.GetPassportByUserid", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();

        }

        public List<Pr_Passport> GetByDate(SearchByDate searchByDate)
        {
            var p = new DynamicParameters();
            p.Add("STARTDATE_ ", searchByDate.StartDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("ENDDATE_ ", searchByDate.EndDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            IEnumerable<Pr_Passport> result = DbContext.Connection.Query<Pr_Passport>("PR_PASSPORT_PACKAGE.GetPassportBydate", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UudateStatus(UpdatePassportStatus passportStatus)
        {
            var p = new DynamicParameters();
            p.Add("STATUS_", passportStatus.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PASSPORT_ID_", passportStatus.Passport_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("PR_PASSPORT_PACKAGE.updatePassportstatus", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
    
}
