using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RenewingPassport.Core.Data
{
    public class Pr_country
    {

        [Key]
        public int Country_Id { get; set; }

        public string CountryType { get; set; }

        public string CountryName { get; set; }

        public string CountryImage { get; set; }

        public string CountryDescrption { get; set; }

       

    }
}
