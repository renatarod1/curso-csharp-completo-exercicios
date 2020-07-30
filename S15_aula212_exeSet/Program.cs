using System;
using System.Collections.Generic;

namespace S15_aula212_exeSet
{
    class Program
    {
        static void Main(string[] args) {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                courseA.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                courseA.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                courseA.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> allCourses = new HashSet<int>(courseA);
            allCourses.UnionWith(courseB);
            allCourses.UnionWith(courseC);
            Console.WriteLine("Total students: "+ allCourses.Count);
        }
    }
}
