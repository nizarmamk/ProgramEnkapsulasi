using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEnkapsulasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Program Data Pemain Sepak Bola Eropa ");
            Console.WriteLine("======================================");
            
            Pemain Pemain1 = new Pemain();
            Pemain Pemain2 = new Pemain();
            Pemain Pemain3 = new Pemain();

            Pemain1.SetDataDiri("Alejandro Garnacho", 18, "Argentina");
            Pemain1.SetDataKlub("Premier League", "Manchester United", 49);
            Console.WriteLine();

            Pemain2.SetDataDiri("Karim Benzema", 35, "Perancis");
            Pemain2.SetDataKlub("La Liga", "Real Madrid", 9);
            Console.WriteLine();

            Pemain3.SetDataDiri("Zlatan Ibrahimovic", 41, "Swedia");
            Pemain3.SetDataKlub("Serie A", "AC Milan", 11);
            Console.WriteLine();
        }
    }
}
