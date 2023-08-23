using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_18
{
    public class Metodlar
    {
        public static void KisiEkle(List<Kisi> kisiler)
        {
            Console.Write("Kişi Adını Giriniz: ");
            string ad = Console.ReadLine();
            Console.Write("Telefon Giriniz: ");
            string telefon = Console.ReadLine();
            kisiler.Add(new Kisi(ad, telefon));
            Console.WriteLine("*********************");
            Console.WriteLine("Kişi Başarıyla Eklendi.");
            Console.WriteLine("*********************");
            Console.WriteLine();
        }

        //-------------------------------------------------

        public static void KisileriListele(List<Kisi> kisiler)
        {
            Console.WriteLine("Kişiler.");
            Console.WriteLine("*********************");
            foreach (var kisi in kisiler)
            {
                Console.WriteLine($"Kişi Adı: {kisi.Ad} | Telefon: {kisi.Telefon}");
            }
            Console.WriteLine("*********************");
            Console.WriteLine();

        }

        //-------------------------------------------------

        public static void KisileriAra(List<Kisi> kisiler)
        {
            Console.Write("Aranacak Kişinin Adını Giriniz: ");
            string arananAd = Console.ReadLine();

            bool bulundu = false;

            foreach (var kisi in kisiler)
            {
                if (kisi.Ad.Contains(arananAd))
                {
                    Console.WriteLine("*********************");
                    Console.WriteLine($"Kişi Adı: {kisi.Ad} | Telefon: {kisi.Telefon}");
                    Console.WriteLine("*********************");
                    bulundu = true;
                }
            }
            if (!bulundu)
            {
                Console.WriteLine("*********************");
                Console.WriteLine("Aranan Kişi Bulunamadı.");
                Console.WriteLine("*********************");
            }
            Console.WriteLine();
        }

        //-------------------------------------------------

        public static void KisiSil(List<Kisi> kisiler)
        {
            Console.Write("Silinecek Kişinin Adını Giriniz: ");
            string silinecekAd = Console.ReadLine();

            Kisi silinecekKisi = null;

            foreach (var kisi in kisiler)
            {
                if (kisi.Ad == silinecekAd)
                {
                    silinecekKisi = kisi;
                    break;
                }
            }

            if (silinecekKisi != null)
            {
                kisiler.Remove(silinecekKisi);
                Console.WriteLine("*********************");
                Console.WriteLine("Kişi Başarıyla Silindi.");
                Console.WriteLine("*********************");
            }
            else
            {
                Console.WriteLine("*********************");
                Console.WriteLine("Kişi Bulunamadı.");
                Console.WriteLine("*********************");
            }
            Console.WriteLine();
        }

        //-------------------------------------------------

        public static void HizliAramayaEkle(List<Kisi> kisiler)
        {
            Console.Write("Hızlı Aramaya Eklemek İstediğiniz Kişinin Adını Giriniz: ");
            string hizliAramaAd = Console.ReadLine();

            Kisi hizliAramaKisi = null;

            foreach (var kisi in kisiler)
            {
                if (kisi.Ad == hizliAramaAd)
                {
                    hizliAramaKisi = kisi;
                    break;
                }
            }

            if (hizliAramaKisi != null)
            {
                Console.WriteLine("*********************");
                Console.WriteLine("Kişi Hızlı Aramaya Eklendi.");
                Console.WriteLine("*********************");
            }
            else
            {
                Console.WriteLine("*********************");
                Console.WriteLine("Kişi Bulunamadı.");
                Console.WriteLine("*********************");
            }
            Console.WriteLine();
        }

        //-------------------------------------------------

        public static void HizliAramaListesi(List<Kisi> hizliAramaListesi)
        {
            Console.WriteLine("Hızlı Arama Listesi:");
            foreach (var kisi in hizliAramaListesi)
            {
                Console.WriteLine("*********************");
                Console.WriteLine($"Kişi Adı: {kisi.Ad} | Telefon: {kisi.Telefon}");
                Console.WriteLine("*********************");
            }
        }

        //-------------------------------------------------

        public static void KisiyiEngelle(List<Kisi> kisiler)
        {
            Console.Write("Engellemek İstediğiniz Kişinin Adını Giriniz: ");
            string engellenecekAd = Console.ReadLine();

            Kisi engellenecekKisi = null;

            foreach (var kisi in kisiler)
            {
                if (kisi.Ad == engellenecekAd)
                {
                    engellenecekKisi = kisi;
                    break;
                }
            }

            if (engellenecekKisi != null)
            {
                Console.WriteLine("*********************");
                Console.WriteLine("Kişi Engellendi.");
                Console.WriteLine("*********************");
            }
            else
            {
                Console.WriteLine("*********************");
                Console.WriteLine("Kişi Bulunamadı.");
                Console.WriteLine("*********************");
            }
            Console.WriteLine();
        }

        //-------------------------------------------------

        public static void EngelliListesi(List<Kisi> engelliListesi)
        {
            Console.WriteLine("Engelli Listesi:");
            foreach (var kisi in engelliListesi)
            {
                Console.WriteLine("*********************");
                Console.WriteLine($"Kişi Adı: {kisi.Ad} | Telefon: {kisi.Telefon}");
                Console.WriteLine("*********************");
            }
        }

        //-------------------------------------------------

        public static void FavorilereEkle(List<Kisi> kisiler)
        {
            Console.Write("Favorilere Eklemek İstediğiniz Kişinin Adını Giriniz: ");
            string favoriAd = Console.ReadLine();

            Kisi favoriKisi = null;

            foreach (var kisi in kisiler)
            {
                if (kisi.Ad == favoriAd)
                {
                    favoriKisi = kisi;
                    break;
                }
            }

            if (favoriKisi != null)
            {
                Console.WriteLine("*********************");
                Console.WriteLine("Kişi Favorilere Eklendi.");
                Console.WriteLine("*********************");
            }
            else
            {
                Console.WriteLine("*********************");
                Console.WriteLine("Kişi Bulunamadı.");
                Console.WriteLine("*********************");
            }
            Console.WriteLine();
        }

        //-------------------------------------------------

        public static void FavoriListesi(List<Kisi> favoriListesi)
        {
            Console.WriteLine("Favori Listesi:");
            foreach (var kisi in favoriListesi)
            {
                Console.WriteLine("*********************");
                Console.WriteLine($"Kişi Ad: {kisi.Ad} | Telefon: {kisi.Telefon}");
                Console.WriteLine("*********************");
            }
        }
    }
}