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
    public class Pr_ReviewRepository : IPr_ReviewRepository
    {

        private readonly IDbContext DbContext;
        public Pr_ReviewRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }


        public List<Pr_Review> GetALLReview()
        {
            IEnumerable<Pr_Review> result = DbContext.Connection.Query<Pr_Review>("Pr_Review_package.GetALLReview", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool CreateReview(Pr_Review pr_Review)
        {
            var p = new DynamicParameters();
            p.Add("Rate_", pr_Review.Rate, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Website_Id_", pr_Review.Website_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Pr_Review_package.CreateReview", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateReview(Pr_Review pr_Review)
        {
            var p = new DynamicParameters();
            p.Add("Review_Id_", pr_Review.Review_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Rate_", pr_Review.Rate, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Website_Id_", pr_Review.Website_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Pr_Review_package.UpdateReview", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteReview(int id)
        {
            var p = new DynamicParameters();
            p.Add("Review_Id_", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Pr_Review_package.DeleteReview", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public float GetAvarage()
        {
            IEnumerable <float>  result = DbContext.Connection.Query<float>("Pr_Review_package.Getavarage", commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();

           
        }
    }
}
