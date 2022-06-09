using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RenewingPassport.Core.Data
{
    public class Pr_Testimonial
    {

        [Key]
        public int Testimonial_Id { get; set; }

        public string Name { get; set; }

        public string Imagepath { get; set; }

        public string  Status { get; set; }

        public string Feedback { get; set; }

        public int Website_Id { get; set; }

        [ForeignKey("Website_Id")]
        public virtual Pr_Website Pr_Website { get; set; }

    }
}
