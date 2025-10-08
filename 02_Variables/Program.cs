using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DoubleDeğişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potato, tomato;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potato = 9.74;
            //tomato = 6.88;
            //
            //Console.WriteLine("----ApplePrice: " + applePrice + " TL");
            //Console.WriteLine("----OrangePrice: " + orangePrice + " TL");
            //Console.WriteLine("----StrawberryPrice: " + strawberryPrice + " TL");
            //Console.WriteLine("----PotatoPrice: " + potato + " TL");
            //Console.WriteLine("----TomatoPrice: " + tomato + " TL");
            //Console.WriteLine();
            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;
            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potato * potatoGram;
            //double tomatoTotalPrice = tomato * tomatoGram;
            //
            //Console.WriteLine("Alınan Ürün : Elma - " + " Birim Fiyati : " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün : Portakal - " + " Birim Fiyati : " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün : Çilek - " + " Birim Fiyati : " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün : Patates - " + " Birim Fiyati : " + potato + " - Gramaj: " + potato + " - Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün : Domates - " + " Birim Fiyati : " + tomato + " - Gramaj: " + tomato + " - Toplam Tutar: " + tomatoTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine();
            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;
            //Console.WriteLine("Shopping Total Price = {0} TL", shoppingTotalPrice);
            #endregion

            #region CharDeğişkenler
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region KlavyedenVeriGirişiStringDeğişkenler

            //Console.WriteLine("**** Hava Yolları Yolcu Bilgiler ****");
            //string passengerName,passengerSurName,passengerDistrict,passengerCity,passengerAge,pasengerIdentityNumber;
            //Console.Write("Yolcu Adı :");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı :");
            //passengerSurName = Console.ReadLine();
            //Console.Write("Yolcu İlçe :");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Yolcu Şehir :");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaş :");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu TC Kimlik No :");
            //pasengerIdentityNumber = Console.ReadLine();
            //
            //Console.WriteLine("--------------------");
            //Console.WriteLine("Yolcunun :");
            //Console.WriteLine("Adı : " + passengerName);
            //Console.WriteLine("Soyadı : " + passengerSurName);
            //Console.WriteLine("İlçesi : " + passengerDistrict);
            //Console.WriteLine("Şehir : " + passengerCity);
            //Console.WriteLine("Yaş : " + passengerAge);
            //Console.WriteLine("TC NO : " + pasengerIdentityNumber);

            #endregion

            #region KlavyedenSayıGirişiveDönüşümler
            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;
            //
            //int shoecount, computercount, chaircount, tvcount;
            //
            //
            //Console.Write("Lütfen aldığını ayakkabı sayısını giriniz: ");
            //shoecount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığını bilgisayar sayısını giriniz: ");
            //computercount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığını sandalye sayısını giriniz: ");
            //chaircount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığını televizyon sayısını giriniz: ");
            //tvcount = int.Parse(Console.ReadLine());
            //
            //double totalPrice = shoecount * shoePrice + computercount * computerPrice + chaircount * chairPrice + tvcount + tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödeme Tutarı : " + totalPrice + " TL");
            #endregion

            #region KlavyedenOndalıklıSayıGirişi
            double exam1, exam2, exam3, result;

            Console.Write("Lütfen 1.Sınav Notunuzu Giriniz : ");
            exam1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lütfen 2.Sınav Notunuzu Giriniz : ");
            exam2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lütfen 3.Sınav Notunuzu Giriniz : ");
            exam3 = Convert.ToDouble(Console.ReadLine());

            result = (exam1 + exam2 + exam3 / 3);
            Console.WriteLine();
            Console.WriteLine("Sınav Ortalaması : " + result);
            #endregion

            #region KlavyedenKarakterGirişleri
            char gender;
            Console.Write("Lütfen Ciniyet Seçimi Yapınız : ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine(gender);
            #endregion
        }
    }
}
