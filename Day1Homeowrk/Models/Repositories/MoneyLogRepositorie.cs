using System;
using System.Collections.Generic;
namespace Day1Homework.Models.Repositories
{
    public class MoneyLogRepositorie
    {
        private static List<MoneyLog> _Logs = new List<MoneyLog>();
        public static void AddMoneyLog(MoneyLog log)
        {
            _Logs.Add(log);
        }
        public static List<MoneyLog> GetAllMoneyLogs()
        {
            if (_Logs.Count == 0)
                insertData();
            return _Logs;
        }
        private static void insertData()
        {
            for(int i = 0; i < 5; i++)
            {
                AddMoneyLog(new MoneyLog { Money = 10 * i, Date = DateTime.Now, LogType = MoneyLogTypeEnum.OutCash });
            }
        }
    }
}