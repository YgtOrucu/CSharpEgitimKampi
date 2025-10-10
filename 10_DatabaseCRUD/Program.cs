using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCRUD
{
    public class Program
    {

        static void Main(string[] args)
        {
            SqlClass sql = new SqlClass();
            SqlConnection baglantı = sql.SqlBaglantı();
            Console.WriteLine(" **** Menü Sipariş İşlem Paneli **** ");
            Console.WriteLine();
            Console.WriteLine("--------------------------");

            #region Kategori Ekleme ve Getirme İşlemi
            //Console.Write("Lütfen eklemek istediğiniz kategori ismini giriniz : ");
            //string categoryName = Console.ReadLine();
            //CategoryAdd(categoryName, baglantı);
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Güncel Kategori Tablosunu Görmek İster misiniz ? (Evet yada Hayır)");
            //string answer = Console.ReadLine();
            //
            //switch (answer)
            //{
            //    case "Evet":
            //        List<string> AllCategories = GetCategories(baglantı);
            //        int number = 1;
            //        Console.WriteLine("Kategoriler");
            //        Console.WriteLine();
            //
            //        foreach (var item in AllCategories)
            //        {
            //            Console.WriteLine(number + ") " + item);
            //            number++;
            //        }
            //        break;
            //    case "Hayır":
            //        return;
            //    default:
            //        Console.Write("Yanlış İşlem Yaptınız Lütfen TEKRAR DENEYİNİZ !!!");
            //        break;
            //}
            #endregion

            #region Ürün Ekleme ve Getirme İşlemi
            //Console.Write("Lütfen Eklemek İstediğiniz Ürünü Yazınız : ");
            //string product = Console.ReadLine();
            //Console.Write("Lütfen Eklemek İstediğiniz Ürününün Fiyatini Yazınız : ");
            //decimal price = decimal.Parse(Console.ReadLine());
            //Console.Write("Lütfen Eklemek İstediğiniz Ürününün Stok'da olup olmadığını belirtiniz : (Var yada Yok)");
            //string status = Console.ReadLine();
            //ProductAdd(product, price, status, baglantı);
            //Console.WriteLine();
            //Console.Write("Ürünlerin Güncel Halini görmek istermisiniz ? (Ör: Evet yada Hayır)");
            //string answers = Console.ReadLine();
            //switch (answers)
            //{
            //    case "Evet":
            //        GetProduct(baglantı);
            //        break;
            //    case "Hayır":
            //        break;
            //    default:
            //        break;
            //}


            #endregion

            #region Ürün Silme İşlemi
            //GetProduct(baglantı);
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("-------------------");
            //Console.Write("Silinecek Ürünü yazınız : ");
            //string ProductName = Console.ReadLine();
            //DeleteProduct(ProductName, baglantı);
            //Console.WriteLine("Ürün Başarılı bir şekilde silinmiştir.");
            #endregion

            #region Ürün Güncelleme İşlemi
            GetProduct(baglantı);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.Write("Güncellemek istediğiniz ürünün Id'sını seçiniz : ");
            int ıd = int.Parse(Console.ReadLine());
            Console.Write("Güncellemek istediğiniz ürünün Adı'sını seçiniz : ");
            string name = Console.ReadLine();
            Console.Write("Güncellemek istediğiniz ürünün Fiyati'sını seçiniz : ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Güncellemek istediğiniz ürünün Durumunu giriniz : (True or False)");
            bool status = bool.Parse(Console.ReadLine());
            UpdateProduct(name, ıd, price, status, baglantı);
            Console.WriteLine("Güncelleme Başarılı");
            #endregion

        }


        #region Kategori Ekleme ve Getirme İşlemi 
        private static List<string> GetCategories(SqlConnection baglantı)
        {
            List<string> Categories = new List<string>();
            baglantı.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM TBL_Category", baglantı);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    string categories = sqlDataReader["CategoryName"].ToString();
                    Categories.Add(categories);
                }
            }
            baglantı.Close();
            sqlDataReader.Close();
            return Categories;
        }

        public static void CategoryAdd(string category, SqlConnection baglantı)
        {
            baglantı.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO TBL_Category (CategoryName) VALUES (@P1)", baglantı);
            sqlCommand.Parameters.AddWithValue("@P1", category);
            sqlCommand.ExecuteNonQuery();
            baglantı.Close();
        }

        #endregion

        #region Ürün Ekleme ve Getirme İşlemi
        public static void ProductAdd(string product, decimal price, string status, SqlConnection sql)
        {
            sql.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO TBL_Product (ProductName,ProductPrice,ProductStatus) VALUES (@p1,@p2,@p3)", sql);
            sqlCommand.Parameters.AddWithValue("@p1", product);
            sqlCommand.Parameters.AddWithValue("@p2", price);
            sqlCommand.Parameters.AddWithValue("@p3", status == "Var" ? true : false);
            sqlCommand.ExecuteNonQuery();
            sql.Close();
        }

        public static void GetProduct(SqlConnection sql)
        {
            sql.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM TBL_Product WHERE ProductStatus = 1", sql);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString() + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            sql.Close();
        }
        #endregion

        #region Ürün Silme İşlemi
        private static void DeleteProduct(string productName, SqlConnection sql)
        {
            sql.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE TBL_Product SET ProductStatus = 0  WHERE ProductName = @P1", sql);
            sqlCommand.Parameters.AddWithValue("@p1", productName);
            sqlCommand.ExecuteNonQuery();
            sql.Close();
        }
        #endregion

        #region Ürün Güncelleme İşlemi
        private static void UpdateProduct(string name, int ıd, decimal price, bool status ,SqlConnection sql)
        {
            sql.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE TBL_Product SET ProductName = @p1 , ProductPrice = @p2 , ProductStatus = @p3 WHERE ProductID = @p4", sql);
            sqlCommand.Parameters.AddWithValue("@p1", name);
            sqlCommand.Parameters.AddWithValue("@p2", price);
            sqlCommand.Parameters.AddWithValue("@p3", status);
            sqlCommand.Parameters.AddWithValue("@p4", ıd);
            sqlCommand.ExecuteNonQuery();
            sql.Close();
        }
        #endregion
    }

}
