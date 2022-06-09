using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RenewingPassport.Core.Data
{
    public class Pr_Review
    {
        [Key]
        public int Review_Id { get; set; }
        public int Rate { get; set; }
        public int Website_Id { get; set; }

        [ForeignKey("Website_Id")]
        public virtual Pr_Website Pr_Website { get; set; }
    }
}
