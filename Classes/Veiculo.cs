namespace ConcessionariaOOP.Classes
{
    public class Veiculo
    {
      protected string Marca {get; set;}
      protected string Modelo {get; set;}
      protected DateTime Ano {get; set;}
      protected int Kilometragem {get; set;}
      protected string Cor {get; set;}
      protected double Valor {get; set;}  

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
      public void Set(DateTime Ano){
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
      public void SetValor(){
          Valor = Valor;
      }

    }
}