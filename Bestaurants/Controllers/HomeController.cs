using Microsoft.AspNetCore.Mvc;

namespace Bestaurants.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}