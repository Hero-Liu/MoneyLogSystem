using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Day1Homework.Models.Repositories
{
    public class MoneyLogRepositorie
    {
        private static List<MoneyLog> _Logs = new List<MoneyLog>();
        private static string strConn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\GitHub\\Source\\Repos\\MoneyLogSystem\\MoneyLogSystem\\Day1Homework\\App_Data\\HomeworkDB.mdf;Integrated Security=True";
        private static SqlConnection myConn = new SqlConnection(strConn);
        public static void AddMoneyLog(MoneyLog log)
        {
            _Logs.Add(log);
        }
        public static List<MoneyLog> GetAllMoneyLogs()
        {
            myConn.Open();
            string query = @"select * from MoneyLog";
            SqlCommand command = new SqlCommand(query, myConn);
            SqlDataReader reader = command.ExecuteReader();
            var logs = new List<MoneyLog>();
            while (reader.Read())
            {
                var log = new MoneyLog {
                    Money = int.Parse(reader["Money"].ToString()),
                    Remark = reader["Remark"].ToString(),
                    Date = DateTime.Parse(reader["Date"].ToString()),
                    LogType = (MoneyLogTypeEnum) int.Parse(reader["LogType"].ToString())
                };
                logs.Add(log);
            }
            myConn.Close();
            return logs;
        }
        //private static void insertData()
        //{
        //    for(int i = 0; i < 5; i++)
        //    {
        //        AddMoneyLog(new MoneyLog { Money = 10 * i, Date = DateTime.Now, LogType = MoneyLogTypeEnum.OutCash });
        //    }
        //}
    }
}