namespace ConcessionariaOOP.Classes
{
    public class Carro : Veiculo
    {
        public bool TransmissaoAutomatica {get; set;}
        public string Combustivel {get; set;}

        public Carro()
        {

        }
        
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
        public override double calcValor(double valor)
        {
            
            if (TransmissaoAutomatica)
            {
                Valor = Valor * 1.1;
            }
            
            return Valor;
        }


    }
}