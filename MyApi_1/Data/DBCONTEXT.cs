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

         
        // IVIDE HARD CODE  CHEYTH DBCONNCETION STRING KODUKKAM ALLEL PROGRAM.CS
        //FIL ILL KODUKKAM IVDE PROGRAM.CS FILE KODUTHIND ATH POYI NOKKAM


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb; Initial Catalog=finedge;Integrated Security=True;TrustServerCertificate=True");

        //}
    }
}