using CrudTodoListApi.Data;
using CrudTodoListApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CrudTodoListApi.Controllers
{
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private DataContext dbContext;
        public TarefaController([FromServices] DataContext dbContext){
            this.dbContext = dbContext;
        }
        
        [HttpGet("/{idTask}")]
        public ActionResult ObterTarefa([FromRoute] int idTask){
            Tarefa? tarefas = dbContext.tarefas
                                .Where(tarefa => tarefa.id == idTask)
                                .AsNoTracking()
                                .FirstOrDefault();
            if (tarefas == null) return NotFound();
            return Ok(tarefas);
        }
        [HttpGet("/")]
        public ActionResult ObterTodasTarefa(){
            List<Tarefa> tarefas = dbContext.tarefas.AsNoTracking().ToList();
            return Ok(tarefas);
        }

        [HttpPost("/")]
        public ActionResult InserirTarefa([FromBody] Tarefa tarefa){

            if (tarefa.DataDeCriacao == DateTime.MinValue)
            {
                tarefa.DataDeCriacao = DateTime.UtcNow;
            }
            dbContext.tarefas.Add(tarefa);
            dbContext.SaveChanges();

            return Ok(tarefa);
        }

        [HttpPut("/{idTask}")]
        public ActionResult AlterarTarefa([FromRoute] int idTask ,[FromBody] Tarefa tarefa){
            Tarefa? tarefaDb = dbContext.tarefas
                                .Where(tarefa => tarefa.id == idTask)
                                .FirstOrDefault();
            if (tarefaDb == null) return NotFound();

            tarefaDb.NomeTarefa = tarefa.NomeTarefa;
            tarefaDb.Concluido = tarefa.Concluido;

            dbContext.tarefas.Update(tarefaDb);
            dbContext.SaveChanges();

            return Ok(tarefaDb);
        }

        [HttpDelete("/{idTask}")]
        public ActionResult DeletarAtividade([FromRoute] int idTask){
            Tarefa? tarefaDb = dbContext.tarefas
                                .Where(tarefa => tarefa.id == idTask)
                                .FirstOrDefault();
            if (tarefaDb == null) return NotFound();

            dbContext.tarefas.Remove(tarefaDb);
            dbContext.SaveChanges();
            return Ok();
        }
    }
}