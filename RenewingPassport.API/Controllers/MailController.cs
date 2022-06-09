using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RenewingPassport.Core.DTO;
using RenewingPassport.Core.Service;
using System;
using System.Threading.Tasks;

namespace RenewingPassport.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMailService mailService;
        public MailController(IMailService mailService)
        {
            this.mailService = mailService;
        }

        [HttpPost("mailrequest")]

        public async Task<IActionResult> SendMail([FromBody] MailRequest request)
        {
            try
            {
                await mailService.SendEmailAsync(request);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }

        }



        [HttpPost("mailPending")]

        public async Task<IActionResult> SendPendingMail([FromBody] MailRequest request)
        {
            try
            {
                await mailService.SendPendingEmailAsync(request);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }

        }


        [HttpPost("mailReject")]

        public async Task<IActionResult> SendRejectMail([FromBody] MailRequest request)
        {
            try
            {
                await mailService.SendRejectEmailAsync(request);
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }

        }
        //mailContact

      







    }
}
