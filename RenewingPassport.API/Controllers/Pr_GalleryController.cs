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
    public class Pr_GalleryController : ControllerBase
    {
        private readonly IPr_GalleryService _pr_GalleryService;
        public Pr_GalleryController(IPr_GalleryService pr_GalleryService)
        {
            _pr_GalleryService = pr_GalleryService;

        }

        [HttpGet]
        [Route("GetALLGallery")]
        public List<Pr_Gallery> GetALLGallery()
        {
            return _pr_GalleryService.GetALLGallery();
        }
        [HttpPost]
        [Route("CreateGallery")]
        public bool CreateGallery(Pr_Gallery pr_Gallery)
        {
            return _pr_GalleryService.CreateGallery(pr_Gallery);
        }

        [HttpPut]
        [Route("UpdateGallery")]
        public bool UpdateGallery(Pr_Gallery pr_Gallery)
        {
            return _pr_GalleryService.UpdateGallery(pr_Gallery);
        }

        [HttpDelete]
        [Route("DeleteGallery/{id}")]
        public bool DeleteGallery(int id)
        {
            return _pr_GalleryService.DeleteGallery(id);
        }



        [HttpPost]
        [Route("UploadImage")]
        public Pr_Gallery UploadImage()
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
                Pr_Gallery pr_Gallery = new Pr_Gallery();
                pr_Gallery.Image = fileName;
                return pr_Gallery;

            }
            catch (Exception e)
            {
                return null;
            }
        }


    }
}
