using gerenciadorTarefas.Models;

namespace gerenciadorTarefas.Repositorios.Interfaces
{
    public interface ITarefaRepositorio
    {
        Task<List<TarefaModel>> ListarUsuarios();
        Task<TarefaModel> BuscarID(int id);
        Task<TarefaModel> Adicionar(TarefaModel model);
        Task<TarefaModel> Atualizar(TarefaModel model, int id);
        Task<bool> Apagar(int id);
    }
}
