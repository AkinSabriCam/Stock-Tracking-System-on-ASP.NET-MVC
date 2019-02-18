using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StokYonetimSistemi.Controllers
{  [Authorize(Roles ="Birim Yetkilisi,Admin,Satın Alma")]
    public class AtıkDepoController : Controller
    {
        Models.StokYonetimEntities4 db = new Models.StokYonetimEntities4();
        public ActionResult Index()
        {
            var model = db.tblAtikKontrol.ToList();
            return View(model);
        }
    }
}