using System;

namespace EstruturaCondicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch - case
            Console.WriteLine("Seja bem-vindo a empresa do Emanuel.");

            Console.WriteLine("Digite 1- Conrtatação e Planos.");
            Console.WriteLine("Digite 2- Reclamações de Serviços Prestados.");
            Console.WriteLine("Digite 3- Segunda Via de Boleto.");
            Console.WriteLine("Digite 4- Sair.");

            var opacaoEntrada = Console.ReadLine();

            switch (opacaoEntrada)
            {
                case "1":
                    Console.WriteLine("Informações sobre plano novo.");
                    break;
                case "2":
                    Console.WriteLine("Fale sobre sua reclamação.");
                    break;
                case "3":
                    Console.WriteLine("Sua nova Via será enviada por email.");
                    break;
                case "4":
                    Console.WriteLine("Finalizando Operação.");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
