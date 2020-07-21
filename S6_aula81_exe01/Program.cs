using System;

namespace S6_aula81_exe01
{
    class Program
    {
        static void Main(string[] args) {
            string[] mn = Console.ReadLine().Split(' ');
            int m = int.Parse(mn[0]);
            int n = int.Parse(mn[1]);

            int[,] mat = new int[m, n];
            
            for (int i = 0; i < m; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            
            int search = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {                
                for (int j = 0; j < n; j++) {
                    if (mat[i,j] == search) {
                        Console.WriteLine("Position "+ i + ","+ j);
                        if (j != 0) {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i != 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (n - 1 != j) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (m - 1 != i) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }                        
                    }                    
                }
            }
        }
    }
}
