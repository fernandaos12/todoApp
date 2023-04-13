using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todoApp.Data.EntitiesModel;

namespace ToDoApp.Infra.Persistence.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
           .ToTable("TB_USERS")
           .HasKey(m => m.Id);

            builder
           .HasMany(m => m.ToDos)
           .WithOne()
           .HasForeignKey(m => m.TodoId)
           .OnDelete(DeleteBehavior.Restrict);
        }
    }
}