using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RenewingPassport.Core.Data
{
    public class Pr_About_Us
    {

        [Key]

        public int About_Us_Id { get; set; }
        public string Mission { get; set; }
        public string Workinghour { get; set; }
        public string Vision { get; set; }
        public string Goals { get; set; }
        public int Website_Id { get; set; }

        [ForeignKey("Website_Id")]
        public virtual Pr_Website Pr_Website { get; set; }
    }
}
