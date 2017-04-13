using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gift_Exchange.Services;

namespace Gift_Exchange.Controllers
{
    public class GiftController : Controller
    {
        // GET: Gift
        public ActionResult Index()
        {
            var gifts = new GiftServices().GetAllGifts();
            //pass into veiw
            return View(gifts);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {

            var Contents = collection["Contents"];
            var GiftHint = collection["GiftHint"];
            var ColorWrappingPaper = collection["ColorWrappingPaper"];
            var Height = collection["Height"];
            var Width = collection["Width"];
            var Depth = collection["Depth"];
            var Weight = collection["Weight"];
            var IsOpen = collection["IsOpen"];
            return RedirectToAction("Index");



        }

    }
}