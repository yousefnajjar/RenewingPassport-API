using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RenewingPassport.Core.Data
{
    public class Pr_Website
    {
        [Key]
        public int Website_Id { get; set; }
        public string Website_Name { get; set; }

        public string Logo { get; set; }

        public string Location { get; set; }

        public string Phonenumber { get; set; }

        public string Email { get; set; }

        public string Descrption { get; set; }

        public ICollection<Pr_Gallery> pr_Galleries { get; set; }
        public ICollection<Pr_Review> pr_Reviews { get; set; }
        public ICollection<Pr_About_Us> pr_About_Us { get; set; }
        public ICollection<Pr_Testimonial> pr_Testimonials { get; set; }
        public ICollection<Pr_Contact_Us> pr_Contact_Us { get; set; }
        public ICollection<Pr_Announcement> pr_Announcements { get; set; }
    }
}
