using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLXEMAY
{
    public class myClass
    {
        static SqlConnection cnt = new SqlConnection();
        public static void taoKetNoi()
        {
            cnt.ConnectionString = @"Data Source=DESKTOP-IB4CE96\BIGBOSS;Initial Catalog=QUANLYXEMAY;Integrated Security=True";
            try
            {
                cnt.Open();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        public static void dongKetNoi()
        {
            cnt.Close();
        }
        public static DataTable getData(string query)
        {
            taoKetNoi();
            DataTable tb = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, cnt);
            sda.Fill(tb);
            dongKetNoi();
            return tb;
        }
    }
}
