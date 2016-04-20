using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace Day1Homework.Models.Repositories
{
    public class MoneyLogRepositorie
    {
        private static string strConn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\GitHub\\Source\\Repos\\MoneyLogSystem\\MoneyLogSystem\\Day1Homework\\App_Data\\HomeworkDB.mdf;Integrated Security=True";
        
        public static void AddMoneyLog(MoneyLog log)
        {
            var myConn = new SqlConnection(strConn);
            var query = @"insert into MoneyLog(Money,Remark,Date,LogType) values (@money,@remark,@date,@logType)";
            myConn.Open();
            SqlCommand command = new SqlCommand(query, myConn);
            command.Parameters.AddWithValue("@money", log.Money);
            command.Parameters.AddWithValue("@remark", log.Remark);
            command.Parameters.AddWithValue("@date", log.Date);
            command.Parameters.AddWithValue("@logType", (int)log.LogType);
            command.ExecuteNonQuery();
            myConn.Close();
        }
        public static List<MoneyLog> GetAllMoneyLogs()
        {
            var myConn = new SqlConnection(strConn);
            string query = @"select * from MoneyLog";
            myConn.Open();
            var command = new SqlCommand(query, myConn);
            var reader = command.ExecuteReader();
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
       
    }
}