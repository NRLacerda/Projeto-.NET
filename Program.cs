using System;
using System.Globalization;

namespace Estudo1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            string teste;
            Console.WriteLine("Vamos inserir um produto no estoque..");
            Console.WriteLine("Insira o nome do produto.");
            p.Name = Console.ReadLine();
            Console.WriteLine("Insira o preço do produto.");
            p.Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quantidade do produto.");
            p.Amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o peso do produto (em Kg).");
            p.Weight = double.Parse(Console.ReadLine());
            Console.WriteLine(p);
        }
    }
}
