﻿using AutomatMediciones.Dominio.Caracteristicas.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomatMediciones.Dominio.Infraestructura.Maps
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuarios");

            builder.HasKey(x => x.UsuarioId);
            builder.Property(x => x.UsuarioId).HasColumnName("usuario_id").HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(x => x.Nombre).HasColumnName("nombre").HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(x => x.Activo).HasColumnName("activo").HasColumnType("TINYINT").IsRequired();
        }
    }
}