using System;

namespace Abstração.Classes
{
    public abstract class Pagamento
    {
        private DateTime data;

        protected float valor;

        public float Valor{
            get; set;
        }

        public DateTime Data{
            get;set;
        }
        
        public string Cancelar(){
            return "";
        }

        public abstract string Desconto(int valor);
    }

       
}