using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuCrud12.Repositorios.Interfaces
{
    interface IUsuarioRepositorio
    {
        Task<List<Models.UsuarioModel>> BuscarTodosUsuarios();
        Task<Models.UsuarioModel> BuscarPorId(int id);
        Task<Models.UsuarioModel> Adicionar(Models.UsuarioModel usuario);
        Task<Models.UsuarioModel> Atualizar(Models.UsuarioModel usuario, int id);
        Task<bool> Apagar(int id);
    }
}
