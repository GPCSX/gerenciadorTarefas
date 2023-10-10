using gerenciadorTarefas.Models;

namespace gerenciadorTarefas.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> ListarUsuarios();
        Task<UsuarioModel> BuscarID(int id);
        Task<UsuarioModel> Adicionar(UsuarioModel model);
        Task<UsuarioModel> Atualizar(UsuarioModel model, int id);
        Task<bool> Apagar(int id);
    }
}
