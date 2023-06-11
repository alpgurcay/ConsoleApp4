using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            string[] Urunler = { "Kola", "Bisküvi", "Çikolata"};
      




            Console.WriteLine("Giriş Türünü Seçin / M-Müşteri / A-Admin");
            string giristuru = Console.ReadLine();


            if (giristuru == "A")
            {
                Console.Write("Kullanıcı adı: ");
                string kullaniciAdi = Console.ReadLine();
                Console.Write("Şifre: ");
                string sifre = Console.ReadLine();
                if (kullaniciAdi == "admin" && sifre == "admin")
                {
                    Console.WriteLine("Admin girişi başarılı. Ürün ve fiyat bilgilerini girin:");

                    while (true)
                    {
                        Console.Write("Ürün adı (Çıkmak için 'q' tuşuna basın): ");
                        string urunAdi = Console.ReadLine();
                        if (urunAdi == "q")
                            break;

                        Console.Write("Fiyat: ");
                        double fiyat = Convert.ToDouble(Console.ReadLine());
                        if (urunAdi == "q")
                        {

                            Console.WriteLine("Ürün ve fiyat bilgileri güncellendi.");
                        }
                        else
                        {
                            Console.WriteLine("");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı Kullanıcı adı veya şifre");
                }

                
            }
            else if (giristuru == "M")
            {
                Console.WriteLine("Ürünler:");

                for (int i = 0; i < Urunler.Length; i++)
                {
                    Console.WriteLine(Urunler[i]);
                }
                

                Console.Write("Ürün adı seçin: ");
                string secilenUrun = Console.ReadLine();

                if (secilenUrun=="kola")
                {
                    double fiyat = 10;
                    

                    Console.Write("Ödeme miktarını girin: ");
                    double odeme = Convert.ToDouble(Console.ReadLine());
                    if (odeme >= fiyat)
                    {
                        double paraUstu = odeme - fiyat;
                        Console.WriteLine($"Para üstü: {paraUstu} TL");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz ödeme miktarı.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz ürün adı.");
                }
                if (secilenUrun == "bisküvi")
                {
                    double fiyat = 15;

                    Console.Write("Ödeme miktarını girin: ");
                    double odeme = Convert.ToDouble(Console.ReadLine());
                    if (odeme >= fiyat)
                    {
                        double paraUstu = odeme - fiyat;
                        Console.WriteLine($"Para üstü: {paraUstu} TL");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz ödeme miktarı.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz ürün adı.");
                }
                if (secilenUrun == "çikolata")
                {

                    double fiyat = 15;


                    Console.Write("Ödeme miktarını girin: ");
                    double odeme = Convert.ToDouble(Console.ReadLine());
                    if (odeme >= fiyat)
                    {
                        double paraUstu = odeme - fiyat;
                        Console.WriteLine($"Para üstü: {paraUstu} TL");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz ödeme miktarı.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz ürün adı.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz kullanıcı adı veya şifre.");
            }

        }

    }
    
}
