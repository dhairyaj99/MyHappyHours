using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MyHappyHours.Models
{
    public class HappyHourContext : DbContext
    {
        public HappyHourContext(DbContextOptions<HappyHourContext> options)
                : base(options)
        { }

        public DbSet<place> places { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Address> addresses { get; set; }

     }
}
