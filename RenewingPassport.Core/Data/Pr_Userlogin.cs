using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RenewingPassport.Core.Data
{
    public class Pr_Userlogin
    {
        [Key]
        public int User_Id { get; set; }
        public string Firstname { get; set;}
        public string Lastname { get; set;}
        public string Password { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public DateTime Registrationtime { get; set; }
        public int Role_Id { get; set; }
        public string Passport_Type { get; set; }
        [ForeignKey ("Role_Id")]
        public virtual Pr_Role  Pr_Role{ get; set; }

        public ICollection<Pr_Passport> pr_Passports { get; set;}
    }
}
