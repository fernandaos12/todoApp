using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using todoApp.Models;
using todoApp.Data.EntitiesModel;

namespace todoApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ToDo> To_Do { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Categories> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDo>()
            .ToTable("TB_TODO")
            .HasKey(m=>m.Id); 
            
            modelBuilder.Entity<ToDo>()
            .HasOne(m=>m.User)
            .WithMany(m=>m.ToDos)
            .HasForeignKey(m=>m.UserId);

            modelBuilder.Entity<User>()
            .ToTable("TB_USERS")
            .HasKey(m=>m.); 

            modelBuilder.Entity<User>()
            .HasMany(m=>m.ToDos)
            .WithOne(m=>m.User)
            .HasForeignKey(m=>m.ToDo_Id); 
            
            modelBuilder.Entity<Categories>()
            .ToTable("TB_CATEGORY")
            .HasKey(m=>m.Id);  
            
            modelBuilder.Entity<Categories>()
            .HasMany()
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
 
        }
    }
}
