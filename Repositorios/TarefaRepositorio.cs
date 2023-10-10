using gerenciadorTarefas.Models;
using gerenciadorTarefas.Repositorios.Interfaces;

namespace gerenciadorTarefas.Repositorios
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        public Task<TarefaModel> Adicionar(TarefaModel model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TarefaModel> Atualizar(TarefaModel model, int id)
        {
            throw new NotImplementedException();
        }

        public Task<TarefaModel> BuscarID(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TarefaModel>> ListarUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}
