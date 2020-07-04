using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Prova_exe_3_1 {
    class Program {
        static void Main(string[] args) {
            int senha;

            senha = Convert.ToInt32(Console.ReadLine());

            do {
                Console.WriteLine("Senha invalida");
                senha = Convert.ToInt32(Console.ReadLine());               
            } while (senha != 2002);

            Console.WriteLine("Acesso Permitido");
            Console.ReadKey();
        }
    }
}
