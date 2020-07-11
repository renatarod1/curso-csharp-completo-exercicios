using System;

namespace S3_aula35_exe02
{
    class Program
    {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int IN = 0, OUT = 0;

            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <=20) {
                    IN++;
                } else {
                    OUT++;
                }
            }
            Console.WriteLine(IN + " in");
            Console.WriteLine(OUT + " out");
        }
    }
}
