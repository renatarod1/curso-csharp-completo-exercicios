using System;
using System.Globalization;

namespace S3_aula24_exe04
{
    class Program
    {
        static void Main(string[] args) {

            int numFunc = int.Parse(Console.ReadLine());
            int horasTrab = int.Parse(Console.ReadLine());
            double valorHoraTrab = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NUMBER = " + numFunc);
            Console.WriteLine("SALARY = U$ " + (horasTrab * valorHoraTrab).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
