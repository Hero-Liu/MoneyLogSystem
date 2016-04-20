using Day1Homework.Models;
using Day1Homework.Models.Repositories;
using Day1Homework.ViewModels;
using System.Web.Mvc;

namespace Day1Homework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("ViewAndAddMoneyLog");
        }
        public ActionResult ViewAndAddMoneyLog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ViewAndAddMoneyLog(MoneyLog moneyLog)
        {
            MoneyLogRepositorie.AddMoneyLog(moneyLog);
            var temp = new MoneyLog { Money = 50 };
            ViewData.Model = new ViewAndAddMoneyLogViewModel{AddedLog = temp};
            return View();
        }

        public ActionResult ChildHistory()
        {
            ViewData.Model = MoneyLogRepositorie.GetAllMoneyLogs();
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