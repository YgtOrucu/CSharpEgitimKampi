using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string [4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";
            //Console.Write(colors[1]);

            //int[] number = new int[5];
            //number[0] = 33;
            //number[1] = 23;
            //number[2] = 12;
            //number[3] = 78;
            //number[4] = 45;
            //Console.Write(number[2]);

            //string[] cities = { "Prag", "Roma", "Paris", "İstanbul" };
            //Console.Write(cities[2]);
            #endregion

            #region Dizide ki tüm elamanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Mavi", "Beyaz", "Yeşil" };
            //
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 745, 889, 6325, 4127, 865, 4412, 456 };
            //
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //
            //}

            //int[] myArrays = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };         
            //int maxNumber = myArrays[0];
            //for (int i = 0; i < myArrays.Length; i++)
            //{
            //    if (myArrays[i] > maxNumber)
            //    {
            //        maxNumber = myArrays[i];
            //    }              
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "Ali", "Ahmet", "Ayşe", "Buse", "Cem" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 2, 5, 74, 85, 32, 12, 89, 996, 54, 11 };
            //Array.Sort(numbers); //Küçükten Büyüye sıralama yapıyor.
            //Array.Reverse(numbers); // Diziyi tersten yazdırıyor.
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Dizi Methotları
            //string[] customers = { "Ali", "Buse", "Ayşe", "Merve" };
            //int index = Array.IndexOf(customers, "Ayşe");
            //Console.Write(index);

            //int[] numbers = { 45, 85, 69, 88, 74, 23, 14, 14 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + " Dizinin en küçük elemanı: " + numbers.Min());

            //string[] cities = new string[5];
            //
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz : ");
            //    cities[i] = Console.ReadLine();
            //    Console.WriteLine();
            //}
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Şehirlerimiz");
            //for (int j = 0; j < cities.Length; j++)
            //{
            //    Console.WriteLine("*** " + cities[j] + " ***");
            //}

            //int[] numbers = new int[5];
            //
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Lütfen tam sayı değeri giriniz : ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //    Console.WriteLine();
            //}
            //Console.WriteLine("-------------------");
            //int sum = 0;
            //for (int j = 0; j < numbers.Length; j++)
            //{
            //    sum += numbers[j];
            //}
            //Console.Write("Girilen Sayıların Toplamı :" + sum);


            int[] numbers = { 1, 5, 8, 12, 78, 96, 36, 85, 74, 23, 96, 52, 114, 75, 698, 45 };

            Console.Write("Çift Sayılar: ");
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {                  
                    Console.WriteLine("* " + numbers[i]);
                }
            }
            Console.WriteLine("-----------------------");
            Console.Write("Tek Sayılar: ");
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine("* " + numbers[i]);
                }
            }
            #endregion
        }
    }
}
