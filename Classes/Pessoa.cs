namespace ConcessionariaOOP.Classes
{
    public class Pessoa
    {
       protected string Nome {get; set;}
       protected string Cpf {get; set;}
       protected DateTime DataNascimento {get; set;}

       public Pessoa(string nome, string cpf, DateTime datanascimento){
           SetNome(nome);
           SetCpf(cpf);
           SetDataNascimento(datanascimento);
       }
       public string GetNome(){
           return Nome;
       }
       public void SetNome(string nome){
           Nome = Nome;
       }
       public string GetCpf(){
           return Cpf;
       }
       public void SetCpf(string cpf){
           Cpf = Cpf;
       }
       public DateTime GetDataNascimento(){
           return DataNascimento;
       }
       public void SetDataNascimento(DateTime datanascimento){
           DataNascimento = DataNascimento;
       }
    }
}