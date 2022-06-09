using RenewingPassport.Core.Data;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Infra.Service
{
    public class Pr_ReviewService : IPr_ReviewService
    {
        private readonly IPr_ReviewRepository _pr_ReviewRepository;

        public Pr_ReviewService(IPr_ReviewRepository pr_ReviewRepository)
        {
            _pr_ReviewRepository = pr_ReviewRepository;
        }


        public List<Pr_Review> GetALLReview()
        {
            return _pr_ReviewRepository.GetALLReview();
        }
        public bool CreateReview(Pr_Review pr_Review)
        {
            return _pr_ReviewRepository.CreateReview(pr_Review);
        }
        public bool UpdateReview(Pr_Review pr_Review)
        {
            return _pr_ReviewRepository.UpdateReview(pr_Review);
        }
        public bool DeleteReview(int id)
        {
            return _pr_ReviewRepository.DeleteReview(id);
        }

        public float GetAvarage()
        {
            return _pr_ReviewRepository.GetAvarage();
        }
    }
}
