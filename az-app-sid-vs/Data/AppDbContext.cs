﻿using Microsoft.EntityFrameworkCore;

namespace az_app_sid_vs.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Person> Persons { get; set; }
    }
}
