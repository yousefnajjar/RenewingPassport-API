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
    
    public class Pr_CardRepository : IPr_CardRepository
    {
        private readonly IDbContext DbContext;
        public Pr_CardRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public bool CreateCard(Pr_Card pr_Card)
        {
            var p = new DynamicParameters();
            p.Add("card_name_", pr_Card.Card_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("cvc_card_", pr_Card.Cvc_Card, dbType: DbType.Int16, direction: ParameterDirection.Input);
            p.Add("BALANCE_", pr_Card.Balance, dbType: DbType.Int16, direction: ParameterDirection.Input);
            p.Add("card_number_", pr_Card.Card_Number, dbType: DbType.Int16, direction: ParameterDirection.Input);
            p.Add("expiry_date_", pr_Card.Expiry_Date, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("user_id_", pr_Card.User_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Pr_Card_PACKAGE.CreateCard", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteCard(int id)
        {
            var p = new DynamicParameters();
            p.Add("Card_ID_", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DbContext.Connection.ExecuteAsync("Pr_Card_PACKAGE.DeleteCard", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Pr_Card> GetALL()
        {
            IEnumerable<Pr_Card> result = DbContext.Connection.Query<Pr_Card>("Pr_Card_PACKAGE.getall", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public Pr_Card getById(int id)
        {
            var p = new DynamicParameters();
            p.Add("User_id_", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Pr_Card> result = DbContext.Connection.Query<Pr_Card>("Pr_Card_PACKAGE.getByid", p, commandType: CommandType.StoredProcedure);
            return result.ToList().FirstOrDefault();
        }

        public bool UpdateCard(Pr_Card pr_Card)
        {
            var p = new DynamicParameters();
            p.Add("(Card_ID_", pr_Card.Card_ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("(card_name_", pr_Card.Card_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("cvc_card_", pr_Card.Cvc_Card, dbType: DbType.Int16, direction: ParameterDirection.Input);
            p.Add("BALANCE_", pr_Card.Balance, dbType: DbType.Int16, direction: ParameterDirection.Input);
            p.Add("card_number_", pr_Card.Card_Number, dbType: DbType.Int16, direction: ParameterDirection.Input);
            p.Add("expiry_date_", pr_Card.Expiry_Date, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("user_id_", pr_Card.User_id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("Pr_Card_PACKAGE.UpdateCard", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool Withdrawal(Withdraw withdraw)
        {
            var p = new DynamicParameters();
            p.Add("Card_ID_", withdraw.Card_ID, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DbContext.Connection.ExecuteAsync("Pr_Card_PACKAGE.Withdrawal", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
