namespace ConcessionariaOOP.Classes
{
    public class Funcionario
    {
        protected string Cargo {get; set;}

        public Funcionario(string cargo){
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