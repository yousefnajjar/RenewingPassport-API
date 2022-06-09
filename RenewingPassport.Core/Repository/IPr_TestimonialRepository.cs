using RenewingPassport.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Core.Repository
{
    public interface IPr_TestimonialRepository
    {
        //Read
        List<Pr_Testimonial> GetAllTestimonial();
        //Create
        bool CreateTestimonial(Pr_Testimonial pr_Testimonial);

        //Update
        bool UpdateTestimonial(Pr_Testimonial pr_Testimonial);

        //Delete
        bool DeleteTestimonial(int id);
    }
}
