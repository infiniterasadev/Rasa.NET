using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Rasa.DBL.Database
{
    using Tables.Auth;

    internal class AuthDatabaseContext : DbContext
    {
        readonly DbConnection connection;

        public DbSet<Account> Accounts { get; set; }

        public AuthDatabaseContext(DbConnection connection)
        {
            this.connection = connection;            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(connection);
        }
    }
}
