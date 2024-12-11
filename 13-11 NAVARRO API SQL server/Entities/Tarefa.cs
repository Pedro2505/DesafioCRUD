using System.ComponentModel.DataAnnotations;
using DesafioCRUD.Controllers;

namespace DesafioCRUD.Entities
{
    public class Tarefa
    {
        [Key]
        public int Id { get; internal set; }
        public required DateTime Data { get; set; }
        public required string Descricao { get; set; }

    }

}
