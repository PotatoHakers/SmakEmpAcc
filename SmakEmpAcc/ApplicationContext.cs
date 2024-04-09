using Microsoft.EntityFrameworkCore;

namespace SmakEmpAcc
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() { }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS06;Initial Catalog = EmployeeAccounting; Integrated Security = True; TrustServerCertificate= True");
        }
    }
}
