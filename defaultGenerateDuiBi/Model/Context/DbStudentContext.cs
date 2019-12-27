using Microsoft.EntityFrameworkCore;

namespace defaultGenerateDuiBi.Model.Context
{
    public class DbStudentContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=(LocalDB)\ProjectsV13;Initial Catalog=test;Integrated Security=True");
        }
    }
}