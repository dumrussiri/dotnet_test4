using dotnet_test4.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_test4.Data;
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<KYC> UserAccount {  get; set; }
    }