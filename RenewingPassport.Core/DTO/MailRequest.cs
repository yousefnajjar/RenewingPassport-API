using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Core.DTO
{
    public class MailRequest
    {
        public string ToEmail { get; set; }
        public string Username { get; set; }
        public string Body { get; set; }
        //public List<IFormFile> Attachments { get; set; }
    }
}
