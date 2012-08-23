using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleCorpSystem.InternalMessages.Sales;
using SampleCorpSystem.MVCSalesApp.Components.Sales;

namespace SampleCorpSystem.MVCSalesApp.Controllers
{
    public class HomeController : Controller
    {
        private ISubmitOrderSender _submitOrderSender;
        public ISubmitOrderSender SubmitOrderSender
        {
            get { return _submitOrderSender; }
            set { _submitOrderSender = value; }
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            SubmitOrderSender.Send(new SubmitOrder());
            return View();
        }
    }
}
