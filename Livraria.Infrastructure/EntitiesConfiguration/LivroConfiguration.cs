using Livraria.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Infrastructure.EntitiesConfiguration
{
    public class LivroConfiguration : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder) 
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Title).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Author).HasMaxLength(200).IsRequired();
            builder.Property(p => p.Release_at).IsRequired();
            builder.Property(p => p.Cover).HasMaxLength(200);
            builder.Property(p => p.Created_at);
            builder.Property(p => p.Updated_at);
        }
    }
}
