using RenewingPassport.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Core.Service
{
    public interface IPr_ReviewService
    {
        List<Pr_Review> GetALLReview();
        bool CreateReview(Pr_Review pr_Review);
        bool UpdateReview(Pr_Review pr_Review);
        bool DeleteReview(int id);
        float GetAvarage();
    }
}

