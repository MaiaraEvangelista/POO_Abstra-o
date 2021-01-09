using System;

namespace Abstração.Classes
{
    public class Boleto : Pagamento
    {
        private float codigoDeBarras;

        public float CodigoDeBarras{
            get{return codigoDeBarras;}
        }

        public void Registrar(){
            Random random = new Random();
            this.codigoDeBarras = random.Next();
        }

        public void GerarBoleto(){

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            float total = this.Valor - (this.Valor * 0.12f);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"O valor do boleto ficou em : R${total}");
            Console.WriteLine($"Data : {this.Data}");
            Console.WriteLine($"Data de Vencimento : {this.Data.AddDays(10)}");
            Console.ResetColor();

        }

        public override string Desconto(int valor)
        {
           return "";
        }
    }

}