using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using TodoApi.Models;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;

        public DbSet<TodoApi.Models.Additional_characteristic>? Additional_characteristic { get; set; }

        public DbSet<TodoApi.Models.Audience>? Audience { get; set; }

        public DbSet<TodoApi.Models.Educational_building>? Educational_building { get; set; }

        public DbSet<TodoApi.Models.Equipment_list>? Equipment_list { get; set; }

        public DbSet<TodoApi.Models.Software_list>? Software_list { get; set; }


    }
}