using Microsoft.EntityFrameworkCore;
using schoolAPI.Models;

namespace schoolAPI.Contexts

{
    public class DbApplicationContext : DbContext
    {
        public DbApplicationContext(DbContextOptions<DbApplicationContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<StudyProgramme> StudyProgrammes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Seed(builder);
            base.OnModelCreating(builder);
        }

        private void Seed(ModelBuilder builder)
        {
           
        }
    }
}
