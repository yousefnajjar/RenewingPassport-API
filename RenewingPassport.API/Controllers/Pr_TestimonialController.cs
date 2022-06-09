using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RenewingPassport.Core.Data;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.IO;

namespace RenewingPassport.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pr_TestimonialController : ControllerBase
    {
        private readonly IPr_TestimonialService pr_TestimonialService;

        public Pr_TestimonialController(IPr_TestimonialService _pr_TestimonialService)
        {
            pr_TestimonialService = _pr_TestimonialService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Pr_Testimonial>), StatusCodes.Status200OK)]
        public List<Pr_Testimonial> GetAllTestimonial()
        {
            return pr_TestimonialService.GetAllTestimonial();
        }

        [HttpPost]
        public bool Create([FromBody] Pr_Testimonial pr_Testimonial)
        {
            return pr_TestimonialService.CreateTestimonial(pr_Testimonial);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public bool Delete(int id)
        {
            return pr_TestimonialService.DeleteTestimonial(id);
        }

        [HttpPut]
        [Route("UpdateTestimonial")]
        public bool Update([FromBody] Pr_Testimonial pr_Testimonial)
        {
            return pr_TestimonialService.UpdateTestimonial(pr_Testimonial);
        }



        /////Image Upload:
        ///
        [HttpPost]
        [Route("UploadTestimonialImage")]
        public Pr_Testimonial UploadTestimonialImage()
        {
            try
            {
                // Image -----> Request ----> Form
                var file = Request.Form.Files[0];

                // file.FileName
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;

                // create folder "Images" in Tahaluf.LMS.API
                var fullPath = Path.Combine("C:\\Users\\User\\Desktop\\final project V3\\Angular\\RenewingPassport\\src\\assets\\Rp_Images", fileName);

                // FileStream
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                // DataBase
                Pr_Testimonial testimonial = new Pr_Testimonial();
                testimonial.Imagepath = fileName;
                return testimonial;

            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
