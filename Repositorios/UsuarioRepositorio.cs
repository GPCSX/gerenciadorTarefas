using gerenciadorTarefas.Data;
using gerenciadorTarefas.Models;
using gerenciadorTarefas.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace gerenciadorTarefas.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly TarefasDBContext _dbContext;
        public UsuarioRepositorio(TarefasDBContext tarefasDBContext) 
        {
            _dbContext = tarefasDBContext;
        }
        public async Task<UsuarioModel> BuscarID(int id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<UsuarioModel>> ListarUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }
        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return usuario;
        }

        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioID = await BuscarID(id);

            if(usuarioID == null)
            {
                throw new Exception("O Usuário não foi encontrado no Banco de Dados");
            }

            _dbContext.Usuarios.Remove(usuarioID);
            await _dbContext.SaveChangesAsync();
            
            return true;

        }

        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioID = await BuscarID(id);

            if(usuarioID == null)
            {
                throw new Exception("O Usuário não foi encontrado no Banco de Dados");
            }

            usuarioID.Nome = usuario.Nome;
            usuarioID.Email = usuario.Email;

            _dbContext.Usuarios.Update(usuarioID);
            await _dbContext.SaveChangesAsync();
            
            return usuarioID;
        }
    }
}
