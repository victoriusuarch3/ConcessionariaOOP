namespace ConcessionariaOOP.Classes
{
    public class Moto
    {
        protected int Cilindrada {get; set;}
        protected string Partida {get; set;}

        public Moto(int cilindrada, string partida){
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

    }
}