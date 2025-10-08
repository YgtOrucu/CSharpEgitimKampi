using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForDöngüsü
            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}
            //
            //Console.Write("Lütfen ekranayazıomasını istediğiniz adedi giriniz :");
            //int finishValue = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= finishValue; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //
            #endregion

            #region For Döngüsü Karar Yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    int number = i;
            //    totalvalue += number;
            //}
            //Console.Write("Toplam Sayı " + totalvalue);

            //int  eventotalnumber = 0;
            //int  oddtotalnumber = 0;
            //for (int i = 1; i <=20; i++)
            //{
            //    if (i % 2 == 0)
            //    { 
            //        eventot alnumber += i;
            //    }
            //    else
            //    {
            //        oddtotalnumber += i;
            //    }
            //}
            //Console.WriteLine("Çift Sayıların Toplamı : {0}", eventotalnumber);
            //Console.WriteLine();
            //Console.Write("Tek Sayıların Toplamı : {0}", oddtotalnumber);
            //int count = 0;
            //int numberscount= 0;
            //for (int i = 1 ; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count += 1;
            //        numberscount += i;
            //    }
            //}
            //Console.WriteLine("1'den 50'ye kadar 7 ye bölünen toplam sayı : {0}", count);
            //Console.Write("1'den 50'ye kadar 7 ye bölünen sayıların toplamı : {0}", numberscount);

            #endregion

            #region While Döngüsü
            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine("Merhaba Dünya");
            //    i++;
            //}
            #endregion

            #region While Döngüsü Karar Yapıları
            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int count = 0;
            //while (i <= 10)
            //{
            //    count += i;
            //    i++;
            //}
            //Console.WriteLine(count);
            #endregion

            #region Örnek Soru
            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız ?

            //int girilensayı;
            //Console.Write("3 basamaklı bir sayı giriniz ");
            //girilensayı = int.Parse(Console.ReadLine());
            //int ones, tens, hundred;
            //int sum;
            //
            //ones = girilensayı % 10;
            //tens = (girilensayı % 100) / 10;
            //hundred = girilensayı / 100;
            //
            //sum = ones + tens + hundred;
            //Console.Write(sum);
            #endregion
        }
    }
}
