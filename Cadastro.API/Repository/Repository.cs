using Cadastro.API.Data;
using Cadastro.API.Models;
using Cadastro.API.Util;
using Cadastro.API.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.API.Repository
{
    public class Repository : IRepository
    {
        public DataContext _context { get; }

        public Repository(DataContext context)
        {
            _context = context;

        }
        public bool Add<T>(T entity) where T : class
        {
            if (entity is Pessoa pessoa)
                return _context.Database
                    .ExecuteSqlRaw($"Pessoa_Insert '{pessoa.Nome}', '{pessoa.Email}', '{pessoa.Endereco}'") > 0;
            else
                return false;
        }
       

        public bool Update<T>(T entity) where T : class
        {
            if (entity is Pessoa pessoa)
                return _context.Database
                    .ExecuteSqlInterpolated($"Pessoa_Update {pessoa.Id}, {pessoa.Nome}, {pessoa.Email}, {pessoa.Endereco}") > 0;
            else
                return false;
        }


        public List<Pessoa> ObtemTodasPessoas()
        {
            return _context.Pessoas.FromSqlInterpolated($"GetPessoas").ToList();
        }
        public Pessoa ObtemPessoaPorId(int id)
        {
            try
            {
                var res = _context.Pessoas.FromSqlInterpolated($"GetPessoaById {id}").ToList();

                return res.FirstOrDefault();
            }
            catch (Exception exc)
            {
                throw new CadastroCheckException($"Erro grave ao tentar Obter Pessoa id {id} - {exc.Message}");
            }
        }

        public bool DeletaPessoaPorId(int id)
        {
            try
            {
                var res = _context.Database.ExecuteSqlRaw("EXEC Pessoa_Delete {0}", id);

                return res > 0;
            }
            catch(Exception exc)
            {
                throw new CadastroCheckException($"Erro grave ao tentar deletar Pessoa id {id} - {exc.Message}");
            }
        }
    }

}