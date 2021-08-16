using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using BojanDamchevski.JokesWebApp.Models.Domain;

namespace BojanDamchevski.JokesWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BojanDamchevski.JokesWebApp.Models.Domain.Joke> Joke { get; set; }
    }
}
