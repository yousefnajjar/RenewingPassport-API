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
    public class Pr_TestimonialRepository : IPr_TestimonialRepository
    {
        private readonly IDbContext DbContext;

        public Pr_TestimonialRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public bool CreateTestimonial(Pr_Testimonial pr_Testimonial)
        {
            var p = new DynamicParameters();
            p.Add("Name_", pr_Testimonial.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Imagepath_", pr_Testimonial.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Status_", pr_Testimonial.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Feedback_", pr_Testimonial.Feedback, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Website_Id_", pr_Testimonial.Website_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("PR_TESTIMONIAL_PACKAGE.CreateTestimonial", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteTestimonial(int id)
        {
            var p = new DynamicParameters();
            p.Add("TESTIMONIAL_ID_", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DbContext.Connection.ExecuteAsync("PR_TESTIMONIAL_PACKAGE.DeleteTestimonial", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Pr_Testimonial> GetAllTestimonial()
        {
            IEnumerable<Pr_Testimonial> result = DbContext.Connection.Query<Pr_Testimonial>("PR_TESTIMONIAL_PACKAGE.GetAllTestimonial", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateTestimonial(Pr_Testimonial pr_Testimonial)
        {
            var p = new DynamicParameters();
            p.Add("TESTIMONIAL_ID_", pr_Testimonial.Testimonial_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Name_", pr_Testimonial.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Imagepath_", pr_Testimonial.Imagepath, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Status_", pr_Testimonial.Status, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Feedback_", pr_Testimonial.Feedback, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Website_Id_", pr_Testimonial.Website_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("PR_TESTIMONIAL_PACKAGE.UpdateTestimonial", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
