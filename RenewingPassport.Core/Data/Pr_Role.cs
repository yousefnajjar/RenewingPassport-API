using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RenewingPassport.Core.Data
{
    public class Pr_Role
    {
        [Key]
        public int Role_Id { get; set; }
        public string Rolename { get; set;}
      

        public ICollection<Pr_Userlogin> pr_Userlogins { get; set; }
    }
}
