using ASPPatterns.Chap3.SmartUI.Web.Entity;
using System;
using System.Data.Entity;
using System.Reflection;

namespace ASPPatterns.Chap3.SmartUI.Web
{
    public class AspPatternsDbContext : DbContext
    {
        public AspPatternsDbContext():base("name=ASPPatternsConnectionString")
        {
            Database.SetInitializer<AspPatternsDbContext>(null);
            Database.Log = x =>
            {
                var info = $"EF 执行 Sql: \n{x}";

                Console.WriteLine(info);
            };
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Product> Products { get; set; }
    }
}