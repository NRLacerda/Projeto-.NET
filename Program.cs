using System;
using System.Globalization;

namespace Estudo1 // Note: actual namespace depends on the project name.
{ // namespace é tipo como se vc fizesse sua propria dependência, 
    // seu código pode ser usado da mesma forma q importamos algo no javacsript
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha 0 ou 1");
            Console.WriteLine("0 para manutenção de produto");
            Console.WriteLine("e 1 para cálculo de triângulos");
            int res = int.Parse(Console.ReadLine());
            if (res == 0)
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
            else
            {
                Console.WriteLine("Entre a os lados do triângulo separados por espaço");
                int sum = 0;
                string perimeter = Console.ReadLine();
                string[] sides = perimeter.Split(" ");
                foreach (var side in sides)
                {
                    sum = Int32.Parse(side) + sum;
                    Console.WriteLine(sum);
                }
                Console.WriteLine("Deseja voltar ao início?");
                Console.WriteLine("Digite 1 para sim e 0 para não");
                int menu = int.Parse(Console.ReadLine());
                if (menu == 1)
                {
                    Console.Write("O-o");
                }
            }
        }
    }
}
