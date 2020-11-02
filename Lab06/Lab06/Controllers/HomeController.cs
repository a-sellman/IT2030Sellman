using System;
using System.Linq;
using Lab06.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab06.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(FaqsContext context)
        {
            this.context = context;
        }

        private FaqsContext context { get; set; }

        [Route("topic/{topic}/category/{category}")]
        [Route("topic/{topic}")]
        [Route("category/{category}")]
        [Route("/")]
        public IActionResult Index(string topic, string category)
        {
            ViewBag.Topics = context.Topics.OrderBy(t => t.Name).ToList();
            ViewBag.Categories = context.Categories.OrderBy(c => c.Name).ToList();

            IQueryable<FAQ> faqs = context.FAQs
                .Include(f => f.Topic)
                .Include(f => f.Category)
                .OrderBy(f => f.Question);

            if (!string.IsNullOrEmpty(topic))
            {
                faqs = faqs.Where(f => f.TopicId == topic);
            }

            if (!string.IsNullOrEmpty(category))
            {
                faqs = faqs.Where(f => f.CategoryId == category);
            }

            return View(faqs.ToList());
        }
    }
}