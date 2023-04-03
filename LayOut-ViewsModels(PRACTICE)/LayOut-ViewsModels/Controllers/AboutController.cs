using Microsoft.AspNetCore.Mvc;

namespace LayOut_ViewsModels.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
