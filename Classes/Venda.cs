namespace ConcessionariaOOP.Classes
{
    public class Venda
    {
       protected Cliente Comprador {get; set;}
       protected Funcionario Vendedor {get; set;}
       protected Veiculo Veiculo {get; set;}
       protected string FormaPagamento {get; set;}
       protected double ValorFinal {get; set;} 

       public Venda(Cliente comprador, Funcionario vendedor, Veiculo veiculo, string formapagamento, double valorfinal){
        SetComprador(comprador);  
        SetVendedor(vendedor);
        SetVeiculo(veiculo);
        SetFormaPagamento(formapagamento);
        SetValorFinal(valorfinal);  
       }   
       public Cliente GetComprador(){
           return Comprador;
       }
       public void SetComprador(Cliente Comprador){
           Comprador = Comprador;
       }
       public Funcionario GetVendedor(){
           return Vendedor;
       }
       public void SetVendedor(Funcionario Vendedor){
           Vendedor = Vendedor;
       }
       public Veiculo GetVeiculo(){
           return Veiculo;
       }
       public void SetVeiculo(Veiculo Veiculo){
           Veiculo = Veiculo;
       }
       public string GetFormaPagamento(){
           return FormaPagamento;
       }
       public void SetFormaPagamento(string FormaPagamento){
           FormaPagamento = FormaPagamento;
       }
       public double GetValorFinal(){
           return ValorFinal;
       }
       public void SetValorFinal(double ValorFinal){
           ValorFinal = ValorFinal;
       }

       public void desconto()
       {
           if(Vendedor.GetCargo() == "Gerente")
           {
               ValorFinal = ValorFinal * 0.95;
           }
       }
    }
}