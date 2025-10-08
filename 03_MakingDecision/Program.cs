using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.Write("Lütfen Şifrenizi Giriniz : ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}
            //Console.WriteLine(password == "abcd" ? "Şifre Doğru" : "Şifre Yanlış");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //
            //string country, capital;
            //Console.Write("Lütfen Ülke Giriniz :");
            //country = Console.ReadLine();
            //Console.Write("Lütfen Şehir Giriniz :");
            //capital = Console.ReadLine();
            //Console.WriteLine(country == "Türkiye" & capital == "Ankara" ? "Bilgiler Doğrulandı" : "Yanlış Bilgi");
            //
            //int number;
            //Console.WriteLine("Sayı Giriniz : ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //int exam1, exam2, exam3;
            //double average;
            //string result = "";
            //Console.Write("Lütfen 1.Sınav Notunuzu Giriniz : ");
            //exam1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Lütfen 2.Sınav Notunuzu Giriniz : ");
            //exam2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Lütfen 3.Sınav Notunuzu Giriniz : ");
            //exam3 = Convert.ToInt32(Console.ReadLine());
            //
            //average = (exam1 + exam2 + exam3 / 3);
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalaması : " + average);
            //
            //if (average < 50)
            //{
            //    result = "Kötü";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "İyi";
            //}
            //if (average > 84)
            //{
            //    result = "Çok İyi";
            //}
            //Console.Write("Sonuç : {0}", result);

            //string city;
            //Console.Write("Lütfen Sehir girişi Yapınız :");
            //city = Console.ReadLine();
            //
            //if (city == "Ankara" | city == "Adana" | city == "Bursa" | city == "Trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}
            #endregion

            #region Mod İşlemleri
            //int number;
            //number = 26;
            //int sonuc = number % 5;
            //Console.WriteLine(sonuc);
            //
            //int number1, number2;
            //double result;
            //Console.Write("Lütfen 1.sayıyı giriniz : ");
            //number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Lütfen 2.sayıyı giriniz ");
            //number2 = int.Parse(Console.ReadLine());
            //
            //result = number1 % number2;
            //
            //Console.WriteLine("1.Sayının 2.Sayıya Bölümünden kalan = {0}", result);

            //int number3;
            //Console.Write("Litfen Bir sayı giriniz : ");
            //number3 = int.Parse(Console.ReadLine());
            //Console.WriteLine(number3 % 2 == 0 ? "Sayı çifttir." : "Sayı tektir.");
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char team;
            //Console.WriteLine("Litfen Takım Sembolunu Giriniz : ");
            //team = char.Parse(Console.ReadLine());
            //
            //if(team == 'G' | team == 'g')
            //{
            //    Console.WriteLine("GALATASARAY");
            //}
            //else if (team == 'F' | team == 'f')
            //{
            //    Console.WriteLine("FENERBAHÇE");
            //}
            //else if (team == 'B' | team == 'b')
            //{
            //    Console.WriteLine("BEŞİKTAŞ");
            //}
            #endregion

            #region Örnek proje Uygulaması
            //Console.WriteLine("**** CSharp Eğitim Kampı Restoran ****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("---------------------------");
            //string menuItem;
            //
            //Console.Write("Lütfen Detayını Görmek İstediğiniz Menüyü seçiniz : ");
            //menuItem = Console.ReadLine();
            //
            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------Ana Yemekler--------");
            //    Console.WriteLine("1 - Kori Soslu Tavuk");
            //    Console.WriteLine("2 - Kızartma Tabağı");
            //    Console.WriteLine("3 - Fasulye Pilav");
            //    Console.WriteLine("4 - Fırında Somon");
            //    Console.WriteLine("5 - Patlıcan Musakka");
            //    Console.WriteLine("--------Ana Yemekler--------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------Çorbalar--------");
            //    Console.WriteLine("1 - Mercimek Çorbası");
            //    Console.WriteLine("2 - EzoGelin Çorbası Tabağı");
            //    Console.WriteLine("--------Çorbalar--------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------Pizzalar--------");
            //    Console.WriteLine("1 - Akdeniz Pizza ");
            //    Console.WriteLine("2 - Karışık Pizza ");
            //    Console.WriteLine("3 - Tavuklu Pizza ");
            //    Console.WriteLine("--------Pizzalar--------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------İçecekler--------");
            //    Console.WriteLine("1 - Kola");
            //    Console.WriteLine("2 - Ayran");
            //    Console.WriteLine("3 - Su");
            //    Console.WriteLine("--------İçecekler--------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------Tatlılar--------");
            //    Console.WriteLine("1 - Triliçe ");
            //    Console.WriteLine("2 - Kazandıbi ");
            //    Console.WriteLine("3 - Sütlaç ");
            //    Console.WriteLine("--------Tatlılar--------");
            //    Console.WriteLine();
            //}
            #endregion

            #region Switch Case
            //string Month;
            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //Month = Console.ReadLine();
            //
            //switch (Month)
            //{
            //    case "Ocak": Console.Write("Ocak Yılın 1. Ayıdır"); break;
            //    case "Şubat": Console.Write("Ocak Yılın 2. Ayıdır"); break;
            //    case "Mart": Console.Write("Ocak Yılın 3. Ayıdır"); break;
            //    case "Nisan": Console.Write("Ocak Yılın 4. Ayıdır"); break;
            //    case "Mayıs": Console.Write("Ocak Yılın 5. Ayıdır"); break;
            //    case "Haziran": Console.Write("Ocak Yılın 6. Ayıdır"); break;
            //    case "Temmuz": Console.Write("Ocak Yılın 7. Ayıdır"); break;
            //    case "Ağustos": Console.Write("Ocak Yılın 8. Ayıdır"); break;
            //    case "Eylül": Console.Write("Ocak Yılın 9. Ayıdır"); break;
            //    case "Ekim": Console.Write("Ocak Yılın 10. Ayıdır"); break;
            //    case "Kasım": Console.Write("Ocak Yılın 11. Ayıdır"); break;
            //    case "Aralık": Console.Write("Ocak Yılın 12. Ayıdır"); break;
            //    default: Console.Write("Hatalı Giriş"); break;
            //
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2;
            //char symbol;
            //double result;
            //Console.Write("1.Sayıyı Giriniz :");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("2.Sayıyı Giriniz :");
            //number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Yapmak istediğiniz işlemi yazın :  1-Toplama 2-Çıkartma 3-Bölme 4-Çarpma");
            //symbol = char.Parse(Console.ReadLine());
            //
            //switch (symbol)
            //{
            //    case '1':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplama İşlemini Sonucu : " + result);
            //        break;
            //    case '2':
            //        result = number1 - number2;
            //        Console.WriteLine("Çıkarma İşlemini Sonucu : " + result);
            //        break;
            //    case '3':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölme İşlemini Sonucu : " + result);
            //        break;
            //    case '4':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpma İşlemini Sonucu : " + result);
            //        break;
            //    default: Console.WriteLine("Yanlış işlem girdiniz.Lütfen Tekrar giriş Yapınız");
            //        symbol= char.Parse(Console.ReadLine());
            //
            //        break;
            //}
            #endregion
        }
    }
}
