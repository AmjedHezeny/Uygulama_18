using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_18
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Kisi> kisiler = new List<Kisi>();
            RehberIslemleri(kisiler);
        }

        static void RehberIslemleri(List<Kisi> kisiler)
        {
            while (true)
            {
                Console.WriteLine("*********************");
                Console.WriteLine("Programımıza Hoş Geldiniz :)");
                Console.WriteLine("*********************");
                Console.WriteLine("1).Kişi Ekle.");
                Console.WriteLine("2).Kişileri Listele.");
                Console.WriteLine("3).Kişileri Ara.");
                Console.WriteLine("4).Kişileri Sil.");
                Console.WriteLine("5).Hızlı Aramaya Ekle.");
                Console.WriteLine("6).Hızlı Arama Listesi.");
                Console.WriteLine("7).Kişiyi Engelle.");
                Console.WriteLine("8).Engelli Listesi.");
                Console.WriteLine("9).Favorilere Ekle.");
                Console.WriteLine("10).Favori Listesi.");
                Console.WriteLine("11).Programdan Çık.");

                Console.Write(">> Seçiminizi Yapınız: ");
                int secim = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Clear();

                try
                {

                    switch (secim)
                    {
                        case 1:
                            Metodlar.KisiEkle(kisiler);
                            break;
                        case 2:
                            Metodlar.KisileriListele(kisiler);
                            break;
                        case 3:
                            Metodlar.KisileriAra(kisiler);
                            break;
                        case 4:
                            Metodlar.KisiSil(kisiler);
                            break;
                        case 5:
                            Metodlar.HizliAramayaEkle(kisiler);
                            break;
                        case 6:
                            Metodlar.HizliAramaListesi(kisiler);
                            break;
                        case 7:
                            Metodlar.KisiyiEngelle(kisiler);
                            break;
                        case 8:
                            Metodlar.EngelliListesi(kisiler);
                            break;
                        case 9:
                            Metodlar.FavorilereEkle(kisiler);
                            break;
                        case 10:
                            Metodlar.FavoriListesi(kisiler);
                            break;
                        case 11:
                            Console.WriteLine("Programı Kullandığınız İçin Teşekkür Ederiz. Çıkış İçin Herhangi Bir Tuşa Basınız.");
                            Console.ReadKey();
                            return;
                        default:
                            Console.WriteLine("Geçersiz Bir Seçim Yaptınız.");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir Hata Oluştu. Lütfen Tekrar Deneyin.");
                }
            }
        }
    }
}