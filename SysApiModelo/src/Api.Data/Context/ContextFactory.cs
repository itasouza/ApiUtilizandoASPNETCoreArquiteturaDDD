using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Usado para criar as migrações
            //var connectionString = "Server=localhost;Port=3306;DataBase=DbModelo;Uid=root;Pwd=";
            var connectionString = "Server=DESKTOP-MO51FPC\\SQLEXPRESS;Database=ApiDB;User Id=sa;Password=root;";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
           /// optionsBuilder.UseMySql(connectionString);
            optionsBuilder.UseSqlServer(connectionString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
