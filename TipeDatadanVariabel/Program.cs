using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipeDatadanVariabel
{
    class Program
    {
        static void Main(string[] args)
        {
            //pertama
            /*string nama, umur;
            Console.Write("\n Masukkan Nama Anda ");
            nama = Console.ReadLine();
            Console.Write("\n Masukkan Umur Anda ");
            umur = Console.ReadLine();
            Console.WriteLine("\n Selamat belajar C# {0} {0}", nama);
            Console.WriteLine("\n Selamat belajar C# {0}", nama +" "+nama);
            Console.WriteLine("\n Nama anda {0}", nama + " Umur anda " + umur);
            Console.Read();*/


            //kedua
            /*const double PI = 3.14;
            string jari_jari;
            double konversi, luas, keliling;
            Console.Write("masukkan jari jari : ");
            jari_jari = Console.ReadLine();
            konversi = Convert.ToDouble(jari_jari);
            luas = PI * konversi * konversi;
            keliling = 2 * PI * konversi;

            Console.WriteLine("luas lingkaran adalah : {0}", luas);
            Console.WriteLine("keliling lingkaran adalah : {0}", keliling);
            Console.Read();*/


            //ketiga
            /*string nim, nama, nabsen,ntugas, nuts, nuas;
            double nakhir,n_absen, n_tugas, n_uts, n_uas;
            Console.Write("\n nim : ");
            nim = Console.ReadLine();
            Console.Write(" nama : ");
            nama = Console.ReadLine();
            Console.Write(" nilai absen : ");
            nabsen = Console.ReadLine();
            Console.Write(" nilai tugas : ");
            ntugas = Console.ReadLine();
            Console.Write(" nilai ÙTS : ");
            nuts = Console.ReadLine();
            Console.Write(" nilai UAS : ");
            nuas = Console.ReadLine();

            n_absen = Convert.ToDouble(nabsen);
            n_tugas = Convert.ToDouble(ntugas);
            n_uts = Convert.ToDouble(nuts);
            n_uas = Convert.ToDouble(nuas);
            nakhir = Convert.ToDouble(n_absen * 10 /100)+(n_tugas * 20 /100)+(n_uts *30/100)+(n_uts * 40/100);
            Console.Write(" nilai akhir : {0}", nakhir);
            Console.Read();*/

            //keempat
            string a, b;
            bool lb, lk, lbs, lks, smd, tsm;
            int var_a, var_b;
            Console.Write("\n masukkan nilai a :");
            a = Console.ReadLine();
            Console.Write("Masukkan nilai b : ");
            b = Console.ReadLine();
            var_a = Convert.ToInt16(a);
            var_b = Convert.ToInt16(b);

            lb = var_a > var_b;//lebih besar
            lk = var_a < var_b;//lebih kecil
            lbs = var_a >= var_b;//lebih kecil sama dengan
            lks = var_a <= var_b;//lebih kecil sama dengan
            smd = var_a == var_b;//sama dengan
            tsm = var_a != var_b;// tidak sama dengan

            Console.WriteLine("\n apakah a lebih besar dari b ? {0}", lb);
            Console.WriteLine(" apakah a lebih dari b {0}", lk);
            Console.WriteLine(" apakah a lebih besar sama dengan b? {0}", lbs);
            Console.WriteLine(" apakah a lebih kecil sama dengan b? {0}", lks);
            Console.WriteLine(" apakah a sama dengan  b ? {0}", smd);
            Console.WriteLine(" apakah a tidak sama dengan b? {0}", tsm);
            Console.Read();

        }
    }
}

