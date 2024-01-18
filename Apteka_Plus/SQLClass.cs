using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Apteka_Plus
{
    internal class SQLClass
    {
        public const string CONNECTION_STRING =
        "SslMode=none;Server=localhost;Database=apteka;port=3306;Uid=root;charset=utf8";

        public static MySqlConnection CONN;

        //Функция SELECT-запроса
        public static List<string> MySelect(string cmdText)
        {
            List<string> list = new List<string>();

            MySqlCommand cmd = new MySqlCommand(cmdText, CONN);
            DbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    list.Add(reader.GetValue(i).ToString());
                }
            }
            reader.Close();

            return list;
        }

        //Функция INSERT/DELET/UPDATE-запроса
        public static void MyUpDate(string cmdText)
        {
            MySqlCommand cmd = new MySqlCommand(cmdText, CONN);
            DbDataReader reader = cmd.ExecuteReader();
            reader.Close();
        }
    }
}
