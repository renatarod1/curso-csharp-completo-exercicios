using System;

namespace S3_aula33_exe03
{
    class Program
    {
        static void Main(string[] args) {
            int alcool = 0, gasolina = 0, diesel = 0;

            int x = int.Parse(Console.ReadLine());
            
            while(x != 4) {
                if (x == 1) {
                    alcool++;                   
                } else if (x == 2) {
                    gasolina++;
                } else if (x == 3) {
                    diesel++;                    
                }
                x = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
