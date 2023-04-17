using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEnkapsulasi
{
    internal class Pemain
    {
        // Fields
        public string nama;
        public string klub;
        public string kebangsaan;
        public string liga;
        public int umur;
        public int nomor;

        // Constructor
        public Pemain(string nama, string klub, string kebangsaan, string liga, int umur, int nomor)
        {
            this.nama = nama;
            this.klub = klub;
            this.kebangsaan = kebangsaan;
            this.liga = liga;
            this.umur = umur;
            this.nomor = nomor;
        }

        public Pemain()
        {

        }

        // Methods
        public void SetDataDiri(string nama, int umur, string kebangsaan)
        {
            this.nama = nama;
            this.umur = umur;
            this.kebangsaan = kebangsaan;
            Console.WriteLine("Nama Pemain      : {0}", this.nama);
            Console.WriteLine("Umur Pemain      : {0}", this.umur);
            Console.WriteLine("Kebangsaan       : {0}", this.kebangsaan);
        }

        public void SetDataKlub(string liga, string klub, int nomor)
        {
            this.liga = liga;
            this.klub = klub;
            this.nomor = nomor;
            Console.WriteLine("Liga Klub Pemain : {0}", this.liga);
            Console.WriteLine("Klub Pemain      : {0}", this.klub);
            Console.WriteLine("Nomor Punggung   : {0}", this.nomor);
            Console.ReadKey();
        }
    }
}
