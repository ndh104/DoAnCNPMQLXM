using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BusinessLayer;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace CUAHANGXEMAY
{
    public class Connection
    {
        public static string _svname;
        public static string _usname;
        public static string _pwrd;
        public static string _dtbase;
        static SqlConnection con = new SqlConnection();
        public static void taoKetNoi()
        {
            con.ConnectionString = Program.cnt;
            try
            {
                con.Open();
            }
            catch (Exception)
            {

            }
        }

        public static void dongKetNoi()
        {
            con.Close();
        }

        public static DataTable laydulieu(string qr)
        {
            taoKetNoi();
            DataTable data = new DataTable();
            SqlDataAdapter dtap = new SqlDataAdapter();
            dtap.SelectCommand = new SqlCommand(qr, con);
            dtap.Fill(data);
            dongKetNoi();
            return data;
        }

        public static DateTime GetFirstDayInMonth(int year, int month)
        {
            return new DateTime(year, month, 1);
        }
    }
}
