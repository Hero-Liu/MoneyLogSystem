using System;

namespace Day1Homeowrk.Models
{
    public class MoneyLog
    {
        public int Money { get; set; }
        public string Remark { get; set; }
        public DateTime Date { get; set; }
        public MoneyLogTypeEnum LogType { get; set; }
    }
}