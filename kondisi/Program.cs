using System;

namespace volume
{
    //Nama  : Mohamad Nafis
    //NIM   : 21104410067
    class pilihan
    {
       
        static void mylih()
        {
            Console.WriteLine("\t Pemrograman Lanjut menghitung Volume");
            Console.WriteLine("\t           Oleh Mohamad Nafis\n\n");

            Console.WriteLine("\t     Menu Pilihan\n");
            Console.WriteLine("\t 1.Hitung Volume Tabung");
            Console.WriteLine("\t 2.Hitung Volume Balok");
            Console.WriteLine("\t 3.Hitung Volume Kubus \n");
            
            
        }
        static void tabung()
        {
            double phi, r, t, vt;
            phi = 3.14;
            
            Console.Write(" Silahkan masukkan jari-jari (r) alas (cm): ");
                r = double.Parse(Console.ReadLine());
            Console.Write(" Silahkan masukkan tinggi (t) tabung (cm): ");
                t = double.Parse(Console.ReadLine());
                vt = (3.14) * r* r * t;
            Console.Write("besar volume tabung adalah : "); Console.WriteLine(vt);
            Console.WriteLine();
        }

        static void balok()
        {
            double p, l, t, vb;

            Console.Write("\tMasukkan nilai panjang: ");
                p = double.Parse(Console.ReadLine());
            Console.Write("\tMasukkan Nilai lebar: ");
                l = double.Parse(Console.ReadLine());
            Console.Write("\tMasukkan Nilai tinggi: ");
                t= double.Parse(Console.ReadLine());
                vb= p* l* t;
            Console.Write("besar volume balok adalah : "); Console.WriteLine(vb);
            Console.WriteLine();
        }
        static void kubus()
        {
            double r, vk;

            Console.Write("Masukkan Nilai Jari-jari(r): ");
            r= double.Parse(Console.ReadLine());
            vk = r * r * r;
            Console.Write("besar volume kubus adalah : "); Console.WriteLine(vk);
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            mulai:
            mylih();
            Console.Write("Masukkan pilihan: ");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:tabung();
                    break;
                case 2:
                    balok();
                    break;
                case 3:
                    kubus();
                    break;
                default:
                    Console.WriteLine("input yang kamu masukkan salah bree");
                    break;
            }
            Console.WriteLine("Menghitung Lagi Bree? (y/t)");
            Console.Write(" Jawab : ");
            char u = char.Parse(Console.ReadLine());

            if (u == 'y' | u == 'Y')
            {
                goto mulai;
            }
            else if (u == 't' | u == 'T')
            {
                Console.WriteLine(" ------------------------- Selamat Belajar! ------------------------");
                Console.WriteLine(" ---------------- Matematika itu Mudah Bukan? Bukannn --------------");
                Console.WriteLine(" --------------- Jangan lupa makan Bree Kesehatanmu ----------------");
                Console.ReadLine();
                Console.Clear();
            }
            else{
                Console.WriteLine("input yang kamu masukkan salah bree");
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
        
}