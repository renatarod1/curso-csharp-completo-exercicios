using System;
using System.Collections.Generic;
using System.IO;

namespace S15_aula214_exe_Dictionary
{
    class Program
    {
        static void Main(string[] args) {
            Dictionary<string, int> candidates = new Dictionary<string, int>();
            Console.Write("Enter de file full path: ");
            string path = Console.ReadLine();

            try {
                using(StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(",");
                        string name = line[0];
                        int votes = int.Parse(line[1]);
                        Candidate candidate = new Candidate { Name = name, Votes = votes };
                        if (candidates.ContainsKey(candidate.Name)) {
                            candidates[candidate.Name] += candidate.Votes;
                        } else {
                            candidates[candidate.Name] = candidate.Votes;
                        }
                    }
                }

                foreach (KeyValuePair<string, int> candidate in candidates) {
                    Console.WriteLine(candidate);
                }
            }
            catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
