using System.Collections.Generic;
namespace Day1Homeowrk.Models.Repositories
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
            return _Logs;
        }
    }
}