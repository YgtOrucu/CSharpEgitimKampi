using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCRUD
{
    public class SqlClass
    {
        public SqlConnection SqlBaglantı()
        {
            SqlConnection sql = new SqlConnection("Data Source=YIGITORUCU\\MY_YOUTUBEKURSU;Initial Catalog=DB_CSharpEgitimKampı;Integrated Security=True;TrustServerCertificate=True");
            return sql;
        }
    }
}
