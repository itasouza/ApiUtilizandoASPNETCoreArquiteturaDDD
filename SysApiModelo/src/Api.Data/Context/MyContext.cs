using Api.Data.Mapping;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Data.Context
{
    public class MyContext:DbContext
    {
        public DbSet<UsuarioEntity> TB_USUARIO { get; set; }

        public MyContext (DbContextOptions<MyContext> options):base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UsuarioEntity>(new UsuarioMap().Configure);
        }
    }
}
