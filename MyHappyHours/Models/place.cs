using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; 

namespace MyHappyHours.Models
{
    public class place
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string aliasname { get; set; }
        public int? categoryId { get; set; } 
        public int? SUbcategoryId { get; set; }
        public int AddressId { get; set; }

        public ICollection<Category> categories { get; set; }
        public ICollection<Address> addresses { get; set; }


    }
}
