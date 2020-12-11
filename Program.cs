using System;
using Abstração.Classes;

namespace Abstração09._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Digite o valor da compra:");
            float ValorDaCompra = float.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Selecione um método de pagamento:");
            Console.WriteLine("1 - Boleto");
            Console.WriteLine("2 - Cartão");
            Console.WriteLine("---------------------------------------");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");

            switch (opcao)
            {
                case 1:
                    Boleto boleto = new Boleto();
                    boleto.Registrar();
                    boleto.Valor = ValorDaCompra;
                    boleto.Data = DateTime.Now;
                    Console.WriteLine($"Código de Barras: {boleto.CodigoDeBarras} ");

                    boleto.GerarBoleto();
                    break;

                case 2:
                     Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Selecione um método de pagamento:");
                    Console.WriteLine("1 - Crédito");
                    Console.WriteLine("2 - Débito");
                    Console.WriteLine("---------------------------------------");
                    int tipo = int.Parse(Console.ReadLine());
                    Console.WriteLine("----------------------------------------");

                        switch (tipo)
                        {
                            case 1:
                                
                                break;

                            case 2:
                            break;

                            default:
                                break;
                        }
                        







                            

                break;


                default:
                    break;
            }
            
        }
    }
}
