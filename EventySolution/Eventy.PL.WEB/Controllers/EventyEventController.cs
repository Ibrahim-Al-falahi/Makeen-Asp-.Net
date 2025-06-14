using Eventy.BLL.Interfaces;
using Eventy.DAL.Entities.EventModule;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eventy.PL.WEB.Controllers
{
    public class EventyEventController : Controller
    {
        private readonly IGenericRepository<EventyEvent> _eventy;

        public EventyEventController(IGenericRepository<EventyEvent> eventy) 
        {
            _eventy = eventy;
        }
        // GET: EventyEventController
        public ActionResult Index()
        {
            var x = _eventy.GetAll();
            return View(x);
        }

        // GET: EventyEventController/Details/5
        public ActionResult Details(int id)
        {
            var x = _eventy.GetById(id);
            return View(x);
        }

        // GET: EventyEventController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventyEventController/Create
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

        // GET: EventyEventController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EventyEventController/Edit/5
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

        // GET: EventyEventController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EventyEventController/Delete/5
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
