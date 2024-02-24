using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JenkinsTestApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        // GET: HomeController
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // GET: HomeController/Details/5
        [HttpGet("{id}")]
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController/Create
        [HttpGet("create")]
        public ActionResult Create()
        {
            return View();
        }

      

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        [HttpGet("{id}/delete")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
