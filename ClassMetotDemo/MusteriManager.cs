using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //Ekle Fonksiyonu
        public void Ekle(Musteri musteri)
            
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " isimli müşteri eklenmiştir.");
            

        }
        //Listele Fonksiyonu
        public void Listele(Musteri[] musteri)
        {
            foreach (var musteriler in musteri)
            {
                Console.WriteLine(musteriler.Ad + " " + musteriler.Soyad + " " + musteriler.Telefon);

            }
        }
    }
}
