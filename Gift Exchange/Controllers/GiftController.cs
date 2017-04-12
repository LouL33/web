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
    }
}