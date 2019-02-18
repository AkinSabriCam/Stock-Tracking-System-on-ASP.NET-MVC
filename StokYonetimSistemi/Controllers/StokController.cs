using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StokYonetimSistemi.Controllers
{    
    public class StokController : Controller
    {
        Models.StokYonetimEntities4 db = new Models.StokYonetimEntities4();
        public ActionResult Index()
        {  var model = db.tblStok.ToList();
            return View(model);
        }
    }
}