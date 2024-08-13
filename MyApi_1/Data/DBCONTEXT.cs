using Microsoft.EntityFrameworkCore;
using MyApi_1.Models;

namespace MyApi_1.Data
{
    public class DBCONTEXT : DbContext
    {
        public DBCONTEXT(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ApiClass> Student {  get; set; }

         
  
    }
}