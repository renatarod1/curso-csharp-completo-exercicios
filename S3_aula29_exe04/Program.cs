using System;

namespace S3_aula29_exe04
{
    class Program
    {
        static void Main(string[] args) {            
            string[] horas = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(horas[0]);
            int horaFinal = int.Parse(horas[1]);
                       
            if (horaInicial < horaFinal) {               
                Console.WriteLine("O JOGO DUROU "+ (horaFinal - horaInicial).ToString() + " HORA(S)");
            } else {
                Console.WriteLine("O JOGO DUROU " + (24 - horaInicial + horaFinal).ToString() + " HORA(S)");
            }            
        }
    }
}
