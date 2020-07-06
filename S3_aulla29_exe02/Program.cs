using System;

namespace S3_aulla29_exe02
{
    class Program
    {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                Console.WriteLine("PAR");
            } else {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
