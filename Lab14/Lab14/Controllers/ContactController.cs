using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab14.Controllers
{
    public class ContactController : Controller
    {
        public ContactController(ContactContext ctx)
        {
            context = ctx;
        }

        private ContactContext context { get; set; }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Category = context.Categories.OrderBy(g => g.Name).ToList();
            return View("Edit", new Contact());
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = context.Contacts.Find(id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
            context.Contacts.Remove(contact);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Categories = context.Categories.OrderBy(g => g.Name).ToList();
            var contact = context.Categories.Find(id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                if (contact.CategoryID == 0)
                    context.Contacts.Add(contact);
                else
                    context.Contacts.Update(contact);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (contact.CategoryID == 0) ? "Add" : "Edit";
                ViewBag.Categories = context.Categories.OrderBy(g => g.Name).ToList();
                return View(contact);
            }
        }
    }
}