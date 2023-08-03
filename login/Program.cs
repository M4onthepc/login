using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hak_sayisi = 0;
            while (true)
            {
                Console.Write("Kullanıcı adınızı giriniz : ");
                string kullaniciAdi = Console.ReadLine();
                Console.Write("Şifrenizi giriniz : ");
                string sifre = Console.ReadLine();
                if (kullaniciAdi == "akif" && sifre == "321")
                {
                    Console.WriteLine("Tebrikler, Başarılı bir şekilde giriş yaptınız...");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Kullanıcı Adınız veya Şifre ile giriş yaptınız...");
                    if (hak_sayisi < 3)
                    {
                        hak_sayisi += 1;
                    }
                    if (hak_sayisi == 3)
                    {
                        Console.WriteLine("Giriş hakkınız dolmuştur. Giriş Yapamazsınız!");
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
