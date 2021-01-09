using System;

namespace Abstração.Classes
{
    public class Debito : Cartao
    {
        private float saldo = 2000;

         public string nome = "Maiara Evangelista de Souza";
         
        public override void Pagar()
        {
            float total = this.Valor - (this.Saldo * valor);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"O valor da compra ficou em : R${total}");
            Console.WriteLine($"Data : {this.Data}");
        }

        public float Saldo{
            get{return saldo;}
        }
    }
}