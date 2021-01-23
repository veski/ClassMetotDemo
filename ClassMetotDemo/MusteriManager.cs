using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi+" "+musteri.MusteriSoyadi+" adlı müsşteri kaydı yapıldı.");
        }

        public void MusteriListele()
        {
            Console.WriteLine("Müşteri listesi ekrana yansıtıldı.");
        }

        public void MusteriSil(int Id)
        {
            Console.WriteLine(Id+" numaralı müşteri kaydı silindi");
        }

    }
}
