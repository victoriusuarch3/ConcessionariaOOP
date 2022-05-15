namespace ConcessionariaOOP.Classes
{
    public class Moto : Veiculo
    {
        protected int Cilindrada {get; set;}
        protected string Partida {get; set;}

        public Moto(string marca, string modelo, DateTime ano, int kilometragem, string cor, double valor, int cilindrada, string partida)
        
        : base (marca, modelo, ano, kilometragem, cor, valor)
        {     
            Cilindrada = cilindrada;
            Partida = partida;
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

       
        public override double calcValor(double valor)
        {   
            
            if (Partida == "Eletrônica")
            {
                valor = valor * 1.1;
            }

            return valor;
        }

    }
}