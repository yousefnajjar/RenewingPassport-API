using RenewingPassport.Core.Data;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Infra.Service
{
    public class Pr_TestimonialService : IPr_TestimonialService
    {
        private readonly IPr_TestimonialRepository _TestimonialRepository;

        public Pr_TestimonialService(IPr_TestimonialRepository TestimonialRepository)
        {
            _TestimonialRepository = TestimonialRepository;
        }

        public bool CreateTestimonial(Pr_Testimonial pr_Testimonial)
        {
            return _TestimonialRepository.CreateTestimonial(pr_Testimonial);
        }

        public bool DeleteTestimonial(int id)
        {
            return _TestimonialRepository.DeleteTestimonial(id);
        }

        public List<Pr_Testimonial> GetAllTestimonial()
        {
            return _TestimonialRepository.GetAllTestimonial();
        }

        public bool UpdateTestimonial(Pr_Testimonial pr_Testimonial)
        {
            return _TestimonialRepository.UpdateTestimonial(pr_Testimonial);
        }
    }
}
