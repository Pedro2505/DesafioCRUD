using DesafioCRUD.Data;
using DesafioCRUD.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace DesafioCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public TasksController(DataContext datacontext)
        {
            _dataContext = datacontext;
        }

        [HttpPost]
        public ActionResult<Tarefa> Create([FromBody] Tarefa tarefas)
        {
            _dataContext.Add(tarefas);
            _dataContext.SaveChanges();
            return Ok("Tarefa Adicionado com Sucesso");
        }

        [HttpGet("{id}")]
        public ActionResult<Tarefa> GetByid(int id)
        {
            var tarefaEncontrada = _dataContext.TabelaTarefa.FirstOrDefault(x => x.Id == id);
            if (tarefaEncontrada == null)
            {
                return NotFound();
            }
            return Ok(tarefaEncontrada);
        }

        [HttpGet]
        public ActionResult<List<Tarefa>> GetAll()
        {
            var tarefaGet = _dataContext.TabelaTarefa.ToList();
            if (tarefaGet == null)
            {
                return NotFound();
            }
            return Ok(tarefaGet);
        }

        [HttpPut("{id}")]
        public ActionResult<Tarefa> Put(int id, Tarefa tarefas)
        {
            var tarefaPut = _dataContext.TabelaTarefa.FirstOrDefault(x => x.Id == id);
            if (tarefaPut == null)
            {
                return NotFound();
            }

            tarefaPut.Descricao = tarefas.Descricao;

            _dataContext.Update(tarefaPut);
            _dataContext.SaveChanges();
            return Ok(tarefaPut);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var tarefaDel = _dataContext.TabelaTarefa.FirstOrDefault(x => x.Id == id);
            if (tarefaDel == null)
            {
                return NotFound();
            }
            _dataContext.Remove(tarefaDel);
            _dataContext.SaveChanges();
            return Ok("Removido com Sucesso!");
        }
    }
}
