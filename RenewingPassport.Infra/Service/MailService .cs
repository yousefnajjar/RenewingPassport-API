using RenewingPassport.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RenewingPassport.Core.Service;
using Microsoft.Extensions.Options;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace RenewingPassport.Infra.Service
{
    public class MailService : IMailService
    {
        private readonly MailSettings _mailSettings;
        public MailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }
        public async Task SendEmailAsync(MailRequest mailRequest)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_mailSettings.Mail);
            email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
            email.Subject = " Renewing Passport Request.";
            var builder = new BodyBuilder();
            builder.HtmlBody = $" Dear {mailRequest.Username} Thank you for using our website to renew your passport.\n " +
                $"We are happy to inform you that your passport renewal has been completed. \n" +
                $"To receive your new passport, please visit the Civil Status and Passports Department.\n";
            email.Body = builder.ToMessageBody();
            using var smtp = new SmtpClient();
            smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(_mailSettings.Mail, _mailSettings.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }




        public async Task SendRejectEmailAsync(MailRequest mailRequest)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_mailSettings.Mail);
            email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
            email.Subject = " Renewing Passport Request.";
            var builder = new BodyBuilder();
            builder.HtmlBody = $" Dear {mailRequest.Username} Thank you for using our website to renew your passport. \n" +
                $"Unfortunately, your passport renewal has been rejected. \n" +
                $"Please ensure that the data attached to the renewal process is accurate, or contact us, or visit the Civil Status and Passports Department to complete the renewal process.";
            email.Body = builder.ToMessageBody();
            using var smtp = new SmtpClient();
            smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(_mailSettings.Mail, _mailSettings.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }



        public async Task SendPendingEmailAsync(MailRequest mailRequest)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_mailSettings.Mail);
            email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
            email.Subject = " Renewing Passport Request.";
            var builder = new BodyBuilder();
            builder.HtmlBody = $"Dear {mailRequest.Username} Thank you for using our website to renew your passport.\n" +
                $" We would like to inform you that your passport renewal application is under study.\n" +
                $" When the process is completed, you will be contacted via the attached e-mail.\n" +
                $" Please visit your prfile and complete paymant process\n";
            email.Body = builder.ToMessageBody();
            using var smtp = new SmtpClient();
            smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(_mailSettings.Mail, _mailSettings.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }


    }
}
