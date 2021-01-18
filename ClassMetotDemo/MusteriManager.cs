using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle()
        {
            Musteri musteri = new Musteri();//eklenecek  musteri nesnesi oluşturuldu
            Console.Write("ID Giriniz: ");
            musteri.ID = Console.ReadLine();
            Console.Write("Isim Giriniz: ");
            musteri.Isim = Console.ReadLine();
            Console.Write("Soyisim Giriniz: ");
            musteri.Soyisim = Console.ReadLine();
            Console.Write("Para Miktarını Giriniz: ");
            musteri.ParaMiktari = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(musteri.Isim +" "+musteri.Soyisim+" isimli musteri eklendi");

        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Isim+" "+musteri.Soyisim+": "+musteri.ID);
            }
            
        }
        public void Sil(Musteri musteri)
        {
            musteri=null;
            Console.WriteLine("Musteri silindi!!! ");
        }
    }
}
