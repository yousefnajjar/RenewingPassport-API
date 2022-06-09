using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RenewingPassport.Core.Data
{
    public class Pr_Announcement
    {
        [Key]

        public int Announcement_Id { get; set; }

        public string Text { get; set; }

        public DateTime Publisheddate { get; set; }

        public string Subject { get; set; }
        public string Category { get; set; }
        public int Website_Id { get; set; }

        [ForeignKey("Website_Id")]
        public virtual Pr_Website Pr_Website { get; set; }
    }
}
