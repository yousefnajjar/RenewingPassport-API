using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RenewingPassport.Core.Data;
using RenewingPassport.Core.DTO;
using RenewingPassport.Core.Service;
using System.Collections.Generic;

namespace RenewingPassport.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Pr_CardController : ControllerBase
    {
        private readonly IPr_CardService _pr_CardService;
        public Pr_CardController(IPr_CardService pr_CardService)
        {
            _pr_CardService = pr_CardService;
        }

        [HttpGet]
        public List<Pr_Card> GetAll()
        {
            return _pr_CardService.GetALL();
        }
        [HttpGet]
        [Route("getById/{id}")]
        public Pr_Card GetById(int id)
        {
            return _pr_CardService.getById(id);
        }

        [HttpPost]
        public bool Create([FromBody] Pr_Card pr_Card)
        {
            return _pr_CardService.CreateCard(pr_Card);
        }

        [HttpPut]
        public bool Update([FromBody] Pr_Card pr_Card)
        {
            return _pr_CardService.UpdateCard(pr_Card);
        }
        [HttpPut]
        [Route("Withdrawal")]
        public bool Withdrawal(Withdraw withdraw)
        {
            return _pr_CardService.Withdrawal(withdraw);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public bool Delete(int id)
        {
            return _pr_CardService.DeleteCard(id);
        }


    }
}
