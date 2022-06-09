using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RenewingPassport.Core.Data
{
    public class Pr_Contact_Us
    {
        [Key]
        public int Contact_Us_Id { get; set; }

        public string Name { get; set; }

        public string Phone_No { get; set; }

        public string Email { get; set; }

        public string Massege { get; set; }

        public int Website_Id { get; set; }

        [ForeignKey("Website_Id")]
        public virtual Pr_Website Pr_Website { get; set; }
    }
}
