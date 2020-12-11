namespace Abstração.Classes
{
    public abstract class Cartao : Pagamento
    {
       public string bandeira;

       public string titular;

       public string numero;

       public string cvv;

       public string SalvarCartao(){
           return "";
       } 

       public abstract void Pagar();
    }
}