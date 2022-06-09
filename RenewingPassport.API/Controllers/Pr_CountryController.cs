using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RenewingPassport.Core.Data;
using RenewingPassport.Core.DTO;
using RenewingPassport.Core.Service;
using System;
using System.Collections.Generic;
using System.IO;

namespace RenewingPassport.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pr_CountryController : ControllerBase
    {
        private readonly IPr_CountryService _pr_CountryService;
        public Pr_CountryController(IPr_CountryService pr_CountryService)
        {
            _pr_CountryService = pr_CountryService;
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<Pr_country>), StatusCodes.Status200OK)]
        public List<Pr_country> GetAllcountry()
        {
            return _pr_CountryService.GetAllcountry();
        }

        [HttpPost]
        public bool Create([FromBody]  Pr_country pr_Country)
        {
            return _pr_CountryService.Createcountry(pr_Country);
        }


        [HttpDelete]
        [Route("delete/{id}")]
        public bool Delete(int id)
        {
            return _pr_CountryService.Deletecountry(id);
        }


        [HttpPost]
        [Route("getByType")]
        public List<Pr_country> GetByType(CountryType countryType)
        {
            return _pr_CountryService.GetByType(countryType);
        }

        [HttpPut]
        public bool Update([FromBody] Pr_country  pr_Country)
        {
            return _pr_CountryService.Updatecountry(pr_Country);
        }


        [HttpPost]
        [Route("UploadImage")]
        public Pr_country UploadTestimonialImage()
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
                Pr_country country = new Pr_country();
                country.CountryImage = fileName;
                return country;

            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
