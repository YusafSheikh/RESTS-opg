using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RESTS_opg.Controllers
{
    public class MusicRecordsController : Controller
    {
        // GET: MusicRecordsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MusicRecordsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MusicRecordsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MusicRecordsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: MusicRecordsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MusicRecordsController/Edit/5
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

        // GET: MusicRecordsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MusicRecordsController/Delete/5
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
