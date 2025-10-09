using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 Yıldız Oluşturma
            //for (int i = 1; i <=10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan Yana 10 Yıldız Oluşturma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Dik Üçgen Oluşturma
            //for (int i = 1; i <=5; i++)
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Tersten Dik Üçgen Oluşturma
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Dik Üçgen ve Tersten Dik Üçgen Birleştirme
            //for (int i = 1; i <=5; i++)
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 4; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Baklava Dilimi

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 4; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //
            //for (int i = 4; i >= 1; i--)
            //{
            //    for (int j = 4; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit Oluşturma
            //int n = 15;
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = n - 1; j >= 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    n--;
            //    Console.WriteLine();
            //}
            #endregion

            #region Ters Piramit Oluşturma
            //int m = 7;
            //for (int i = 9; i >=0 ; i--)
            //{
            //    for (int j = m - 1; j >= 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    m++;
            //    Console.WriteLine();
            //}
            #endregion
        }
    }
}
