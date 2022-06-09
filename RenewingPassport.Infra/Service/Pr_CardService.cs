using RenewingPassport.Core.Data;
using RenewingPassport.Core.DTO;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Infra.Service
{
    public class Pr_CardService : IPr_CardService
    {
        private readonly IPr_CardRepository _pr_CardRepository;
        public Pr_CardService(IPr_CardRepository pr_CardRepository)
        {
            _pr_CardRepository = pr_CardRepository;
        }
        public bool CreateCard(Pr_Card pr_Card)
        {
            return _pr_CardRepository.CreateCard(pr_Card);
        }

        public bool DeleteCard(int id)
        {
            return _pr_CardRepository.DeleteCard(id);
        }

        public List<Pr_Card> GetALL()
        {
            return _pr_CardRepository.GetALL();
        }

        public Pr_Card getById(int id)
        {
            return _pr_CardRepository.getById(id);
        }

        public bool UpdateCard(Pr_Card pr_Card)
        {
            return _pr_CardRepository.UpdateCard(pr_Card);
        }

        public bool Withdrawal(Withdraw withdraw)
        {
            return _pr_CardRepository.Withdrawal(withdraw);
        }
    }
}
