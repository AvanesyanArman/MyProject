using Microsoft.EntityFrameworkCore;
using ProjectDAL.Entities;

namespace ProjectDAL
{
    public class BankDbContext:DbContext
    {
        public BankDbContext()
        {
            
        }
        public BankDbContext(DbContextOptions<BankDbContext> contextOptions):
            base(contextOptions) 
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BankDbContext;");
        }
        public DbSet<Accounts> UserAccounts { get; set; }
        public DbSet<UsersAndAdmins> Users {  get; set; }

        public DbSet<Cards> UserCards { get; set; }
        public DbSet<Savings> UserSavings { get; set; }
        public DbSet<Transfers> UserTransfers { get; set; }

    }
}
