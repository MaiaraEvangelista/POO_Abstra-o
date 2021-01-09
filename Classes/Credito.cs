using System;

namespace Abstração.Classes
{
    public class Credito : Cartao
    {
        private float limite = 3000;

        public string nome = "Maiara Evangelista de Souza";

        public override void Pagar()
        {
            float total = this.Valor - (this.Limite * valor);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"O valor da compra ficou em : R${total}");
            Console.WriteLine($"Data : {this.Data}");
           
        }

        public float Limite{
            get{return limite;}
        }

         public override string Desconto(int valor)
        {
             if (valor > 800)
            {
                Console.WriteLine("As compras acima de R$800,00 reais recebem um desconto de 30% do valor da sua compra ");
            }
                else{
                     Console.WriteLine("Desconto recusado!");
                }
            
             return "";
        }
    }
}