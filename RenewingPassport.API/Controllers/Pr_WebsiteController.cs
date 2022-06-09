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
    public class Pr_WebsiteController : ControllerBase
    {
        private readonly IPr_WebsiteService pr_WebsiteService;

        public Pr_WebsiteController(IPr_WebsiteService _pr_WebsiteService)
        {
            pr_WebsiteService = _pr_WebsiteService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Pr_Website>), StatusCodes.Status200OK)]
        public List<Pr_Website> GetAllWebsite()
        {
            return pr_WebsiteService.GetAllWebsite();
        }

        [HttpPost]
        public bool Create([FromBody] Pr_Website pr_Website)
        {
            return pr_WebsiteService.CreateWebsite(pr_Website);
        }


        [HttpPut]
        [Route("UpdateWebsite")]
        public bool Update([FromBody] Pr_Website pr_Website)
        {
            return pr_WebsiteService.UpdateWebsite(pr_Website);
        }




        /////Image Upload:
        ///
        [HttpPost]
        [Route("UploadWebImage")]
        public Pr_Website UploadWebImage()
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
                Pr_Website website = new Pr_Website();
                website.Logo = fileName;
                return website;

            }
            catch (Exception e)
            {
                return null;
            }
        }


    }
}
