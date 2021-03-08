using System.Collections.Generic;
using Cadastro.API.Models;
using Cadastro.API.Util;

namespace Cadastro.API.Interfaces.Repository
{
    public interface IRepository 
    {
        bool Add<T> (T entity) where T : class;
        bool Update<T> (T entity) where T : class;
        public List<Pessoa> ObtemTodasPessoas();
        public Pessoa ObtemPessoaPorId(int id);
        public bool DeletaPessoaPorId(int id);
    }
}