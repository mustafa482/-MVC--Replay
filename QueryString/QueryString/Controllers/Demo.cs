using Microsoft.AspNetCore.Mvc;

namespace QueryString.Controllers
{
    [Route("demo")]
    public class Demo : Controller
    {
        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("demo2")]
        public IActionResult Demo2([FromQuery(Name ="id")] string id)
        {
            ViewBag.id = id;
            return View();
        }
        [Route("demo3")]
        public IActionResult Demo3([FromQuery(Name="id1")] int id1,[FromQuery(Name ="id2")] string id2)
        {
            ViewBag.id1 = id1;
            ViewBag.id2 = id2;
            return View();
        }
        [Route("demo4")]
        public IActionResult Demo4()
        {
            var id1 = int.Parse(HttpContext.Request.Query["id1"].ToString());
            var id2 = HttpContext.Request.Query["id2"].ToString();
            ViewBag.id1 = id1;
            ViewBag.id2 = id2;

            return View();
        }
    }
}
