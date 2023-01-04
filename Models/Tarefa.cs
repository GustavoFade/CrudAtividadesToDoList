using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudTodoListApi.Models
{
    [Table("tarefa")]
    public class Tarefa
    {
        [Key]
        public int id { get; set; }
        public string nomeTarefa { get; set; }
        public bool concluido { get; set; }
        public DateTime dataDeCriacao { get; set; }
    }
}