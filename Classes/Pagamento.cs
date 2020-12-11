using System;

namespace Abstração.Classes
{
    public class Pagamento
    {
        private DateTime data;

        public DateTime Data{
            get;set;
        }

        protected float valor;

        public float Valor{
            get;set;
        } 

        public string Cancelar(){
            return "";
        }
    }
}