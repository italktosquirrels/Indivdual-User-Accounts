using System;
using System.Collections.Generic;
using System.Text;
using IUAv2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IUAv2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        //DbSets for Additional Tables
        public DbSet<Team> Teams { get; set; }
    }
}
