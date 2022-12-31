using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudTodoListApi.Models
{
    [Table("tarefa")]
    public class Tarefa
    {
        [Key]
        public int id { get; set; }
        public string NomeTarefa { get; set; }
        public bool Concluido { get; set; }
        public DateTime DataDeCriacao { get; set; }
    }
}