using RenewingPassport.Core.Data;
using RenewingPassport.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Core.Service
{
    public interface IPr_PaymantService
    {
        bool CreatePaymant(Pr_Paymant pr_Paymant);
        List<PaymantFollowUp> GetAllPaymantInfo();
        int GetSum();
    }
}
