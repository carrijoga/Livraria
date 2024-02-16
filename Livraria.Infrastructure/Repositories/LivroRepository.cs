using Livraria.Domain.Abstractions;
using Livraria.Domain.Entities;
using Livraria.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Infrastructure.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly ApplicationDbContext _context;

        public LivroRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Livro> AdicionarLivro(Livro livro)
        {
            if (_context is not null && livro is not null && _context.Livros is not null)
            {
                _context.Livros.Add(livro);

                await _context.SaveChangesAsync();

                return livro;
            }
            else
            {
                throw new InvalidOperationException("Dados inválidos...");
            }
        }

        public Task AtualizarLivro(Livro livro)
        {
            throw new NotImplementedException();
        }

        public Task DeletarLivro(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Livro?> ObterLivro(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Livro>> ObterLivros()
        {
            throw new NotImplementedException();
        }
    }
}
