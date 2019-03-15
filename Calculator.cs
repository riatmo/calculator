using System;

namespace CaclulatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Opsi kalkulator
            Console.WriteLine("Pilihan operasi hitung kalkulator");
            Console.WriteLine("_________________________________");
            Console.WriteLine("1. Perkalian");
            Console.WriteLine("2. Penjumlahan");
            Console.WriteLine("3. Pengurangan");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("__________________________________");

            Console.Write("Masukan pilihan perhitungan : ");
            int choice = Convert.ToInt32(Console.ReadLine());


            //Percabangan & eksekusi nilai
            if (choice == 1)
            {
                //Input nilai
                Console.Write("\n\nMasukan nilai a : ");
                float a = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nMasukan nilai b : ");
                float b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\nHasil " + a + " * " + b + " = " + (a * b));
                Console.WriteLine();
                Console.WriteLine("\n\nTekan sembarang tombol untuk keluar");
                Console.Read();
            }
            else if (choice == 2)
            {
                //Input nilai
                Console.Write("\n\nMasukan nilai a : ");
                float a = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nMasukan nilai b : ");
                float b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\nHasil " + a + " + " + b + " = " + (a + b));
                Console.WriteLine();
                Console.WriteLine("\n\nTekan sembarang tombol untuk keluar");
                Console.Read();
            }
            else if (choice == 3)
            {
                //Input nilai
                Console.Write("\n\nMasukan nilai a : ");
                float a = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nMasukan nilai b : ");
                float b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\nHasil " + a + " - " + b + " = " + (a - b));
                Console.WriteLine();
                Console.WriteLine("\n\nTekan sembarang tombol untuk keluar");
                Console.Read();
            }
            else if (choice == 4)
            {
                //Input nilai
                Console.Write("\n\nMasukan nilai a : ");
                float a = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nMasukan nilai b : ");
                float b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n\nHasil " + a + " / " + b + " = " + (a / b));
                Console.WriteLine();
                Console.WriteLine("\n\nTekan sembarang tombol untuk keluar");
                Console.Read();
            }

            else
            {

                Console.WriteLine("\n\nPastikan memilih antara menu 1-4");
                Console.WriteLine("\n\nTekan sembarang tombol untuk keluar");
                Console.Read();
            }


        }
    }
}