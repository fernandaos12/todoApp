using System.Reflection;
using Microsoft.EntityFrameworkCore;
using todoApp.Data.EntitiesModel;


namespace ToDoApp.Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ToDo> To_Do { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());  
            //adiciona todas as classes de uma vez diminuindo o tamanho qdo entidades muito grandes using reflections 
            //aplicado na camada de infra em configurations           
       
        }
    }
}
