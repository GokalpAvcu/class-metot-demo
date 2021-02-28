using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Gökalp";
            musteri1.Soyad = "Avcu";
            musteri1.Telefon =  5422387416;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Tayfun";
            musteri2.Soyad = "Dağcı";
            musteri2.Telefon = 5068213946;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Uygar";
            musteri3.Soyad = "Süslü";
            musteri3.Telefon =  5678394398;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Listele(musteriler);





        }
    }
}
