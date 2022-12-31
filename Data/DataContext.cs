using CrudTodoListApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudTodoListApi.Data
{
    public class DataContext : DbContext
    {
        const string CONNECTION_STRING = "DataSource=todolist.db;Cache=Shared";

        public DbSet<Tarefa> tarefas {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(CONNECTION_STRING);
            base.OnConfiguring(optionsBuilder);
        }
    }
}