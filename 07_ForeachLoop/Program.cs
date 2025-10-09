using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForEach Döngüsü
            //string[] cities = { "Ankara", "İstanbul", "Varşova", "Milano" };
            //
            //foreach(var item in cities)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] numbers = { 1, 5, 6, 78, 96, 254, 365, 278, 41, 3, 8, 4, 78, 65 };
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] numbers = { 1, 5, 6, 78, 96, 254, 365, 278, 41, 3, 8, 4, 65 };
            //Array.Sort(numbers);
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine("------------");
            //foreach (int item in numbers)
            //{
            //    if (item % 2 == 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //List<string> Persons = new List<string>();
            //
            //Console.WriteLine("Lütfen Adınızı ve Soyadınızı Giriniz :");
            //string AdSoyad = Console.ReadLine();
            //Persons.Add(AdSoyad);
            //Console.WriteLine("Lütfen Yaşınızı Giriniz :");
            //string Yas = Console.ReadLine();
            //Persons.Add(Yas);
            //Console.WriteLine("Lütfen Yaşadığınız İli Giriniz :");
            //string İl = Console.ReadLine();
            //Persons.Add(İl);
            //Console.WriteLine("Lütfen Mail Adresinizi Giriniz :");
            //string Mail = Console.ReadLine();
            //Persons.Add(Mail);
            //Console.WriteLine("Kişi Bilgileri");
            //Console.WriteLine("---------------");
            //foreach (var item in Persons)
            //{
            //    Console.WriteLine(item);
            //}

            //string word = "Merhaba";
            //foreach (char item in word)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Örnek Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Sınıfınız da bulunan toplam öğrenci sayısını giriniz :");
            int studentcount = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");

            string[] studentsName = new string[studentcount];
            double[] studentsExamAvg = new double[studentcount];

            for (int i = 0; i < studentcount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin ismini giriniz : ");
                studentsName[i] = Console.ReadLine();

                double totalexamResult = 0;

                //Her öğrenci için 3 sınav girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentsName[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz : ");
                    double value = double.Parse(Console.ReadLine());
                    totalexamResult += value;
                }
                Console.WriteLine();
                studentsExamAvg[i] = totalexamResult / 3;
            }

            //Sınav Ortalamaları ve Durumu

            for (int i = 0; i < studentcount; i++)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"{studentsName[i]} adlı öğrencinin ortalaması : {studentsExamAvg[i]}");

                if (studentsExamAvg[i] < 50)
                {
                    Console.WriteLine($"{studentsName[i]} adlı öğrenci dersten kaldı.");
                }
                else
                {
                    Console.WriteLine($"{studentsName[i]} adlı öğrenci dersi geçti.");
                }
                Console.WriteLine("-----------------------------------");
            }
            #endregion
        }
    }
}
