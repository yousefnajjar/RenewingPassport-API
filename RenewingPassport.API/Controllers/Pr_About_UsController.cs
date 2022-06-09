using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RenewingPassport.Core.Data;
using RenewingPassport.Core.Service;
using System.Collections.Generic;

namespace RenewingPassport.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pr_About_UsController : ControllerBase
    {

        private readonly IPr_About_UsService _pr_About_UsService;

        public Pr_About_UsController(IPr_About_UsService pr_About_UsService)
        {
            _pr_About_UsService = pr_About_UsService;
        }

        [HttpGet]
        [Route("GetALLAboutus")]
        public List<Pr_About_Us> GetALLAboutus()
        {
            return _pr_About_UsService.GetALLAboutus();
        }

        [HttpPost]
        [Route("CreateAboutUs")]
        public bool CreateAboutUs([FromBody] Pr_About_Us pr_About_Us)
        {
            return _pr_About_UsService.CreateAboutUs(pr_About_Us);
        }

        [HttpPut]
        [Route("UpdateAboutUs")]
        public bool UpdateAboutUs([FromBody] Pr_About_Us pr_About_Us)
        {
            return _pr_About_UsService.UpdateAboutUs(pr_About_Us);
        }

        [HttpDelete]
        [Route("DeleteAboutUs/{id}")]
        public bool DeleteAboutUs(int id)
        {
            return _pr_About_UsService.DeleteAboutUs(id);   
        }
    }
}
