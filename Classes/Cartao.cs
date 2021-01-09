using System;

namespace Abstração.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string bandeira;

        public string numero;

        public string titular;

        public string CVV;

        public string SalvarCartao(){
            return "";
        }

        public abstract void Pagar();

        //observar se poderá ser apagado depois (inclusão própria)
        public void Registrar(){

        }

        public override string Desconto(int valor)
        {
            return "";
           
        }
            
          

    }
}