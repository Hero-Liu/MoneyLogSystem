using Day1Homeowrk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day1Homeowrk.ViewModels
{
    public class ViewAndAddMoneyLogViewModel
    {
        public MoneyLog AddedLog { get; set; }
        public List<MoneyLog> HistroyLog { get; set; }
    }
}