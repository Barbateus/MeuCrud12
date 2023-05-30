using MeuCrud12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuCrud12.Repositorios.Interfaces
{
    interface IUsuarioRepositorio
    {
        Task<List<Models.UsuarioModel>> BuscarTodosUsuarios();
        Task<List<UsuarioModel>> BuscarPorId(int id);
        Task<UsuarioModel> Adicionar(Models.UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(Models.UsuarioModel usuario, int id);
        Task<bool> Apagar(int id);
    }
}
