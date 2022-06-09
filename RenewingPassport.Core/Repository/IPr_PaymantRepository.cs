using RenewingPassport.Core.Data;
using RenewingPassport.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Core.Repository
{
   
    public interface IPr_PaymantRepository
    {
        bool CreatePaymant(Pr_Paymant pr_Paymant);
        List<PaymantFollowUp> GetAllPaymantInfo();
        int GetSum();
        
    }
}
