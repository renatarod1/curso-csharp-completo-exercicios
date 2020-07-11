using System;

namespace S3_aula33_exe02
{
    class Program
    {
        static void Main(string[] args) {

            string[] vetLine = Console.ReadLine().Split(' ');
            int x = int.Parse(vetLine[0]);
            int y = int.Parse(vetLine[1]);

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("primeiro");
                } else if (x < 0 && y > 0) {
                    Console.WriteLine("segundo");
                } else if (x < 0 && y < 0) {
                    Console.WriteLine("terceiro");
                } else {
                    Console.WriteLine("quarto");
                }
                
                vetLine = Console.ReadLine().Split(' ');
                x = int.Parse(vetLine[0]);
                y = int.Parse(vetLine[1]);
            }

        }
    }
}
