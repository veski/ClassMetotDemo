using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 1;
            musteri.TcKimlikNo = "12345678901";
            musteri.MusteriNumarasi = 3231212;
            musteri.MusteriAdi = "Veli";
            musteri.MusteriSoyadi = "Eski";
            musteri.IbanNo = "TR12 1234 1234 1234 1234 12";
            musteri.IdKolayAdresTipi = 1;
            musteri.KolayAdresi = "veli.eski.20@gmail.com";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri);
            musteriManager.MusteriListele();
            musteriManager.MusteriSil(musteri.Id);

        }
    }
}
