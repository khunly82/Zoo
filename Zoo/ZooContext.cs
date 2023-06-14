using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class ZooContext: DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Lion> Lions { get; set; }
        public DbSet<Otarie> Otaries { get; set; }
        public DbSet<Elephant> Elephants { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // integrated security=true
            options.UseSqlServer(@"server=K-LAPTOP;database=Zoo;uid=sa;pwd=test1234;trustServerCertificate=true");
        }
    }
}
