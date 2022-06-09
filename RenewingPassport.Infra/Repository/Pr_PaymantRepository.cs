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
    
    public class Pr_PaymantRepository : IPr_PaymantRepository
    {
        private readonly IDbContext DbContext;
        public Pr_PaymantRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public bool CreatePaymant(Pr_Paymant pr_Paymant)
        {
            var p = new DynamicParameters();
            p.Add("ammount_", pr_Paymant.Ammount, dbType: DbType.Int16, direction: ParameterDirection.Input);
            p.Add("card_Id_", pr_Paymant.Card_ID, dbType: DbType.Int16, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Pr_Paymant_PACKAGE.CreatePaymant", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<PaymantFollowUp> GetAllPaymantInfo()
        {
            IEnumerable<PaymantFollowUp> result = DbContext.Connection.Query<PaymantFollowUp>("Pr_Paymant_PACKAGE.get", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public int GetSum()
        {
            IEnumerable<int> result = DbContext.Connection.Query<int>("Pr_Paymant_PACKAGE.getsum", commandType: CommandType.StoredProcedure);
            return result.ToList().FirstOrDefault();
        }
    }
}
