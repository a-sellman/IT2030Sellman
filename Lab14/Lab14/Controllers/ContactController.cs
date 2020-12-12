using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab14.Models;

namespace Lab14.Controllers
{
    public class ContactController : Controller
    {
        public ContactController(ContactContext ctx)
        {
            this.data = new UnitOfWork(ctx);
        }

        private IUnitOfWork data { get; set; }
        private UnitOfWork data { get; set; }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Categories = data.Categories.List(new QueryOptions<Category> { OrderBy = c => c.Name });
            return View("Edit", new Contact());
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var options = new QueryOptions<Contact>
            {
                Includes = "Category",
                Where = c => c.ContactId == id
            };

            var contact = data.Contacts.Get(options);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
            data.Contacts.Delete(contact);
            data.Save();

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Details(int id)
        {
            var options = new QueryOptions<Contact>
            {
                Includes = "Category",
                Where = c => c.ContactId == id
            };
            var contact = data.Contacts.Get(options);
            return View(contact);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Categories = data.Categories.List(new QueryOptions<Category> { OrderBy = c => c.Name });
            var options = new QueryOptions<Contact>
            {
                Includes = "Category",
                Where = c => c.ContactId == id
            };
            var contact = data.Contacts.Get(options);
            return View("Edit", contact);
        }

        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            string action = (contact.ContactId == 0) ? "Add" : "Edit";
            if (ModelState.IsValid)
            {
                if (action == "Add")
                {
                    contact.DateAdded = DateTime.Now;
                    data.Contacts.Insert(contact);
                }
                else
                {
                    data.Contacts.Update(contact);
                }

                data.Save();
            }
        }
    }
}