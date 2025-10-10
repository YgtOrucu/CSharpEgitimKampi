using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("Data Source=YigitOrucu\\SQLEXPRESS;Initial Catalog=DB_CSharpEgitimKampı;Integrated Security=True;TrustServerCertificate=True");
            string table = "Select*From TBL_Category";
            string tableNumber;
            Console.WriteLine(" **** CSharp Veri Tabanlı Ürün-Kategori Bilgi Sistemi **** ");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("---------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen Yapmak İstediğiniz İşlemin numarasını Giriniz :");
            tableNumber = Console.ReadLine();
            Console.WriteLine("---------------------------------");
            List<string> AllCatgory = GetCategory(connection, table);
            Console.WriteLine("Kategoriler");
            int number = 1;
            foreach (var item in AllCatgory)
            {
                Console.WriteLine(number +") " +item);
                number++;
            }  
        }
        public static List<string> GetCategory(SqlConnection con, string tableName)
        {
            con.Open();
            List<string> Categories = new List<string>();
            SqlCommand sqlCommand = new SqlCommand(tableName, con);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    string CategoryName = sqlDataReader["CategoryName"].ToString();
                    Categories.Add(CategoryName);
                }
            }
            con.Close();
            sqlDataReader.Close();
            return Categories;
        }
    }
}
