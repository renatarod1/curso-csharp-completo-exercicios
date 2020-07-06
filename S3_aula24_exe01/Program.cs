using System;

namespace S3_aula24_exe01
{
    class Program
    {
        static void Main(string[] args) {
            int valor1, valor2;

            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"SOMA = {valor1 + valor2}");
        }
    }
}
