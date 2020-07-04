using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1_Prova_exe_3_2 {
    class Program {
        static void Main(string[] args) {
            int IN = 0;
            int OUT = 0;

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                int x = Convert.ToInt32(Console.ReadLine());

                if (x >= 10 && x <= 20) {
                    IN++;
                } else {
                    OUT++;
                }
            }
            Console.WriteLine(IN + " in");
            Console.WriteLine(OUT + " out");
            Console.ReadKey();
        }
    }
}
