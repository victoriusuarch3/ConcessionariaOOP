namespace ConcessionariaOOP.Classes
{
    public class Moto : Veiculo
    {
        protected int Cilindrada {get; set;}
        protected string Partida {get; set;}

        public Moto(string marca, string modelo, DateTime ano, int kilometragem, string cor, double valor, int cilindrada, string partida) 
        : base (marca, modelo, ano, kilometragem, cor, valor)
        
        {
            SetCilindrada(cilindrada);
            SetPartida(partida);
        }

        public int GetCilindrada(){
            return Cilindrada;
        }
        public void SetCilindrada(int cilindrada){
            Cilindrada = Cilindrada;
        }
        public string GetPartida(){
            return Partida;
        }
        public void SetPartida(string Partida){
            Partida = Partida;
        }

        public void ValorCilindrada()
        {
            var ValorMoto = (Cilindrada * 50);
            Valor = ValorMoto;
            if (Partida == "Eletrônica")
            {
                Valor = Valor * 1.1;
            }
        }

    }
}