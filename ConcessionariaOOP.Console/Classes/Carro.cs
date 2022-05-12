namespace ConcessionariaOOP.Classes
{
    public class Carro : Veiculo
    {
        protected bool TransmissaoAutomatica {get; set;}
        protected string Combustivel {get; set;}

        public Carro(string marca, string modelo, DateTime ano, int kilometragem, string cor, double valor, bool transmissaoautomatica, string combustivel)
            : base (marca, modelo, ano, kilometragem, cor, valor)
        
        {
            SetTransmissaoAutomatica(transmissaoautomatica);
            SetCombustivel(combustivel);
        }

        public bool GetTransmissaoAutomatica(){
            return TransmissaoAutomatica;
        }
        public void SetTransmissaoAutomatica(bool transmissaoautomatica){
            TransmissaoAutomatica = TransmissaoAutomatica;
        }
        public string GetCombustivel(){
            return Combustivel;
        }
        public void SetCombustivel(string combustivel){
            Combustivel = Combustivel;
        }
        public override double calcValor()
        {
            
            if (TransmissaoAutomatica)
            {
                Valor = Valor * 1.1;
            }
            
            return Valor;
        }


    }
}