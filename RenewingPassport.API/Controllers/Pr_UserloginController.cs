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
    public class Pr_UserloginController : ControllerBase
    {
        private readonly  IPr_UserloginService _pr_UserloginService;
        public Pr_UserloginController(IPr_UserloginService pr_UserloginService)
        {
            _pr_UserloginService = pr_UserloginService;
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<Pr_Userlogin>), StatusCodes.Status200OK)]
        public List<Pr_Userlogin> GetAllUser()
        {
            return _pr_UserloginService.GetAllUser();
        }


        [HttpPost]
        [Route("CreateUser")]
        public bool CreateUser([FromBody]  Pr_Userlogin pr_Userlogin)
        {
            return _pr_UserloginService.CreateUser(pr_Userlogin);
        }




        [HttpPost]
        [Route("GetByEmail")]
        
        public Pr_Userlogin GetByEmail([FromBody] GetByEmail email )
        {
            return _pr_UserloginService.GetByEmail(email);
        }


        [HttpPut]
        [Route("UpdatUser")]
        public bool UpdatUser([FromBody] Pr_Userlogin pr_Userlogin )
        {
            return _pr_UserloginService.UpdatUser(pr_Userlogin);
        }


        [HttpPut]
        [Route("UpdatePassword")]
        public bool UpdatPassword([FromBody] UpdatePassword updatePassword)
        {
            return _pr_UserloginService.UpdatePassword(updatePassword);
        }

        [HttpDelete]
        [Route("DeleteUser/{id}")]
        public bool DeleteUser(int id)
        {
            return _pr_UserloginService.DeleteUser(id);
        }


        /////Image Upload:
        ///
        [HttpPost]
        [Route("UploadUserImage")]
        public Pr_Userlogin UploadUserImage()
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
                Pr_Userlogin userlogin = new Pr_Userlogin();
                userlogin.Image = fileName;
                return userlogin;

            }
            catch (Exception e)
            {
                return null;
            }
        }



        

    }
}
