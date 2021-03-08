namespace Cadastro.API.Models
{
    public class Pessoa
    {
        public Pessoa(){}

        public Pessoa(int id, string nome, string endereco, string email) 
        {
                this.Id = id;
                this.Nome = nome;
                this.Email = email;
                this.Endereco = endereco;
               
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
    }
}