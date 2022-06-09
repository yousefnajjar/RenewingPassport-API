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
    public class Pr_PaymantController : ControllerBase
    {
        private readonly  IPr_PaymantService _PaymantService;
        public Pr_PaymantController(IPr_PaymantService PaymantService)
        {
            _PaymantService = PaymantService;
        }
        [HttpGet]
        public List<PaymantFollowUp> GetAllPaymantInfo()
        {
            return _PaymantService.GetAllPaymantInfo();
        }

        [HttpPost]
        public bool Create([FromBody]  Pr_Paymant pr_Paymant)
        {
            return _PaymantService.CreatePaymant(pr_Paymant);
        }

        [HttpGet]
        [Route("GetSum")]
        public int GetSum()
        {
            return _PaymantService.GetSum();
        }

    }
}
