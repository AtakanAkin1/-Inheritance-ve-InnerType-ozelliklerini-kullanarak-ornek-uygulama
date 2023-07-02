using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_inheritance_uygulamasi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Musteri M1 = new Musteri();

                Console.WriteLine("Kalitim uygulamasi musteri bilgilendirme formuna hos geldiniz. Lutfen bilgilerinizi giriniz.");

                Console.Write("Adiniz: ");
                string Ad = Console.ReadLine();
                M1.ad = Ad;

                Console.Write("Soyadiniz: ");
                string Soyad = Console.ReadLine();
                M1.soyad = Soyad;

                Console.Write("Telefon Numaraniz: ");
                string Telefon = Console.ReadLine();

                Console.Write("Cinsiyetiniz(E/K): ");
                char Cinsiyet = Convert.ToChar(Console.ReadLine());
                M1.cinsiyet = Cinsiyet;

                Console.Write("Yapilmasini istediginiz isi: ");
                string yapilacakIs = Console.ReadLine();
                M1.verilenIs = yapilacakIs;

                Console.Write("Yapilacak isin odeme tutari: ");
                int ucret = Convert.ToInt32(Console.ReadLine());
                M1.ucretBedeli = ucret;
                Console.WriteLine("Lutfen bekleyiniz bilgileriniz listeleniyor...");
                System.Threading.Thread.Sleep(3000);
                BilgileriYazdir(M1);
                Console.WriteLine("Cikmak icin ENTER tusuna basiniz.");
               
            }
            catch(Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Istenilen bilgiler girilmedi veya programda hata olustu lutfen bilgilerinizi eksiksiz giriniz. ");
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
        static void BilgileriYazdir(Musteri M1)
        {
            Console.Clear();
            Console.WriteLine("--Musteri Bilgileri--");
            Console.WriteLine("Adiniz: "+M1.ad);
            Console.WriteLine("Soyadiniz: "+M1.soyad);
            Console.WriteLine("Telefon Numaraniz: "+M1.telefon);
            Console.WriteLine("Cinsiyetiniz: "+M1.cinsiyet);
            Console.WriteLine("Yapilmasini istediginiz is: "+M1.verilenIs);
            Console.WriteLine("Toplam odediginiz tutar: "+M1.ucretBedeli);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Proje ile ilgilenen yonetici: "+M1.Y1.yoneticiIsmi);
            Console.WriteLine("Proje ile ilgilenen yoneticinin unvani: "+M1.Y1.unvan);
        }

    }
}
