using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RenewingPassport.Core.Data
{
    public class Pr_Card
    {
        [Key]
        public int Card_ID { get; set; }
        public string Card_Name { get; set; }
        public int Cvc_Card { get; set; }
        public int Balance { get; set; }
        public int Card_Number { get; set; }
        public DateTime Expiry_Date { get; set; }
        public int User_id { get; set; }
        [ForeignKey("User_id")]
        public virtual Pr_Userlogin Pr_Userlogin { get; set; }

       
    }
}
