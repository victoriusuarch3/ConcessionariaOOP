namespace ConcessionariaOOP.Classes
{
    public class Veiculo
    {
      public string Marca {get; set;}
      public string Modelo {get; set;}
      public DateTime Ano {get; set;}
      public int Kilometragem {get; set;}
      public string Cor {get; set;}
      public double Valor {get; set;}  

        public Veiculo()
        {

        }
      public Veiculo(string marca, string modelo, DateTime ano, int kilometragem, string cor, double valor){
          SetMarca(marca);
          SetModelo(modelo);
          SetAno(ano);
          SetKilometragem(kilometragem);
          SetCor(cor);
          SetValor(valor);
      }
      public string GetMarca(){
          return Marca;
      }
      public void SetMarca(string Marca){
          Marca = Marca;
      }
      public string GetModelo(){
          return Modelo;
      }
      public void SetModelo(string Modelo){
          Modelo = Modelo;
      }
      public DateTime GetAno(){
          return Ano;
      }
      public void SetAno(DateTime Ano){
          Ano = Ano;
      }
      public int GetKilometragem(){
          return Kilometragem;
      }
      public void SetKilometragem(int Kilometragem){
          Kilometragem = Kilometragem;
      }
      public string GetCor(){
          return Cor;
      }
      public void SetCor(string Cor){
          Cor = Cor;
      }
      public double GetValor(){
          return Valor;
      }
      public void SetValor(double valor){
          Valor = valor;
      }

      public virtual double calcValor(double valor)
      {
          return 0;
      }

      public bool ValidarAno(datetime ano)
      {
          if(ano > Datetime.Parse("01/01/2004") && ano < DateTime.Now)
          {
              return true;
          }
          throw new ErroException("Error entrada ano");
          
      }

    }
}