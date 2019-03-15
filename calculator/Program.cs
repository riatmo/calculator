using System;

namespace CaclulatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input nilai
            Console.WriteLine("Masukan angka pertama : ");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan angka kedua : ");
            float b = Convert.ToInt32(Console.ReadLine());

            //Opsi kalkulator
            Console.WriteLine();
            Console.WriteLine("Pilihan operasi hitung kalkulator  ");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("1: Perkalian");
            Console.WriteLine("2: Penjumlahan");
            Console.WriteLine("3: Pengurangan");
            Console.WriteLine("4: Pembagian");
            Console.WriteLine("__________________________________________");

            Console.WriteLine("Masukan pilihan perhitungan : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            //Percabangan & eksekusi nilai
            if (choice == 1)
            {
                Console.WriteLine("Hasil : " + (a * b));
                Console.Read();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Hasil : " + (a + b));

                Console.Read();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Hasil : " + (a - b));

                Console.Read();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Hasil : " + (a / b));

                Console.Read();
            }

            else
            {

                Console.WriteLine("Pastikan memilih antara menu 1-4");

            }

        }
    }
}