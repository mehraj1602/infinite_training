using Assignment1.Models;
using Assignment1.Repository;
using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace Assignment1.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepository _repo;

        public ContactController()
        {
            _repo = new ContactRepository(new ContactContext());
        }
        public ContactController(IContactRepository repo)
        {
            _repo = repo;
        }

        public async Task<ActionResult> Index()
        {
            var contacts = await _repo.GetAllAsync();
            return View(contacts);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Contact contact)
        {
            if (!ModelState.IsValid)
                return View(contact);

            await _repo.CreateAsync(contact);
            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult> Delete(long Id)
        {
            var contacts = await _repo.GetAllAsync();
            var contact = contacts.FirstOrDefault(c => c.Id == Id);
            if (contact == null)
                return HttpNotFound();

            return View(contact);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(long Id)
        {
            await _repo.DeleteAsync(Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
