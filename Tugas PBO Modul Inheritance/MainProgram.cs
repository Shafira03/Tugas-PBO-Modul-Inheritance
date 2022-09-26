using System;
using ThisProcessor;
using ThisVga;

namespace TugasPBO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook();
            Laptop laptop2 = new IdeaPad();
            Predator predator = new Predator();

            laptop1.vga = new Nvidia();
            laptop1.processor = new CoreI5();
            laptop2.vga = new ThisVga.AMD();
            laptop2.processor = new Ryzen();
            predator.vga = new ThisVga.AMD();
            predator.processor = new CoreI7();

            //Soal no.1
            //Jalankan method LaptopDinyalakan() dan LaptopDinyalakan() pada laptop2
            //laptop2.LaptopDinyalakan();
            //laptop2.LaptopDimatikan();

            //Soal no.2
            //Jalankan method NyalakanLampu() pada laptop1
            //laptop1.Ngoding();

            //Soal no.3
            //menampilkan di console spesifikasi(merk vga, merk processor, tipe processor)apa yang digunakan laptop1
            //Console.WriteLine("Merk Vga: " + laptop1.vga.merk +
            //    "\n" + "Merk Processor: " + laptop1.processor.merk +
            //    "\n" + "Tipe Processor: " + laptop1.processor.tipe);

            //Soal no.4
            //Jalankan method BermainGame() pada predator
            //predator.BermainGame();

            //Soal no.5
            //Buatlah sebuah variabel acer bertipe data ACER, kemudian masukkan objek predator sebagai nilainya.
            ////Jalankan method BermainGame() pada acer
            //ACER acer = new Predator();
            //acer.BermainGame();

        }
    }
}