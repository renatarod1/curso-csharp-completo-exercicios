using System;

namespace S3_aula29_exe03
{
    class Program
    {
        static void Main(string[] args) {
            
            string[] AB = Console.ReadLine().Split(' ');
            int a = int.Parse(AB[0]);
            int b = int.Parse(AB[1]);

            if (a % b == 0 || b % a == 0) {
                Console.WriteLine("São Multiplos");
            } else {
                Console.WriteLine("Não sao Multiplos");
            }
        }
    }
}
