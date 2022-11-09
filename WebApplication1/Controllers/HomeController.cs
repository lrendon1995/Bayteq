using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Code;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private List<PetsViewModel> SesionPets
        {
            get => (List<PetsViewModel>)Session["SesionPets"];
            set => Session["SesionPets"] = value;
        }

        public ActionResult Index()
        {
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

        public ActionResult GetAllPets()
        {
            SesionPets = PetCode.GetPets("/pet/findByStatus?status=available");


            return PartialView("ListaPets",SesionPets);
        }
    }
}