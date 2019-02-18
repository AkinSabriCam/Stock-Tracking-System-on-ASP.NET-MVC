using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StokYonetimSistemi.Controllers
{   [Authorize(Roles ="Birim Yetkilisi")]
    public class PersonelController : Controller
    {
        Models.StokYonetimEntities4 db = new Models.StokYonetimEntities4();
        public ActionResult Index()
        {
            List<Models.tblPersonel> model = new List<Models.tblPersonel>();  
            var Personels = db.tblPersonel.ToList();   
            foreach(var per in Personels)
            {
                if (per.departmanId == Convert.ToInt16(Session["departmanid"]))
                {
                    model.Add(per);
                }
            }
            return View(model);
        }
    }
}