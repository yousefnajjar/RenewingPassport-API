using DinkToPdf;
using DinkToPdf.Contracts;
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
    public class Pr_PassportController : ControllerBase
    {
        private readonly IPr_PassportService _pr_PassportService;
       
        public Pr_PassportController(IPr_PassportService pr_PassportService)
        {
            _pr_PassportService = pr_PassportService;
          

            
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Pr_Passport>), StatusCodes.Status200OK)]
        public List<Pr_Passport> GetAllPassport()
        {
            return _pr_PassportService.GetAllPassport();
        }


        [HttpPost]
        [Route("CreatePassport")]
        public bool CreatePassport([FromBody] Pr_Passport pr_Passport)
        {
            return _pr_PassportService.CreatePassport(pr_Passport);
        }

        [HttpPut]
        [Route("UpdatPassport")]
        public bool UpdatPassport([FromBody] Pr_Passport pr_Passport )
        {
            return _pr_PassportService.UpdatPassport(pr_Passport) ;
        }

        [HttpDelete]
        [Route("DeletePassport/{id}")]
        public bool DeletePassport(int id)
        {
            return _pr_PassportService.DeletePassport(id);
        }


        [HttpPut]
        [Route("Updatstatus")]
        public bool UpdatStatus([FromBody] UpdatePassportStatus passportStatus )
        {
            return _pr_PassportService.UudateStatus(passportStatus);
        }


        /////Image Upload:
        ///
        [HttpPost]
        [Route("UploadCard")]
        public Pr_Passport UploadCardImage()
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
                Pr_Passport passport = new Pr_Passport();
                passport.Img_Card = fileName;
                return passport;

            }
            catch (Exception e)
            {
                return null;
            }
        }


        /////Image Upload:
        ///
        [HttpPost]
        [Route("UploadPassport")]
        public Pr_Passport UploadOldPassportImage()
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
                Pr_Passport passport = new Pr_Passport();
                passport.Img_Oldpassport = fileName;
                return passport;

            }
            catch (Exception e)
            {
                return null;
            }
        }


        /////Image Upload:
        ///
        [HttpPost]
        [Route("UploadPersonalImage")]
        public Pr_Passport UploadPersonalImage()
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
                Pr_Passport passport = new Pr_Passport();
                passport.Image = fileName;
                return passport;

            }
            catch (Exception e)
            {
                return null;
            }
        }


        [HttpPost]
        [Route("getbydate")]
        public List<Pr_Passport> GetByDate(SearchByDate searchByDate)
        {
            return _pr_PassportService.GetByDate(searchByDate);
        }


        [HttpGet]
        [Route("GetAllStatusPending")]
        [ProducesResponseType(typeof(List<Pr_Passport>), StatusCodes.Status200OK)]
        public List<Pr_Passport> GetAllStatusNull()
        {
            return _pr_PassportService.GetAllStatusNull();
        }


        [HttpPost]
        [Route("AdminSearch")]
        [ProducesResponseType(typeof(List<Pr_Passport>), StatusCodes.Status200OK)]
        public List<Pr_Passport> AdminSearch(AdminSearchPassportDTO adminSearch)
        {
            return _pr_PassportService.AdminSearch(adminSearch);
        }



        [HttpPut]
        [Route("Genarate")]
        public bool GenarateNewPassport( [FromBody] int id)
        {
            return _pr_PassportService.GenarateNewPassport(id);
        }


        [HttpPut]
        [Route("Reject")]
        public bool Reject([FromBody] int id)
        {
            return _pr_PassportService.RejectPassport(id);
        }


        [HttpPost]
        [Route("getpassport")]
        public Pr_Passport GetPassportByUserid(GetPassportById getPassportById)
        {
            return _pr_PassportService.GetPasspoetByUserid(getPassportById);
        }





        

    }
}
