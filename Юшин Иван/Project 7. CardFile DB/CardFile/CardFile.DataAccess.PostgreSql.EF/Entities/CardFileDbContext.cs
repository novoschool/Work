using CardFile.Core.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFile.DataAccess.PostgreSql.EF.Entities
{
    public class CardFileDbContext : DbContext
    {
        private const string ConnectionString = @"Server=localhost;port=5432;Database=CardFile2;User Id=postgres;Password=Qwerty123;";
        // Database first
        // Code first
        public CardFileDbContext() : base("MainContext") // base(new NpgsqlConnection(ConnectionString), true)
        { }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
