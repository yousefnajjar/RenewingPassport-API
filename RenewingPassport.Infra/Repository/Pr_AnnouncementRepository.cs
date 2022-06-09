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
    public class Pr_AnnouncementRepository : IPr_AnnouncementRepository
    {
        private readonly IDbContext DbContext;

        public Pr_AnnouncementRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public bool CreateAnnouncementl(Pr_Announcement pr_Announcement)
        {
            var p = new DynamicParameters();
            p.Add("Text_", pr_Announcement.Text, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Publisheddate_", pr_Announcement.Publisheddate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("Subject_", pr_Announcement.Subject, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Category_", pr_Announcement.Category, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Website_Id_", pr_Announcement.Website_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("PR_ANNOUNCEMENT_PACKAGE.CreateAnnouncement", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteAnnouncement(int id)
        {
            var p = new DynamicParameters();
            p.Add("Announcement_Id_", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DbContext.Connection.ExecuteAsync("PR_ANNOUNCEMENT_PACKAGE.DeleteAnnouncement", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Pr_Announcement> GetAllAnnouncement()
        {
            IEnumerable<Pr_Announcement> result = DbContext.Connection.Query<Pr_Announcement>("PR_ANNOUNCEMENT_PACKAGE.GetAllAnnouncement", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateAnnouncement(Pr_Announcement pr_Announcement)
        {
            var p = new DynamicParameters();
            p.Add("Announcement_Id_", pr_Announcement.Announcement_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Text_", pr_Announcement.Text, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Publisheddate_", pr_Announcement.Publisheddate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("Subject_", pr_Announcement.Subject, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Website_Id_", pr_Announcement.Website_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Category_", pr_Announcement.Category, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("PR_ANNOUNCEMENT_PACKAGE.UpdateAnnouncement", p, commandType: CommandType.StoredProcedure);
            return true;
        }


        public List<Pr_Announcement> SearchAnnouncement(SearchAnnouncementDTO searchAnnouncement)
        {
            var p = new DynamicParameters();
            p.Add("Subject_", searchAnnouncement.Subject, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Category_", searchAnnouncement.Category, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.Query<Pr_Announcement>("PR_ANNOUNCEMENT_PACKAGE.searchAnnouncement", p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
