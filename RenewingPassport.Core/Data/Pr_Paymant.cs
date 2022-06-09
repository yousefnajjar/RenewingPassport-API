using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RenewingPassport.Core.Data
{
    public class Pr_Paymant
    {
        
        [Key]
        public int Paymant_ID { get; set; }
        public int Ammount { get; set; }
        public int Card_ID { get; set; }
        [ForeignKey("Card_ID")]
        public virtual Pr_Card Pr_Cards { get; set; }
    }
}
