using RenewingPassport.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Core.Service
{
    public interface IPr_TestimonialService
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
