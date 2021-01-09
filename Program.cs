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

            Console.WriteLine();
            Console.WriteLine("Selecione um método de pagamento:");
            Console.WriteLine("1 - Boleto");
            Console.WriteLine("2 - Cartão");
            Console.WriteLine();
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Boleto boleto = new Boleto();
                    boleto.Registrar();
                    boleto.Valor = ValorDaCompra;
                    boleto.Data = DateTime.Now;
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Código de Barras: {boleto.CodigoDeBarras} ");
                    Console.ResetColor();

                    boleto.GerarBoleto();
                break;

                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Selecione um método de pagamento:");
                    Console.WriteLine("1 - Crédito");
                    Console.WriteLine("2 - Débito");
                    Console.WriteLine();
                    int tipo = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                        switch (tipo)
                        {
                            case 1:
                                Credito credito = new Credito();
                                Console.WriteLine("Você escolheu a forma de pagamento crédito, vamos lá: ");
                                Console.WriteLine();
                                Console.WriteLine($"O nome do titular é: {credito.nome} ");
                                Console.WriteLine();
                                Console.WriteLine($"Qual a bandeira do seu cartão {credito.bandeira}:");
                                string bandeira = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine($"Digite o CVV: ");
                                string CVV = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine($"Seu limite é de: {credito.Limite}");
                                Console.WriteLine();
                                credito.Registrar();
                                credito.Valor = ValorDaCompra;
                                credito.Data = DateTime.Now;
                                
                               
                               credito.Pagar();

                            break;

                            case 2:
                               Debito debito = new Debito();
                                Console.WriteLine("Você escolheu a forma de pagamento Débito, vamos lá: ");
                                Console.WriteLine();
                                Console.WriteLine($"O nome do titular é: {debito.nome} ");
                                Console.WriteLine();
                                Console.WriteLine($"Qual a bandeira do seu cartão {debito.bandeira}:");
                                string mastro = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine($"Digite o CVV: ");
                                string numero = Console.ReadLine();
                                Console.WriteLine();
                                Console.WriteLine($"Seu saldo atual é de : {debito.Saldo}");
                                Console.WriteLine();
                                debito.Registrar();
                                debito.Valor = ValorDaCompra;
                                debito.Data = DateTime.Now;
                                
                                
                                debito.Pagar();
                            break;
                            
                            
                        default:  
                        Console.WriteLine($"Pagamento sendo processado. . .");
                        
                        break;
                        }
                        Console.WriteLine($"Deseja cancelar o pagamento? S/N");
                       string resposta = Console.ReadLine();
                        
                        
                    while(resposta == "s")
                    Console.WriteLine($"Pagamento cancelado!");

                    while (resposta == "n")
                    Console.WriteLine($"Pagamento Confirmado!");
                    
                break;
                

            default:
            Console.WriteLine($"Sistema Encerrado!");
            
            break;
            }
            
        }
    }
}
