using S13_aula192_exe_Files_Directories.Entities;
using System;
using System.Globalization;
using System.IO;

namespace S13_aula192_exe_Files_Directories
{
    class Program
    {
        static void Main(string[] args) {            
            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();
            string path = Path.GetDirectoryName(sourceFilePath);
            string targetDirectoryPath = path + @"\out";           

            try {
                Directory.CreateDirectory(targetDirectoryPath);
                string targetFilePath = targetDirectoryPath + @"\summary.csv";

                string[] lines = File.ReadAllLines(sourceFilePath);

                using(StreamWriter sw = File.AppendText(targetFilePath)) {
                    foreach (string line in lines) {
                        string[] item = line.Split(",");
                        string name = item[0];
                        double price = double.Parse(item[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(item[2]);
                        Product product = new Product(name, price, quantity);
                        sw.WriteLine(product.Name + "," + product.TotalValue().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}
