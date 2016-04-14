using Day1Homeowrk.Models;
using Day1Homeowrk.Models.Repositories;
using Day1Homeowrk.ViewModels;
using System.Web.Mvc;

namespace Day1Homeowrk.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewAndAddMoneyLog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ViewAndAddMoneyLog(MoneyLog moneyLog)
        {
            MoneyLogRepositorie.AddMoneyLog(moneyLog);
            var viewModel = new ViewAndAddMoneyLogViewModel { AddedLog=moneyLog, HistroyLog = MoneyLogRepositorie.GetAllMoneyLogs()};
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}