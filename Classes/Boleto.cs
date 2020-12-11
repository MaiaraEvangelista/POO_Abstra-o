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
            Random randomico = new Random();
            this.codigoDeBarras = randomico.Next();
        }

        public void GerarBoleto(){
            float total = this.Valor -(this.Valor * 0.12f);
            Console.WriteLine($"O valor do Boleto ficou em: R${total} ");
            Console.WriteLine($"Data: {this.Data}");
            Console.WriteLine($"Data de Vencimento: {this.Data.AddDays(10)}");

            this.Valor = total;
        }
    }
}