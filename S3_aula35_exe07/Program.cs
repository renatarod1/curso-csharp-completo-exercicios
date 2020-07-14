using System;

namespace S3_aula35_exe07
{
    class Program
    {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.Write(i + " ");
                Console.Write(Math.Pow(i, 2) + " ");
                Console.WriteLine(Math.Pow(i, 3) + " ");
            }
        }
    }
}
