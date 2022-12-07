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
            Console.WriteLine("Insira quantidade a ser adicionada:");
            int qntd = int.Parse(Console.ReadLine());
            p.AddAmount(qntd); //chama funçaõ q add qntd, passando o parametro 
            Console.WriteLine("Dados atualizados" + p);
            Console.WriteLine("Deseja remover alguma quantidade? Se sim informe abaixo:");
            int qntdDel = int.Parse(Console.ReadLine());
            p.RemAmount(qntdDel); //chama função q remove quantidade, passando o parametro 
            Console.WriteLine("Dados atualizados" + p);
        }
    }
}
