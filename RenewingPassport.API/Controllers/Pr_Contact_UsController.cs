using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RenewingPassport.Core.Data;
using RenewingPassport.Core.Repository;
using RenewingPassport.Core.Service;
using System.Collections.Generic;

namespace RenewingPassport.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pr_Contact_UsController : ControllerBase
    {
        private readonly IPr_Contact_UsService _pr_Contact_UsService;

        public Pr_Contact_UsController(IPr_Contact_UsService pr_Contact_UsService )
        {
            _pr_Contact_UsService = pr_Contact_UsService;
        }
     

        [HttpGet]
        [Route("GetAllContact_Us")]
        public List<Pr_Contact_Us> GetAllContact_Us()
        {
            return _pr_Contact_UsService.GetAllContact_Us();
        }

        [HttpPost]
        [Route("CreateContact_Us")]
        public bool CreateContact_Us([FromBody] Pr_Contact_Us pr_Contact_Us)
        {
            return _pr_Contact_UsService.CreateContact_Us(pr_Contact_Us);   
        }

        [HttpPut]
        [Route("UpdateContact_Us")]
        public bool UpdateContact_Us([FromBody] Pr_Contact_Us pr_Contact_Us)
        {
            return _pr_Contact_UsService.UpdateContact_Us(pr_Contact_Us);
        }

        [HttpDelete]
        [Route("DeleteContact_Us/{id}")]
        public bool DeleteContact_Us(int id)
        {
            return _pr_Contact_UsService.DeleteContact_Us(id);
        }
    }
}
