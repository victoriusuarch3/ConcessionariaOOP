namespace ConcessionariaOOP.Classes
{
    public class Carro
    {
        protected bool TransmissaoAutomatica {get; set;}
        protected string Combustivel {get; set;}

        public Carro(bool transmissaoautomatica, string combustivel){
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
        public void SetCombustivel(){
            Combustivel = Combustivel;
        }
    }
}