using MeuCrud12.Models;

using MeuCrud12.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuCrud12.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly Data.SistemaTarefasDBContex _dbContext;
        public UsuarioRepositorio(Data.SistemaTarefasDBContex sistemaTarefasDBContex)
        {
            _dbContext = sistemaTarefasDBContex;
        }

        public async Task<List<UsuarioModel>> BuscarPorId(int id)
        {
           
            return await _dbContext.Usuarios.Where(x => x.Id == id.ToString()).ToListAsync();

        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }
        public Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            throw new NotImplementedException();
        }


    }
}
