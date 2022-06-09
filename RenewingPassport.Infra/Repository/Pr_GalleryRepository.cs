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
    public class Pr_GalleryRepository : IPr_GalleryRepository
    {
        private readonly IDbContext DbContext;

        public Pr_GalleryRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }


        public bool CreateGallery(Pr_Gallery pr_Gallery)
        {
            var p = new DynamicParameters();
            p.Add("IMAGE_", pr_Gallery.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Website_Id_", pr_Gallery.Website_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("PR_Gallery_PACKAGE.CreateGallery", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteGallery(int id)
        {
            var p = new DynamicParameters();
            p.Add("gallery_Id_", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DbContext.Connection.ExecuteAsync("PR_Gallery_PACKAGE.DeleteGallery", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Pr_Gallery> GetALLGallery()
        {
            IEnumerable<Pr_Gallery> result = DbContext.Connection.Query<Pr_Gallery>("PR_Gallery_PACKAGE.GetAllGallery", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateGallery(Pr_Gallery pr_Gallery)
        {
            var p = new DynamicParameters();
            p.Add("gallery_id_", pr_Gallery.Gallery_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("IMAGE_", pr_Gallery.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("WEBSITE_ID_", pr_Gallery.Website_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("PR_Gallery_PACKAGE.UpdateGallery", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
