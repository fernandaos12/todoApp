using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoApp.Core.Entities;

namespace ToDoApp.Infra.Persistence.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {      
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
            .ToTable("TB_CATEGORY")
            .HasKey(m => m.Id);

            builder
            .HasMany(m => m.ToDos)
            .WithOne()
            .HasForeignKey(m => m.TodoId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}