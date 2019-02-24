using Chinook.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chinook.UI.MVC.Controllers
{
    public class ArtistController : Controller
    {
        // GET: Artist
        public ActionResult Index() //DESDE ESTA OPCION SE AGREGA UNA VISTA
        {
            var da = new clsArtistDA();
            var model = da.Gets();

            return View(model);
        }
    }
}