namespace Cadastro.API.Util
{
    public class CadastroCheckException : System.Exception
    {
        public CadastroCheckException() { }
        public CadastroCheckException(string message) : base(message) { }
        public CadastroCheckException(string message, System.Exception inner) : base(message, inner) { }
        protected CadastroCheckException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}