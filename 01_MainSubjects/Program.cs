using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine();
            Console.WriteLine("1- Ana Yemekler");
            Console.WriteLine("2- Tatlılar");
            Console.WriteLine("3- İçecekler");
            Console.WriteLine();
            Console.Write("Lütfen yemek kategorisi seçiniz: ");
            Console.WriteLine(
                Console.ReadLine() == "1" ? "Ana Yemekler" :
                Console.ReadLine() == "2" ? "Tatlılar" :
                Console.ReadLine() == "3" ? "İçecekler" : "Geçersiz Seçim"
                );
            Console.ReadLine();
            #endregion

            #region StringDeğişkenler

            //string Name;
            //Name = "Yiğit";
            //Console.WriteLine(Name);
            //
            //string customerName,customerSurname,costumerPhone,costumerEmail,district,city;
            //customerName = "Yiğit";
            //customerSurname = "Yılmaz";
            //costumerEmail = "abc@gmail.com";   
            //costumerPhone = "1234567890";
            //district = "Kadıköy";
            //city = "İstanbul";
            //
            //Console.WriteLine("**** Rezervasyon Kartı ****"); 
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Müşteri Adı: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: "  + costumerPhone + " " + costumerEmail);
            //Console.WriteLine("Adres: " + district + " / " + city);
            //Console.WriteLine("------------------------------");

            #endregion

            #region IntDeğişkenler

            //int hamburgerPrice = 300;
            //int ColaPrice = 30;
            //int waterPrice = 25;
            //int priesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;
            //
            //Console.WriteLine("**** Restoran Menü Fiyat Listesi **** ");
            //Console.WriteLine();
            //Console.WriteLine("---- Hamburger : " + hamburgerPrice + " TL ");
            //Console.WriteLine("---- Cola : " + ColaPrice + " TL ");
            //Console.WriteLine("---- Water : " + priesPrice + " TL ");
            //Console.WriteLine("---- Pries : " + hamburgerPrice + " TL ");
            //Console.WriteLine("---- Pizza : " + pizzaPrice + " TL ");
            //Console.WriteLine("---- Lemonade : " + lemonadePrice + " TL ");
            //Console.WriteLine();
            //Console.WriteLine("**** Restoran Menü Fiyat Listesi **** ");
            //
            //
            //int hamburgerCount, cokeCount, waterCount, friesCount, pizzaCount, lemonadeCount;
            //int totalhamburgerPrice = 0;
            //
            //hamburgerCount = 3;
            //cokeCount = 3;
            //waterCount = 3;
            //friesCount = 1;
            //pizzaCount = 0;
            //lemonadeCount = 0;
            //totalhamburgerPrice = hamburgerCount * hamburgerPrice;
            //
            //Console.WriteLine("Hamburger Total Price : " + totalhamburgerPrice);
            #endregion
        }
    }
}
