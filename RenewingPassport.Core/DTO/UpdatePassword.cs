using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Core.DTO
{
    public class UpdatePassword
    {
        public string Password { get; set; }
        public int User_Id { get; set; }
    }
}
