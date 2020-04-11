using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyHappyHours.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set;  }
        public string Country { get; set; }
        public string PostalCode { get; set; }


    }
}
