
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using todoApp.Data.EntitiesModel;


namespace ToDoApp.Infra.Persistence.Configuration
{
    public class ToDoConfiguration : IEntityTypeConfiguration<ToDo>
    { 
        public void Configure(EntityTypeBuilder<ToDo> builder)
        {
            builder
           .ToTable("TB_TODO")
           .HasKey(m => m.Id);

            builder
            .HasOne(m => m.User)
            .WithMany(m => m.ToDos)
            .HasForeignKey(m => m.Category)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}