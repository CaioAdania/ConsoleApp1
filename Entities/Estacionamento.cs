using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    internal class Estacionamento
    {
        private List<Carro> carrosEstacionados;

        public Estacionamento()
        {
            carrosEstacionados = new List<Carro>();
        }

        public void AdicionarCarro(Carro carro)
        {
            carrosEstacionados.Add(carro);
            Console.WriteLine("Carro adicionado ao estacionamento.");
        }

        public void RemoverCarro(string placa)
        {
            Carro carroRemovido = carrosEstacionados.Find(carro => carro.Placa == placa);
            if (carroRemovido != null)
            {
                carrosEstacionados.Remove(carroRemovido);
                Console.WriteLine("Carro removido do estacionamento.");
            }
            else
            {
                Console.WriteLine("Carro não encontrado no estacionamento.");
            }
        }

        public void ExibirCarrosEstacionados()
        {
            if (carrosEstacionados.Count > 0)
            {
                Console.WriteLine("Carros estacionados:");
                foreach (Carro carro in carrosEstacionados)
                {
                    Console.WriteLine($"Marca: {carro.Marca}, Modelo: {carro.Modelo}, Placa: {carro.Placa}");
                }
            }
            else
            {
                Console.WriteLine("Não há carros estacionados no momento.");
            }
        }
    }
}
