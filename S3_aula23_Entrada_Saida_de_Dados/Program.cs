using System;
using System.Globalization;

namespace S3_aula23_Entrada_Saida_de_Dados
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] linha = Console.ReadLine().Split(' ');
            string ultimoNome = linha[0];
            int idade = int.Parse(linha[1]);
            double altura = double.Parse(linha[2], CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
