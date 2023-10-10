using System.ComponentModel;

namespace gerenciadorTarefas.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set;}
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataVencimento { get; set; }
        public string? Responsavel { get; set; }
        public StatusTarefa Status { get; set; }

        public int? UsuarioID { get; set; }
        public virtual UsuarioModel? Usuario { get; set; }
    }

    public enum StatusTarefa
    {
        [Description("Pendente")]
        Pendente = 1,
        [Description("Em Andamento")]
        EmAndamento = 2,
        [Description("Concluido")]
        Concluida = 3
    }
}
