using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RenewingPassport.Core.Data;
using RenewingPassport.Core.Service;
using System.Collections.Generic;

namespace RenewingPassport.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pr_ReviewController : ControllerBase
    {
        private readonly IPr_ReviewService _pr_ReviewService;

        public Pr_ReviewController(IPr_ReviewService pr_ReviewService)
        {
            _pr_ReviewService = pr_ReviewService;
        }

        [HttpGet]
        [Route("GetALLReview")]
        public List<Pr_Review> GetALLReview()
        {
            return _pr_ReviewService.GetALLReview();
        }

        [HttpPost]
        [Route("CreateReview")]
        public bool CreateReview([FromBody] Pr_Review pr_Review)
        {
            return _pr_ReviewService.CreateReview(pr_Review);
        }

        [HttpPut]
        [Route("UpdateReview")]
        public bool UpdateReview([FromBody] Pr_Review pr_Review)
        {
            return _pr_ReviewService.UpdateReview(pr_Review);
        }

        [HttpDelete]
        [Route("DeleteReview/{id}")]
        public bool DeleteReview(int id)
        {
            return _pr_ReviewService.DeleteReview(id);
        }


        [HttpGet]
        [Route("Getavrage")]
        public float Getavrage()
        {
            return _pr_ReviewService.GetAvarage();
        }
    }
}
