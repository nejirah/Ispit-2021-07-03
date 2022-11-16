using FIT_Api_Examples.Modul1.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FIT_Api_Examples.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Ispit20210702Posalji> Ispit20210702Posalji { get; set; }

        public ApplicationDbContext(
            DbContextOptions options) : base(options)
        {
        }
    }
}
