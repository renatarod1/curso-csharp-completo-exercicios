using System;

namespace S6_aula71_exe01
{
    class Program
    {
        static void Main(string[] args) {
            Estudante[] estudantesQuartos = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int qtdQuartos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdQuartos; i++) {
                Console.WriteLine("Aluguel #"+i);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numQuarto = int.Parse(Console.ReadLine());
                estudantesQuartos[numQuarto] = new Estudante(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados");
            for (int i = 0; i < estudantesQuartos.Length; i++) {
                if (estudantesQuartos[i] != null) {
                    Console.WriteLine(i + ": " + estudantesQuartos[i]);
                }                
            }
        }
    }
}
