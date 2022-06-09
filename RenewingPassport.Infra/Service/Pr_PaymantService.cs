using RenewingPassport.Core.Data;
using RenewingPassport.Core.DTO;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Infra.Service
{
    public class Pr_PaymantService : IPr_PaymantService
    {
        private readonly IPr_PaymantRepository _PaymantRepository;
        public Pr_PaymantService(IPr_PaymantRepository PaymantRepository)
        {
            _PaymantRepository = PaymantRepository;
        }
        public bool CreatePaymant(Pr_Paymant pr_Paymant)
        {
            return _PaymantRepository.CreatePaymant(pr_Paymant);
        }

        public List<PaymantFollowUp> GetAllPaymantInfo()
        {
            return _PaymantRepository.GetAllPaymantInfo();
        }

        public int GetSum()
        {
            return _PaymantRepository.GetSum();
        }
    }
}
