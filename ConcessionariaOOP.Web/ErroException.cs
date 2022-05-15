namespace ConcessionariaOOP.Web
{
    public class MyException : System.Exception    
    {
        public ErroException(string mensagem)
        : base(mensagem)
        {
            
        }
    }
}