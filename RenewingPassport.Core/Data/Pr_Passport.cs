using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RenewingPassport.Core.Data
{
    public class Pr_Passport
    {
        [Key]
        public int Passport_Id { get; set; }
        public string Passportnumber { get; set; }
        public string Fullname { get; set; }
        public int National_No { get; set; }

        public string Gender { get; set; }

        public string Img_Card { get; set; }

        public string Img_Oldpassport { get; set; }

        public DateTime Birthdate { get; set; }

        public string Placeofbirth { get; set; }

        public DateTime Expirydate { get; set; }

        public DateTime Dateofissue { get; set; }

        public DateTime Requesttime { get; set; }
          
        public int User_Id { get; set; }

        public string Status { get; set; }
        public string Passport_Type { get; set; }
        public string Mother_Name { get; set; }
        public string Authority { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }

        [ForeignKey("User_Id")]
        public virtual Pr_Userlogin Pr_Userlogin{ get; set; }


    }
}
