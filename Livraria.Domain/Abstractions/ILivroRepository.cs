using Livraria.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Domain.Abstractions
{
    public interface ILivroRepository
    {
        Task<IEnumerable<Livro>> ObterLivros();
        Task<Livro?> ObterLivro(int Id);
        Task<Livro> AdicionarLivro(Livro livro);
        Task DeletarLivro(int Id);
        Task AtualizarLivro(Livro livro);
    }
}
