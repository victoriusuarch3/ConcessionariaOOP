namespace ConcessionariaOOP.Classes
{
    public class Cliente
    {
        protected string Email {get; set;}
        protected string Telefone {get; set;}

        public Cliente(string email, string telefone){
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