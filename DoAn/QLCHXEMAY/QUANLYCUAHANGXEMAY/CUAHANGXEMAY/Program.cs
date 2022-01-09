using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using DataAccessLayer;
using BusinessLayer;
using System.Data.SqlClient;

namespace CUAHANGXEMAY
{
    static class Program
    {
        internal static string cnt;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();

            if (File.Exists("connectdb.dba"))
            {
                string conStr = "";
                //Doc file connect
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open("connectdb.dba", FileMode.Open, FileAccess.Read);
                connect cp = (connect)bf.Deserialize(fs);

                //Decrypt noi dung
                string servername = Encryptor.Decrypt(cp.servername, "qwertyuiop", true);
                string username = Encryptor.Decrypt(cp.username, "qwertyuiop", true);
                string pass = Encryptor.Decrypt(cp.passwd, "qwertyuiop", true);
                string database = Encryptor.Decrypt(cp.database, "qwertyuiop", true);
                conStr += "Data Source=" + servername + "; Initial Catalog=" + database + ";User ID=" + username + ";Password = " + pass + ";";
                cnt = conStr;
                Connection._svname = servername;
                Connection._usname = username;
                Connection._pwrd = pass;
                Connection._dtbase = database;
                SqlConnection con = new SqlConnection(conStr);
                fs.Close();
            }
            Application.Run(new frmDangNhap());
        }
    }
}
