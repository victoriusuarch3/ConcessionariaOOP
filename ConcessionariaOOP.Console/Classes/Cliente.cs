namespace ConcessionariaOOP.Classes
{
    public class Cliente : Pessoa
    {
        protected string Email {get; set;}
        protected string Telefone {get; set;}

        public Cliente(string nome, string cpf, DateTime datanascimento, string email, string telefone) 
        : base(nome, cpf, datanascimento)
        {
            SetEmail(email);
            SetTelefone(telefone);
        }
        public string GetEmail(){
            return Email;
        }
        public void SetEmail(string email){
            Email = Email;
        }
        public string GetTelefone(){
            return Telefone;
        }
        public void SetTelefone(string Telefone){
            Telefone = Telefone;
        }
    }
}