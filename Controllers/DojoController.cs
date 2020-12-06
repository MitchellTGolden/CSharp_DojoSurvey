
using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers
{
    public class DojoController : Controller
    {

        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public IActionResult Index()
        {
            return View();
        }
        //for each route this controller is to handle:
        [Route("result")]
        public IActionResult Result(string name, string dojo, string favLang, string comment)
        {
            ViewBag.name = name;
            ViewBag.dojo = dojo;
            ViewBag.favLang = favLang;
            ViewBag.comment = comment;

            return View();
        }
    }
}