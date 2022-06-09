using System;
using System.Collections.Generic;
using System.Text;

namespace RenewingPassport.Core.DTO
{
    public class AdminSearchPassportDTO
    {
       
        public string Passportnumber { get; set; }
        public string Fullname { get; set; }
        public int National_No { get; set; }
        public string Gender { get; set; }      
        public string Address { get; set; }
    }
}
