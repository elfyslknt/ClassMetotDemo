using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = "121212";
            musteri1.Isim = "Sema";
            musteri1.Soyisim = "Gok";
            musteri1.ParaMiktari = 115;

            Musteri musteri2 = new Musteri();
            musteri2.ID = "111111";
            musteri2.Isim = "Bahar";
            musteri2.Soyisim = "Yagmur";
            musteri2.ParaMiktari = 892;

            Musteri musteri3 = new Musteri();
            musteri3.ID = "141414";
            musteri3.Isim = "Yaz";
            musteri3.Soyisim = "Gunes";
            musteri3.ParaMiktari = 1000;

            

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Listele(musteriler);
            Console.WriteLine("--------");
            musteriManager.Ekle();
            Console.WriteLine("--------");
            musteriManager.Sil(musteri1);
         


        }
    }
}
