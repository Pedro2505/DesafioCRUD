using DesafioCRUD.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesafioCRUD.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Tarefa> TabelaTarefa { get; set; }
    }
}
