using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RenewingPassport.Core.Data;
using RenewingPassport.Core.Service;
using System.Collections.Generic;

namespace RenewingPassport.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pr_RoleController : ControllerBase
    {
        private readonly IPR_RoleService _pr_Role;
        public Pr_RoleController(IPR_RoleService pr_Role)
        {
            _pr_Role = pr_Role;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Pr_Role>), StatusCodes.Status200OK)]
        public List<Pr_Role> GetAllBook()
        {
            return _pr_Role.GetAllRole();
        }


        [HttpPost]
        [Route("CreateRole")]
        public bool CreateRole([FromBody] Pr_Role pr_Role)
        {
            return _pr_Role.CreateRole(pr_Role);
        }


        [HttpPut]
        [Route("UpdatRole")]
        public bool UpdatRole([FromBody] Pr_Role pr_Role)
        {
            return _pr_Role.UpdatRole(pr_Role);
        }

        [HttpDelete]
        [Route("DeleteRole/{id}")]
        public bool DeleteRole(int id)
        {
            return _pr_Role.DeleteRole(id);
        }
    }
}
