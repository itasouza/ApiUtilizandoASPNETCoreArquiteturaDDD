using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Data.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioEntity>
    {
        public void Configure(EntityTypeBuilder<UsuarioEntity> builder)
        {
            builder.ToTable("TB_USUARIO");
            builder.HasKey(u => u.Id);
            builder.HasIndex(u => u.Email).IsUnique();
            builder.Property(u => u.Nome).IsRequired().HasMaxLength(120);
            builder.Property(u => u.Email).HasMaxLength(100);
            builder.HasIndex(u => u.Login).IsUnique();
            builder.Property(u => u.Login).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Senha).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Status).IsRequired().HasMaxLength(1);

        }
    }
}
