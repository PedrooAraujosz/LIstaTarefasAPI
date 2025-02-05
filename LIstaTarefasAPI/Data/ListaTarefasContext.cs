using LIstaTarefasAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LIstaTarefasAPI.Data
{
    public class ListaTarefasContext : DbContext
    {
        public ListaTarefasContext(DbContextOptions<ListaTarefasContext> options) : base(options)
        {
        }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<TipoTarefa> TiposTarefas { get; set; }
    }
}
