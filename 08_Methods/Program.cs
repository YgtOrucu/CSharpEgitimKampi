using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Methotlar

            //Geriye değer döndürmeyen methotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yılmaz");
            //    Console.WriteLine("Büşra Kaya");
            //    Console.WriteLine("Betül Çakmak");
            //    Console.WriteLine("Ahmet Yılmaz");
            //}
            //CustomerList();

            //void Sum()
            //{
            //    int x, y, z;
            //    x = 1; y = 2; z = 5;
            //    Console.Write(x + y + z);
            //}
            //Sum();
            #endregion

            #region Geriye değer döndürmeyen parametreli methotlar

            //void WriteMethod(string text)
            //{
            //    Console.WriteLine(text);
            //}
            //WriteMethod("Ahmet");
            //
            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşterinin Adı : {0}  Soyadı : {1}", name, surname);
            //}
            //CustomerCard("Ahmet", "Yüksel");
            //CustomerCard("Mehmet", "Kaya");
            //CustomerCard("Ayşe", "Balcı");
            #endregion

            #region Geriye değer döndüren methotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();
            //
            //string CustomerKart()
            //{
            //    string name, surname;
            //    name = "Ali";
            //    surname = "Kaya";
            //    return name + " " + surname;
            //}
            //
            //Console.WriteLine(CustomerKart());
            #endregion

            #region Geriye değer döndüren parametreli methotlar


            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke : " + countryName + " Şehir: " + capital + "Bayrak Rengi: " + flagColor + ".";
            //    return cardInfo;
            //}
            //
            //Console.Write("Lütfen Ülkeyi Giriniz : ");
            //string countryname = Console.ReadLine();
            //Console.Write("Lütfen Şehiri Giriniz : ");
            //string Capital = Console.ReadLine();
            //Console.Write("Lütfen Bayrak rengini Giriniz : ");
            //string FlagColor = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine(CountryCard(countryname, Capital, FlagColor));

            //int SumNumbers(int one,int two,int three)
            //{
            //    int totalnumbers = one + two + three;
            //    return totalnumbers;
            //}
            //
            //int x, y, z;
            //
            //Console.Write("Lütfen 1.Sayıyı giriniz: ");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.Sayıyı giriniz: ");
            //y = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3.Sayıyı giriniz: ");
            //z = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("-------------");
            //Console.WriteLine("Girilen Sayıların Toplamı : " + SumNumbers(x, y, z));
            #endregion

            #region Örnek Uygulama
            string ExamResult(string PersonName,string PersonSurname,int ex1,int ex2,int ex3)
            {
                double aveg = (ex1 + ex2 + ex3) / 3;

                if (aveg < 50)
                {
                    return PersonName + " " + PersonSurname + " adlı öğrencinin Ortalaması " + aveg + "'dır.  BAŞARISIZ !!!"; 
                }
                else
                {
                    return PersonName + " " + PersonSurname + " adlı öğrencinin Ortalaması " + aveg + "'dır.  BAŞARILI !!!";
                }
            }
            
          
            int exam1, exam2, exam3;
            string Name, Surname;

            Console.WriteLine("Öğrencinin ; ");
            Console.Write("Adı :");
            Name = Console.ReadLine();
            Console.Write("Soyadı :");
            Surname = Console.ReadLine();
            Console.Write("1.Sınav notu :");
            exam1 = int.Parse(Console.ReadLine());
            Console.Write("2.Sınav notu :");
            exam2 = int.Parse(Console.ReadLine());
            Console.Write("3.Sınav notu :");
            exam3 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(ExamResult(Name, Surname, exam1, exam2, exam3));

            #endregion
        }
    }
}
