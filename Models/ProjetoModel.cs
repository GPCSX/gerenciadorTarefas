using System.ComponentModel.DataAnnotations;

namespace gerenciadorTarefas.Models
{
    public class ProjetoModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O Campo Titulo é Obrigatorio ")]
        public required string Titulo { get; set; }
        public string? Descricao { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DataCriacao { get; set; }
    }
}
