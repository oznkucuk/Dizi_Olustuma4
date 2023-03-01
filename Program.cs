using System;

namespace dizi_icerisindeki_en_buyuk_sayi
{
    class Program
    {
        static void Main(string[] args)
        {
            // girilen değerleri bir diziye atıp sonra içlerinden en büyük olanı ekrana yazdıran program
            int[] sayilar = new int[5]; // 5 elemanlı bir dizi oluşturduk.

            for (int i = 0; i < 5; i++)     //dizi elamanlarını ekleyebilmek için for döngüsü açıp kullanıcıdan sayı girmesini istedik
            {
                Console.Write($"{i + 1}. Sayıyı girin: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());//matematiksel işlem yapacağımız için convert yapmak zorundayız
            }

            int enbuyuk;
            enbuyuk = sayilar[0];//enbuyuk isimli değişkenimizi dizinin 0. elemanı olarak tanımladık
            for (int i = 1; i < sayilar.Length; i++) // dizi elamanlarının tamamını gezip kontrol edebilmek için döngü oluşturduk. dizinin 0. elemanı tanımlı
            {                                           //olduğu için 1. elemandan itibarek döngüyü başlatıyoruz.
                if (enbuyuk < sayilar[i]) // dizinin i. elemanı enbuyuk değerinden büyükse ata değilse diğer elemana geç'i ifade eden karar yapısı.
                {
                    enbuyuk = sayilar[i];
                }
            }
            Console.WriteLine(enbuyuk);
        }
    }
}
