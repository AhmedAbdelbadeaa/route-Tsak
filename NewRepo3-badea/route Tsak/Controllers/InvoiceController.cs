using Microsoft.AspNetCore.Mvc;

namespace route_Tsak.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
