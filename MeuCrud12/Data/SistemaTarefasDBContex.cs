using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuCrud12.Data
{
    public class SistemaTarefasDBContex : Microsoft.EntityFrameworkCore.DbContext
    {
        public SistemaTarefasDBContex(DbContextOptions<SistemaTarefasDBContex> options)
                : base(options)
        {

        }

        public DbSet<Models.UsuarioModel> Usuarios { get; set; }
        public DbSet<Models.TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
