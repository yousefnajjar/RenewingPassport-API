using RenewingPassport.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RenewingPassport.Core.Service
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
        Task SendRejectEmailAsync(MailRequest mailRequest);
        Task SendPendingEmailAsync(MailRequest mailRequest);

       

    }
}
