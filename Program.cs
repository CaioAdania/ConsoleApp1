using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estacionamento estacionamento = new Estacionamento();

            while (true)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1. Adicionar carro");
                Console.WriteLine("2. Remover carro");
                Console.WriteLine("3. Exibir carros estacionados");
                Console.WriteLine("4. Sair");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite a marca do carro: ");
                        string marca = Console.ReadLine();
                        Console.Write("Digite o modelo do carro: ");
                        string modelo = Console.ReadLine();
                        Console.Write("Digite a placa do carro: ");
                        string placa = Console.ReadLine();

                        Carro novoCarro = new Carro() { Marca = marca, Modelo = modelo, Placa = placa };
                        estacionamento.AdicionarCarro(novoCarro);
                        break;
                    case 2:
                        Console.Write("Digite a placa do carro a ser removido: ");
                        string placaRemover = Console.ReadLine();
                        estacionamento.RemoverCarro(placaRemover);
                        break;
                    case 3:
                        estacionamento.ExibirCarrosEstacionados();
                        break;
                    case 4:
                        Console.WriteLine("Fechando programa");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
