namespace ConcessionariaOOP.Classes
{
    public class Funcionario : Pessoa
    {
        protected string Cargo {get; set;}

        public Funcionario (string nome, string cpf, DateTime datanascimento, string cargo) 
        : base (nome, cpf, datanascimento)
        {
            SetCargo(cargo);
        }
        public string GetCargo(){
            return Cargo;
        }
        public void SetCargo(string cargo){
            Cargo = Cargo;
        }
    }
}