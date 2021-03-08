using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Cadastro.API.Models;
using System;
using System.Linq;
using Cadastro.API.Data;
using Cadastro.API.Interfaces.Repository;
using Cadastro.API.Util;

namespace Cadastro.API.Controllers
{
    [ApiController]
    [Route("api/Cadastro")]
    public class PessoaControllers : Controller
    {
        private readonly DataContext _context;
        public readonly IRepository _Repo;
        public PessoaControllers(DataContext context, IRepository repo)
        {
            _Repo = repo;
            _context = context;
        }
        public List<Pessoa> Pessoas = new List<Pessoa>();

        [HttpGet("ObtemTodasPessoas")]
        public IActionResult Get()
        {
            return Ok(_Repo.ObtemTodasPessoas());
        }
        [HttpGet("BuscarPessoa")]
        public IActionResult Get(int Id)
        {
            var pessoa = _Repo.ObtemPessoaPorId(Id);
            if (pessoa == null)
                return BadRequest($"Nenhuma pessoa com id '{Id}' encontrada");

            return Ok(pessoa);
        }

        [HttpDelete("DeletarPessoa")]
        public IActionResult Delete(int Id)
        {
            try
            {
                if (_Repo.DeletaPessoaPorId(Id))
                    return Ok($"Sucesso ao deletar id: {Id}");
                else
                    return BadRequest($"Não foi possível deletar id: {Id}");
            }
            catch(CadastroCheckException exc)
            {
                return BadRequest($"Erro ao tentar deletar o cadastro da pessoa id {Id} - {exc.Message}");
            }
        }

        [HttpPost("CadastrarPessoa")]
        public IActionResult Post(Pessoa pessoa)
        {
            try
            {    
                if (pessoa == null)
                    return BadRequest($"Objeto inválido para pessoa");
                
                if(_Repo.Add(pessoa))
                    return Ok($"Nova pessoa incluída - Pessoa {pessoa.Id}") ;

                return BadRequest("Erro ao salvar pessoa");
            }
            catch(Exception e)
            {
                return BadRequest($"Erro ao incluir pessoa: {e.Message}");          
            }
        }

        [HttpPut("AtualizaCadastro")]
        public IActionResult Put(Pessoa pessoa)
        {
            try
            {
                if (pessoa == null)
                    return BadRequest($"Objeto inválido para Pessoa");

               
                if (_Repo.Update(pessoa))
                        return Ok($"Atualização dos dados do ID - {pessoa.Id} com sucesso");

                return BadRequest("Erro ao atualizar o cadastro.");
            }
            catch (CadastroCheckException e)
            {
                return BadRequest($"Erro ao atualizar o registro: {e.Message}");
            }
            catch (Exception e)
            {
                return BadRequest($"Erro grave ao atualizar o registro: {e.Message}");
            }
        }
    }
}