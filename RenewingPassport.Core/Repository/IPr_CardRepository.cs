using RenewingPassport.Core.Data;
using RenewingPassport.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Core.Repository
{
    public interface IPr_CardRepository
    {
        List<Pr_Card> GetALL();
        bool CreateCard(Pr_Card pr_Card);
        bool UpdateCard(Pr_Card pr_Card);
        bool DeleteCard(int id);
        bool Withdrawal(Withdraw withdraw);
        Pr_Card getById(int id);
    }
}
